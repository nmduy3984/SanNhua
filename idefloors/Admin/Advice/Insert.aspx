﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="Insert.aspx.cs" Inherits="Admin_Advice_Insert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".ddlType").change(function () {
                var sel = $(this).val();
                if (sel == 1) {
                    $(".Video").css({ display: "none" });
                    $(".Pdf").css({ display: "block" });
                } else {
                    $(".Video").css({ display: "block" });
                    $(".Pdf").css({ display: "none" });
                }
            });
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
    <div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/Advice/QLAdvice.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Hướng dẫn lắp đặt</a> >> Tạo mới
   
</div>
<div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 720px;margin-top:30px;">
            <div class="inputSmallContain">
             
                <div>
                    <span>Chọn loại file hướng dẫn</span>
                    <asp:DropDownList ID="ddlType" CssClass="ddlType" runat="server" >
                        <asp:ListItem Text="PDF" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Video" Value="0"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <span>Tiêu đề</span>
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mô tả</span>
                    <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                </div>
                
                <div>
                    <span>Tiêu đề (EN)</span>
                    <asp:TextBox ID="txtTitleEN" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mô tả (EN)</span>
                    <asp:TextBox ID="txtDescriptionEN" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Tiêu đề (CAM)</span>
                    <asp:TextBox ID="txtTitleCAM" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mô tả (CAM)</span>
                    <asp:TextBox ID="txtDescriptionCAM" runat="server"></asp:TextBox>
                </div>
                
                 <div class="Video" style="display:none;">
                    <span>Hình ảnh-ImgURL (.jpg)</span>
                    <asp:FileUpload ID="fileUploadImg" runat="server" Width="400px"/>
                </div>
                <div class="Video" style="display:none;">
                    <span>Đường dẫn Video</span>
                    <asp:TextBox ID="txtLinkVideo" runat="server"></asp:TextBox>
                </div>
                <div class="Pdf">
                    <span>File hướng dẫn</span>
                    <asp:FileUpload ID="fileManualAdvice" runat="server" Width="400px"/>
<%--                     <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileManualAdvice" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="Pdf">
                    <span>File hướng dẫn (EN)</span>
                    <asp:FileUpload ID="fileManualAdviceEN" runat="server" Width="400px"/>
<%--                     <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileManualAdvice" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="Pdf">
                    <span>File hướng dẫn (CAM)</span>
                    <asp:FileUpload ID="fileManualAdviceCAM" runat="server" Width="400px"/>
<%--                     <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileManualAdvice" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                </div>
                <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Tạo Mới" OnClick="btnSubmit_Click" ></asp:Button>                     
                    <asp:HyperLink ID="btnCancel" runat="server" CssClass="btn_gray"  NavigateUrl="~/Admin/Advice/QLAdvice.aspx">
                        Bỏ Qua
                    </asp:HyperLink>
                    
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>

