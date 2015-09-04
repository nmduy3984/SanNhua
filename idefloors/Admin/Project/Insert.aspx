﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="Insert.aspx.cs" Inherits="Admin_Project_Insert" %>
<%@ Register Namespace="CustomEditor" TagPrefix="one" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/Project/QLProject.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Dự Án</a> >> Tạo mới
   
</div>
<div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 720px;margin-top:30px;">
          <div class="inputSmallContain">
                <div>
                    <span>Tiêu Đề</span>
                    <asp:TextBox ID="txtTieuDe" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mô tả</span>
                    <one:CustomEditor ID="txtDes" Height="150" runat="server" />
                </div>
              <div>
                    <span>Tiêu Đề (EN)</span>
                    <asp:TextBox ID="txtTieuDeEN" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mô tả (EN)</span>
                    <one:CustomEditor ID="txtDesEN" Height="150" runat="server" />
                </div>
                <div>
                    <span>Tiêu Đề (CAM)</span>
                    <asp:TextBox ID="txtTieuDeCAM" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mô tả (CAM)</span>
                    <one:CustomEditor ID="txtDesCAM" Height="150" runat="server" />
                </div>
                <div>
                    <span>Hình ảnh (.jpg)</span>
                    <asp:FileUpload ID="fileUploadImg" runat="server" Width="400px" />
                    <asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadImg" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <span>Nội Dung</span>
                </div>
                <div style="clear: both; margin: 0px; padding: 0px;">
                    <CE:Editor ID="txtContent" AutoConfigure="Simple" runat="server" Width="100%" Height="200">
                            <TextAreaStyle BackColor="White" BorderColor="#DDDDDD" BorderStyle="Solid" BorderWidth="1px"
                                CssClass="CuteEditorFrame" Height="100%" Width="100%" />
                        </CE:Editor>
                </div>
                <div>
                    <span>Nội Dung (EN)</span>
                </div>
                <div style="clear: both; margin: 0px; padding: 0px;">
                    <CE:Editor ID="txtContentEN" AutoConfigure="Simple" runat="server" Width="100%" Height="200">
                            <TextAreaStyle BackColor="White" BorderColor="#DDDDDD" BorderStyle="Solid" BorderWidth="1px"
                                CssClass="CuteEditorFrame" Height="100%" Width="100%" />
                        </CE:Editor>
                </div>
                <div>
                    <span>Nội Dung (CAM)</span>
                </div>
                <div style="clear: both; margin: 0px; padding: 0px;">
                    <CE:Editor ID="txtContentCAM" AutoConfigure="Simple" runat="server" Width="100%" Height="200">
                            <TextAreaStyle BackColor="White" BorderColor="#DDDDDD" BorderStyle="Solid" BorderWidth="1px"
                                CssClass="CuteEditorFrame" Height="100%" Width="100%" />
                        </CE:Editor>
                </div>
                <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Tạo Mới" OnClick="btnSubmit_Click"></asp:Button>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn_gray"  NavigateUrl="~/Admin/Project/QLProject.aspx">
                        Bỏ Qua
                    </asp:HyperLink>
                </div>
            </div>
        </div>
    </div>
     <asp:ToolkitScriptManager ID="TkScript1" runat="server" ScriptMode="Release" EnablePageMethods="true">
    </asp:ToolkitScriptManager>
</asp:Content>

