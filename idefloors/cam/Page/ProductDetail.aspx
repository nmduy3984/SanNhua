<%@ Page Title="" Language="C#" MasterPageFile="~/cam/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="Page_ProductDetail" %>

<%@ Register src="../Control/ProductDetail.ascx" tagname="ProductDetail" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <uc1:ProductDetail ID="ProductDetail1" runat="server" />
</asp:Content>

