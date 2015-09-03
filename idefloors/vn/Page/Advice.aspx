<%@ Page Title="" Language="C#" MasterPageFile="~/vn/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="Advice.aspx.cs" Inherits="Page_Advice" %>

<%@ Register src="../Control/Advice.ascx" tagname="Advice" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:Advice ID="Advice1" runat="server" />
</asp:Content>

