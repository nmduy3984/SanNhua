<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Banner.ascx.cs" Inherits="Control_Common_Banner" %>
<div class="center_header">
    <div id="AjaxLoading">
        <img  alt="idefloors.vn" src="../../Images/ajax-load.gif" />&nbsp; Loading... Please wait...
    </div>
    <div class="bg_topmenu">
        <div id="logo">
            <a href="Home.aspx"><img  alt="idefloors.vn" src="../../Images/logo.png" alt="logo" /></a>
        </div>
        <div id="banner">
            <img  alt="idefloors.vn" src="../../Images/banner.png" alt="banner" />
        </div>
        <div id="aboutus">
            <ul>
                <li><a href="AboutUS.aspx">AboutUS</a></li>
                <li>&nbsp;|&nbsp;</li>
                <li><a href="Contact.aspx">Contact</a></li>
            </ul>
        </div>
        <div id="lang">
            <ul>
                <li>
                    <asp:LinkButton ID="lnkVN" runat="server"  OnClick="lnkVN_Click"><img  alt="idefloors.vn" src="../../Images/vn.png" alt="vn" width="30" height="20" /></asp:LinkButton>
                   
                </li>
                <li>
                    <asp:LinkButton ID="lnkEN" runat="server"  OnClick="lnkEN_Click">
                        <img  alt="idefloors.vn" src="../../Images/en.png" alt="en" width="30" height="20" />
                    </asp:LinkButton>
                </li>
                <li>
                    <asp:LinkButton ID="lnkCAM" runat="server"  OnClick="lnkCAM_Click">
                        <img  alt="idefloors.vn" src="../../Images/cam.png" alt="en" width="30" height="20" />

                    </asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
</div>
