<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="QLSanPham.aspx.cs" Inherits="Admin_SanPham_QLSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">

 
<div class="topPanel">
    <div class="floatLeft">
        <asp:LinkButton CssClass="btn_green" ID="btnAdd" OnClick="btnAdd_Click"
            runat="server">Tạo mới</asp:LinkButton>
        <asp:LinkButton CssClass="btn_green" ForeColor="#ca0303" ID="btnDelete"
            OnClick="btnDelete_Click" OnClientClick="return checkDelete('Are you sure delete all selected items');"
            runat="server">Xóa sản phẩm</asp:LinkButton>
     </div>
</div>

<div style="margin:auto; width:100%">
    <div style="float:right;margin-bottom: 11px;margin-top: 10px;"><%=_Status%> || Page size 
            <asp:DropDownList ID="ddlPageSize" AutoPostBack="true" onselectedindexchanged = "btnGetData_Click" runat="server" >
              <asp:ListItem Text= "4" Value ="4" ></asp:ListItem>
              <asp:ListItem Text= "10" Value ="10" ></asp:ListItem>
              <asp:ListItem Text= "30" Value ="30" ></asp:ListItem>
              <asp:ListItem Text= "50" Value ="50" ></asp:ListItem>
              <asp:ListItem Text= "100" Value ="100" ></asp:ListItem>
            </asp:DropDownList> 
            &nbsp;<%=_Pagination%>
    </div>
    <table class="table_Blue" id="mainData" style="min-width:600px" cellpadding="0" cellspacing="0">
        <tr>
            <th scope="col" width="25">
               
            </th>
             <th scope="col" width="50">
                <span>Hình đại diện (ImgURL)</span>
            </th>
            <th scope="col">
                <span>Mã Sản Phẩm</span>
            </th>
            <th scope="col">
                <span>Tên Sản Phẩm</span>
            </th>
            <th scope="col">
                <span>Tên Sản Phẩm (EN)</span>
            </th>
            <th scope="col">
                <span>Tên Sản Phẩm (CAM)</span>
            </th>
            <th scope="col">
                <span>Tên Danh Mục Sản Phẩm</span>
            </th>
            <th scope="col">
                <span>Kích thước</span>
            </th>
            
           <%-- <th>SL Hình ảnh</th>
             <th scope="col">
                <span></span>
            </th>
             <th scope="col">
                <span></span>
            </th>--%>
        </tr>

        <%
            for (int i = 0; i < dtSanPham.Rows.Count; i++)
            {
                string ID = dtSanPham.Rows[i]["ID"].ToString();
                //string image = dtSanPham.Rows[i]["ImageUrl"].ToString();
                string maSP = dtSanPham.Rows[i]["ProductID"].ToString();
                string size = dtSanPham.Rows[i]["Size"].ToString();

                string tenSP = dtSanPham.Rows[i]["Name"].ToString();
                string tenSPEN = dtSanPham.Rows[i]["NameEN"].ToString();
                string tenSPCAM = dtSanPham.Rows[i]["NameCAM"].ToString();
                string tenDMSP = dtSanPham.Rows[i]["CategoryName"].ToString();
                string hinhanh = dtSanPham.Rows[i]["ImageUrl"].ToString();  
          
        %>
        <tr>
            <td>
                <input type="checkbox" name="chk" value="<%=ID%>" />
            </td>
            <td align="center">
                <img  alt="idefloors.vn" height="150px" width="150px;" src="/Images/ProductImages/<%=hinhanh%>" />
            </td>
            <td>
                   <a href="Edit.aspx?ID=<%=ID%>"><%=maSP%></a>
            </td>
            <td>
                <%=tenSP%>
            </td>   
            <td>
                <%=tenSPEN%>
            </td>
            <td>
                <%=tenSPCAM%>
            </td>
            <td>
                <%=tenDMSP%>
            </td> 
             <td>
                 <%=size%>
            </td> 
         </tr>
        <%} %>

    </table>
</div>
</asp:Content>

