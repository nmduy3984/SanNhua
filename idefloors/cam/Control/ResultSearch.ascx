﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ResultSearch.ascx.cs" Inherits="Control_ResultSearch" %>
<%@ Import Namespace="System.Data" %>

<% 
    DataTable categoryLevel1 = new DataTable();
    categoryLevel1 = DataAccess.GetDatatable("exec GetAllCategoryLevel 1");
   foreach (DataRow row0 in categoryLevel1.Rows)
   {
       DataTable categoryLevel2 = new DataTable();
       categoryLevel2 = DataAccess.GetDatatable("select * from fnGetAllChild(" + row0["CategoryID"].ToString() + ")");
       foreach (DataRow row1 in categoryLevel2.Rows)
       {
           DataTable productByCategory = new DataTable();
           productByCategory = DataAccess.GetDatatable("select * from Product  where productid like '%"+key+"%' and Status=1 and CategoryID =" + row1["CategoryID"].ToString() + " order by CreatedDate desc");
%>

    <%if (productByCategory.Rows.Count > 0)
      { %>
<div class="c2">
    <div class="t_c2"><a href="javascript:void();"><%= row0["NameCAM"] %> - <%= row1["NameCAM"] %></a></div>
    <div class="seemore" style="display:none;"><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>">Xem thêm&nbsp;&#187;</a></div>
    <div style='clear: both;'></div>
    
    <% if ((bool)row1["ViewType"])
       { %>
    <div class="fixed_img_col2" id='Popup<%= row1["CategoryID"].ToString() %>'>
        <script type="text/javascript">
            $('#Popup<%= row1["CategoryID"].ToString() %>').magnificPopup({
                delegate: 'a',
                type: 'image',
                tLoading: 'Loading image #%curr%...',
                mainClass: 'mfp-img-mobile',
                gallery: {
                    enabled: true,
                    navigateByImgClick: true,
                    preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
                },
                image: {
                    tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
                    titleSrc: function (item) {
                        var arr = item.el.attr('title').split('#idefloors.vn#');
                        return '<div style="float:left;padding-left:5px;color:#403d3b;font-size:12px;font-weight:normal;">' + arr[1] + '</div>' + arr[0] + '<div style="float:right;font-size:12px; font-weight:normal;"><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>" style="color:#6ab901;">Xem thêm&nbsp;&#187;</a></div>';
                    }
                }
            });

        </script>
        <ul>
            <% foreach (DataRow row2 in productByCategory.Rows)
               {
                   string name = row2["NameCAM"].ToString().Trim();
            %>
            <li>
                <a title="<% if (name != ""){ %><%=name%> - <% } %><%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                    <span class="thumb">
                        <img  alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                    </span>
                    <strong><% if (name != ""){ %><%=name%><br /><% } %><%=row2["ProductID"]%></strong>
                </a>
            </li>
            <%
               }  %>
        </ul>
        <%}
       else
       { %>
        <div class="fixed_img_col4" id='Popup<%= row1["CategoryID"].ToString() %>'>
            <script type="text/javascript">
                $('#Popup<%= row1["CategoryID"].ToString() %>').magnificPopup({
                    delegate: 'a',
                    type: 'image',
                    tLoading: 'Loading image #%curr%...',
                    mainClass: 'mfp-img-mobile',
                    gallery: {
                        enabled: true,
                        navigateByImgClick: true,
                        preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
                    },
                    image: {
                        tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
                        titleSrc: function (item) {
                            var arr = item.el.attr('title').split('#idefloors.vn#');
                            return '<div style="float:left;padding-left:5px;color:#403d3b;font-size:12px;font-weight:normal;">' + arr[1] + '</div>' + arr[0] + '<div style="float:right;font-size:12px; color:#6ab901; font-weight:normal;"><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>" style="color:#6ab901;">Xem thêm&nbsp;&#187;</a></div>';
                        }
                    }
                });

            </script>
            <% 
           int count = 1;
           foreach (DataRow row2 in productByCategory.Rows)
           {
               string name = row2["NameCAM"].ToString().Trim();
               if (count > 3) count = 1;
               if (count == 1)
               {
            %>
            <ul>
                <%}
               if (count <= 3)
               {
                %>
                <li>
                    <a title="<% if (name != ""){ %><%=name%> - <% } %><%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                        <span class="thumb">
                            <img  alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                        </span>
                        <strong><% if (name != ""){ %><%=name%><br /><% } %><%=row2["ProductID"]%></strong>
                    </a>
                </li>
                <%
               }
               if (count == 3)
               { %>
            </ul>
            <%}
               count++;
           }  %>
            <%} %>
        </div>
    </div>
    <%}%>
    <%}
   }%>
