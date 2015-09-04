using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_Flash_Edit : System.Web.UI.Page
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
                DataTable dt = DataAccess.GetRecord("Flash", "Id", ID);
                if (dt.Rows.Count == 1)
                {
                    txtImg.Text = dt.Rows[0]["ImgUrl"].ToString();
                    txtThumb.Text = dt.Rows[0]["ThumbUrl"].ToString();
                    txtLink.Text = dt.Rows[0]["Link"].ToString();
                    //txtTitle.Text = dt.Rows[0]["Title"].ToString();
                }
            }
            else
            {
                 MessageBox.Show(Page, "Khong tim thay tin tuc nay");
                 Utilities.redirectClient(Page, "/Admin/Flash/QLFlash.aspx");
            }
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = Request.QueryString["ID"];
                string link = txtLink.Text;
                //string title = txtTitle.Text;
               
                DateTime now = DateTime.Now;
                string Img = ID + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
                string thumb = ID + "_thumb_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
               
                if (this.fileUploadImg.HasFile)
                {
                    string sMapPath = StringHelper.getFolderFlashImages;
                    if (File.Exists(sMapPath + txtImg.Text))
                        File.Delete(sMapPath + txtImg.Text);
                    //xóa cái cũ ùi mới save cái mới
                    this.fileUploadImg.SaveAs(sMapPath + Img);
                }
                else
                    Img = txtImg.Text;

                if (this.fileUploadThumb.HasFile)
                {
                    string sMapPath = StringHelper.getFolderFlashImages;
                    if (File.Exists(sMapPath + txtThumb.Text))
                        File.Delete(sMapPath + txtThumb.Text);
                    //xóa cái cũ ùi mới save cái mới
                    this.fileUploadThumb.SaveAs(sMapPath + thumb);
                }
                else
                    thumb = txtThumb.Text;


                string sql = @"Update Flash set Link = N'" + link + 
                                    "',ImgUrl = '" + Img + "',ThumbUrl = '" + thumb +
                                       "' where Id = " + ID + "";
                DataAccess.Update(sql);
                MessageBox.Show(Page, "Cap Nhat Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Page, "Cap Nhat That Bai");
                return;
            }
            Utilities.redirectClient(Page, "/Admin/Flash/QLFlash.aspx");
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Utilities.redirectClient(Page, "/Admin/Flash/QLFlash.aspx");
        }
       
}