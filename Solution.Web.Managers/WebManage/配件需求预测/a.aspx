<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="a.aspx.cs" Inherits="Solution.Web.Managers.WebManage.配件需求预测.a" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>配件预测</title>
     
    <!-- 引入 echarts.js -->
    
    <script type="text/javascript" src=".//echarts.js"></script>

       
    
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


    <form id="form1" runat="server">
    <f:pagemanager id="PageManager1" runat="server" />
    <f:panel id="Panel1" runat="server" title="配件预测" enableframe="false" bodypadding="10px"
        enablecollapse="True">
        <toolbars>
            <f:Toolbar ID="toolBar" runat="server">
                <Items>
                    <f:Button ID="ButtonRefresh" runat="server"     Text="刷新页面"  Icon="ArrowRefresh" OnClick="ButtonRefresh_Click" CssClass="inline"></f:Button>
                    <f:Button ID="ButtonSearch" runat="server"      Text="原始库存"  Icon="Magnifier"    OnClick="ButtonSearch_Click"></f:Button>  
                           
                    <f:Button ID="Button2" EnablePostBack="false" Text="预测结果静态" runat="server">
        </f:Button>
                    <f:Button ID="Button3" runat="server"    Text="预测结果动态" EnablePostBack="False"></f:Button>
                           
        <f:Window ID="Window2" Hidden="true" EnableIFrame="true" EnableMaximize="true"
            EnableResize="true" Target="Parent" runat="server" Height="450px" Width="900px"
            Title="窗体二">
        </f:Window>
        
                </Items>
            </f:Toolbar>
                              </toolbars>
              

        <items>
            <f:Form ID="Form6" ShowBorder="True" BodyPadding="5px" ShowHeader="False" runat="server">
                <Rows>
                    <f:FormRow ID="FormRow1" runat="server">
                        <Items>
                            <f:TextBox Label="年份" ID="txtAssemName" runat="server" NextFocusControl="ButtonSearch_Click"  Width="260px" />
                            <f:TextBox Label="库存数量" ID="txtTypeName" runat="server" Width="260px" NextFocusControl="ButtonSearch_Click"/>
                        </Items>
                    </f:FormRow>
                  
                    

                </Rows>
            </f:Form>
            <f:Grid ID="Grid1" EnableFrame="false" EnableCollapse="true" AllowSorting="true" IsDatabasePaging="True"
            PageSize="50" ShowBorder="true" ShowHeader="False" AllowPaging="true" runat="server" DataKeyNames="Id" EnableColumnLines="true"
            OnPageIndexChange="Grid1_PageIndexChange" OnSort="Grid1_Sort">
                <Columns>
                    <f:RowNumberField Width="30px" ID="ctl06" ColumnID="Panel1_Grid1_ctl06" />
                    <f:BoundField Width="250px" DataField="AddYear" SortField="Id" HeaderText="年份" ID="ctl07" ColumnID="Panel1_Grid1_ctl07" />
                    <f:BoundField Width="180px" DataField="RainCount" SortField="RainCount" HeaderText="库存数量" ID="ctl08" ColumnID="Panel1_Grid1_ctl08" />
                    
                </Columns>
            </f:Grid>
            <f:Label runat="server" ID="lblSpendingTime" Text=""></f:Label>
            <f:HiddenField runat="server" ID="SortColumn" Text="Id"></f:HiddenField>
        </items>
    </f:panel>
    </form>
</body>
</html>


