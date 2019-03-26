<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iframe_iframe_window1.aspx.cs" Inherits="Solution.Web.Managers.WebManage.配件需求预测.iframe_iframe_window1" %>

<!DOCTYPE html>
<html>
<head runat="server"> <script type="text/javascript" src=".//echarts.js"></script>
    <title></title>

</head>
<body>
     <!-- 为ECharts准备一个具备大小（宽高）的Dom -->
    <div id="main" style="width: 600px;height:400px;"></div>
     <script type="text/javascript">
         require.config({
             paths: {
                 echarts: 'http://echarts.baidu.com/build/dist'

             }
         });
         require(
               [
                   'echarts',
                   'echarts/chart/bar' // 使用柱状图就加载bar模块，按需加载
               ],
               function (ec) {
                   // 基于准备好的dom，初始化echarts图表
                   var myChart = ec.init(document.getElementById('main'));

                   var option = {
                       tooltip: {
                           show: true
                       },
                       legend: {
                           data: ['Actual', 'Budget']
                       },
                       xAxis: [
                           {
                               type: 'category',
                               data: ['一月', '二月', '三月', '四月', '五月', '六月', '七月', '八月', '九月', '十月', '十一月', '十二月']
                           }
                       ],
                       yAxis: [
                           {
                               type: 'value'
                           }
                       ],
                       series: [
                          { "name": "actual", "type": "bar", "data": [26061649.1, 26161649.41, 21782199.14, 27749708.51, 8819500.47, 27711342.26, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0] } ,
                            {
                                'name': 'Budget',
                                'type': 'bar',
                                'data': [28176503.36, 26161649.41, 21782199.14, 27749708.51, 8819500.47, 27711342.26, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, ]
                            }
                       ]
                   };
                   // 为echarts对象加载数据 
                   myChart.setOption(option);})
    </script>
   <%-- <form id="form1" runat="server">
        <f:PageManager AutoSizePanelID="formPanel" ID="PageManager1" runat="server"></f:PageManager>
        <f:Panel ID="formPanel" ShowBorder="false" ShowHeader="false"
            runat="server">
            <Toolbars>
                <f:Toolbar runat="server">
                    <Items>
                        <f:Button ID="btnPostBackClose" runat="server" OnClick="btnPostBackClose_Click"
                            Text="关闭-回发父页面">
                        </f:Button>
                        <f:Button ID="ButtonGetData0" runat="server"  OnClick="ButtonGetData_Click"
                            Text="获取原始数据">
                        </f:Button>
                        <f:Button ID="btnServerClick" Text="服务器端事件" OnClick="btnServerClick_Click" runat="server">
                         </f:Button>
                        
                       
                        <f:Button ID="ButtonGetData1" runat="server" OnClick="ButtonGetData_Click" Text="生成测试数据">
                        </f:Button>
                        <f:Button ID="ButtonGetData2" runat="server" OnClick="ButtonGetData_Click" Text="预测结果">
                        </f:Button>
                        
                       
                    </Items>
                </f:Toolbar>
            </Toolbars>
            <Items>
                <f:Label ID="labResult" CssStyle="font-weight:bold;" runat="server">     
                   
                </f:Label>

            </Items>
        </f:Panel>
        <f:Window ID="Window1" Hidden="true" EnableIFrame="true" runat="server"
            EnableMaximize="true" EnableResize="true" Height="300px" Width="600px"
            Title="窗体三">
        </f:Window>
        <f:Window ID="Window2" Hidden="true" EnableIFrame="true" runat="server"
            EnableMaximize="true" EnableResize="true" Target="Parent" Height="300px" Width="600px"
            CloseAction="HidePostBack" Title="窗体四">

        </f:Window>


       <%-- <asp:ListBox ID="ListBox1" runat="server"  Width="1186px"></asp:ListBox>--%>

        
    <%--</form>--%>

   

</body>
</html>