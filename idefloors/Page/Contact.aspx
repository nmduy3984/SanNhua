<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Page_Contact" %>

<%@ Register src="../Control/Contact.ascx" tagname="Contact" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <uc1:Contact ID="Contact1" runat="server" />
    </form>
</asp:Content>

