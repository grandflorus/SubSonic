using System;
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
 *   创建日期：2017-10-17
 *   文件名称：OnlineUsersList.aspx.cs
 *   描    述：在线用户列表文件
 *             
 *   修 改 人：
 *   修改日期：
 *   修改原因：
 ***********************************************************************/
using SubSonic.Query;

namespace Solution.Web.Managers.WebManage.Systems.Security
{
    public partial class OnlineUsersList : PageBase
    {
        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        #endregion

        #region 接口函数，用于UI页面初始化，给逻辑层对象、列表等对象赋值
        public override void Init()
        {
            //逻辑对象赋值
            bll = OnlineUsersBll.GetInstence();
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
            OnlineUsersBll.GetInstence().BindGrid(Grid1, Grid1.PageIndex + 1, Grid1.PageSize, null, sortList);
        }
        
        #endregion


        #region 列表属性绑定

        #region Grid点击事件
        /// <summary> 
        /// Grid点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Grid1_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            GridRow gr = Grid1.Rows[e.RowIndex];
            //获取主键ID
            var id = ConvertHelper.Cint0(gr.DataKeys[0].ToString());
            //获取在线用户实体
            var model = OnlineUsersBll.GetInstence().GetModelForCache(id);
            if (model == null)
                return;

            switch (e.CommandName)
            {
                case "GetOut":
                    //从在线表中删除用户
                    OnlineUsersBll.GetInstence().UserExit(model.UserHashKey);
                    //刷新当前页面
                    FineUI.PageContext.Refresh();
                    break;
                case "ManagerColumn":
                    Window1.IFrameUrl = "../Authority/ManagerView.aspx?Id=" + model.Manager_Id + "&" + MenuInfoBll.GetInstence().PageUrlEncryptStringNoKey(model.Manager_Id + "");
                    Window1.Hidden = false;
                    break;
                case "LoginLog":
                    Window1.IFrameUrl = "LoginLogList.aspx?Id=" + model.Manager_Id + "&" + MenuInfoBll.GetInstence().PageUrlEncryptStringNoKey(model.Manager_Id + "");
                    Window1.Hidden = false;
                    break;
                case "UserLog":
                    Window1.IFrameUrl = "UseLogList.aspx?Id=" + model.Manager_Id + "&" + MenuInfoBll.GetInstence().PageUrlEncryptStringNoKey(model.Manager_Id + "");
                    Window1.Hidden = false;
                    break;
            }
        }
        #endregion

        #endregion



    }
}