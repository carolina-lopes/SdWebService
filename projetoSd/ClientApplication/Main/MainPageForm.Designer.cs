namespace ClientApplication
{
    partial class MainPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.loginUtilizadorButton = new System.Windows.Forms.Button();
            this.loginAdminButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistarButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginUtilizadorButton
            // 
            this.loginUtilizadorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginUtilizadorButton.Location = new System.Drawing.Point(544, 398);
            this.loginUtilizadorButton.Name = "loginUtilizadorButton";
            this.loginUtilizadorButton.Size = new System.Drawing.Size(75, 23);
            this.loginUtilizadorButton.TabIndex = 0;
            this.loginUtilizadorButton.Text = "Login Aluno";
            this.loginUtilizadorButton.UseVisualStyleBackColor = true;
            this.loginUtilizadorButton.Click += new System.EventHandler(this.ButtonLoginAluno_Click);
            // 
            // loginAdminButton
            // 
            this.loginAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginAdminButton.Location = new System.Drawing.Point(636, 398);
            this.loginAdminButton.Name = "loginAdminButton";
            this.loginAdminButton.Size = new System.Drawing.Size(125, 23);
            this.loginAdminButton.TabIndex = 1;
            this.loginAdminButton.Text = "Login Administrador";
            this.loginAdminButton.UseVisualStyleBackColor = true;
            this.loginAdminButton.Click += new System.EventHandler(this.LoginAdminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to College Data Center";
            // 
            // RegistarButton
            // 
            this.RegistarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistarButton.Location = new System.Drawing.Point(43, 398);
            this.RegistarButton.Name = "RegistarButton";
            this.RegistarButton.Size = new System.Drawing.Size(75, 23);
            this.RegistarButton.TabIndex = 3;
            this.RegistarButton.Text = "Registar";
            this.RegistarButton.UseVisualStyleBackColor = true;
            this.RegistarButton.Click += new System.EventHandler(this.RegistarButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(134, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 30;
            this.exitButton.Text = "Sair";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(412, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 334);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.RegistarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginAdminButton);
            this.Controls.Add(this.loginUtilizadorButton);
            this.Name = "MainPageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginUtilizadorButton;
        private System.Windows.Forms.Button loginAdminButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegistarButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

