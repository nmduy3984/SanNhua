﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="References.aspx.cs" Inherits="Page_References" %>

<%@ Register src="../Control/References.ascx" tagname="References" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <uc1:References ID="References1" runat="server" />
    </form>
</asp:Content>

