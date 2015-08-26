<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="InsertImages.aspx.cs" Inherits="Admin_SanPham_InsertImages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/SanPham/QLSanPham.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Sản Phẩm</a> >> Tạo nhiều hình ảnh SP
 </div>
 <div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 600px;margin-top:30px;">
            <div class="inputSmallContain">
                <div>
                    <span>Tên Sản Phẩm</span>
                    <asp:TextBox ID="txtTenSanPham" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mã Sản Phẩm</span>
                    <asp:TextBox ID="txtMaSanPham" Enabled="false" runat="server"></asp:TextBox>
                </div>
                  <div>
                    <span>Hình ảnh</span>
                    <asp:FileUpload ID="fileUpload1" runat="server" /> (.jpg)
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUpload1" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                 <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Tạo Mới" OnClick="btnSubmit_Click"
                        OnClientClick="return checkValid();"></asp:Button>
                    <asp:Button ID="btnCancel" runat="server" Text="Bỏ qua" OnClick="btnCancel_Click">
                    </asp:Button>
                </div>
        </div>
        </div>
    </div>
</asp:Content>

