using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_SanPham_EditSizeSP : System.Web.UI.Page
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
            string sql = "Select * from Size s left join SanPham sp on s.MaSanPham = sp.MaSanPham where s.ID =" + ID;
            DataTable dtSP = DataAccess.GetDatatable(sql);
            if (dtSP.Rows.Count == 1)
            {
                txtgia.Text = dtSP.Rows[0]["Gia"].ToString();
                txtMaSanPham.Text = dtSP.Rows[0]["MaSanPham"].ToString();
                txtTenSanPham.Text = dtSP.Rows[0]["TenSanPham"].ToString();
                txtSize.Text = dtSP.Rows[0]["Size"].ToString();
                txtSoLuong.Text = dtSP.Rows[0]["SoLuong"].ToString();
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
           string ID = Request.QueryString["ID"];
            string size = txtSize.Text;
            string sl = txtSoLuong.Text;
            DataAccess.Insert("Update Size set Size = " + size + ",SoLuong = " + sl + " where ID = " + ID);
            MessageBox.Show(Page, "Cap Nhat Size & SL Cho SP Thanh Cong");
        }
        catch (Exception)
        {
            MessageBox.Show(Page, "Cap Nhat Size & SL Cho SP That Bai");
        }
        Utilities.redirectClient(Page, "/Admin/SanPham/QLSanPham.aspx");
        //Utilities.redirectClient(Page, Request.Url.AbsolutePath);

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/SanPham/QLSanPham.aspx");
    }
}