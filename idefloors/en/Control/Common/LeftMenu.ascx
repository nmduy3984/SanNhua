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
            <span><%= row0["NameEN"] %></span>
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
                <li><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>"><span><%= row1["NameEN"] %></span></a>
                    <ul>
                        <%
                       if (CategoryLevel2 != null)
                       {
                           foreach (DataRow row2 in CategoryLevel2.Rows)
                           {
                        %>
                        <li><a href="ProductByCategory.aspx?Id=<%= row2["CategoryID"].ToString() %>"><span><%= row2["NameEN"]%></span></a></li>
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
            <span>CONTACT</span>
        </div>
        <div class="defaultContent cate-menu-content">
            <ul>
                <%if (thamso.Rows.Count>0)
                  { %>
                <li><a href="#"><span>Hotline: <%= thamso.Rows[0]["Phone"].ToString() %></span></a> </li>
                <li><a href="#"><span>Mobile: <%= thamso.Rows[0]["Mobile"].ToString() %></span></a> </li>
                <% 
                    string[] arr = thamso.Rows[0]["Email"].ToString().Split(';');
                    for( int i=0 ; i<arr.Length; i++){
                        %>
                        <li><a href="mailto:<%= arr[i] %>"><span>Email: <%= arr[i] %></span></a> </li>
                <%
                    }
                    %>
                <li>
                    <a href="skype:<%= thamso.Rows[0]["Skype"].ToString() %>">Skype: Mr.Lưu</a>
                </li>
                <%} %>
            </ul>
        </div>
        <div class="defaultFooter cate-menu-footer">
            <div>
            </div>
        </div>
    </div>
</div>
