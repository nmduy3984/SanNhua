using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Admin_Advice_Edit : System.Web.UI.Page
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
            DataTable dtSP = DataAccess.GetRecord("Advice", "ID", ID);
            if (dtSP.Rows.Count == 1)
            {
                txtTitle.Text = dtSP.Rows[0]["Title"].ToString();
                txtTitleEN.Text = dtSP.Rows[0]["TitleEN"].ToString();
                txtTitleCAM.Text = dtSP.Rows[0]["TitleCAM"].ToString();
                txtDescription.Text = dtSP.Rows[0]["Description"].ToString();
                txtDescriptionEN.Text = dtSP.Rows[0]["DescriptionEN"].ToString();
                txtDescriptionCAM.Text = dtSP.Rows[0]["DescriptionCAM"].ToString();
                txtImgVideoUrl.Text = dtSP.Rows[0]["ImageUrl"].ToString();
                txtManualFile.Text = dtSP.Rows[0]["FileName"].ToString();
                txtManualFileEN.Text = dtSP.Rows[0]["FileNameEN"].ToString();
                txtManualFileCAM.Text = dtSP.Rows[0]["FileNameCAM"].ToString();
                txtLinkVideo.Text = dtSP.Rows[0]["LinkVideo"].ToString();
                ddlType.SelectedValue = dtSP.Rows[0]["Type"].ToString() == "True" ? "1" : "0";

            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string ID = Request.QueryString["ID"];

        string title = txtTitle.Text;
        string des = txtDescription.Text;
        string titleEN = txtTitleEN.Text;
        string desEN = txtDescriptionEN.Text;
        string titleCAM = txtTitleCAM.Text;
        string desCAM = txtDescriptionCAM.Text;
        string linkVideo = txtLinkVideo.Text;

        string type = ddlType.SelectedValue;



        DateTime now = DateTime.Now;


        string strNameImg = ID + ".jpg";
        if (this.fileUploadImg.HasFile)
        {
            string sMapPath = StringHelper.getFolderAdviceImages;
            if (File.Exists(sMapPath + txtImgVideoUrl.Text))
                File.Delete(sMapPath + txtImgVideoUrl.Text);

            this.fileUploadImg.SaveAs(sMapPath + strNameImg);
        }
        else
            strNameImg = txtImgVideoUrl.Text;

        string strNamePDF = fileManualAdvice.FileName;
        if (this.fileManualAdvice.HasFile)
        {
            string sMapPath = StringHelper.getFolderAdvicePDF;
            if (File.Exists(sMapPath + txtManualFile.Text))
                File.Delete(sMapPath + txtManualFile.Text);

            this.fileManualAdvice.SaveAs(sMapPath + strNamePDF);
        }
        else
            strNamePDF = txtManualFile.Text;

        string strNamePDFEN = fileManualAdviceEN.FileName;
        if (this.fileManualAdviceEN.HasFile)
        {
            string sMapPath = StringHelper.getFolderAdvicePDF;
            if (File.Exists(sMapPath + txtManualFileEN.Text))
                File.Delete(sMapPath + txtManualFileEN.Text);

            this.fileManualAdviceEN.SaveAs(sMapPath + strNamePDFEN);
        }
        else
            strNamePDFEN = txtManualFileEN.Text;

        string strNamePDFCAM = fileManualAdviceCAM.FileName;
        if (this.fileManualAdviceCAM.HasFile)
        {
            string sMapPath = StringHelper.getFolderAdvicePDF;
            if (File.Exists(sMapPath + txtManualFileCAM.Text))
                File.Delete(sMapPath + txtManualFileCAM.Text);

            this.fileManualAdviceCAM.SaveAs(sMapPath + strNamePDFCAM);
        }
        else
            strNamePDFCAM = txtManualFileCAM.Text;

        string sql = @"update Advice set Title = N'{0}',TitleEN = N'{1}',TitleCAM = N'{2}',ImageUrl ='{3}', Description =N'{4}', DescriptionEN =N'{5}', DescriptionCAM =N'{6}',Type = {7}, LinkVideo =N'{8}', UserModified =N'{9}', ModifiedDate ='{10}', FileName =N'{11}', FileNameEN =N'{12}', FileNameCAM =N'{13}'
                       where ID ={14}  ";

        sql = string.Format(sql, title, titleEN, titleCAM, strNameImg, des, desEN, desCAM, type, linkVideo, Session["Username"], now.ToString(), strNamePDF, strNamePDFEN, strNamePDFCAM, ID);
        try
        {
            DataAccess.Update(sql);
            MessageBox.Show(Page, "Cap Nhat thanh cong");
        }
        catch (Exception ex)
        {
            MessageBox.Show(Page, "Cap Nhat that bai. " + ex.Message.Replace("\r", "").Replace("\n", "").Replace("'", "''"));
        }

        Utilities.redirectClient(Page, "/Admin/Advice/QLAdvice.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/Advice/QLAdvice.aspx");
    }
}