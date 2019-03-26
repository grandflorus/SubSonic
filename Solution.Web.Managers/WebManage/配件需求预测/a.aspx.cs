using System;
using System.Collections.Generic;
using DotNet.Utilities;

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
 *   描    述：配件预测文件
 *             
 *   修 改 人：
 *   修改日期：
 *   修改原因：
 ***********************************************************************/
using SubSonic.Query;


namespace Solution.Web.Managers.WebManage.配件需求预测
{
    public partial class a  : PageBase
    {
        //int _id = 0;

        //#region Page_Load
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    //获取管理员Id——用于查询指定管理员日志
        //    //_id = RequestHelper.GetInt0("Id");

        //    //if (!IsPostBack)
        //    //{
        //    //    //设定初始化时间
        //    //    dpStart.Text = DateTime.Now.ToString("yyyy-M-d");
        //    //    dpEnd.Text = DateTime.Now.AddDays(1).ToString("yyyy-M-d");

        //    //    LoadData();
        //    //}
        //}
        //#endregion
        //#region Page_Load
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        //获取ID值
        //        hidId.Text = RequestHelper.GetInt0("Id") + "";

        //        //加载数据
        //        LoadData();
        //    }
        //}

        #region 接口函数，用于UI页面初始化，给逻辑层对象、列表等对象赋值
        public override void Init()
        {
            //逻辑对象赋值
            bll = RainFallBll.GetInstence();
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
            RainFallBll.GetInstence().BindGrid(Grid1, Grid1.PageIndex + 1, Grid1.PageSize, InquiryCondition(), sortList);
        }

        /// <summary>
        /// 查询条件
        /// </summary>
        /// <returns></returns>
        private List<ConditionHelper.SqlqueryCondition> InquiryCondition()
        {
            var wheres = new List<ConditionHelper.SqlqueryCondition>();

            #region    配件名称查询      
            //配件名称
            if (!string.IsNullOrEmpty(txtAssemName.Text.Trim()))
            {
                wheres.Add(new ConditionHelper.SqlqueryCondition(ConstraintType.And, RainFallTable.AddYear, Comparison.Like, "%" + StringHelper.FilterSql(txtAssemName.Text) + "%"));
            }


            #endregion

            #region    生产地址查询      
            //生产地址
            if (!string.IsNullOrEmpty(txtTypeName.Text.Trim()))
            {
                wheres.Add(new ConditionHelper.SqlqueryCondition(ConstraintType.And, RainFallTable.RainCount, Comparison.Like, "%" + StringHelper.FilterSql(txtTypeName.Text) + "%"));
            }


            #endregion



            return wheres;



        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

                Button2.OnClientClick = Window2.GetShowReference("./iframe_iframe_window1.aspx");
                Button3.OnClientClick = Window2.GetShowReference("./WebForm1.aspx");

            }

            

        }


        //public override string Save()
        //{
        //    string result = string.Empty;

        //    try
        //    {
        //        #region 赋值

        //        //获取实体
        //        var model = new RainFall(x => x.Id == id);
        //        model.WebName = StringHelper.Left(txtWebName.Text, 50);
        //        model.WebDomain = StringHelper.Left(txtWebDomain.Text, 50, true, false);
        //        model.WebEmail = StringHelper.Left(txtWebEmail.Text, 50, true, false);

        //        //var model1 = new RainFall(x => x.Id == id);


        //        //model.WebName  = StringHelper.GetArrayStr(model.WebName)+"A";
        //        #endregion

        //        //----------------------------------------------------------
        //        //存储到数据库
        //        WebConfigBll.GetInstence().Save(this, model);


                //public RainForm()
                //    {
                //        InitializeComponent();
                //        this.chart1.ChartAreas[0].AxisX.Interval = 1;
                //        this.chart1.ChartAreas[0].AxisX.Minimum = 1961;
                //        this.chart1.ChartAreas[0].AxisY.Minimum = 600;
                //        this.chart1.ChartAreas[0].AxisY.Maximum = 1700;
                //        for (int i = 0; i < Program.length_Rain; i++)
                //            this.listBox1.Items.Add(Program.iniYearData_Rain[i].year + "年" + "-------------------------------------------------"
                //                + Program.iniYearData_Rain[i].data + "  mm");
                //    }
                //  预测算法

            }
}
#endregion