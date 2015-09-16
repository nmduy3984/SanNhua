﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="ThamSo.aspx.cs" Inherits="Admin_TinTuc_Insert" %>

<%@ Register Namespace="CustomEditor" TagPrefix="one" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="Server">
    <div style="width: 100%; float: left; margin-top: 30px;">
        <a href="/Admin/GioiThieu/AboutUS.aspx" style="color: #333333; font-size: 15px; font-weight: bold;">Quản Lý Giới Thiệu Cty</a>
   
    </div>
    <div style="width: 100%; float: left;">
        <div class="inputSmall" style="width: 720px; margin-top: 30px;">
            <div class="inputSmallContain">                
                <div>
                    <span>Phone</span>
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Mobile</span>
                    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span>Email</span>
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div>
                    <span>Skype</span>
                    <asp:TextBox ID="txtSkype" runat="server"></asp:TextBox>
                </div>
                <div style="width: 260px; float: right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Tạo Mới" OnClick="btnSubmit_Click"></asp:Button>

                </div>
            </div>
        </div>
    </div>
    <asp:ToolkitScriptManager ID="TkScript1" runat="server" ScriptMode="Release" EnablePageMethods="true">
    </asp:ToolkitScriptManager>
</asp:Content>

