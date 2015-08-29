using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

public partial class Admin_SanPham_DeleteImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string x = Request.QueryString["ID"] == null ? "" : Request.QueryString["ID"];
        string maSP = Request.QueryString["maSP"] == null ? "" : Request.QueryString["maSP"];
        if (x != "")
        {
            try
            {
                string[] arr = x.Split(',');
                foreach (string item in arr)
                {
                    DataTable dtHA = DataAccess.GetRecord("HinhAnh","ID",item);
                    if (dtHA.Rows.Count == 1)
                        if (File.Exists(StringHelper.getFolderImages + dtHA.Rows[0]["HinhAnh"]))
                            File.Delete(StringHelper.getFolderImages + dtHA.Rows[0]["HinhAnh"]);
                    DataAccess.Delete("delete from HinhAnh where ID =" + item);
                }
               // DataAccess.Delete("delete from HinhAnh where ID in (" + x + ")");
                MessageBox.Show(Page, "Xoa Thanh Cong");
            }
            catch (Exception)
            {
                MessageBox.Show(Page, "Xoa That Bai");
            }
        }
        Utilities.redirectClient(Page, "/Admin/SanPham/ShowImages.aspx?maSP=" + maSP);
    }
}