using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication.AdminArea
{
    public partial class AdminVerUcForm : Form
    {
        public AdminVerUcForm()
        {
            InitializeComponent();
            cb_grau.Items.Add("Licenciatura");
            cb_grau.Items.Add("Mestrado");
            cb_grau.Items.Add("Doutoramento");
        }

        private void B_voltar_Click(object sender, EventArgs e)
        {
            AdminAreaForm form1 = new AdminAreaForm();
            this.Hide();
            form1.ShowDialog();
        }

        private void buttonVerUc_Click(object sender, EventArgs e)
        {
            textBoxUc.Clear();
            String selected = cb_grau.Text;

            try
            {
                AdminService1.AdminService admin = new AdminService1.AdminService();

                if (selected == "Licenciatura")
                {
                    var cadeiras = admin.getCadeirasL();

                    foreach (var cadeira in cadeiras)
                    {
                        string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                        textBoxUc.AppendText(cadeira.NumeroAluno.ToString() + " " + Security.Decrypt(nomtemp[0]) + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }

                }

                if (selected == "Mestrado")
                {
                    var cadeiras = admin.getCadeirasM();

                    foreach (var cadeira in cadeiras)
                    {


                        string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                        textBoxUc.AppendText(cadeira.NumeroAluno.ToString() + " " + Security.Decrypt(nomtemp[0]) + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }

                }


                if (selected == "Doutoramento")
                {
                    var cadeiras = admin.getCadeirasD();

                    foreach (var cadeira in cadeiras)
                    {

                        string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                        textBoxUc.AppendText(cadeira.NumeroAluno.ToString() + " " + Security.Decrypt(nomtemp[0]) + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }

                }
            }
            catch (Exception)
            {

                AdminServiceBackup.AdminServiceBackup admin = new AdminServiceBackup.AdminServiceBackup();

                if (selected == "Licenciatura")
                {
                    var cadeiras = admin.getCadeirasL();

                    foreach (var cadeira in cadeiras)
                    {


                        string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                        textBoxUc.AppendText(cadeira.NumeroAluno.ToString() + " " + Security.Decrypt(nomtemp[0]) + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }

                }

                if (selected == "Mestrado")
                {
                    var cadeiras = admin.getCadeirasM();

                    foreach (var cadeira in cadeiras)
                    {

                        string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                        textBoxUc.AppendText(cadeira.NumeroAluno.ToString() + " " + Security.Decrypt(nomtemp[0]) + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }

                }


                if (selected == "Doutoramento")
                {
                    var cadeiras = admin.getCadeirasD();

                    foreach (var cadeira in cadeiras)
                    {

                        string[] nomtemp = cadeira.NomeCadeira.Split(' ', '\r', '\n');
                        textBoxUc.AppendText(cadeira.NumeroAluno.ToString() + " " + Security.Decrypt(nomtemp[0]) + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }

                }
            }



        }
    }
}
