<%@ Page Title="" Language="C#" MasterPageFile="~/cam/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="Projects.aspx.cs" Inherits="Page_Projects" %>

<%@ Register src="../Control/Projects.ascx" tagname="Projects" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <uc1:Projects ID="Projects1" runat="server" />
</asp:Content>

