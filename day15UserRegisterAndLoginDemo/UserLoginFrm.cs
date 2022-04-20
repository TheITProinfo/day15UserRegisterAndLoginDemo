using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace day15UserRegisterAndLoginDemo
{
    public partial class UserLoginFrm : Form
    {
        public UserLoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckFrom())
            {
                return;
            }

            // MessageBox.Show("Login Success!");
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn =new SqlConnection(connStr))
            {

                using (SqlCommand cmd= conn.CreateCommand())
                {
                    conn.Open();

                    string sql = string.Format(" select count(1) from UserInfo where UserName='{0}' and UserPassword='{1}'", txtUserName.Text,txtPassword.Text);
                    cmd.CommandText = sql;

                   object result= cmd.ExecuteScalar();
                   int nums = int.Parse(result.ToString());

                   if (nums >= 1)

                   {
                       MessageBox.Show("Login OK");
                       this.Close();
                   }

                   else
                   {
                       MessageBox.Show("Login failure");

                   }



                }
            }

        }

        #region Method Validate form
        private bool CheckFrom()
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
            {
                MessageBox.Show("Please enter User Name");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPassword.Text.Trim()))
            {

                MessageBox.Show("Please Enter Password!");
                return false;
            }



            return true;
        } 
        #endregion
    }
}
