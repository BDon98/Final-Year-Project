using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace FinalYearProject
{
    public partial class _Default : Page
    {
        static string con = System.Configuration.ConfigurationManager.ConnectionStrings["BurdenModelContainer"].ConnectionString;

        static System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder e = new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder(con);
        string ProviderConnectionString = e.ProviderConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnPlaintiff_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Category.aspx/?Party=Plaintiff");
        }

        protected void btnDefendant_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Category.aspx/?Party=Defendant");
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SignUp.aspx/?");
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            bool userMatch = false;
            bool passMatch = false;
            string User = txtUsername.Text;
            string Password = txtPassword.Text;
            SqlConnection conn = new SqlConnection(ProviderConnectionString);
            conn.Open();
            string query = "SELECT UserId FROM Users Where Username = @User";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@User", User);
            cmd.Parameters.AddWithValue("@Pass", Password);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                userMatch = true;
                query = "SELECT UserId FROM Users Where Username = @User AND Password = @Pass";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@User", User);
                cmd.Parameters.AddWithValue("@Pass", Password);
                rdr = cmd.ExecuteReader();
                if(rdr.HasRows)
                {
                    passMatch = true;
                }
            }
            conn.Close();

            if(userMatch)
            {
                if(passMatch)
                {
                    err_Login.Visible = false;
                    FormsAuthentication.SetAuthCookie(User, true);
                    Response.Redirect("~/Category.aspx/?Party=Defendant");
                }
                else
                {
                    err_Login.Text = "*Incorrect Password";
                    err_Login.IsValid = false;
                }
            }
            else 
            {
                err_Login.Text = "*Incorrect Username";
                err_Login.IsValid = false;
            }
        }
    }
}