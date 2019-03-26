using DotNet.Utilities;
using FineUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Solution.Logic.Managers;

namespace Solution.Web.Managers.WebManage.配件需求预测
{
    public partial class iframe_iframe_window1 : System.Web.UI.Page
    {
        private bool click;

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnPostBackClose_Click(object sender, EventArgs e)
        {
            PageContext.RegisterStartupScript(FineUI.ActiveWindow.GetHidePostBackReference());
        }
        public double[] result_guess = new double[Forecast.testNum_Rain];
        protected void ButtonGetData_Click(object sender, EventArgs e)
        {

            //int startyear =  int.Parse(Forecast.iniYearData_Rain[4].year);
            //int startyear = int.Parse(Forecast.iniYearData_Rain[4].year);


            //if (click == false)
            //    Alert.ShowInTop("这是服务器端事件");
            //else
            //    for (int i = 0; i < Forecast.testNum_Rain; i++)
            //    {
            //        double[] inp = new double[4] { Forecast.testInput_Rain[i][0],
            //                                       Forecast.testInput_Rain[i][1],
            //                                       Forecast.testInput_Rain[i][2],
            //                                       Forecast.testInput_Rain[i][3] };

            //        for (int j = 0; j < 4; ++j)
            //            inp[j] = Forecast.premnmx(inp[j], Forecast.min_Rain[j], Forecast.max_Rain[j]);

            //        double[] t = { inp[0], inp[1], inp[2], inp[3] };

            //        // 使用网络对训练样本计算输出
            //        double[] result = Forecast.network_Rain.Compute(t);
            //        result_guess[i] = ((result[0] + 1) * (Forecast.max_Rain[0] - Forecast.min_Rain[0]) / 2) + Forecast.min_Rain[0];
            //        //this.ListBox998.Items.Add((1616 + i).ToString() + "预测值为" + result_guess[i].ToString());
            //    }
        }

        protected void btnServerClick_Click(object sender, EventArgs e)
        {
            Alert.ShowInTop("这是服务器端事件");
        }
    }
}

      