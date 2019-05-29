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
    public partial class UserAreaForm : Form
    {
        public UserAreaForm(String email)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        
            String num;
            String grau;
            String nome;
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AuthDB; Integrated Security = True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select NumeroAluno, Nome, GrauEnsino from Users where Email='" + email + "'", con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    num = dataReader.GetValue(0).ToString();
                    nome = dataReader.GetValue(1).ToString();
                    grau = dataReader.GetValue(2).ToString();
                    textBoxNome.Text = nome;
                    textBoxNumero.Text = num;
                    textBoxGrau.Text = grau;


                    try
                    {
                        UserService.UserService user = new UserService.UserService();// ligacao a base de dados principal

                        if (grau == "Licenciatura")
                        {
                            var x = user.getCadeiras(Int32.Parse(num));
                            foreach (var cadeira in x)
                            {
                                string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');// eliminacao de espacos, tabs e newlines para uma bao desencriptacao
                                descricao.AppendText(Security.Decrypt(nomtemp[0]));
                                descricao.AppendText("\t");
                                descricao.AppendText(cadeira.NotaFinal.ToString());
                                descricao.AppendText(Environment.NewLine);
                            }

                        }



                        if (grau == "Mestrado")
                        {
                            var x = user.getCadeirasM(Int32.Parse(num));
                            foreach (var cadeira in x)
                            {
                                string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                                descricao.AppendText(Security.Decrypt(nomtemp[0]));
                                descricao.AppendText("\t");
                                descricao.AppendText(cadeira.NotaFinal.ToString());
                                descricao.AppendText(Environment.NewLine);
                            }

                        }


                        if (grau == "Doutoramento")
                        {
                            var x = user.getCadeirasD(Int32.Parse(num));
                            foreach (var cadeira in x)
                            {
                                string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                                descricao.AppendText(Security.Decrypt(nomtemp[0]));
                                descricao.AppendText("\t");
                                descricao.AppendText(cadeira.NotaFinal.ToString());
                                descricao.AppendText(Environment.NewLine);
                            }

                        }
                    }
                    catch (Exception)
                    {

                        UserServiceBackup.UserServiceBackup user = new UserServiceBackup.UserServiceBackup();// em caso de indisponibilidade a base de dados ira buscar informacao a base de dados secundaria

                        if (grau == "Licenciatura")
                        {
                            var x = user.getCadeiras(Int32.Parse(num));
                            foreach (var cadeira in x)
                            {
                                string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                                descricao.AppendText(Security.Decrypt(nomtemp[0]));
                                descricao.AppendText("\t");
                                descricao.AppendText(cadeira.NotaFinal.ToString());
                                descricao.AppendText(Environment.NewLine);
                            }

                        }



                        if (grau == "Mestrado")
                        {
                            var x = user.getCadeirasM(Int32.Parse(num));
                            foreach (var cadeira in x)
                            {
                                string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                                descricao.AppendText(Security.Decrypt(nomtemp[0]));
                                descricao.AppendText("\t");
                                descricao.AppendText(cadeira.NotaFinal.ToString());
                                descricao.AppendText(Environment.NewLine);
                            }

                        }


                        if (grau == "Doutoramento")
                        {
                            var x = user.getCadeirasD(Int32.Parse(num));
                            foreach (var cadeira in x)
                            {
                                string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                                descricao.AppendText(Security.Decrypt(nomtemp[0]));
                                descricao.AppendText("\t");
                                descricao.AppendText(cadeira.NotaFinal.ToString());
                                descricao.AppendText(Environment.NewLine);
                            }

                        }
                    }

                }
                dataReader.Close();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            


        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
