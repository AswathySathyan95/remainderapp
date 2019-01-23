using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Delete_Update : System.Web.UI.Page
{
    connect cn = new connect();
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.start();
        cn.dr = cn.read("select Time,Reminder,Location from Reminder where Id='" + Session["id"].ToString() + "'");
        if (cn.dr.Read())
        {
            txtWhen.Text = Session["date"].ToString();
            txtTime.Text = cn.dr.GetValue(0).ToString();
            txtReminder.Text = cn.dr.GetValue(1).ToString();
            txtLoc.Text = cn.dr.GetValue(2).ToString();
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        cn.dml("update Reminder set Time='" + txtTime.Text.ToString() + "',Reminder='" + txtReminder.Text.ToString() + "',Location='" + txtLoc.Text.ToString() + "' where Id='" + Session["id"].ToString() + "'");
        Response.Redirect("MainPage.aspx");
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        cn.dml("delete from Reminder where Id='" + Session["id"].ToString() + "'");
        Response.Redirect("MainPage.aspx");
    }
}