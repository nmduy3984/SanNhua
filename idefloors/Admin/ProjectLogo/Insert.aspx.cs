﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ProjectLogo_Insert : System.Web.UI.Page
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
            DataTable dtID = DataAccess.GetDatatable("select max(Id) from ProjectLogo");
            string id1 = dtID.Rows.Count == 0 ? "0" : dtID.Rows[0][0].ToString() == "" ? "0" : dtID.Rows[0][0].ToString();
            int ID = Convert.ToInt32(id1) + 1;
            //string title = txtTitle.Text;
            string link = txtLink.Text;

            DateTime now = DateTime.Now;
            string Img = ID.ToString() + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
 
            if (this.fileUploadImg.HasFile)
            {
                string sMapPath = StringHelper.getFolderProjectLogoImages;
                this.fileUploadImg.SaveAs(sMapPath + Img);
            }
            else
                Img = "";
 
            string sql = @"Insert into ProjectLogo(Link,ImgUrl,UserCreated,CreatedDate) 
                            Values(N'" + link + "','" + Img + "','" + Session["UserName"] + "','" + now.ToString()  + "')";
            DataAccess.Insert(sql);
            MessageBox.Show(Page,"Tao Moi Thanh Cong");
        }
        catch(Exception ex)
        {
            MessageBox.Show(Page, "Tao Moi That Bai. Vui Long thu lai");
            return;
        }
        Utilities.redirectClient(Page, "/Admin/ProjectLogo/QLProjectLogo.aspx");
        //Utilities.redirectClient(Page, Request.Url.AbsolutePath);

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/ProjectLogo/QLProjectLogo.aspx");
    }
    
}