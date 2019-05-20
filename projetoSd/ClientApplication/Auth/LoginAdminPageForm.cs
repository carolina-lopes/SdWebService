using ClientApplication.AdminArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class LoginAdminPageForm : Form
    {
        public LoginAdminPageForm()
        {
            InitializeComponent();
        }
        private void LoginAButton_Click(object sender, EventArgs e)
        {

            string email = textBoxEmailA.Text;
            string password = textBoxPasswordA.Text;
            string passCheck = "";
            if (!(email.Equals("")) && !(password.Equals("")))
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AuthDB; Integrated Security = True");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select Password from Administrators where Email='" + email + "'", con);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        passCheck = dataReader.GetValue(0).ToString();
                    }
                    dataReader.Close();
                    cmd.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                if (password.Equals(passCheck))
                {
                    AdminAreaForm form2 = new AdminAreaForm();
                    this.Hide();
                    form2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Por favor use credencias válidas.");
                    textBoxEmailA.Clear();
                    textBoxPasswordA.Clear();
                }
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainPageForm form2 = new MainPageForm();
            this.Hide();
            form2.ShowDialog();
        }
    }
}
