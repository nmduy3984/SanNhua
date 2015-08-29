﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_SanPham_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadData();
    }
   
    protected void LoadData()
    {
        string ID = Request.QueryString["ID"] == null ? "" : Request.QueryString["ID"];
        
       

        if (ID != "")
        {
            DataTable dtSP = DataAccess.GetRecord("Product", "ID", ID);
            if (dtSP.Rows.Count == 1)
            {
                txtKichThuoc.Text = dtSP.Rows[0]["Size"].ToString();
                txtMaSanPham.Text = dtSP.Rows[0]["ProductID"].ToString();
                txtTenSanPham.Text = dtSP.Rows[0]["Name"].ToString();
                string catID = dtSP.Rows[0]["CategoryID"].ToString();
                txtImgUrl.Text = dtSP.Rows[0]["ImageUrl"].ToString();
                txtDes.Text = dtSP.Rows[0]["Description"].ToString();
                ddlStatus.SelectedValue = dtSP.Rows[0]["Status"].ToString() == "True" ? "1" : "0"; 
               // txtThumb.Text = dtSP.Rows[0]["ThumUrl"].ToString();

                DataAccess.LoadCategory(ref ddlDanhMuc, catID);
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string ID = Request.QueryString["ID"];

        string tenSP = txtTenSanPham.Text;
        string maSP = txtMaSanPham.Text;
        string kichthuoc = txtKichThuoc.Text;
        string madm = ddlDanhMuc.SelectedValue;
        string des = txtDes.Text;
        string status = ddlStatus.SelectedValue.ToString();

        string sql = "select * from Product where ProductID = '" + maSP + "' and ID != " + ID ;
        DataTable dtSP = DataAccess.GetDatatable(sql);
        if (dtSP.Rows.Count > 0)
        {
            MessageBox.Show(Page, "Mã Sản Phẩm Đã Tồn Tại");
            return;
        }

        DateTime now = DateTime.Now;
        string strNameImg = maSP + ".jpg";
       // string strNamethumb = now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".jpg";
        if (this.fileUploadImg.HasFile)
        {
            string sMapPath = StringHelper.getFolderImages;
            if (File.Exists(sMapPath + txtImgUrl.Text))
                File.Delete(sMapPath + txtImgUrl.Text);

            this.fileUploadImg.SaveAs(sMapPath + strNameImg);
        }
        else
            strNameImg = txtImgUrl.Text;

        //if (this.fileUploadThumbnail.HasFile)
        //{
        //    string sMapPath = StringHelper.getFolderImages;
        //    this.fileUploadThumbnail.SaveAs(sMapPath + strNamethumb);
        //    if (File.Exists(sMapPath + txtImgUrl.Text))
        //        File.Delete(sMapPath + txtImgUrl.Text);
        //}
        //else
        //    strNamethumb = txtThumb.Text;


        sql = @"update Product set Name = N'{0}',Size = N'{1}',CategoryID = {2},ImageUrl ='{3}', Description ='{4}',Status = {5}
                       where ID ='{6}'  ";

        sql = string.Format(sql, tenSP, kichthuoc, ddlDanhMuc.SelectedValue, strNameImg, des, status, ID);
        try
        {
            DataAccess.Update(sql);
            MessageBox.Show(Page, "Cap Nhat thanh cong");
        }
        catch (Exception ex)
        {
            MessageBox.Show(Page, "Cap Nhat that bai. " + ex.Message.Replace("\r", "").Replace("\n", "").Replace("'", "''"));
        }

        Utilities.redirectClient(Page, "/Admin/SanPham/QLSanPham.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/SanPham/QLSanPham.aspx");
    }
}