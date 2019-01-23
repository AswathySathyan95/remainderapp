using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Event : System.Web.UI.Page
{
    connect cn = new connect();
    String a = "Event";
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.start();
        txtDate.Text = Session["date"].ToString();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
         cn.dml("insert into Reminder(When,Time,Reminder,Location,Category) values('"+txtDate.Text.ToString()+"','"+txtTime.Text.ToString()+"','"+txtEvent.Text.ToString()+"','"+txtLocation.Text.ToString()+"','"+a.ToString()+"')");
        Response.Redirect("MainPage.aspx");
    }
}