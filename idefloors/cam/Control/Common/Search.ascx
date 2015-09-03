<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Search.ascx.cs" Inherits="Control_Common_Search" %>
<div id="SearchForm">
    <div id="SearchFormContainer">

        <asp:TextBox ID="txtSearch" runat="server" CssClass="search-input"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" UseSubmitBehavior="true" Text="" CssClass="search-button" OnClick="btnSearch_Click" />
    </div>
</div>
