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
        DataTable dt = DataAccess.GetDatatable("select * from AboutUS");
        if (dt.Rows.Count > 0)
        {
            btnSubmit.Text = "Cập nhật";
            txtContent.Text = dt.Rows[0]["Content"].ToString();
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (btnSubmit.Text.Equals("Tạo Mới"))
            {
                DataTable dtID = DataAccess.GetDatatable("select max(ID) from AboutUS");
                string id1 = dtID.Rows.Count == 0 ? "0" : dtID.Rows[0][0].ToString() == "" ? "0" : dtID.Rows[0][0].ToString();
                int ID = Convert.ToInt32(id1) + 1;
                string content = txtContent.Text.Replace("'", "''");


                DateTime now = DateTime.Now;
                string sql = @"Insert into AboutUS(Content,UserCreated,CreatedDate) 
                            Values(N'" + content + "','" + Session["UserName"] + "','" + now.ToString() + "')";
                //UserCreated,UserModified,CreatedDate,ModifiedDate,
                DataAccess.Insert(sql);
                MessageBox.Show(Page, "Tao Moi Thanh Cong");
            }
            else
            {
                DateTime now = DateTime.Now;
                string content = txtContent.Text.Replace("'", "''");
                string sql = @"Update AboutUS set Content = N'" + content + "',UserModified = '" + Session["UserName"] +
                                    "',ModifiedDate = '" + now.ToString() + "'";
                DataAccess.Update(sql);
                MessageBox.Show(Page, "Cap Nhat Thanh Cong");
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(Page, "That Bai. Vui Long thu lai");
            return;
        }
        Utilities.redirectClient(Page, "/Admin/GioiThieu/AboutUS.aspx");
        //Utilities.redirectClient(Page, Request.Url.AbsolutePath);

    }

   
}