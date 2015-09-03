<%@ Page Title="" Language="C#" MasterPageFile="~/vn/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="ResultSearch.aspx.cs" Inherits="Page_ResultSearch" %>

<%@ Register src="../Control/ResultSearch.ascx" tagname="ResultSearch" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <uc1:ResultSearch ID="ResultSearch1" runat="server" />
</asp:Content>

