using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_SanPham_Insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataAccess.LoadCategory(ref ddlDanhMuc, "-1");
        }
    }
    //protected void LoadDM()
    //{

    //    DataTable dtDanhMuc = DataAccess.GetRecord("Category");
    //    ddlDanhMuc.Items.Add( new ListItem("--Chọn Danh Mục--", "-1"));
    //    foreach (DataRow dr in dtDanhMuc.Rows)
    //    {
    //        ddlDanhMuc.Items.Add(new ListItem(dr["Name"].ToString(), dr["CategoryID"].ToString()));
    //    }
    //}
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string tenSP = txtTenSanPham.Text;
        string des = txtDes.Text;
        string tenSPEN = txtTenSanPhamEN.Text;
        string desEN = txtDesEN.Text;
        string tenSPCAM = txtTenSanPhamCAM.Text;
        string desCAM = txtDesCAM.Text;

        string maSP = txtMaSanPham.Text;
        string kichthuoc = txtKichThuoc.Text;
        string madm = ddlDanhMuc.SelectedValue;
        string status = ddlStatus.SelectedValue.ToString();
        string seq = (txtSeq.Text.Trim() == "") ? "0" : txtSeq.Text.Trim();
        string isNewProduct = ddlIsNewProduct.SelectedValue.ToString();

        string sql = "select * from Product where ProductID = '" + maSP + "'";
        DataTable dtSP = DataAccess.GetDatatable(sql);
        if (dtSP.Rows.Count > 0)
        {
            MessageBox.Show(Page, "Mã Sản Phẩm Đã Tồn Tại");
            return;
        }

        DateTime now = DateTime.Now;
        string strName = maSP + ".jpg";
        if (this.fileUploadImg.HasFile)
        {
            string sMapPath = StringHelper.getFolderImages;
            this.fileUploadImg.SaveAs(sMapPath + strName);
        }
        else
            strName = "";


        sql = @"Insert into Product(ProductID,Name,Size,ImageUrl,CategoryID,Description,Status,Seq,IsNewProduct,NameEN,DescriptionEN,NameCAM,DescriptionCAM)
                       Values(N'{0}',N'{1}',N'{2}','{3}',{4},'{5}',{6},{7},{8},N'{9}',N'{10}',N'{11}',N'{12}')
                    ";
        sql = string.Format(sql, maSP, tenSP, kichthuoc, strName, ddlDanhMuc.SelectedValue, des,status, seq, isNewProduct,tenSPEN,desEN,tenSPCAM,desCAM);
        try
        {
            DataAccess.Insert(sql);
            MessageBox.Show(Page, "Tao moi thanh cong");
        }
        catch (Exception ex)
        {
            MessageBox.Show(Page, "Tao moi that bai. "+ex.Message.Replace("\r","").Replace("\n","").Replace("'","''"));
        }

        Utilities.redirectClient(Page, "/Admin/SanPham/QLSanPham.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/SanPham/QLSanPham.aspx");
    }
}