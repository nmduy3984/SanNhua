using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_TinTuc_Edit : System.Web.UI.Page
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
                DataTable dt = DataAccess.GetRecord("News", "ID", ID);
                if (dt.Rows.Count == 1)
                {
                    txtTieuDe.Text = dt.Rows[0]["Title"].ToString();
                    txtDes.Content = Server.HtmlDecode(dt.Rows[0]["Description"].ToString());
                    //txtContent.Content = Server.HtmlDecode(dt.Rows[0]["Content"].ToString());
                    txtContent.Text = dt.Rows[0]["Content"].ToString();
                    txtImg.Text = dt.Rows[0]["ImageUrl"].ToString();
                }
            }
            else
            {
                 MessageBox.Show(Page, "Khong tim thay tin tuc nay");
                 Utilities.redirectClient(Page, "/Admin/TinTuc/QLTinTuc.aspx");
            }
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = Request.QueryString["ID"];
                string tieude = txtTieuDe.Text;
                string des = Server.HtmlEncode(txtDes.Content.Trim());
                //string content = Server.HtmlEncode(txtContent.Content.Trim());
                string content = txtContent.Text.Trim();
               
                DateTime now = DateTime.Now;
                string Img = ID + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
               
                if (this.fileUploadImg.HasFile)
                {
                    string sMapPath = StringHelper.getFolderNewImages;
                    if (File.Exists(sMapPath + txtImg.Text))
                        File.Delete(sMapPath + txtImg.Text);
                    //xóa cái cũ ùi mới save cái mới
                    this.fileUploadImg.SaveAs(sMapPath + Img);
                }
                else
                    Img = txtImg.Text;


                string sql = @"Update News set Title = N'" + tieude + "',[Description] = N'" + des +
                                    "',ImageUrl = '" + Img + "',Content = N'" + content +
                                       "' where ID = " + ID + "";
                DataAccess.Update(sql);
                MessageBox.Show(Page, "Cap Nhat Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Page, "Cap Nhat That Bai");
                return;
            }
            Utilities.redirectClient(Page, "/Admin/TinTuc/QLTinTuc.aspx");
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Utilities.redirectClient(Page, "/Admin/TinTuc/QLTinTuc.aspx");
        }
       
}