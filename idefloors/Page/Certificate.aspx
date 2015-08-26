<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="Certificate.aspx.cs" Inherits="Page_Certificate" %>

<%@ Register src="../Control/Certificate.ascx" tagname="Certificate" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <uc1:Certificate ID="Certificate1" runat="server" />
    </form>
</asp:Content>

