using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_Certificate_Edit : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {               
                //Load Data
                this.LoadData();
            }
        }

        private void LoadData()
        {
            string ID = Request.QueryString["ID"] == null ? "" : Request.QueryString["ID"];
            if (ID != "")
            {
                DataTable dt = DataAccess.GetRecord("Certificate", "CertificateID", ID);
                if (dt.Rows.Count == 1)
                {
                    txtTieuDe.Text = dt.Rows[0]["Title"].ToString();
                    txtFileName.Text = dt.Rows[0]["FileName"].ToString();
                    txtImg.Text = dt.Rows[0]["ImgUrl"].ToString();
                }
            }
            else
            {
                MessageBox.Show(Page, "Khong tim thay Certificate nay");
                 Utilities.redirectClient(Page, "/Admin/Certificate/QLCertificate.aspx");
            }
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = Request.QueryString["ID"];
                string tieude = txtTieuDe.Text;
               
                DateTime now = DateTime.Now;
                
                string Img = ID.ToString() + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
                string FileName = tieude + "_" + ID.ToString() + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".pdf";

                if (this.fileUploadImg.HasFile)
                {
                    string sMapPath = StringHelper.getFolderCerImages;
                    if (File.Exists(sMapPath + txtImg.Text))
                        File.Delete(sMapPath + txtImg.Text);
                    //xóa cái cũ ùi mới save cái mới
                    this.fileUploadImg.SaveAs(sMapPath + Img);
                }
                else
                    Img = txtImg.Text;

                if (this.fileUploadFile.HasFile)
                {
                    string sMapPath1 = StringHelper.getFolderCerFile;
                    this.fileUploadFile.SaveAs(sMapPath1 + FileName);
                }
                else
                    FileName = "";

                string sql = @"Update Certificate set Title = N'" + tieude + "',ImgUrl = N'" + Img + "',[FileName] = N'" + FileName +
                                       "' where CertificateID = " + ID + "";
                DataAccess.Update(sql);
                MessageBox.Show(Page, "Cap Nhat Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Page, "Cap Nhat That Bai");
                return;
            }
            Utilities.redirectClient(Page, "/Admin/Certificate/QLCertificate.aspx");
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Utilities.redirectClient(Page, "/Admin/Certificate/QLCertificate.aspx");
        }
       
}