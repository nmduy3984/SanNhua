/// <summary>
/// Summary description for MessageBox
/// </summary>
using System.Web.UI;
using System;
public class MessageBox
{
	public MessageBox(){}
    public static void Show(System.Web.UI.Page p, object mess)
    {
        //HttpContext.Current.Response.Write("<script>alert('"+mess.ToString()+"')</script>");        
        System.Web.UI.LiteralControl lt = new System.Web.UI.LiteralControl();
        lt.Text=  "<script language=\"javascript\" type=\"text/javascript\"> alert(\"" + mess.ToString() + "\")</script>";
        p.Header.Controls.Add(lt);        
    }

    /// <summary>
    /// Register Script In UpdatePanel
    /// </summary>
    /// <param name="p"></param>
    /// <param name="mess"></param>
    public static void ShowScript(System.Web.UI.Page p, string mess)
    {
        ScriptManager.RegisterStartupScript(p, p.GetType(), "Alert" + DateTime.Now.Millisecond.ToString(), string.Format("alert('{0}');", mess.Replace("'", "\"").Replace("\r", "").Replace("\n", "")), true);
    }
}
