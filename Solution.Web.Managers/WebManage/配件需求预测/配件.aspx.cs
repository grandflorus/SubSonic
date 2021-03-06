﻿using System;
using System.Collections.Generic;
using DotNet.Utilities;
using FineUI;
using Solution.DataAccess.DataModel;
using Solution.DataAccess.DbHelper;
using Solution.Logic.Managers;
using Solution.Web.Managers.WebManage.Application;
/***********************************************************************
 *   作    者：PengFei（彭飞）
 *   邮    箱：xjvspf@163.com
 *   QQ    号：124041108
 *  
 *   创建日期：2017-11-10
 *   文件名称：itcast_partList.aspx.cs
 *   描    述：配件信息查询文件
 *             
 *   修 改 人：
 *   修改日期：
 *   修改原因：
 ***********************************************************************/
using SubSonic.Query;

namespace Solution.Web.Managers.WebManage.配件需求预测
{
    public partial class 配件 : PageBase
    {
        //int _id = 0;

        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            //获取管理员Id——用于查询指定管理员日志
            //_id = RequestHelper.GetInt0("Id");

            //if (!IsPostBack)
            //{
            //    //设定初始化时间
            //    dpStart.Text = DateTime.Now.ToString("yyyy-M-d");
            //    dpEnd.Text = DateTime.Now.AddDays(1).ToString("yyyy-M-d");

            //    LoadData();
            //}
        }
        #endregion

        #region 接口函数，用于UI页面初始化，给逻辑层对象、列表等对象赋值
        public override void Init()
        {
            //逻辑对象赋值
            bll = itcast_partBll.GetInstence();
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
            itcast_partBll.GetInstence().BindGrid(Grid1, Grid1.PageIndex + 1, Grid1.PageSize, InquiryCondition(), sortList);
        }

        /// <summary>
        /// 查询条件
        /// </summary>
        /// <returns></returns>
        private List<ConditionHelper.SqlqueryCondition> InquiryCondition()
        {
            var wheres = new List<ConditionHelper.SqlqueryCondition>();

            #region    配件名称      
            //配件名称
            if (!string.IsNullOrEmpty(txtAssemName.Text.Trim()))
            {
                wheres.Add(new ConditionHelper.SqlqueryCondition(ConstraintType.And, itcast_partTable.AssemName, Comparison.Like, "%" + StringHelper.FilterSql(txtAssemName.Text) + "%"));
            }


            #endregion

            #region    生产地址      
            //生产地址
            if (!string.IsNullOrEmpty(txtProLocation.Text.Trim()))
            {
                wheres.Add(new ConditionHelper.SqlqueryCondition(ConstraintType.And, itcast_partTable.ProLocation, Comparison.Like, "%" + StringHelper.FilterSql(txtProLocation.Text) + "%"));
            }


            #endregion



            return wheres;



        }
    }
}
#endregion