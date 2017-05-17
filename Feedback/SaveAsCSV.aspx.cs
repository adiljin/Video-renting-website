using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Feedback_SaveAsCSV : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Name"] == null)
            return;
        Label1.Text = Request.QueryString["Name"].ToString();
        Label2.Text = Request.QueryString["Email"].ToString();
        Label3.Text = Request.QueryString["Comments"].ToString();
        System.IO.FileStream fs = new
            System.IO.FileStream(Page.Server.MapPath("Feedbacks.csv"),
            System.IO.FileMode.Append, System.IO.FileAccess.Write);
        System.IO.StreamWriter sw = new System.IO.StreamWriter(fs);
        sw.WriteLine(Request.QueryString["Name"].ToString() + ","
            + Request.QueryString["Email"].ToString() + ","
            + "\"" + Request.QueryString["Comments"].ToString() + "\"");
        sw.Close();
        fs.Close();
    }
}