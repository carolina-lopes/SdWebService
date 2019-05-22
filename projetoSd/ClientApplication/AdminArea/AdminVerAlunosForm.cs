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
    public partial class AdminVerAlunosForm : Form
    {
        public AdminVerAlunosForm()
        {
            InitializeComponent();
            comboBoxGrau.Items.Add("Licenciatura");
            comboBoxGrau.Items.Add("Mestrado");
            comboBoxGrau.Items.Add("Doutoramento");

        }
        private void VerAlunos_Click_1(object sender, EventArgs e)
        {
            textBoxAlunos.Clear();
            String selected = comboBoxGrau.Text;

            try
            {
                AdminService1.AdminService admin = new AdminService1.AdminService();


                if (selected == "Licenciatura")
                {
                    var alunos = admin.getAlunosL();

                    foreach (var aluno in alunos)
                    {


                        string[] nomtemp = aluno.Nome.Split(' ', '\r', '\n');
                        textBoxAlunos.AppendText(ClientApplication.Security.Decrypt(nomtemp[0]));
                        textBoxAlunos.AppendText("\t");
                        textBoxAlunos.AppendText(aluno.NumeroAluno.ToString());
                        textBoxAlunos.AppendText(Environment.NewLine);
                    }
                }

                if (selected == "Mestrado")
                {
                    var alunos = admin.getAlunosM();

                    foreach (var aluno in alunos)
                    {
                        string[] nomtemp = aluno.Nome.Split(' ', '\r', '\n');
                        textBoxAlunos.AppendText(ClientApplication.Security.Decrypt(nomtemp[0]));
                        textBoxAlunos.AppendText("\t");
                        textBoxAlunos.AppendText(aluno.NumeroAluno.ToString());
                        textBoxAlunos.AppendText(Environment.NewLine);
                    }
                }

                if (selected == "Doutoramento")
                {
                    var alunos = admin.getAlunosD();

                    foreach (var aluno in alunos)
                    {
                        string[] nomtemp = aluno.Nome.Split(' ', '\r', '\n');
                        textBoxAlunos.AppendText(ClientApplication.Security.Decrypt(nomtemp[0]));
                        textBoxAlunos.AppendText("\t");
                        textBoxAlunos.AppendText(aluno.NumeroAluno.ToString());
                        textBoxAlunos.AppendText(Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {

                AdminServiceBackup.AdminServiceBackup admin = new AdminServiceBackup.AdminServiceBackup();


                if (selected == "Licenciatura")
                {
                    var alunos = admin.getAlunosL();

                    foreach (var aluno in alunos)
                    {
                        string[] nomtemp = aluno.Nome.Split(' ', '\r', '\n');
                        textBoxAlunos.AppendText(ClientApplication.Security.Decrypt(nomtemp[0]));
                        textBoxAlunos.AppendText("\t");
                        textBoxAlunos.AppendText(aluno.NumeroAluno.ToString());
                        textBoxAlunos.AppendText(Environment.NewLine);
                    }
                }

                if (selected == "Mestrado")
                {
                    var alunos = admin.getAlunosM();

                    foreach (var aluno in alunos)
                    {
                        string[] nomtemp = aluno.Nome.Split(' ', '\r', '\n');
                        textBoxAlunos.AppendText(ClientApplication.Security.Decrypt(nomtemp[0]));
                        textBoxAlunos.AppendText("\t");
                        textBoxAlunos.AppendText(aluno.NumeroAluno.ToString());
                        textBoxAlunos.AppendText(Environment.NewLine);
                    }
                }

                if (selected == "Doutoramento")
                {
                    var alunos = admin.getAlunosD();

                    foreach (var aluno in alunos)
                    {
                        string[] nomtemp = aluno.Nome.Split(' ', '\r', '\n');
                        textBoxAlunos.AppendText(ClientApplication.Security.Decrypt(nomtemp[0]));
                        textBoxAlunos.AppendText("\t");
                        textBoxAlunos.AppendText(aluno.NumeroAluno.ToString());
                        textBoxAlunos.AppendText(Environment.NewLine);
                    }
                }
            }

        }

        private void Voltar_Click_1(object sender, EventArgs e)
        {
            AdminAreaForm form1 = new AdminAreaForm();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
