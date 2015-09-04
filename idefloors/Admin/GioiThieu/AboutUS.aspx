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

                </div>
            </div>
        </div>
    </div>
    <asp:ToolkitScriptManager ID="TkScript1" runat="server" ScriptMode="Release" EnablePageMethods="true">
    </asp:ToolkitScriptManager>
</asp:Content>

