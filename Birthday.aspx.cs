using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Birthday : System.Web.UI.Page
{
    connect cn = new connect();
    String a = "Birthday";
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.start();
        txtDate.Text = Session["date"].ToString();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        cn.dml("insert into Reminder(When,Time,Category) values('"+txtDate.Text.ToString()+"','"+txtTime.Text.ToString()+"','"+a.ToString()+"')");
        Response.Redirect("MainPage.aspx");
    }
}