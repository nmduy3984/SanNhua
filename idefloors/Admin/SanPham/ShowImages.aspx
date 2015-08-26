<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="ShowImages.aspx.cs" Inherits="Admin_SanPham_ShowImages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div style="width: 100%; float: left;margin-top:30px;">
    <a href="/Admin/SanPham/QLSanPham.aspx" style="color:#333333;font-size: 15px;font-weight: bold;">Quản Lý Sản Phẩm</a> >> Quản lý hình ảnh
   
</div>
<div class="topPanel">
    <div class="floatLeft">
       <asp:LinkButton CssClass="btn_green" ForeColor="#ca0303" ID="btnDelete"
            OnClick="btnDelete_Click" OnClientClick="return checkDelete('Are you sure delete all selected items');"
            runat="server">Xóa hình ảnh</asp:LinkButton>
     </div>
</div>

<div style="margin:auto; width:100%">
    <table class="table_Blue" id="mainData" style="min-width:600px" cellpadding="0" cellspacing="0">
    <tr>
            <th scope="col" width="25">
               
            </th>
            <th scope="col">
                <span>Mã Sản Phẩm</span>
            </th>
            <th scope="col">
                <span>Hình Ảnh</span>
            </th>
           
        </tr>
    <%
        foreach (System.Data.DataRow dr in dt.Rows)
        {    
          
        %>
        <tr>
            <td>
                <input type="checkbox" name="chk" value="<%=dr["ID"]%>" />
            </td>
            <td>
                <%=dr["MaSanPham"]%>
            </td> 
             <td align="center">
                <img height="200px" src="/Images/ProductImages/<%=dr["HinhAnh"]%>" />
            </td>   
         </tr>
        <%} %>

    </table>
</div>
</asp:Content>

