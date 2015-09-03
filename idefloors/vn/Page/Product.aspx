<%@ Page Title="" Language="C#" MasterPageFile="~/vn/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Page_Product" %>

<%@ Register src="../Control/Product.ascx" tagname="Product" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <uc1:Product ID="Product1" runat="server" />
</asp:Content>

