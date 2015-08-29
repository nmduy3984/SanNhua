using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_SanPham_InsertSPSize : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadData();
    }
    protected void LoadData()
    {
        string ID = Request.QueryString["ID"] == null ? "" : Request.QueryString["ID"];
        if (ID != "")
        {
            DataTable dtSP = DataAccess.GetRecord("SanPham", "ID", ID);
            if (dtSP.Rows.Count == 1)
            {
                txtgia.Text = dtSP.Rows[0]["Gia"].ToString();
                txtMaSanPham.Text = dtSP.Rows[0]["MaSanPham"].ToString();
                txtTenSanPham.Text = dtSP.Rows[0]["TenSanPham"].ToString();
               
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string maSP = txtMaSanPham.Text;
            string size = txtSize.Text;
            string sl = txtSoLuong.Text;
            DataAccess.Insert("Insert into Size(MaSanPham,Size,SoLuong) Values(N'" + maSP + "',"+size+","+sl+")");
            MessageBox.Show(Page, "Tao Moi Size Cho SP Thanh Cong");
        }
        catch (Exception)
        {
            MessageBox.Show(Page, "Tao Moi Size Cho SP That Bai");
        }
        //Utilities.redirectClient(Page, "/Admin/DanhMuc/QLDanhMucSP.aspx");
        Utilities.redirectClient(Page, Request.Url.PathAndQuery);

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/SanPham/QLSanPham.aspx");
    }
}