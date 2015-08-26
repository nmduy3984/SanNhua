using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_SanPham_InsertImages : System.Web.UI.Page
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
               
                txtMaSanPham.Text = dtSP.Rows[0]["MaSanPham"].ToString();
                txtTenSanPham.Text = dtSP.Rows[0]["TenSanPham"].ToString();

            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            
            if (this.fileUpload1.HasFile)
            {
                string maSP = txtMaSanPham.Text;
                DateTime now = DateTime.Now;
                string strName = now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
                string sMapPath = StringHelper.getFolderImages;
               
                this.fileUpload1.SaveAs(sMapPath + strName);
                DataAccess.Insert("Insert into HinhAnh(MaSanPham,HinhAnh) Values(N'" + maSP + "','" + strName +"')");
                MessageBox.Show(Page, "Tao moi hình ảnh cho SP thanh cong");
            }
            else
                MessageBox.Show(Page, "Không tìm thấy hình ảnh");
        }
        catch (Exception)
        {
            MessageBox.Show(Page, "Tao Moi Size hình ảnh cho sP That Bai");
        }
        //Utilities.redirectClient(Page, "/Admin/DanhMuc/QLDanhMucSP.aspx");
        //Utilities.redirectClient(Page, Request.Url.AbsolutePath);
        Utilities.redirectClient(Page, Request.Url.PathAndQuery);

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/SanPham/QLSanPham.aspx");
    }
}