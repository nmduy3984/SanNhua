using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DanhMuc_Insert : System.Web.UI.Page
{
    public DataTable dd = new DataTable();
    public int maxID = 0;
    public string value = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataAccess.LoadCategory(ref ddlDanhMucCha, "-1");
        }
       
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            string name = txtTenDanhMuc.Text;
            string des = Server.HtmlEncode(txtDes.Content.ToString());
            string nameEN = txtTenDanhMucEN.Text;
            string desEN = Server.HtmlEncode(txtDesEN.Content.ToString());
            string nameCAM = txtTenDanhMucCAM.Text;
            string desCAM = Server.HtmlEncode(txtDesCAM.Content.ToString());
            string seq = (txtSeq.Text.Trim() == "") ? "0" : txtSeq.Text.Trim();
            string parentID = ddlDanhMucCha.SelectedValue.ToString() == "-1" ? "0" : ddlDanhMucCha.SelectedValue.ToString();
            string sql = "";

            DateTime now = DateTime.Now;
            string strHA_img = name + "_" + parentID + "_img.jpg";
            if (this.fileUploadImg.HasFile)
            {
                string sMapPath = StringHelper.getFolderCategoryImages;
                this.fileUploadImg.SaveAs(sMapPath + strHA_img);
            }
            else
                strHA_img = "";

            string strHA_thumb = "";
            //string strHA_thumb = name + "_" + parentID + "_thumb.jpg";
            //if (this.fileUploadThumbnail.HasFile)
            //{
            //    string sMapPath = StringHelper.getFolderCategoryImages;
            //    this.fileUploadThumbnail.SaveAs(sMapPath + strHA_thumb);
            //}
            //else
            //    strHA_thumb = "";

            sql = @"Insert into Category(Name,Description,NameEN,DescriptionEN,NameCAM,DescriptionCAM,ImageUrl,ThumUrl,UserCreated,CreatedDate,ParentID,Seq) 
                            Values(N'" + name + "',N'" + des + "',N'" + nameEN + "',N'" + desEN + "',N'" + nameCAM + "',N'" + desCAM + "','" + strHA_img + "','" + strHA_thumb + "','" + Session["UserName"] + "','" + now.ToString() + "'," + parentID.ToString() + "," + seq + ")";
             //UserCreated,UserModified,CreatedDate,ModifiedDate,
            DataAccess.Insert(sql);
            MessageBox.Show(Page,"Tao Moi Thanh Cong");
        }
        catch(Exception)
        {
            MessageBox.Show(Page, "Tao Moi That Bai");
            return;
        }
        Utilities.redirectClient(Page, "/Admin/DanhMuc/QLDanhMucSP.aspx");
        //Utilities.redirectClient(Page, Request.Url.AbsolutePath);

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/DanhMuc/QLDanhMucSP.aspx");
    }
    
}