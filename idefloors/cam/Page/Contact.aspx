<%@ Page Title="" Language="C#" MasterPageFile="~/cam/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Page_Contact" %>

<%@ Register src="../Control/Contact.ascx" tagname="Contact" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <uc1:Contact ID="Contact1" runat="server" />
</asp:Content>

