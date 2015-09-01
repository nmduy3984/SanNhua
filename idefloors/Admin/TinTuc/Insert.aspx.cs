using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_TinTuc_Insert : System.Web.UI.Page
{
    public DataTable dd = new DataTable();
    public int maxID = 0;
    public string value = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable  dtID= DataAccess.GetDatatable("select max(ID) from News");
            string id1 = dtID.Rows.Count == 0 ? "0" : dtID.Rows[0][0].ToString() == "" ? "0" : dtID.Rows[0][0].ToString();
            int ID = Convert.ToInt32(id1) + 1;
            string tieude = txtTieuDe.Text;
            string des = Server.HtmlEncode(txtDes.Content.Trim());
            //string content = Server.HtmlEncode(txtContent.Content.Trim());
            string content = txtContent.Text.Replace("'", "''");

            DateTime now = DateTime.Now;
            string Img = ID.ToString() + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";

            if (this.fileUploadImg.HasFile)
            {
                string sMapPath = StringHelper.getFolderNewImages;
                this.fileUploadImg.SaveAs(sMapPath + Img);
            }
            else
                Img = "";

            string sql = @"Insert into News(Title,[Description],Content,ImageUrl,UserCreated,CreatedDate) 
                            Values(N'" + tieude + "',N'" + des + "',N'" + content + "','" + Img + "','" + Session["UserName"] + "','" + now.ToString()  + "')";
             //UserCreated,UserModified,CreatedDate,ModifiedDate,
            DataAccess.Insert(sql);
            MessageBox.Show(Page,"Tao Moi Thanh Cong");
        }
        catch(Exception ex)
        {
            MessageBox.Show(Page, "Tao Moi That Bai. Vui Long thu lai");
            return;
        }
        Utilities.redirectClient(Page, "/Admin/TinTuc/QLTinTuc.aspx");
        //Utilities.redirectClient(Page, Request.Url.AbsolutePath);

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/TinTuc/QLTinTucSP.aspx");
    }
    
}