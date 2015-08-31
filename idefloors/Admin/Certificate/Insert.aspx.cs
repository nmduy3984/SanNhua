using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Certificate_Insert : System.Web.UI.Page
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
            DataTable dtID = DataAccess.GetDatatable("select max(CertificateID) from Certificate");
            string id1 = dtID.Rows.Count == 0 ? "0" : dtID.Rows[0][0].ToString() == "" ? "0" : dtID.Rows[0][0].ToString();
            int ID = Convert.ToInt32(id1) + 1;
            string tieude = txtTieuDe.Text;
           

            DateTime now = DateTime.Now;
            string Img = ID.ToString() + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
            string FileName = tieude+"_"+ID.ToString() + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".pdf";

            if (this.fileUploadImg.HasFile)
            {
                string sMapPath = StringHelper.getFolderCerImages;
                this.fileUploadImg.SaveAs(sMapPath + Img);
            }
            else
                Img = "";

            if (this.fileUploadFile.HasFile)
            {
                string sMapPath1 = StringHelper.getFolderCerFile;
                this.fileUploadFile.SaveAs(sMapPath1 + FileName);
            }
            else
                FileName = "";


            string sql = @"Insert into Certificate(Title,FileName,ImgUrl) 
                            Values(N'" + tieude + "',N'" + FileName + "',N'" + Img + "')";
             //UserCreated,UserModified,CreatedDate,ModifiedDate,
            DataAccess.Insert(sql);
            MessageBox.Show(Page,"Tao Moi Thanh Cong");
        }
        catch(Exception ex)
        {
            MessageBox.Show(Page, "Tao Moi That Bai. Vui Long thu lai");
            return;
        }
        Utilities.redirectClient(Page, "/Admin/Certificate/QLCertificate.aspx");
        //Utilities.redirectClient(Page, Request.Url.AbsolutePath);

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/Certificate/QLCertificate.aspx");
    }
    
}