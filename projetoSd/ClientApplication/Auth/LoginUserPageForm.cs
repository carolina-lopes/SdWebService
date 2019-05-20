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
    public partial class LoginUserPageForm : Form
    {
        public LoginUserPageForm()
        {
            InitializeComponent();
        }

        private void LoginUserPageForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginUButton_Click(object sender, EventArgs e)
        {
           
            string email = textBoxEmailU.Text;
            string password = textBoxPasswordU.Text;
            string passCheck="";
            if (!(email.Equals("")) && !(password.Equals("")))
            {
                SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AuthDB; Integrated Security = True");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select Password from Users where Email='" + email + "'", con);
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
                    UserAreaForm form2 = new UserAreaForm(textBoxEmailU.Text.ToString());
                    this.Hide();
                    form2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Por favor use credencias válidas.");
                    textBoxEmailU.Clear();
                    textBoxPasswordU.Clear();
                }
            }
        }
        

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainPageForm form2 = new MainPageForm();
            this.Hide();
            form2.ShowDialog();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
