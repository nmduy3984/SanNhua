<%@ Page Title="" Language="C#" MasterPageFile="~/en/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="AboutUS.aspx.cs" Inherits="Page_AboutUS" %>

<%@ Register src="../Control/AboutUS.ascx" tagname="AboutUS" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:AboutUS ID="AboutUS1" runat="server" />
</asp:Content>

