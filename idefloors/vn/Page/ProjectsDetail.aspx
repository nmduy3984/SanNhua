<%@ Page Title="" Language="C#" MasterPageFile="~/vn/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="ProjectsDetail.aspx.cs" Inherits="Page_ProjectsDetail" %>

<%@ Register src="../Control/ProjectsDetail.ascx" tagname="ProjectsDetail" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <uc1:ProjectsDetail ID="ProjectsDetail1" runat="server" />
</asp:Content>

