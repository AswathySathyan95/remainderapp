using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

public partial class MainPage : System.Web.UI.Page
{
    connect cn = new connect();
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.start();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Session["date"] = Calendar1.SelectedDate.ToLongDateString();
        Panel1.Visible = true;
        GridView1.Visible = true;
        GridView1.DataSource = cn.fill("select Reminder,Time,Category from Reminder where When='" + Session["date"].ToString() + "'");
        GridView1.DataBind();
    }
    protected void btnBirthday_Click(object sender, EventArgs e)
    {
        Response.Redirect("Birthday.aspx");
    }
    protected void btnAnniversary_Click(object sender, EventArgs e)
    {
        Response.Redirect("Anniversary.aspx");
    }
    protected void btnEvent_Click(object sender, EventArgs e)
    {
        Response.Redirect("Event.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["id"] = GridView1.SelectedRow.Cells[1].ToString();
        Response.Redirect("Delete_Update.aspx");
    }
}