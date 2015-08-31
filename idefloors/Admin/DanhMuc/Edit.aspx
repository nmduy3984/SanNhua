<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Admin_DanhMuc_Edit" %>
<%@ register namespace="CustomEditor" tagprefix="one" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/DanhMuc/QLDanhMucSP.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Danh Mục Sản Phẩm</a> >> Cập nhật
   
</div>
<div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 720px;margin-top:30px;">
            <div class="inputSmallContain">
                <div>
                    <span>Danh Mục Cha</span>
                    <asp:HiddenField ID="hiddenParentID" runat="server" Value="-1"/> 
                    <asp:DropDownList ID="ddlDanhMucCha" runat="server">
                    </asp:DropDownList>
                </div>
                <div>
                    <span>Tên Danh Mục</span>
                    <asp:TextBox ID="txtTenDanhMuc" runat="server"></asp:TextBox>
                </div>
                 <div>
                    <span>Giới thiệu</span>
                     <one:CustomEditor ID="txtDes" Height="300" runat="server" />
                </div>
                 <div>
                    <span>Hình ảnh-ImgURL (.jpg)</span>
                    <asp:FileUpload ID="fileUploadImg" runat="server" Width="400px"/>
                     <%--<asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadImg" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                     <asp:TextBox ID="txtImg" Visible="false" runat="server"></asp:TextBox>
                </div>
                 <%--<div>
                    <span>Hình ảnh-Thumb (.jpg)</span>
                    <asp:FileUpload ID="fileUploadThumbnail" runat="server"  Width="400px"/> 
                     <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadThumbnail" Display="Dynamic"></asp:RequiredFieldValidator>
                     <asp:TextBox ID="txtThumb" Visible="false" runat="server"></asp:TextBox>
                </div>--%>
                <div>
                    <span>Thứ tự show</span>
                     <asp:TextBox ID="txtSeq" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Cho Phép Hiển thị</span>
                    <asp:DropDownList ID="ddlIsShow" runat="server">
                        <asp:ListItem Text="Có" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Không" Value="0"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Cập Nhật" OnClick="btnSubmit_Click"></asp:Button>
                    
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn_gray"  NavigateUrl="~/Admin/DanhMuc/QLDanhMucSP.aspx">
                        Bỏ Qua
                    </asp:HyperLink>
                </div>
            </div>
        </div>
    </div>
       <asp:ToolkitScriptManager ID="TkScript1" runat="server" ScriptMode="Release" EnablePageMethods="true">
    </asp:ToolkitScriptManager>
</asp:Content>

