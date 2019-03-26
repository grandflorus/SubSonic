<%@ WebHandler Language="C#" Class="ajax" %>

using System;
using  System.Collections.Generic;
using System.Web;
using System.Text;

public class ajax : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        string action = context.Request.QueryString["action"];
        switch (action)
        {
            case "Show":
                Show(); break;
            case "ShowChart":
                ShowChart();break;
        }
    }

    protected static void Show()
    {
     //   System.Threading.Thread.Sleep(3000);
        string ID = HttpContext.Current.Request["ID"];
        WriteJson("ID", ID);
    }

    private  void ShowChart()
    {
        //考虑到图表的series数据为一个对象数组 这里额外定义一个series的类
        List<Series> seriesList = new List<Series>();

        Series series1 = new Series();
        series1.name = "actual";
        series1.type = "bar";
        series1.data = new List<double>(){ 26061649.1, 26161649.41, 21782199.14, 27749708.51, 8819500.47, 27711342.26, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 };

        Series series2 = new Series();
        series2.name = "Budget";
        series2.type = "bar";
        series2.data = new List<double>() { 28176503.36, 26161649.41, 21782199.14, 27749708.51, 8819500.47, 27711342.26, 2777777.00, 0.00, 0.00, 0.00, 0.00, 0.00, };

        seriesList.Add(series1);
        seriesList.Add(series2);
        var newObj = new
        {
            series = seriesList
        };

        string strJson = ToJson(newObj);

        WriteJson(strJson);
    }

    public static string ToJson( object obj)
    {
        return NewtonsoftJson(obj);
    }

    public static string NewtonsoftJson(object obj)
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.None);
    }

    private static void WriteJson(string str)
    {
        HttpContext.Current.Response.Write(str);
        //HttpContext.Current.Response.ContentType = "text/plain"; //设置MIME格式
        HttpContext.Current.Response.End();
    }
    

    /// <summary>
    /// 输出Json
    /// </summary>
    /// <param name="key"></param>
    /// <param name="val"></param>
    private static void WriteJson(string key, string val)
    {
        HttpContext.Current.Response.Write(GetJSON(key, val));
        HttpContext.Current.Response.ContentType = "text/plain"; //设置MIME格式
        HttpContext.Current.Response.End();
    }

   
    
    /// <summary>
    /// 获取JSON字符串
    /// </summary>
    /// <param name="dic"></param>
    /// <returns></returns>
    private static string GetJSON(string key, string val)
    {
        return string.Format("{{\"{0}\":\"{1}\"}}", key, val);
    }


    /// <summary>
    /// 定义一个Series类 设置其每一组sereis的一些基本属性
    /// </summary>
    class Series
    {
        /// <summary>
        /// sereis序列组id
        /// </summary>
        //public int id
        //{
        //    get;
        //    set;
        //}

        /// <summary>
        /// series序列组名称
        /// </summary>
        public string name
        {
            get;
            set;
        }

        /// <summary>
        /// series序列组呈现图表类型(line、column、bar等)
        /// </summary>
        public string type
        {
            get;
            set;
        }

        /// <summary>
        /// series序列组的数据为数据类型数组
        /// </summary>
        public List<double> data
        {
            get;
            set;
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}