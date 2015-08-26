<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Hệ thống quản lý</title>
    <link rel="stylesheet" type="text/css" href="/Admin/CSS/Login.css"/>
</head>
<body id="mainLogin">
    <div class="body" style="background-color: #363b47">
        <table cellspacing="0" width="100%">
            <tbody>
                <tr>
                    <td class="companyLogo">
                        <a href="#" target="_blank" class="topLogo">
                            <!--<img src="#" name="logo" border="0" height="50">-->
                        </a>
                    </td>
                   
                </tr>
            </tbody>
        </table>
    </div>

    <table id="pageLayout" border="0" cellpadding="0" cellspacing="0" width="100%">
        <tbody>
            <tr>
                <td id="screenWH">
                    <div class="screenBody" id="login">
                        <div class="formArea">
                            <table cellpadding="0" cellspacing="0" width="100%">
                                <tbody>
                                    <tr>
                                        <td id="loginTitle">
                                            <b> <br /> 
                                            Hệ thống quản lý</b>                                                
                                        </td>
                                    </tr>
                                    <tr>
                                        <td id="loginForm">
                                            <p>
                                                Điền thông tin của tên đăng nhập và mật khẩu, Sau đó bấm "Đăng Nhập"
                                            </p>

                                            <form id="form0" name="form0" runat="server" target="_parent">
                                            <table class="formFields" cellspacing="0" width="100%">
                                                <tbody>
                                                    <tr>
                                                        <td valign="top">
                                                            <table>
                                                                <tr>
                                                                    <td width="120">
                                                                        <asp:Label ID="lblUserName" runat="server" AssociatedControlID="txtUserName">Tên đăng nhập</asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtUserName" runat="server" Width="200px" Height="16px"></asp:TextBox>
                                                                        <asp:RequiredFieldValidator ID="rqUserName" runat="server" SetFocusOnError="true"
                                                                            ControlToValidate="txtUserName" ErrorMessage="*" ValidationGroup="ctl00$ctl01$Login1"></asp:RequiredFieldValidator>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="lblPassword" runat="server" AssociatedControlID="txtPassword">Mật khẩu</asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="200px" Height="16px"></asp:TextBox>
                                                                        <asp:RequiredFieldValidator ID="rqPassword" runat="server" SetFocusOnError="true"
                                                                            ControlToValidate="txtPassword" ErrorMessage="*" ValidationGroup="ctl00$ctl01$Login1"></asp:RequiredFieldValidator>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" CommandName="Login" Text="Đăng nhập" ValidationGroup="ctl00$ctl01$Login1" Width="90" />
                                                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Remember" Visible="false" Checked="true" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            </form>
                                            <div class="formButtons">
                                                <form name="form1">
                                                <table cellspacing="0" width="100%">
                                                    <tbody>
                                                        <tr>
                                                            <td class="main" id="get_password">
                                                                <input autocomplete="off" name="login_name" value="" type="hidden">
                                                                <a href="/Channels/Other/UserManagement/RecoveryPassword.aspx">
                                                                Forgot your password?</a>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                                </form>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
    
    <script language="javascript">document.getElementById('txtUserName').focus();</script>

</body>

</html>
