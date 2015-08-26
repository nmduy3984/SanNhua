<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="Insert.aspx.cs" Inherits="Admin_SanPham_Insert" %>

<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="Server">
    <div style="width: 100%; float: left; margin-top: 30px;">
        <a href="/Admin/SanPham/QLSanPham.aspx" style="color: #333333; font-size: 15px; font-weight: bold;">Quản Lý Sản Phẩm</a> >> Tạo mới
   
    </div>
    <div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 720px; margin-top: 30px;">
            <div class="inputSmallContain">

                <div>
                    <span>Danh Mục</span>
                    <asp:DropDownList ID="ddlDanhMuc" runat="server">
                    </asp:DropDownList>
                </div>
                <div>
                    <span>Tên Sản Phẩm</span>
                    <asp:TextBox ID="txtTenSanPham" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mã Sản Phẩm</span>
                    <asp:TextBox ID="txtMaSanPham" runat="server"></asp:TextBox>
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
                    <span>Hình ảnh-ImgURL (.jpg)</span>
                    <asp:FileUpload ID="fileUploadImg" runat="server" Width="400px" />
                    <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadImg" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                
                <%--<div>
                    <span>Hình ảnh-Thumb (.jpg)</span>
                    <asp:FileUpload ID="fileUploadThumbnail" runat="server"  Width="400px"/> 
                     <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadThumbnail" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>--%>
                <div>
                    <span>Cho Phép Hiển thị</span>
                    <asp:DropDownList ID="ddlStatus" runat="server">
                        <asp:ListItem Text="Có" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Không" Value="0"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Tạo Mới" OnClick="btnSubmit_Click"></asp:Button>
                    <asp:HyperLink ID="btnCancel" runat="server" CssClass="btn_gray" NavigateUrl="~/Admin/SanPham/QLSanPham.aspx">
                        Bỏ Qua
                    </asp:HyperLink>

                </div>
                <div style="clear:both;">
                    <CE:Editor ID="txtHuongdansd" runat="server" Height="700" Width="100%" ConfigurationPath="~/CuteSoft_Client/CuteEditor/Configuration/AutoConfigure/MyTool.config"
						EditorWysiwygModeCss="~/example.css">
						<TextAreaStyle BackColor="White" BorderColor="#DDDDDD" BorderStyle="Solid" BorderWidth="1px"
							CssClass="CuteEditorFrame" Height="100%" Width="100%" />
					<TextAreaStyle BackColor="White" BorderColor="#DDDDDD" BorderStyle="Solid" BorderWidth="1px"
							CssClass="CuteEditorFrame" Height="100%" Width="100%" /></CE:Editor>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

