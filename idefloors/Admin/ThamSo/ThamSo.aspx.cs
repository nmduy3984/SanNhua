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
        DataTable dt = DataAccess.GetDatatable("select * from ThamSo");
        if (dt.Rows.Count > 0)
        {
            btnSubmit.Text = "Cập nhật";
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtSkype.Text = dt.Rows[0]["Skype"].ToString();
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (btnSubmit.Text.Equals("Tạo Mới"))
            {
                DataTable dtID = DataAccess.GetDatatable("select max(ID) from ThamSo");
                string id1 = dtID.Rows.Count == 0 ? "0" : dtID.Rows[0][0].ToString() == "" ? "0" : dtID.Rows[0][0].ToString();
                int ID = Convert.ToInt32(id1) + 1;
                string phone = txtPhone.Text.Trim();
                string mobile = txtMobile.Text.Trim();
                string email = txtEmail.Text.Trim();
                string skype = txtSkype.Text.Trim();


                DateTime now = DateTime.Now;
                string sql = @"Insert into ThamSo(Phone,Mobile,Email,Skype,UserCreated,CreatedDate) 
                            Values(N'" + phone + "',N'" + mobile + "',N'" + email + "',N'" + skype + "','" + Session["UserName"] + "','" + now.ToString() + "')";
                //UserCreated,UserModified,CreatedDate,ModifiedDate,
                DataAccess.Insert(sql);
                MessageBox.Show(Page, "Tao Moi Thanh Cong");
            }
            else
            {
                DateTime now = DateTime.Now;
                string phone = txtPhone.Text.Trim();
                string mobile = txtMobile.Text.Trim();
                string email = txtEmail.Text.Trim();
                string skype = txtSkype.Text.Trim();
                string sql = @"Update ThamSo set phone = N'" + phone + "',mobile = N'" + mobile + "',email = N'" + email + "',skype = N'" + skype + "',UserModified = '" + Session["UserName"] +
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
        Utilities.redirectClient(Page, "/Admin/ThamSo/ThamSo.aspx");
        //Utilities.redirectClient(Page, Request.Url.AbsolutePath);

    }

   
}