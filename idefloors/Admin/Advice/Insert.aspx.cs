using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_Advice_Insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string title = txtTitle.Text;
        string des = txtDescription.Text;
        string titleEN = txtTitleEN.Text;
        string desEN = txtDescriptionEN.Text;
        string titleCAM = txtTitleCAM.Text;
        string desCAM = txtDescriptionCAM.Text;
        string linkVideo = txtLinkVideo.Text;
        string manualFile = txtLinkVideo.Text;

        string type = ddlType.SelectedValue;



        DateTime now = DateTime.Now;
        string strName = fileUploadImg.FileName;

        if (type == "0")
        {
            if (this.fileUploadImg.HasFile)
            {
                string sMapPath = StringHelper.getFolderAdviceImages;
                this.fileUploadImg.SaveAs(sMapPath + strName);
            }
            else
                strName = "";
        }

        string strNamePDF = fileManualAdvice.FileName;
        if (this.fileManualAdvice.HasFile)
        {
            string sMapPath = StringHelper.getFolderAdvicePDF;
            this.fileManualAdvice.SaveAs(sMapPath + strNamePDF);
        }
        else
            strNamePDF = "";

        string strNamePDFEN = fileManualAdviceEN.FileName;
        if (this.fileManualAdviceEN.HasFile)
        {
            string sMapPath = StringHelper.getFolderAdvicePDF;
            this.fileManualAdviceEN.SaveAs(sMapPath + strNamePDFEN);
        }
        else
            strNamePDFEN = "";

        string strNamePDFCAM = fileManualAdviceCAM.FileName;
        if (this.fileManualAdviceCAM.HasFile)
        {
            string sMapPath = StringHelper.getFolderAdvicePDF;
            this.fileManualAdviceCAM.SaveAs(sMapPath + strNamePDFCAM);
        }
        else
            strNamePDFCAM = "";

        string sql = @"Insert into Advice(Title, TitleEN, TitleCAM, Description,DescriptionEN,DescriptionCAM, ImageUrl, LinkVideo, UserCreated,CreatedDate, FileName, FileNameEN, FileNameCAM, Type)
                       Values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}','{9}',N'{10}',N'{11}',N'{12}','{13}')
                    ";
        sql = string.Format(sql, title, titleEN, titleCAM, des, desEN, desCAM, strName, linkVideo, Session["UserName"], now.ToString(), strNamePDF, strNamePDFEN, strNamePDFCAM, type);
        try
        {
            DataAccess.Insert(sql);
            MessageBox.Show(Page, "Tao moi thanh cong");
        }
        catch (Exception ex)
        {
            MessageBox.Show(Page, "Tao moi that bai. " + ex.Message.Replace("\r", "").Replace("\n", "").Replace("'", "''"));
        }

        Utilities.redirectClient(Page, "/Admin/Advice/QLAdvice.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/Advice/QLAdvice.aspx");
    }

}