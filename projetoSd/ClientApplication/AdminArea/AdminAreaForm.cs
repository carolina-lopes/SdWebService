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
    public partial class AdminAreaForm : Form
    {
        public AdminAreaForm()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Uc_Click(object sender, EventArgs e)
        {
            AdminAddUcForm form1 = new AdminAddUcForm();
            this.Hide();
            form1.ShowDialog();
        }

        private void VerUc_Click(object sender, EventArgs e)
        {
            AdminVerUcForm form1 = new AdminVerUcForm();
            this.Hide();
            form1.ShowDialog();
        }

        private void AddAluno_Click(object sender, EventArgs e)
        {
            AdminAddAlunosForm form1 = new AdminAddAlunosForm();
            this.Hide();
            form1.ShowDialog();
        }

        private void VerAluno_Click(object sender, EventArgs e)
        {
            AdminVerAlunosForm form1 = new AdminVerAlunosForm();
            this.Hide();
            form1.ShowDialog();
        }

        private void buttonVerUcALuno_Click(object sender, EventArgs e)
        {
            AdminVerUcAlunoForm form1 = new AdminVerUcAlunoForm();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
