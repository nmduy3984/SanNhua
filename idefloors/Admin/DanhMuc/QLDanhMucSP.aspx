<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="QLDanhMucSP.aspx.cs" Inherits="Admin_DanhMuc_QLDanhMucSP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div class="topPanel">
    <div class="floatLeft">
        <asp:LinkButton CssClass="btn_green" ID="btnAdd" OnClick="btnAdd_Click"
            runat="server">Tạo mới</asp:LinkButton>
        <asp:LinkButton CssClass="btn_green" ForeColor="#ca0303" ID="btnDelete"
            OnClick="btnDelete_Click" OnClientClick="return checkDelete('Are you sure delete all selected items');"
            runat="server">Xóa danh mục</asp:LinkButton>
       
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
            <th scope="col" width="25">
                <span>Ảnh đại diện (Img)</span>
            </th>
             <th scope="col" width="25">
               Mã Danh Mục
            </th>
            <th scope="col">
                <span>Tên Danh Mục Sản Phẩm</span>
            </th>
           <%-- <th scope="col">
               Mô tả
            </th>--%>
             <th scope="col">
                <span>Thư tự show</span>
            </th>
            
        </tr>

        <%
        foreach (System.Data.DataRow dr in dt.Rows)
        {    
            string Parentname = "";
            string ParentID = "";
            string name = "";
            name = dr["Name"].ToString();
            if(dr["ParentID"].ToString()!="0" && dr["ParentID"].ToString()!="")
            { 
                 System.Data.DataTable dtParent = DataAccess.GetRecord("Category","CategoryID",dr["ParentID"].ToString());
                 if (dtParent.Rows.Count > 0)
                 {
                     Parentname = dtParent.Rows[0]["Name"].ToString();
                     ParentID = dtParent.Rows[0]["ParentID"].ToString();
                     name = Parentname + " >> " + name;
                     if (ParentID != "0" && ParentID != "")
                     {
                         dtParent = DataAccess.GetRecord("Category", "CategoryID", ParentID);
                         if (dtParent.Rows.Count > 0)
                         {
                             Parentname = dtParent.Rows[0]["Name"].ToString();
                             name = Parentname + " >> " + name;
                         }
                     }
                 }
            }
        %>
        <tr>
            <td>
                <input type="checkbox" name="chk" value="<%=dr["CategoryID"]%>" />
            </td>
             <td>
                 <img height="150px" width="150px;" src="/Images/CategoryImages/<%=dr["ImageUrl"]%>" />
            </td> 
            <td>
                <%=dr["CategoryID"]%>
            </td> 
            <td>
                <a href="Edit.aspx?ID=<%=dr["CategoryID"]%>"><%=name%></a>
            </td>  
            <%-- <td>
                <%=dr["Description"]%>
            </td>--%>
              <td>
                <%=dr["Seq"]%>
            </td> 
            
         </tr>
        <%} %>

    </table>
</div>
</asp:Content>


