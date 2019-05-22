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
    public partial class AdminVerUcAlunoForm : Form
    {
        public AdminVerUcAlunoForm()
        {
            InitializeComponent();
            comboBoxGrau.Items.Add("Licenciatura");
            comboBoxGrau.Items.Add("Mestrado");
            comboBoxGrau.Items.Add("Doutoramento");
        }

        private void buttonVerUc_Click(object sender, EventArgs e)
        {
            textBoxUc.Clear();
            int num = Int32.Parse(textBoxNum.Text);
            String selected = comboBoxGrau.Text;

            try
            {
                AdminService1.AdminService admin = new AdminService1.AdminService();

                if (selected == "Licenciatura")
                {
                    var cadeiras = admin.getCadeirasAlunoL(num);

                    foreach (var cadeira in cadeiras)
                    {
                        textBoxUc.AppendText(cadeira.NomeCadeira + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }
                }

                if (selected == "Mestrado")
                {
                    var cadeiras = admin.getCadeirasAlunoM(num);

                    foreach (var cadeira in cadeiras)
                    {
                        textBoxUc.AppendText(cadeira.NomeCadeira + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }
                }

                if (selected == "Doutoramento")
                {
                    var cadeiras = admin.getCadeirasAlunoD(num);

                    foreach (var cadeira in cadeiras)
                    {
                        textBoxUc.AppendText(cadeira.NomeCadeira + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {

                AdminServiceBackup.AdminServiceBackup admin = new AdminServiceBackup.AdminServiceBackup();

                if (selected == "Licenciatura")
                {
                    var cadeiras = admin.getCadeirasAlunoL(num);

                    foreach (var cadeira in cadeiras)
                    {
                        textBoxUc.AppendText(cadeira.NomeCadeira + " " + cadeira.NotaFinal);
                    }
                }

                if (selected == "Mestrado")
                {
                    var cadeiras = admin.getCadeirasAlunoM(num);

                    foreach (var cadeira in cadeiras)
                    {
                        textBoxUc.AppendText(cadeira.NomeCadeira + " " + cadeira.NotaFinal);
                    }
                }

                if (selected == "Doutoramento")
                {
                    var cadeiras = admin.getCadeirasAlunoD(num);

                    foreach (var cadeira in cadeiras)
                    {
                        textBoxUc.AppendText(cadeira.NomeCadeira + " " + cadeira.NotaFinal);
                        textBoxUc.AppendText(Environment.NewLine);
                    }
                }
            }

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            AdminAreaForm form1 = new AdminAreaForm();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
