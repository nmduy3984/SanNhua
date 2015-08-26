<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="EditSizeSP.aspx.cs" Inherits="Admin_SanPham_EditSizeSP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">

<div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/SanPham/QLSanPham.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Sản Phẩm</a> >> Cập nhật size cho SP
   
</div>
<div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 600px;margin-top:30px;">
            <div class="inputSmallContain">
               
                <div>
                    <span>Tên Sản Phẩm</span>
                    <asp:TextBox ID="txtTenSanPham" Enabled="false" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mã Sản Phẩm</span>
                    <asp:TextBox ID="txtMaSanPham" Enabled="false" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Giá Sản Phẩm</span>
                    <asp:TextBox ID="txtgia" Enabled="false" runat="server"></asp:TextBox>
                </div>
                 <div>
                    <span>Size</span>
                      <asp:TextBox ID="txtSize" runat="server"></asp:TextBox>
                </div>
                 <div>
                    <span>Số lượng</span>
                      <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
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

