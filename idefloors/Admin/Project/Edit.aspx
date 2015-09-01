﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Admin_Project_Edit" %>
<%@ Register Namespace="CustomEditor" TagPrefix="one" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/Project/QLProjectSP.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Dự Án</a> >> Cập nhật
   
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
                    <span>Hình ảnh (.jpg)</span>
                    <asp:FileUpload ID="fileUploadImg" runat="server" Width="400px" />
                    <%--<asp:RequiredFieldValidator CssClass="val_btn" Width="100px" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please upload file" ControlToValidate="fileUploadImg" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                    <asp:TextBox ID="txtImg" Visible="false" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Nội Dung</span>
                </div>
                <div style="clear: both; margin: 0px; padding: 0px;">
                    <ce:editor id="txtContent" runat="server" width="703px" height="700px" usehtmlentities="False" />
                </div>
                
                <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Cập Nhật" OnClick="btnSubmit_Click"></asp:Button>
                    
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

