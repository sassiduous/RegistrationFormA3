using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormAssignment1
{
    public partial class ConfirmRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Display();
        }

        public void Display()
        {
            UserNameDisplay.Text = Session["UserName"].ToString();
            EmailDisplay.Text= Session["Email"].ToString();
            PasswordDisplay.Text=   Session["Password"].ToString();
            ConfirmPasswordDisplay.Text=  Session["ConfirmPassword"].ToString();
            CountryDisplay.Text=  Session["Country"].ToString();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            string UserName = Session["UserName"].ToString();
            string Email = Session["Email"].ToString();
            string Password = Session["Password"].ToString();
            string ConfirmPassword = Session["ConfirmPassword"].ToString();
            string Country = Session["Country"].ToString();
            dbinsert(UserName, Email, Password, ConfirmPassword, Country);
        }
        public string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["WebFormsA3ConnectionString"].ConnectionString;
        }

        public void dbinsert(string userName, string email, string password, string confirmPassword, string country)
        {
            SqlConnection ctn = new SqlConnection(GetConnectionString());
            string sql = "INSERT INTO Registration (UserName, Email, Password, ConfirmPassword, Country) "+ "VALUES (@userName, @email, @password, @confirmPassword, @country)";

            try
            {
                ctn.Open();
                SqlCommand cd = new SqlCommand(sql, ctn);
                SqlParameter[] prmtr = new SqlParameter[5];
                prmtr[0] = new SqlParameter("@userName", SqlDbType.NChar, 10);
                prmtr[1] = new SqlParameter("@email", SqlDbType.NChar, 10);
                prmtr[2] = new SqlParameter("@password", SqlDbType.NChar, 10);
                prmtr[3] = new SqlParameter("@confirmPassword", SqlDbType.NChar, 10);
                prmtr[4] = new SqlParameter("@country", SqlDbType.NChar, 10);

                prmtr[0].Value = userName;
                prmtr[1].Value = email;
                prmtr[2].Value = password;
                prmtr[3].Value = confirmPassword;
                prmtr[4].Value = country;

                for (int i = 0; i < prmtr.Length; i++)
                {
                    cd.Parameters.Add(prmtr[i]);
                }
                cd.CommandType = CommandType.Text;
                cd.ExecuteNonQuery();
                Response.Redirect("Admin.aspx");
                //Response.Write("Registration successful");

            }

            catch (System.Data.SqlClient.SqlException e)
            {
                string msge = "Database error";
                msge += e.Message;
                throw new Exception(msge);
            }
            finally
            {
                ctn.Close();
            }
                // throw new NotImplementedException();
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Session["UserName"] = UserNameDisplay.Text;
            Session["Email"] = EmailDisplay.Text;
            Session["Password"] = PasswordDisplay.Text;
            Session["ConfirmPassword"] = ConfirmPasswordDisplay.Text;
            Session["Country"] = CountryDisplay.Text;

            Server.Transfer("~/Registration.aspx");

            //Response.Redirect("Registration.aspx");
        }
    }
}