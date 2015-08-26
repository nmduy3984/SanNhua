using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_SanPham_DeleteSizeSP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string x = Request.QueryString["ID"] == null ? "" : Request.QueryString["ID"];
        if (x != "")
        {
            try
            {
                DataAccess.Delete("delete from Size where ID in (" + x + ")");
                MessageBox.Show(Page, "Xoa Size Thanh Cong");
            }
            catch (Exception)
            {
                MessageBox.Show(Page, "Xoa Size That Bai");
            }
        }
        Utilities.redirectClient(Page, "/Admin/SanPham/QLSanPham.aspx");
    }
}