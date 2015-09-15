﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Product.ascx.cs" Inherits="Control_CatagoryDetail" %>
<%@ Import Namespace="System.Data" %>
<%@ Register Src="NewProduct.ascx" TagName="NewProduct" TagPrefix="uc1" %>

<uc1:NewProduct ID="NewProduct1" runat="server" />


<div class="c2">
    <div class="t_c2">
    </div>
</div>
<% 
    foreach (DataRow row0 in categoryLevel1.Rows)
    {
        DataTable categoryLevel2 = new DataTable();
        categoryLevel2 = DataAccess.GetDatatable("select * from fnGetAllChildHaveFilter(" + row0["CategoryID"].ToString() + ")");
        foreach (DataRow row1 in categoryLevel2.Rows)
        {
            DataTable productByCategory = new DataTable();
            productByCategory = DataAccess.GetDatatable("select * from Product  where Status=1 and CategoryID =" + row1["CategoryID"].ToString() + " order by seq");
%>
            <div class="c2">
            <%if (productByCategory.Rows.Count > 0)
            { %>
                <div class="t_c2"><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>"><%= row0["NameEN"] %> - <%= row1["NameEN"] %></a></div>
                <div class="seemore"><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>">Xem thêm&nbsp;&#187;</a></div>
                <div style='clear: both;'></div>
            <%}
              else
              {
            %>
                <div class="t_c2"><a href="javascript:void();"><%= row0["NameEN"] %> - <%= row1["NameEN"] %></a></div>
                <div class="seemore" style="display: none;"><a href="javascript:void();">Xem thêm&nbsp;&#187;</a></div>
                <div style='clear: both;'></div>
            <%
              } %>
            <% 
            if ((bool)row1["ViewType"])
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
                    
                <% int count = 1;
                   int dem = 0;
                   int numRow = 0;
                   foreach (DataRow row2 in productByCategory.Rows)
                   {
                       string name = row2["NameEN"].ToString().Trim();
                       if(row1["NumRowToView"].ToString() != "")
                       {
                           numRow++;
                           if (numRow <= (int)row1["NumRowToView"] * 2)
                           {
                               if (count > 2) count = 1;
                               if (count == 1)
                               {
                                    %><ul><%
                               }
                               if (count <= 2)
                               {
                                    %>
                                    <li>
                                        <a title="<% if (name != ""){ %><%=name%> - <% } %><%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                                            <span class="thumb">
                                                <img alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                                            </span>
                                            <strong><% if (name != ""){ %><%=name%><br /><% } %><%=row2["ProductID"]%></strong>
                                        </a>
                                    </li>
                                    <%
                               }
                               else
                               {
                                    %></ul><%
                                   numRow = 0;
                                   break;
                               }
                           }
                           if (count == 2)
                           { %></ul><%}
                           count++;
                       }else
                       {
                           dem++;
                            if (count > 2) count = 1;
                            if (count == 1 )
                            {%><ul><%}
                            if (count <= 2)
                            {
                                %>
                                <li>
                                    <a title="<% if (name != ""){ %><%=name%> - <% } %><%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                                        <span class="thumb">
                                            <img alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                                        </span>
                                        <strong><% if (name != ""){ %><%=name%><br /><% } %><%=row2["ProductID"]%></strong>
                                    </a>
                                </li>
                                <%
                            }
                            if (count == 2 || dem == productByCategory.Rows.Count)
                            {%></ul><%}
                            count++;
                       }
                   } 
            }
            else
            { %>
                <div class="fixed_img_col4" id="Div1">
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
                    int dem = 0;
                   int numRow = 0;
                   foreach (DataRow row2 in productByCategory.Rows)
                   {
                       string name = row2["NameEN"].ToString().Trim();
                       if(row1["NumRowToView"].ToString() != "")
                       {
                           numRow++;
                           if (numRow <= (int)row1["NumRowToView"] * 3)
                           {
                               if (count > 3) count = 1;
                               if (count == 1)
                               {%><ul><%}
                                if (count <= 3)
                                {
                                    %>
                                    <li>
                                        <a title="<% if (name != ""){ %><%=name%> - <% } %><%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                                            <span class="thumb">
                                                <img alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                                            </span>
                                            <strong><% if (name != ""){ %><%=name%><br /><% } %><%=row2["ProductID"]%></strong>
                                        </a>
                                    </li>
                                    <%
                                }
                                else
                                {
                                    %></ul><%
                                   numRow = 0;
                                   break;
                                }
                           }
                            if (count == 3)
                            { %></ul><%}
                           count++;
                       }else
                       {
                            dem++;
                            
                            if (count > 3) count = 1;
                            if (count == 1)
                            {%><ul><%}
                            if (count <= 3)
                            {
                                %>
                                <li>
                                    <a title="<% if (name != ""){ %><%=name%> - <% } %><%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                                        <span class="thumb">
                                            <img alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                                        </span>
                                        <strong><% if (name != ""){ %><%=name%><br /><% } %><%=row2["ProductID"]%></strong>
                                    </a>
                                </li>
                                <%
                            }
                            if (count == 3 || dem == productByCategory.Rows.Count)
                            { %></ul><%}
                            count++;
                       } 
                   } 
            } %>
                </div>
            </div>
        <%}
   }%>
