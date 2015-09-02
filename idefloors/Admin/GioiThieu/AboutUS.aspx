<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="AboutUS.aspx.cs" Inherits="Admin_TinTuc_Insert" %>

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
                    <span>Nội Dung</span>
                </div>
                <div style="clear: both; margin: 0px; padding: 0px;">
                    <ce:editor id="txtContent" runat="server" width="703px" height="700px" usehtmlentities="False" />
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

