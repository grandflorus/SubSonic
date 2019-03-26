<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="配件.aspx.cs" Inherits="Solution.Web.Managers.WebManage.配件需求预测.配件" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>配件信息查询</title>
</head>
<body>
    <form id="form1" runat="server">
    <f:pagemanager id="PageManager1" runat="server" />
    <f:panel id="Panel1" runat="server" title="配件信息查询" enableframe="false" bodypadding="10px"
        enablecollapse="True">
        <toolbars>
            <f:Toolbar ID="toolBar" runat="server">
                <Items>
                    <f:Button ID="ButtonRefresh" runat="server" Text="刷新" Icon="ArrowRefresh" OnClick="ButtonRefresh_Click" CssClass="inline"></f:Button>
                    <f:Button ID="ButtonSearch" runat="server" Text="查询" Icon="Magnifier" OnClick="ButtonSearch_Click"></f:Button>
                 
                </Items>
            </f:Toolbar>
        </toolbars>
        <items>
            <f:Form ID="Form6" ShowBorder="True" BodyPadding="5px" ShowHeader="False" runat="server">
                <Rows>
                    <f:FormRow ID="FormRow1" runat="server">
                        <Items>
                            <f:TextBox Label="配件名称" ID="txtAssemName" runat="server" NextFocusControl="ButtonSearch_Click"  Width="260px" />
                            <f:TextBox Label="配件类型" ID="txtTypeName" runat="server" Width="260px" NextFocusControl="ButtonSearch"/>
                        </Items>
                    </f:FormRow>
                    <f:FormRow ID="FormRow2" runat="server">
                        <Items>
                            <f:TextBox Label="配件编号" ID="txtAssemCode" runat="server" Width="260px" />
                            <f:TextBox Label="存放仓库" ID="txtLocationStock" runat="server" Width="260px" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow ID="FormRow3" runat="server">
                        <Items>
                            <f:TextBox Label="生产厂家" ID="txtVendorID" runat="server" Width="260px" />
                            <f:TextBox Label="生产地址" ID="txtProLocation" runat="server" Width="260px" />
                            
                        </Items>
                    </f:FormRow>

                </Rows>
            </f:Form>
            <f:Grid ID="Grid1" EnableFrame="false" EnableCollapse="true" AllowSorting="true" IsDatabasePaging="True"
            PageSize="15" ShowBorder="true" ShowHeader="False" AllowPaging="true" runat="server" DataKeyNames="Id" EnableColumnLines="true"
            OnPageIndexChange="Grid1_PageIndexChange" OnSort="Grid1_Sort">
                <Columns>
                    <f:RowNumberField Width="30px" />
                    <f:BoundField Width="250px" DataField="AssemName" SortField="Id" HeaderText="配件名称" />
                    <f:BoundField Width="180px" DataField="TypeName" SortField="Id" HeaderText="配件类型" />
                    <f:BoundField Width="100px" DataField="AssemCode" SortField="Id" HeaderText="配件编号"  />
                    <f:BoundField Width="180px" DataField="VendorID" SortField="Id" HeaderText="生产厂家" />
                    <f:BoundField Width="150px" DataField="ProLocation" SortField="Id" HeaderText="生产地址" />
                    <f:BoundField Width="150px" DataField="LocationStock" SortField="Id" HeaderText="存放仓库" />
                    <f:BoundField Width="100px" DataField="Unit" SortField="Id" HeaderText="计量单位" />
                    <f:BoundField Width="250px" DataField="Remark" HeaderText="备注" ExpandUnusedSpace="true" />
                </Columns>
            </f:Grid>
            <f:Label runat="server" ID="lblSpendingTime" Text=""></f:Label>
            <f:HiddenField runat="server" ID="SortColumn" Text="Id"></f:HiddenField>
        </items>
    </f:panel>
    </form>
</body>
</html>


