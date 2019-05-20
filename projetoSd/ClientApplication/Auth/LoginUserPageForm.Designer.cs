namespace ClientApplication
{
    partial class LoginUserPageForm
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
            this.LoginUButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmailU = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginUButton
            // 
            this.LoginUButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginUButton.Location = new System.Drawing.Point(492, 296);
            this.LoginUButton.Name = "LoginUButton";
            this.LoginUButton.Size = new System.Drawing.Size(75, 23);
            this.LoginUButton.TabIndex = 16;
            this.LoginUButton.Text = "Login";
            this.LoginUButton.UseVisualStyleBackColor = true;
            this.LoginUButton.Click += new System.EventHandler(this.LoginUButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(154, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login Utilizador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // textBoxPasswordU
            // 
            this.textBoxPasswordU.Location = new System.Drawing.Point(154, 199);
            this.textBoxPasswordU.Name = "textBoxPasswordU";
            this.textBoxPasswordU.PasswordChar = '*';
            this.textBoxPasswordU.Size = new System.Drawing.Size(270, 20);
            this.textBoxPasswordU.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // textBoxEmailU
            // 
            this.textBoxEmailU.Location = new System.Drawing.Point(154, 161);
            this.textBoxEmailU.Name = "textBoxEmailU";
            this.textBoxEmailU.Size = new System.Drawing.Size(270, 20);
            this.textBoxEmailU.TabIndex = 11;
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(411, 296);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "Sair";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginUserPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.LoginUButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPasswordU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmailU);
            this.Name = "LoginUserPageForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginUserPageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginUButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPasswordU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmailU;
        private System.Windows.Forms.Button exitButton;
    }
}