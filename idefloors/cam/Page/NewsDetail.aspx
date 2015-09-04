<%@ Page Title="" Language="C#" MasterPageFile="~/cam/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="NewsDetail.aspx.cs" Inherits="Page_NewsDetail" %>

<%@ Register src="../Control/NewsDetail.ascx" tagname="NewsDetail" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <uc1:NewsDetail ID="NewsDetail1" runat="server" />
</asp:Content>

