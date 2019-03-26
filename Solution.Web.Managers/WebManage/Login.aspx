<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Solution.Web.Managers.WebManage.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>汽车服务预定系统——后端管理系统</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label>
            本框架内置 ExtJS 库，如果运行后会出现：ERROR: extjs folder is lost! 这个错误，点击确认后自动跳转到ExtJS 库下载地址，请自行下载后手工添加到Solution.Web.Managers项目的根目录中即可正常运行</label>
    </div>
    <f:PageManager ID="PageManager1" AutoSizePanelID="regionPanel" runat="server" />

    <f:Window ID="LoginWin" runat="server" Title="登录" IsModal="false" EnableClose="false" Width="350px" Hidden="False">
        <Items>
            <f:SimpleForm ID="SimpleForm1" runat="server" ShowBorder="false" BodyPadding="10px"
                LabelWidth="60px" ShowHeader="false">
                <Items>
                    <f:TextBox ID="txtUserName" Label="用户名" runat="server" Height="32px">
                    </f:TextBox>
                    <f:TextBox ID="txtPassword" Label="密  码" TextMode="Password" runat="server" Height="32px">
                    </f:TextBox>
                    <f:TextBox ID="txtCaptcha" Label="验证码" runat="server" Height="32px">
                    </f:TextBox>
                    <f:Panel ID="Panel1" CssStyle="padding-left:65px;" ShowBorder="false" ShowHeader="false"
                        Height="50px" runat="server">
                        <Items>
                            <f:Image ID="imgCaptcha" CssStyle="float:left;" runat="server" ImageWidth="100px"
                                ImageHeight="32px">
                            </f:Image>
                            <f:LinkButton CssStyle="float:left;margin-top:8px;margin-right:100px;" ID="btnRefresh"
                                Text="看不清？" runat="server" OnClick="btnRefresh_Click">
                            </f:LinkButton>
                        </Items>
                    </f:Panel>
                </Items>
            </f:SimpleForm>
        </Items>
        <Toolbars>
            <f:Toolbar ID="Toolbar1" runat="server" ToolbarAlign="Right" Position="Footer">
                <Items>
                    <f:Button ID="Button1" Text="登录" Type="Submit" ValidateForms="SimpleForm1" ValidateTarget="Top"
                        runat="server" OnClick="BtnLogin_Click">
                    </f:Button>
                    <f:Button ID="btnReset" Text="重置" Type="Reset" EnablePostBack="false" runat="server">
                    </f:Button>
                </Items>
            </f:Toolbar>
        </Toolbars>
    </f:Window>
    </form>
</body>
</html>
