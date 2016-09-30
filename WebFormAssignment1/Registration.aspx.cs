using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormAssignment1
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page previouspage = Page.PreviousPage;
            if (previouspage != null)
            {
                TextBoxUN.Text     =  Session["UserName"].ToString();
                TextBoxEmail.Text  =  Session["Email"].ToString();
                TextBoxPswrd.Text  =  Session["Password"].ToString();
                TextBoxCPswrd.Text =  Session["ConfirmPassword"].ToString();
                DropDownListCountry.Text = Session["Country"].ToString();
            }

        }  
        protected void Send()
        {
            Session["UserName"] = TextBoxUN.Text;
            Session["Email"] = TextBoxEmail.Text;
            Session["Password"] = TextBoxPswrd.Text;
            Session["ConfirmPassword"] = TextBoxCPswrd.Text;
            Session["Country"] = DropDownListCountry.Text;
            Response.Redirect("ConfirmRegistration.aspx");
            //Response.Redirect("~/ConfirmRegistration.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}