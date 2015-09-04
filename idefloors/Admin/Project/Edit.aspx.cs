using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_Project_Edit : System.Web.UI.Page
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
                DataTable dt = DataAccess.GetRecord("Projects", "ID", ID);
                if (dt.Rows.Count == 1)
                {
                    txtTieuDe.Text = dt.Rows[0]["Title"].ToString();
                    txtDes.Content = Server.HtmlDecode(dt.Rows[0]["Description"].ToString());
                    txtContent.Text = dt.Rows[0]["Content"].ToString();

                    txtTieuDeEN.Text = dt.Rows[0]["TitleEN"].ToString();
                    txtDesEN.Content = Server.HtmlDecode(dt.Rows[0]["DescriptionEN"].ToString());
                    txtContentEN.Text = dt.Rows[0]["ContentEN"].ToString();
                    txtTieuDeCAM.Text = dt.Rows[0]["TitleCAM"].ToString();
                    txtDesCAM.Content = Server.HtmlDecode(dt.Rows[0]["DescriptionCAM"].ToString());
                    txtContentCAM.Text = dt.Rows[0]["ContentCAM"].ToString();
                    //txtContent.Content = Server.HtmlDecode(dt.Rows[0]["Content"].ToString());
                    txtImg.Text = dt.Rows[0]["ImageUrl"].ToString();
                }
            }
            else
            {
                 MessageBox.Show(Page, "Khong tim thay tin tuc nay");
                 Utilities.redirectClient(Page, "/Admin/Project/QLProject.aspx");
            }
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = Request.QueryString["ID"];
                string tieude = txtTieuDe.Text;
                string des = Server.HtmlEncode(txtDes.Content.Trim());
                string content = txtContent.Text.Replace("'", "''");

                string tieudeEN = txtTieuDeEN.Text;
                string desEN = Server.HtmlEncode(txtDesEN.Content.Trim());
                string contentEN = txtContentEN.Text.Replace("'", "''");
                string tieudeCAM = txtTieuDeCAM.Text;
                string desCAM = Server.HtmlEncode(txtDesCAM.Content.Trim());
                string contentCAM = txtContentCAM.Text.Replace("'", "''");
                //string content = Server.HtmlEncode(txtContent.Content.Trim());

                DateTime now = DateTime.Now;
                string Img = ID + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
               
                if (this.fileUploadImg.HasFile)
                {
                    string sMapPath = StringHelper.getFolderProjectsImages;
                    if (File.Exists(sMapPath + txtImg.Text))
                        File.Delete(sMapPath + txtImg.Text);
                    //xóa cái cũ ùi mới save cái mới
                    this.fileUploadImg.SaveAs(sMapPath + Img);
                }
                else
                    Img = txtImg.Text;


                //string sql = @"Update Projects set Title = N'" + tieude + "',[Description] = N'" + des +
                //                    "',ImageUrl = '" + Img + "',Content = N'" + content +
                //                       "' where ID = " + ID + "";
                string sql = @"Update Projects set Title = N'" + tieude + "',[Description] = N'" + des + "',TitleEN = N'" + tieudeEN + "',[DescriptionEN] = N'" + desEN + "',TitleCAM = N'" + tieudeCAM + "',[DescriptionCAM] = N'" + desCAM +
                    "',ImageUrl = '" + Img + "',Content = N'" + content + "',ContentEN = N'" + contentEN + "',ContentCAM = N'" + contentCAM +
                       "' where ID = " + ID + "";

                DataAccess.Update(sql);
                MessageBox.Show(Page, "Cap Nhat Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Page, "Cap Nhat That Bai");
                return;
            }
            Utilities.redirectClient(Page, "/Admin/Project/QLProject.aspx");
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Utilities.redirectClient(Page, "/Admin/Project/QLProject.aspx");
        }
       
}