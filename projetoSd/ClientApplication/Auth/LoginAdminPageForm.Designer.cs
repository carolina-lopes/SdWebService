namespace ClientApplication
{
    partial class LoginAdminPageForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmailA = new System.Windows.Forms.TextBox();
            this.LoginAButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(173, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // textBoxPasswordA
            // 
            this.textBoxPasswordA.Location = new System.Drawing.Point(173, 226);
            this.textBoxPasswordA.Name = "textBoxPasswordA";
            this.textBoxPasswordA.PasswordChar = '*';
            this.textBoxPasswordA.Size = new System.Drawing.Size(270, 20);
            this.textBoxPasswordA.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // textBoxEmailA
            // 
            this.textBoxEmailA.Location = new System.Drawing.Point(173, 188);
            this.textBoxEmailA.Name = "textBoxEmailA";
            this.textBoxEmailA.Size = new System.Drawing.Size(270, 20);
            this.textBoxEmailA.TabIndex = 5;
            // 
            // LoginAButton
            // 
            this.LoginAButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginAButton.Location = new System.Drawing.Point(649, 381);
            this.LoginAButton.Name = "LoginAButton";
            this.LoginAButton.Size = new System.Drawing.Size(75, 23);
            this.LoginAButton.TabIndex = 10;
            this.LoginAButton.Text = "Login";
            this.LoginAButton.UseVisualStyleBackColor = true;
            this.LoginAButton.Click += new System.EventHandler(this.LoginAButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(556, 381);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 29;
            this.exitButton.Text = "Sair";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginAdminPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.LoginAButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPasswordA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmailA);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoginAdminPageForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPasswordA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmailA;
        private System.Windows.Forms.Button LoginAButton;
        private System.Windows.Forms.Button exitButton;
    }
}