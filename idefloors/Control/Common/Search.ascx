<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Search.ascx.cs" Inherits="Control_Common_Search" %>
<div id="SearchForm">
    <div id="SearchFormContainer">
        <input name="txtSearch" type="text" id="txtSearch" class="search-input" value="Tìm kiếm" />
        &nbsp;<input type="submit" name="btnSearch" value="" id="btnSearch"
            class="search-button" />
     <%--<form id="frmsearch" name="frmsearch" runat="server" target="_parent"> 
        <asp:TextBox ID="txtSearch" runat="server" CssClass="search-input"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Button" CssClass="search-button"  OnClick="btnSearch_Click"  />
          </form>--%>
    </div>
</div>