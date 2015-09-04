<%@ Page Title="" Language="C#" MasterPageFile="~/cam/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="Certificate.aspx.cs" Inherits="Page_Certificate" %>

<%@ Register src="../Control/Certificate.ascx" tagname="Certificate" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <uc1:Certificate ID="Certificate1" runat="server" />
</asp:Content>

