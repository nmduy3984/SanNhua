﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Page_Home" %>

<%@ Register src="../Control/Catagory.ascx" tagname="Catagory" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    

    <form id="form1" runat="server">
        <uc1:Catagory ID="Catagory1" runat="server" />
    </form>
    

</asp:Content>

