<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataPassSet.aspx.cs" Inherits="Solution.Web.Managers.WebManage.DataPass.DataPassSet" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>系统配置编辑</title>
</head>
<body>
        


        <form id="form1" runat="server">
          <f:pagemanager id="PageManager1" runat="server" />
         <f:SimpleForm ID="SimpleForm1" BodyPadding="5px"  LabelAlign="Top" EnableCollapse="true"
            Title="一级指标" runat="server" LabelWidth="120px">
            <Items> <f:HiddenField runat="server" ID="hidId" Text="0">
                    </f:HiddenField>
                                          
              <f:Grid ID="Grid1" EnableFrame="false" EnableCollapse="true" AllowSorting="true" IsDatabasePaging="True"
            PageSize="15" ShowBorder="true" ShowHeader="False" AllowPaging="true" runat="server" DataKeyNames="Id" EnableColumnLines="true"
            OnPageIndexChange="Grid1_PageIndexChange" OnSort="Grid1_Sort">
                <Columns>
                    <f:RowNumberField Width="30px" />
                    <f:BoundField Width="400px" DataField="AssemName" SortField="Id" HeaderText="一级指标1" />
                    <f:BoundField Width="400px" DataField="TypeName" SortField="Id" HeaderText="一级指标2" />
                    <f:BoundField Width="400px" DataField="AssemCode" SortField="Id" HeaderText="一级指标3"  />
                    <f:BoundField Width="400px" DataField="VendorID" SortField="Id" HeaderText="一级指标4" />
                 
                </Columns>
            </f:Grid>   

               
            </Items>

        </f:SimpleForm>
        
        <f:SimpleForm ID="SimpleForm2" BodyPadding="5px"  EnableCollapse="true"
            Title="二级指标" runat="server">

            </f:SimpleForm>
            
           
                 <f:Form ID="Form6" ShowBorder="True" BodyPadding="5px" ShowHeader="False" runat="server">
                <Rows>
                    <f:FormRow ID="FormRow1" runat="server">
                        <Items>
                                <f:TextBox Label="指标1" ID="txtAssemName" runat="server"   Width="260px" />
                                <f:TextBox Label="指标2" ID="txtTypeName" runat="server" Width="260px" />
                                <f:TextBox Label="指标3" ID="TextBox1" runat="server" Width="260px" />
                                <f:TextBox Label="指标4" ID="TextBox6" runat="server" Width="260px" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow ID="FormRow2" runat="server">
                        <Items>
                            <f:TextBox Label="指标1" ID="txtAssemCode" runat="server" Width="260px" />
                            <f:TextBox Label="指标2" ID="txtLocationStock" runat="server" Width="260px" />
                            <f:TextBox Label="指标3" ID="TextBox2" runat="server" Width="260px" />
                            <f:TextBox Label="指标4" ID="TextBox3" runat="server" Width="260px" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow ID="FormRow3" runat="server">
                        <Items>
                            <f:TextBox Label="指标1" ID="txtVendorID" runat="server" Width="260px" />
                            <f:TextBox Label="指标2" ID="txtProLocation" runat="server" Width="260px" />
                            <f:TextBox Label="指标3" ID="TextBox4" runat="server" Width="260px" />
                            <f:TextBox Label="指标4" ID="TextBox5" runat="server" Width="260px" />
                            
                        </Items>
                    </f:FormRow>

                </Rows>

            </f:Form>
                 <f:Button ID="btnSubmit" runat="server" ValidateForms="SimpleForm1" Text="提交表单" OnClick="ButtonSave_Click">
                </f:Button>
           
        
        <br />
        <f:Label ID="labResult" ShowLabel="false" runat="server" CssStyle="font-weight:bold;">
        </f:Label>
  
       
    



    
<%--    <f:Panel ID="Panel1" runat="server" EnableFrame="false" BodyPadding="10px" EnableCollapse="True" ShowHeader="False" Width="600px">
        <Toolbars>
            <f:Toolbar ID="toolBar" runat="server">
                <Items>
                    <f:Button ID="ButtonSave" runat="server" Text="保存" Icon="Disk" OnClick="ButtonSave_Click"></f:Button>
                </Items>
            </f:Toolbar>
        </Toolbars>
        <Items>
            <f:Panel ID="Panel2" runat="server" EnableFrame="false" BodyPadding="5px" EnableCollapse="True" ShowHeader="False" ShowBorder="False" Width="600px">
                <Items>
                    <f:GroupPanel ID="GroupPanel1" runat="server" BoxConfigAlign="Center" Width="570px"
                        EnableCollapse="True" Title="网站基础信息">
                        <Items>
                            <f:TextBox ID="txtWebName" Label="网站名称" runat="server" Width="500px">
                            </f:TextBox>
                            <f:TextBox ID="txtWebDomain" Label="网站地址" runat="server" Width="500px">
                            </f:TextBox>
                            <f:TextBox ID="txtWebEmail" Label="管理员邮箱" runat="server" Width="500px">
                            </f:TextBox>
                            <f:TextBox ID="TextBox1" Label="Seo标题" runat="server" Width="500px">
                            </f:TextBox>
                            <f:TextBox ID="TextBox2" Label="Seo关键字" runat="server" Width="500px">
                            </f:TextBox>
                            <f:TextBox ID="TextBox3" Label="Seo说明" runat="server" Width="500px">
                            </f:TextBox>
                        </Items>
                    </f:GroupPanel>
                    
                
                </Items>
            </f:Panel>
        </Items>
    </f:Panel>--%>



          
<%--    </form>
    <form id="form2" runat="server">
        <f:PageManager ID="PageManager2" runat="server" />--%>
        <f:SimpleForm ID="SimpleForm3" runat="server" BodyPadding="5px" Width="550px" EnableCollapse="true"
            Title="简单表单">
            <Items>
                <f:DropDownList ID="ddlSheng" Label="省份" ShowRedStar="true" CompareType="String"
                    CompareValue="-1" CompareOperator="NotEqual" CompareMessage="请选择省份！" runat="server"
                    AutoPostBack="true" OnSelectedIndexChanged="ddlSheng_SelectedIndexChanged">
                </f:DropDownList>
                <f:DropDownList ID="ddlShi" Label="地区市" ShowRedStar="true" CompareType="String"
                    CompareValue="-1" CompareOperator="NotEqual" CompareMessage="请选择地区市！" runat="server" Enabled="false"
                    AutoPostBack="true" OnSelectedIndexChanged="ddlShi_SelectedIndexChanged">
                </f:DropDownList>
                <f:DropDownList ID="ddlXian" ShowRedStar="true" CompareType="String" CompareValue="-1"
                    CompareOperator="NotEqual" CompareMessage="请选择县区市！" Label="县区市" runat="server" Enabled="false">
                </f:DropDownList>
                <f:Button ID="Button1" runat="server" Text="获取选中的省市县" ValidateForms="SimpleForm1"
                    ValidateTarget="Top" OnClick="btnSubmit_Click">
                </f:Button>

            </Items>
        </f:SimpleForm>
        <br />
        <f:Label ID="Label1" runat="server" ShowLabel="false" CssStyle="font-weight:bold;">
        </f:Label>
        <br />
    </form>
</body>
</html>
