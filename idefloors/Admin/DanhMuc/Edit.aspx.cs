using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_DanhMuc_Edit : System.Web.UI.Page
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
                DataTable dt = DataAccess.GetRecord("Category", "CategoryID", ID);
                if (dt.Rows.Count == 1)
                {
                    txtTenDanhMuc.Text = dt.Rows[0]["Name"].ToString();
                    txtDes.Content = Server.HtmlDecode(dt.Rows[0]["Description"].ToString());
                    txtTenDanhMucEN.Text = dt.Rows[0]["NameEN"].ToString();
                    txtDesEN.Content = Server.HtmlDecode(dt.Rows[0]["DescriptionEN"].ToString());
                    txtTenDanhMucCAM.Text = dt.Rows[0]["NameCAM"].ToString();
                    txtDesCAM.Content = Server.HtmlDecode(dt.Rows[0]["DescriptionCAM"].ToString());
                    txtImg.Text = dt.Rows[0]["ImageUrl"].ToString();
                    //txtThumb.Text = dt.Rows[0]["ThumUrl"].ToString();
                    txtSeq.Text = dt.Rows[0]["Seq"].ToString();
                    ddlIsShow.SelectedValue = dt.Rows[0]["isShow"].ToString() == "True" ? "1" : "0";
                    DataAccess.LoadCategory(ref ddlDanhMucCha, dt.Rows[0]["ParentID"].ToString());
                }
            }
            else
            {
                 MessageBox.Show(Page, "Khong tim thay danh muc nay");
                 Utilities.redirectClient(Page, "/Admin/DanhMuc/QLDanhMucSP.aspx");
            }
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = Request.QueryString["ID"];
                string name = txtTenDanhMuc.Text;
                string des = Server.HtmlEncode(txtDes.Content.Trim());
                string nameEN = txtTenDanhMucEN.Text;
                string desEN = Server.HtmlEncode(txtDesEN.Content.ToString());
                string nameCAM = txtTenDanhMucCAM.Text;
                string desCAM = Server.HtmlEncode(txtDesCAM.Content.ToString());

                string Thumb = "";//txtThumb.Text;
                string parentId = ddlDanhMucCha.SelectedValue.ToString() == "-1" ? "0" : ddlDanhMucCha.SelectedValue.ToString();
                string Seq = txtSeq.Text;
                DateTime now = DateTime.Now;
                string Img = name + "_" + parentId + "_"+ now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
               
                if (this.fileUploadImg.HasFile)
                {
                    string sMapPath = StringHelper.getFolderCategoryImages;
                    if (File.Exists(sMapPath + txtImg.Text))
                        File.Delete(sMapPath + txtImg.Text);
                    //xóa cái cũ ùi mới save cái mới
                    this.fileUploadImg.SaveAs(sMapPath + Img);
                }
                else
                    Img = txtImg.Text;

                
                string sql = @"Update Category set Name = N'" + name + "',[Description] = N'" + des +
                    "',NameEN =N'" + nameEN + "',[DescriptionEN] = N'" + desEN +
                        "',NameCAM =N'" + nameCAM + "',[DescriptionCAM] = N'" + desCAM +
                                    "',ImageUrl = '" + Img + "',thumurl = '" + Thumb +
                                       "', isShow =" + ddlIsShow.SelectedValue +
                                       ", ParentID =" + parentId +
                                       ",Seq=" + Seq + " where CategoryID = " + ID + "";
                DataAccess.Update(sql);
                MessageBox.Show(Page, "Cap Nhat Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Page, "Cap Nhat That Bai"+ex.Message.ToString());
                return;
            }
            Utilities.redirectClient(Page, "/Admin/DanhMuc/QLDanhMucSP.aspx");
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Utilities.redirectClient(Page, "/Admin/DanhMuc/QLDanhMucSP.aspx");
        }
       
}