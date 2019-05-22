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
    public partial class AdminAddAlunosForm : Form
    {
        public AdminAddAlunosForm()
        {
            InitializeComponent();
            cb_grau.Items.Add("Licenciatura");
            cb_grau.Items.Add("Mestrado");
            cb_grau.Items.Add("Doutoramento");
        }

        private void B_add_alunos_Click(object sender, EventArgs e)
        {
            String nome = textBoxNome.Text;
            int num = Int32.Parse(textBoxNum.Text);
            String selected = cb_grau.Text;
            nome = ClientApplication.Security.Encrypt(nome);
            try
            {
                AdminService1.AdminService admin = new AdminService1.AdminService();
                AdminServiceBackup.AdminServiceBackup adminback = new AdminServiceBackup.AdminServiceBackup();
                if (selected == "Licenciatura")
                {
                    admin.addAlunoL(nome, num);
                    adminback.addAlunoL(nome, num);
                    textBoxNome.Clear();
                    textBoxNum.Clear();
                }

                if (selected == "Mestrado")
                {
                    admin.addAlunoM(nome, num);
                    adminback.addAlunoM(nome, num);
                    textBoxNome.Clear();
                    textBoxNum.Clear();
                }

                if (selected == "Doutoramento")
                {
                    admin.addAlunoD(nome, num);
                    adminback.addAlunoD(nome, num);
                    textBoxNome.Clear();
                    textBoxNum.Clear();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Impossivel de adicionar");
            }


        }

        private void B_voltar_Click(object sender, EventArgs e)
        {
            AdminAreaForm form1 = new AdminAreaForm();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
