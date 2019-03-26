<%@ WebHandler Language="C#" Class="Chart" %>

using System;
using System.Web;

public class Chart : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        string action = context.Request.QueryString["Action"];

        switch (action)
        {
        }
        
        
    }
    
    
    
        /// <summary>
        /// 显示自定义菜单
        /// </summary>
     /*   private void ShowMenu()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();

            List<SubButton> sub_button2 = new List<SubButton>() {
                new SubButton(){type="click", name="优惠活动",key="优惠活动"},
                new SubButton(){type="click", name="新品速递",key="新品速递"},
                new SubButton(){type="click", name="每日惊喜",key="每日惊喜"}
          };
            List<SubButton> sub_button3 = new List<SubButton>() {
                 new SubButton(){type="click", name="会员积分查询",key="会员积分查询"},
             new SubButton(){type="click", name="APP下载",key="APP下载"},
             new SubButton(){type="click", name="网络旗舰店",key="网络旗舰店"},
             new SubButton(){type="click", name="留言反馈",key="留言反馈"}
          };
            Team team = new Team()
            {
                button = new List<BaseButton>() { new button() { type = "click", name = "金价查询", key = "金价查询"}
            ,new SubBaseButton() { name = "神秘宝盒",sub_button=sub_button2} 
            ,new SubBaseButton() {name = "更多",sub_button=sub_button3} }
            };

            string json = js.Serialize(team);
            var client = new WebClient();
            client.Headers["Content-Type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            var strResult = client.UploadString(string.Format("https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}", HttpContext.Current.Application["token"]), json);
            HttpContext.Current.Response.Write(strResult);
        }
      * */
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

    }