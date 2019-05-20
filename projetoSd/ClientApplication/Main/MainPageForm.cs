using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientApplication 
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void ButtonLoginAluno_Click(object sender, EventArgs e)
        {
            LoginUserPageForm form2 = new LoginUserPageForm();
            this.Hide();
            form2.ShowDialog();
        }

        private void LoginAdminButton_Click(object sender, EventArgs e)
        {
            LoginAdminPageForm form2 = new LoginAdminPageForm();
            this.Hide();
            form2.ShowDialog();
        }

        private void RegistarButton_Click(object sender, EventArgs e)
        {
            RegisterForm form2 = new RegisterForm();
            this.Hide();
            form2.ShowDialog();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
