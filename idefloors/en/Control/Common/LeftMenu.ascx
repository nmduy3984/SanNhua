<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftMenu.ascx.cs" Inherits="Control_Common_LeftMenu" %>
<%@ Import Namespace="System.Data" %>

<div class="left">
    <% foreach (DataRow row0 in CategoryLevel0.Rows)
       {
           DataTable CategoryLevel1 = new DataTable();
           CategoryLevel1 = DataAccess.GetDatatable("select * from fnGetAllChildHaveFilter(" + row0["CategoryID"].ToString() + ")");
    %>
    <div class="idefloors.vn cate-menu">
        <div class="defaultTitle cate-menu-title">
            <span><%= row0["Name"] %></span>
        </div>
        <%
           if (CategoryLevel1 != null)
           {
        %>
        <div class="defaultContent cate-menu-content">
            <ul>
                <% foreach (DataRow row1 in CategoryLevel1.Rows)
                   {
                       DataTable CategoryLevel2 = new DataTable();
                       CategoryLevel2 = DataAccess.GetDatatable("select * from fnGetAllChildHaveFilter(" + row1["CategoryID"].ToString() + ")");
                %>
                <li><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>"><span><%= row1["Name"] %></span></a>
                    <ul>
                        <%
                       if (CategoryLevel2 != null)
                       {
                           foreach (DataRow row2 in CategoryLevel2.Rows)
                           {
                        %>
                        <li><a href="ProductByCategory.aspx?Id=<%= row2["CategoryID"].ToString() %>"><span><%= row2["Name"]%></span></a></li>
                        <%}
                       }  %>
                    </ul>
                </li>
                <%
                   }  %>
            </ul>
        </div>
        <% } %>
    </div>

    <%
       }  %>
    <div id="Div3" class="idefloors.vn cate-menu">
        <div class="defaultTitle cate-menu-title">
            <span>LIÊN HỆ</span>
        </div>
        <div class="defaultContent cate-menu-content">
            <ul>

                <li><a href="#"><span>Hotline: 08.66795275</span></a> </li>
                <li><a href="#"><span>Mobile: 0917 703 997</span></a> </li>
                <li><a href="mailto:trungluu1987@gmail.com"><span>Email: trungluu1987@gmail.com</span></a> </li>
                <li><a href="mailto:luupham@hiepphatcorp.com"><span>Email: luupham@hiepphatcorp.com</span></a> </li>
                <li>
                    <a href="skype:trungluu1987ms">Skype: Anh Lưu</a>
                </li>

            </ul>
        </div>
        <div class="defaultFooter cate-menu-footer">
            <div>
            </div>
        </div>
    </div>
</div>
