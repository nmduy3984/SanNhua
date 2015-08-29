using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DanhMuc_Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string x = Request.QueryString["ID"] ==null ? "": Request.QueryString["ID"];
        if (x != "")
        {
           try
            {
                DataAccess.Delete("delete from Category where CategoryID in (" + x + ")");
                MessageBox.Show(Page, "Xoa Thanh Cong");
            }
            catch (Exception)
            {
                MessageBox.Show(Page, "Xoa That Bai. Xoa San Pham cua danh muc truoc khi xoa danh muc");
            }
        }
        Utilities.redirectClient(Page, "/Admin/DanhMuc/QLDanhMucSP.aspx");
    }
}