using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration_SaveRegistr : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Login"] == null)
            return;
        Label1.Text = Request.QueryString["Login"].ToString();
        Label2.Text = Request.QueryString["Password"].ToString();
        Label3.Text = Request.QueryString["E-mail"].ToString();
        System.IO.FileStream fs = new
            System.IO.FileStream(Page.Server.MapPath("Registration.csv"),
            System.IO.FileMode.Append, System.IO.FileAccess.Write);
        System.IO.StreamWriter sw = new System.IO.StreamWriter(fs);
        sw.WriteLine(Request.QueryString["Login"].ToString() + ","
            + Request.QueryString["Password"].ToString() + ","
            + "\"" + Request.QueryString["E-mail"].ToString() + "\"");
        sw.Close();
        fs.Close();
    }
}