<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Admin_Certificate_Edit" %>
<%@ register namespace="CustomEditor" tagprefix="one" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/Certificate/QLCertificate.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Certificate</a> >> Cập nhật
   
</div>
<div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 720px;margin-top:30px;">
            <div class="inputSmallContain">
                <div>
                    <span>Tên chứng nhận</span>
                    <asp:TextBox ID="txtTieuDe" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Tên chứng nhận (EN)</span>
                    <asp:TextBox ID="txtTieuDeEN" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Tên chứng nhận (CAM)</span>
                    <asp:TextBox ID="txtTieuDeCAM" runat="server"></asp:TextBox>
                </div>
                  <div>
                    <span>Hình ảnh (.jpg)</span>
                    <asp:FileUpload ID="fileUploadImg" runat="server" Width="400px"/>
                     <%--<asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadImg" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                       <asp:TextBox ID="txtImg" Visible="false" runat="server"></asp:TextBox>

                </div>
               <div>
                    <span>File (.pdf)</span>
                    <asp:FileUpload ID="fileUploadFile" runat="server" Width="400px"/>
                    <%-- <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadFile" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                    <asp:TextBox ID="txtFileName" Visible="false" runat="server"></asp:TextBox>
                </div>

                
                <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Cập Nhật" OnClick="btnSubmit_Click"></asp:Button>
                    
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn_gray"  NavigateUrl="~/Admin/Certificate/QLCertificate.aspx">
                        Bỏ Qua
                    </asp:HyperLink>
                </div>
            </div>
        </div>
    </div>
       <asp:ToolkitScriptManager ID="TkScript1" runat="server" ScriptMode="Release" EnablePageMethods="true">
    </asp:ToolkitScriptManager>
</asp:Content>

