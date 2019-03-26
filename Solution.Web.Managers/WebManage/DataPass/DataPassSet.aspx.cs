using System;
using DotNet.Utilities;
using Solution.DataAccess.DataModel;
using Solution.Logic.Managers;
using Solution.Web.Managers.WebManage.Application;
using FineUI;
using System.Data;

/***********************************************************************
 *   作    者：PengFei（彭飞）
 *   邮    箱：xjvspf@163.com
 *   QQ    号：124041108
 *  
 *   创建日期：2017-10-17
 *   文件名称：WebConfigEdit.aspx.cs
 *   描    述：系统配置编辑页面
 *             
 *   修 改 人：
 *   修改日期：
 *   修改原因：
 ***********************************************************************/
namespace Solution.Web.Managers.WebManage.DataPass
{
    public partial class DataPassSet : PageBase
    {



        private int id = 1;
        //private string[] a;

        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //加载数据
                BindSheng();
                BindShi();
                BindXian();
                
                LoadData();
            }
        }

        private void BindSheng()
        {
            BranchBll.GetInstence().BandDropDownList(this, ddlSheng);

            ddlSheng.Items.Insert(0, new ListItem("选择省份", "-1"));
            ddlSheng.SelectedValue = "-1";
        }

        private void BindShi()
        {
            string sheng = ddlSheng.SelectedValue;

            if (sheng != "-1")
            {
                BranchBll.GetInstence().BandDropDownList(this, ddlSheng);
            }

            ddlShi.Items.Insert(0, new ListItem("选择地区市", "-1"));
            ddlShi.SelectedValue = "-1";

            // 是否禁用
            ddlShi.Enabled = !(ddlShi.Items.Count == 1);
        }

        private void BindXian()
        {
            string shi = ddlShi.SelectedValue;

            if (shi != "-1")
            {
                BranchBll.GetInstence().BandDropDownList(this, ddlSheng);
            }

            ddlXian.Items.Insert(0, new ListItem("选择县级市", "-1"));
            ddlXian.SelectedValue = "-1";

            // 是否禁用
            ddlXian.Enabled = !(ddlXian.Items.Count == 1);
        }

        protected void ddlSheng_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlShi.Items.Clear();
            BindShi();

            ddlXian.Items.Clear();
            BindXian();
        }

        protected void ddlShi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlXian.Items.Clear();
            BindXian();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Label1.Text = "您选择为：" + ddlSheng.SelectedValue + " | " + ddlShi.SelectedValue + (ddlXian.SelectedValue == "-1" ? "" : " | " + ddlXian.SelectedValue);
        }

        #endregion

        #region 接口函数，用于UI页面初始化，给逻辑层对象、列表等对象赋值
        public override void Init()
        {

        }
        #endregion

        #region 加载数据
        /// <summary>读取数据</summary>
        public override void LoadData()
        {
            ////获取指定ID的系统配置内容
            //var model = DataPassTestBll.GetInstence().GetModelForCache(x => x.Id == 10);
            //if (model == null)
            //    return;

            ////NumberBox1.Text = model.a;
            ////NumberBox2.Text = model.b;
            ////NumberBox3.Text = model.c;
            //NumberBox4.Text = model.d;







        }

        #endregion





        #region 保存
        /// <summary>
        /// 数据保存
        /// </summary>
        /// <returns></returns>

        //var model1 = new RainFall(x => x.Id == id);



        #endregion


        public override string Save()

        {
            string result = string.Empty;
            int id = ConvertHelper.Cint0(hidId.Text);
            if (id == 0)
            {

                try
                {
                    #region 赋值

                    //获取实体
                    var model = new DataPassTest(x => x.Id == id);
                    //model.a = NumberBox1.Text;
                    //model.b = NumberBox2.Text;
                    //model.c = NumberBox3.Text;
                    int num1 = int.Parse(model.a);
                    int num2 = int.Parse(model.b);
                    int num3 = int.Parse(model.c);
                    int sum ;
                    int[]   weight = new int[] { 12, 2, 3};
                    sum = weight[0] * num1;
                    var model1 = new ResultTest(x => x.Id == id);
                    model1.SummerTest = sum.ToString();


                    //----------------------------------------------------------
                    //存储到数据库
                    DataPassTestBll.GetInstence().Save(this, model);
                    ResultTestBll.GetInstence().Save(this, model1);
                    if (model.a.Length > 0)
                    {

                        return "修改成功！";
                    }
                }



                catch (Exception e)
                {
                    result = "保存失败！";

                    //出现异常，保存出错日志信息
                    CommonBll.WriteLog(result, e);
                }

               
            }
            return result;
        }
    }
}
      
            #endregion
        

