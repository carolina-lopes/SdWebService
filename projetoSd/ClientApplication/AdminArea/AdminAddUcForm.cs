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
    public partial class AdminAddUcForm : Form
    {
        public AdminAddUcForm()
        {
            InitializeComponent();
            cb_grau.Items.Add("Licenciatura");
            cb_grau.Items.Add("Mestrado");
            cb_grau.Items.Add("Doutoramento");
        }

        private void B_add_uc_Click(object sender, EventArgs e)
        {
            String nomeUc = textBoxNomeUc.Text;
            int numUc = Int32.Parse(textBoxNumeroUc.Text);
            int numAluno = Int32.Parse(textBoxNumAluno.Text);
            int nota = Int32.Parse(textBoxNota.Text);
            String selected = cb_grau.Text;

            AdminService1.AdminService admin = new AdminService1.AdminService();
            AdminServiceBackup.AdminServiceBackup adminback = new AdminServiceBackup.AdminServiceBackup();

            if(selected == "Licenciatura")
            {
                try
                {
                    admin.addCadeiraL(nomeUc, numAluno, nota, numUc);
                    adminback.addCadeiraL(nomeUc, numAluno, nota, numUc);
                }
                catch (Exception)
                {

                    MessageBox.Show("Impossivel de adicionar");
                }
                textBoxNomeUc.Clear();
                textBoxNota.Clear();
                textBoxNumAluno.Clear();
                textBoxNumeroUc.Clear();
            }

            if (selected == "Mestrado")
            {
                try
                {
                    admin.addCadeiraM(nomeUc, numAluno, nota, numUc);
                    adminback.addCadeiraM(nomeUc, numAluno, nota, numUc);
                }
                catch (Exception)
                {

                    MessageBox.Show("Impossivel de adicionar");
                }
                textBoxNomeUc.Clear();
                textBoxNota.Clear();
                textBoxNumAluno.Clear();
                textBoxNumeroUc.Clear();
            }

            if (selected == "Doutoramento")
            {
                try
                {

                    admin.addCadeiraD(nomeUc, numAluno, nota, numUc);
                    adminback.addCadeiraD(nomeUc, numAluno, nota, numUc);
                }
                catch (Exception)
                {

                    MessageBox.Show("Impossivel de adicionar");
                }
                textBoxNomeUc.Clear();
                textBoxNota.Clear();
                textBoxNumAluno.Clear();
                textBoxNumeroUc.Clear();
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
