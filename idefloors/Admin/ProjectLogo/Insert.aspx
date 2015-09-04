<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="Insert.aspx.cs" Inherits="Admin_ProjectLogo_Insert" %>
<%@ register namespace="CustomEditor" tagprefix="one" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/ProjectLogo/QLProjectLogo.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Logo Dự Án Thi Công</a> >> Tạo mới
   
</div>
<div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 720px;margin-top:30px;">
          <div class="inputSmallContain">
                <%--<div>
                    <span>Tiêu đề</span>
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </div>--%>
                <div>
                    <span>Liên kết</span>
                    <asp:TextBox ID="txtLink" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Hình Logo (.jpg)</span>
                    <asp:FileUpload ID="fileUploadImg" runat="server" Width="400px"/>
                     <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadImg" Display="Dynamic"></asp:RequiredFieldValidator>
                     <asp:TextBox ID="txtImg" Visible="false" runat="server"></asp:TextBox>
                </div>  
                <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Tạo Mới" OnClick="btnSubmit_Click"></asp:Button>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn_gray"  NavigateUrl="~/Admin/ProjectLogo/QLProjectLogo.aspx">
                        Bỏ Qua
                    </asp:HyperLink>
                </div>
            </div>
        </div>
    </div>
     <asp:ToolkitScriptManager ID="TkScript1" runat="server" ScriptMode="Release" EnablePageMethods="true">
    </asp:ToolkitScriptManager>
</asp:Content>

