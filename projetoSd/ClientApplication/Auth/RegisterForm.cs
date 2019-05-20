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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            comboBoxGrauEnsino.Items.Add("Licenciatura");
            comboBoxGrauEnsino.Items.Add("Mestrado");
            comboBoxGrauEnsino.Items.Add("Doutoramento");

            comboBoxTipoConta.Items.Add("Administrador");
            comboBoxTipoConta.Items.Add("Utilizador");

            textBoxNome.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxNumAluno.Enabled = false;
            textBoxPassword.Enabled = false;
            textBoxRepeatPassword.Enabled = false;
            comboBoxGrauEnsino.Enabled = false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        string selectedType = "";

        private void ComboBoxTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNome.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxNumAluno.Enabled = false;
            textBoxPassword.Enabled = false;
            textBoxRepeatPassword.Enabled = false;
            comboBoxGrauEnsino.Enabled = false;

            Object selected = comboBoxTipoConta.SelectedItem;
            selectedType = selected.ToString();
            if (selectedType.Equals("Administrador")) {
                textBoxNome.Enabled = true;
                textBoxEmail.Enabled = true;
                textBoxPassword.Enabled = true;
                textBoxRepeatPassword.Enabled = true;
            }else
            {
                textBoxNome.Enabled = true;
                textBoxEmail.Enabled = true;
                textBoxNumAluno.Enabled = true;
                textBoxPassword.Enabled = true;
                textBoxRepeatPassword.Enabled = true;
                comboBoxGrauEnsino.Enabled = true;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (selectedType.Equals("Administrador"))
            {
                string email = textBoxEmail.Text;
                string nome = textBoxNome.Text;
                string password = textBoxPassword.Text;
                string repPassword = textBoxRepeatPassword.Text;

                if (!(email.Equals(""))&& !(password.Equals("")) && !(nome.Equals("")) && !(repPassword.Equals("")))
                {
                    if (password.Equals(repPassword))
                    {
                        //database deploy
                        SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AuthDB; Integrated Security = True");
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("Insert into Administrators (Nome,Email,Password) values ('"+nome+"','"+email+"','"+password+"')", con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        MainPageForm form2 = new MainPageForm();
                        this.Hide();
                        form2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("As palavras passe não correspondem.");
                        textBoxPassword.Clear();
                        textBoxRepeatPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor preencha todos os campos necessários.");
                }
            }
            else
            {

                string email = textBoxEmail.Text;
                string nome = textBoxNome.Text;
                string password = textBoxPassword.Text;
                string repPassword = textBoxRepeatPassword.Text;
                int numeroAluno = int.Parse(textBoxNumAluno.Text);
                string grau = comboBoxGrauEnsino.SelectedItem.ToString();


                if (!(email.Equals("")) && !(password.Equals("")) && !(nome.Equals("")) && !(repPassword.Equals("")) && !(grau.Equals("")))
                {
                    if (password.Equals(repPassword))
                    {
                        //database deploy
                        SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AuthDB; Integrated Security = True");
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("Insert into Users (Nome,Email,Password,NumeroAluno,GrauEnsino) values ('" + nome + "','" + email + "','" + password + "','"+numeroAluno+"','"+grau+"')", con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        MainPageForm form2 = new MainPageForm();
                        this.Hide();
                        form2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("As palavras passe não correspondem.");
                        textBoxPassword.Clear();
                        textBoxRepeatPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor preencha todos os campos necessários.");
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
