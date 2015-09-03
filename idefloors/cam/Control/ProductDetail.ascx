<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductDetail.ascx.cs" Inherits="Control_ProductDetail" %>
<%@ Import Namespace="System.Data" %>

<%if (productByID.Rows.Count > 0)
  {
      DataTable categoryByProductId = new DataTable();
      categoryByProductId = DataAccess.GetRecord("Category", "CategoryID", productByID.Rows[0]["CategoryID"].ToString());
%>
<div class="wrapproductdetail" id='ProductDetail<%= productByID.Rows[0]["ProductID"].ToString()%>'>
    <script type="text/javascript">
        $('#ProductDetail<%= productByID.Rows[0]["ProductID"].ToString() %>').magnificPopup({
            delegate: 'a',
            type: 'image',
            tLoading: 'Loading image #%curr%...',
            mainClass: 'mfp-img-mobile',
            gallery: {
                enabled: false,
                navigateByImgClick: false,
                preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
            },
            image: {
                tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
                titleSrc: function (item) {
                    var arr = item.el.attr('title').split('#idefloors.vn#');
                    return '<div style="float:left;padding-left:5px;color:#403d3b;font-size:12px;font-weight:normal;">' + arr[1] + '</div>' + arr[0] + '<div style="float:right;font-size:12px; font-weight:normal;"><a href="ProductByCategory.aspx?Id=<%= productByID.Rows[0]["CategoryID"].ToString() %>" style="color:#6ab901;">Xem thêm&nbsp;&#187;</a></div>';
                }
            }
        });
    </script>

    <div class="img_link">
        <a title="<%=productByID.Rows[0]["Name"]%> - <%=productByID.Rows[0]["ProductID"]%>#idefloors.vn#<%=productByID.Rows[0]["Size"]%>" href="../../Images/ProductImages/<%=productByID.Rows[0]["ImageUrl"]%>">
            <span class="thumb">
                <img  alt="idefloors.vn" u="image" class="img" src="../../Images/ProductImages/<%= productByID.Rows[0]["ImageUrl"] %>" />
            </span>
        </a>

    </div>
    <div class="content">
        <div class="title"><%= productByID.Rows[0]["ProductID"] %></div>
        <div class="desc">
            <div class="detail"><strong>Đăng ngày: </strong><%= string.Format(productByID.Rows[0]["CreatedDate"].ToString(),"dd/MM/yyyy") %></div>
            <div class="detail"><strong>Nhóm hàng: </strong><%= categoryByProductId.Rows[0]["Name"] %></div>
            <div class="detail"><strong>Mã sản phẩm: </strong><%= productByID.Rows[0]["ProductID"] %></div>
        </div>
    </div>
    <div class="splitspace"></div>
</div>
<%
  }
  else
  {
%>
<div>Không tìm thấy.</div>
<%
  } %>


<br />
<%if (productOtherID.Rows.Count > 0)
  { %>
<div class="c2">
    <div class="t_c2"><a href='#'>Sản phẩm liên quan</a></div>
    <div style='clear: both;'></div>
    <div class="fixed_img_col4">
        <%int count = 1;
          foreach (DataRow row in productOtherID.Rows)
          {
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
                <a title="<%=row["Name"]%> - <%=row["ProductID"]%>#idefloors.vn#<%=row["Size"]%>" href="ProductDetail.aspx?Id=<%=row["ProductID"]%>">
                    <span class="thumb">
                        <img  alt="idefloors.vn" src="../../Images/ProductImages/<%=row["ImageUrl"]%>" />
                    </span>
                    <strong><%=row["Name"]%><br /><%=row["ProductID"]%></strong>
                </a>
            </li>
            <%  
              }

              if (count == 3)
              { %>
        </ul>
        <%}
              count++;
          }%>
    </div>
</div>
<%} %>