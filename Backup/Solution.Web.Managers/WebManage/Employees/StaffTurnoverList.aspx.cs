﻿using System;
using System.Collections.Generic;
using DotNet.Utilities;
using FineUI;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;
using Solution.Logic.Managers;
using Solution.Web.Managers.WebManage.Application;
/***********************************************************************
 *   作    者：AllEmpty（陈焕）-- 1654937@qq.com
 *   博    客：http://www.cnblogs.com/EmptyFS/
 *   技 术 群：327360708
 *  
 *   创建日期：2014-06-27
 *   文件名称：StaffTurnoverList.aspx.cs
 *   描    述：离职员工列表管理
 *             
 *   修 改 人：
 *   修改日期：
 *   修改原因：
 ***********************************************************************/
using SubSonic.Query;

namespace Solution.Web.Managers.WebManage.Employees
{
    public partial class StaffTurnoverList : PageBase
    {
        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //绑定部门
                BranchBll.GetInstence().BandDropDownListShowAll(this, ddlBranch_Id, true);

                LoadData();
            }
        }
        #endregion

        #region 接口函数，用于UI页面初始化，给逻辑层对象、列表等对象赋值
        public override void Init()
        {
            //逻辑对象赋值
            bll = ManagerBll.GetInstence();
            //表格对象赋值
            grid = Grid1;
        }
        #endregion

        #region 加载数据
        /// <summary>读取数据</summary>
        public override void LoadData()
        {
            //设置排序
            if (sortList == null)
            {
                Sort(null);
            }

            //绑定Grid表格
            bll.BindGrid(Grid1, Grid1.PageIndex + 1, Grid1.PageSize, InquiryCondition(), sortList);
        }

        /// <summary>
        /// 查询条件
        /// </summary>
        /// <returns></returns>
        private List<ConditionHelper.SqlqueryCondition> InquiryCondition()
        {
            var wheres = new List<ConditionHelper.SqlqueryCondition>();
            //添加条件：只显示离职人员
            wheres.Add(new ConditionHelper.SqlqueryCondition(ConstraintType.And, ManagerTable.IsWork, Comparison.Equals, 0));

            //登陆账号
            if (!string.IsNullOrEmpty(txtLoginName.Text.Trim()))
            {
                wheres.Add(new ConditionHelper.SqlqueryCondition(ConstraintType.And, ManagerTable.LoginName, Comparison.Like, "%" + StringHelper.FilterSql(txtLoginName.Text) + "%"));
            }
            //中文名称
            if (!string.IsNullOrEmpty(txtCName.Text.Trim()))
            {
                wheres.Add(new ConditionHelper.SqlqueryCondition(ConstraintType.And, ManagerTable.CName, Comparison.Like, "%" + StringHelper.FilterSql(txtCName.Text) + "%"));
            }
            //绑定部门编码
            if (ddlBranch_Id.SelectedValue != "0")
            {
                wheres.Add(new ConditionHelper.SqlqueryCondition(ConstraintType.And, ManagerTable.Branch_Code, Comparison.StartsWith,
                    StringHelper.FilterSql(ddlBranch_Id.SelectedValue)));
            }

            return wheres;
        }

        #endregion

        #region 列表属性绑定

        #region 列表按键绑定——修改列表控件属性
        /// <summary>
        /// 列表按键绑定——修改列表控件属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Grid1_PreRowDataBound(object sender, FineUI.GridPreRowEventArgs e)
        {
            //绑定是否编辑列
            var lbfEdit = Grid1.FindColumn("ButtonEdit") as LinkButtonField;
            lbfEdit.Text = "编辑";
            //lbfEdit.Enabled = MenuInfoBll.GetInstence().CheckControlPower(this, "ButtonEdit");
        }
        #endregion

        #region Grid点击事件
        /// <summary> 
        /// Grid点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Grid1_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            GridRow gr = Grid1.Rows[e.RowIndex];
            //获取当前点击列的主键ID
            object id = gr.DataKeys[0];

            switch (e.CommandName)
            {
                case "ButtonEdit":
                    //打开编辑窗口
                    Window1.IFrameUrl = "ManagerEdit.aspx?Id=" + id + "&" + MenuInfoBll.GetInstence().PageUrlEncryptStringNoKey(id + "");
                    Window1.Hidden = false;

                    break;
            }
        }
        #endregion

        #endregion

        #region 删除记录
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <returns></returns>
        public override string Delete()
        {
            //获取要删除的Id组
            var id = GridViewHelper.GetSelectedKeyArray(Grid1);

            //如果没有选择记录，则直接退出
            if (id == null)
            {
                return "请选择要删除的记录。";
            }

            try
            {
                //逐个删除对应的图片
                foreach (var i in id)
                {
                    ManagerBll.GetInstence().DelPhotoImg(this, i);
                }

                //删除记录
                bll.Delete(this, id);

                return "删除编号Id为[" + string.Join(",", id) + "]的数据记录成功。";
            }
            catch (Exception e)
            {
                string result = "尝试删除编号ID为[" + string.Join(",", id) + "]的数据记录失败！";

                //出现异常，保存出错日志信息
                CommonBll.WriteLog(result, e);

                return result;
            }
        }
        #endregion

        #region 设置员工复职
        /// <summary>
        /// 设置员工复职
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonRecovery_Click(object sender, EventArgs e)
        {
            //获取要操作的ID
            var id = GridViewHelper.GetSelectedKeyArray(Grid1, true);

            //如果没有选择记录，则直接退出
            if (id == null)
            {
                FineUI.Alert.ShowInParent("请选择你要处理的记录", FineUI.MessageBoxIcon.Information);
            }

            try
            {
                //逐个设置离职
                foreach (var i in id)
                {
                    var name = ManagerBll.GetInstence().GetCName(this, i);
                    ManagerBll.GetInstence().UpdateValue(this, i, ManagerTable.IsWork, 1, ManagerTable.IsEnable, 1, "{0}将员工" + name + "[" + i + "]设置为正常（复职）状态");
                }

                LoadData();

                FineUI.Alert.ShowInParent("编号Id为[" + string.Join(",", id) + "]的员工已设置为复职", FineUI.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string result = "尝试设置编号ID为[" + string.Join(",", id) + "]的员工复职失败！";

                //出现异常，保存出错日志信息
                CommonBll.WriteLog(result, ex);

                FineUI.Alert.ShowInParent(result, FineUI.MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}