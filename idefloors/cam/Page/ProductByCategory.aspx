﻿<%@ Page Title="" Language="C#" MasterPageFile="~/cam/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="ProductByCategory.aspx.cs" Inherits="Page_ProductByCatagory" %>

<%@ Register src="../Control/ProductByCategory.ascx" tagname="ProductByCategory" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <uc1:ProductByCategory ID="ProductByCategory1" runat="server" />
</asp:Content>

