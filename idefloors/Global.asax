<%@ Application Language="C#" %>
<%@ Import namespace="System.Threading" %>
<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Collections.Generic" %>
<%@ Import namespace="System.IO" %>
<script runat="server">
protected void Application_BeginRequest(Object sender, EventArgs e)
{
    HttpCookie cookie = Request.Cookies["ActiveStoreID"];
    if (cookie == null)
    {
        cookie = new HttpCookie("ActiveStoreID");
        cookie.Value = "-1";
    }
    cookie.Expires = DateTime.Now.AddDays(3);
    Response.Cookies.Add(cookie);
    
}
void Application_Start(object sender, EventArgs e)
{
    // Code that runs on application startup
   
}

void Application_End(object sender, EventArgs e)
{
    //  Code that runs on application shutdown
}

void Application_Error(object sender, EventArgs e)
{
    // Code that runs when an unhandled error occurs

}

void Session_Start(object sender, EventArgs e)
{    
    // Code that runs when a new session is started
    if (Session["Lang"] == null) Session["Lang"] = "EN";
    Session["UserName"] = "";
    Session["UserID"] = "";
}

void Session_End(object sender, EventArgs e)
{
    // Code that runs when a session ends. 
    // Note: The Session_End event is raised only when the sessionstate mode
    // is set to InProc in the Web.config file. If session mode is set to StateServer 
    // or SQLServer, the event is not raised.
}


</script>
