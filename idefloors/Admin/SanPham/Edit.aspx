<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Admin_SanPham_Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/SanPham/QLSanPham.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Sản Phẩm</a> >> Cập nhật
</div>
<div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 600px;margin-top:30px;">
            <div class="inputSmallContain">
             
                <div>
                    <span>Tên Danh Mục</span>
                    <asp:DropDownList ID="ddlDanhMuc" runat="server" >
                            
                    </asp:DropDownList>
                </div>
                <div>
                    <span>Tên Sản Phẩm</span>
                    <asp:TextBox ID="txtTenSanPham" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mã Sản Phẩm</span>
                    <asp:TextBox ID="txtMaSanPham" Enabled="false" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Kích thước</span>
                    <asp:TextBox ID="txtKichThuoc" runat="server"></asp:TextBox>
                </div>
                 <div>
                    <span>Mô tả</span>
                    <asp:TextBox ID="txtDes" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div>
                    <span>Hình ảnh-ImgURL(.jpg)</span>
                    <asp:FileUpload ID="fileUploadImg" runat="server" /> 
                     <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadImg" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                      <asp:TextBox ID="txtImgUrl" Visible="false" runat="server"></asp:TextBox>
                </div>

                <%--<div>
                    <span>Hình ảnh-Thumb(.jpg)</span>
                    <asp:FileUpload ID="fileUploadThumbnail" runat="server"  Width="400px"/> 
                     <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadThumbnail" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="txtThumb" Visible="false" runat="server"></asp:TextBox>
                </div>--%>
                 <div>
                    <span>Cho Phép Hiển thị</span>
                    <asp:DropDownList ID="ddlStatus" runat="server">
                        <asp:ListItem Text="Có" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Không" Value="0"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Cập Nhật" OnClick="btnSubmit_Click"
                        OnClientClick="return checkValid();"></asp:Button>
                    <asp:Button ID="btnCancel" runat="server" Text="Bỏ qua" OnClick="btnCancel_Click">
                    </asp:Button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

