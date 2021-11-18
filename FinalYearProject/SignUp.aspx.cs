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
    public partial class SignUp : System.Web.UI.Page
    {
        static string con = System.Configuration.ConfigurationManager.ConnectionStrings["BurdenModelContainer"].ConnectionString;

        static System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder e = new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder(con);
        string ProviderConnectionString = e.ProviderConnectionString; 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            SqlConnection conn = new SqlConnection(ProviderConnectionString);
            conn.Open();
            string query = "SELECT UserId FROM Users Where Username = @User";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@User", Username);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                err_SignUp.IsValid = false;
            }
            else
            {
                query = "INSERT Users (Name, Username, Password) VALUES (@Name, @Username, @Pass)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Pass", Password);
                cmd.ExecuteNonQuery();
                conn.Close();
                FormsAuthentication.SetAuthCookie(Username, true);
                Response.Redirect("~/Category.aspx/?Party=Defendant");
            }
        }
    }
}