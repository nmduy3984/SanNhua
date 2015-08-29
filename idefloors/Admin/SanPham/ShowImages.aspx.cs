using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_SanPham_ShowImages : System.Web.UI.Page
{
    public DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        string maSP = Request.QueryString["maSP"] == null ? "" : Request.QueryString["maSP"];
        if(maSP == "")
            dt = DataAccess.GetRecord("HinhAnh");
        else if (maSP != "")
            dt = DataAccess.GetRecord("HinhAnh","MaSanPham",maSP);
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string maSP = Request.QueryString["maSP"] == null ? "" : Request.QueryString["maSP"];
        string x = Request.Form["chk"];
        Utilities.redirectClient(Page, "/Admin/SanPham/DeleteImage.aspx?maSP=" + maSP + "&ID=" + x);
    }
    
}