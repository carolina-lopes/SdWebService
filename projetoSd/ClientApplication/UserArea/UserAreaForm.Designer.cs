namespace ClientApplication
{
    partial class UserAreaForm
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
            this.Sair = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Grau = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxGrau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(486, 366);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(113, 40);
            this.Sair.TabIndex = 5;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // descricao
            // 
            this.descricao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descricao.Enabled = false;
            this.descricao.Location = new System.Drawing.Point(40, 190);
            this.descricao.Multiline = true;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Size = new System.Drawing.Size(395, 216);
            this.descricao.TabIndex = 6;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(37, 110);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(44, 13);
            this.Numero.TabIndex = 7;
            this.Numero.Text = "Numero";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(400, 110);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 8;
            this.Nome.Text = "Nome";
            // 
            // Grau
            // 
            this.Grau.AutoSize = true;
            this.Grau.Location = new System.Drawing.Point(37, 36);
            this.Grau.Name = "Grau";
            this.Grau.Size = new System.Drawing.Size(30, 13);
            this.Grau.TabIndex = 9;
            this.Grau.Text = "Grau";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(442, 109);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(157, 20);
            this.textBoxNome.TabIndex = 12;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(91, 110);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(152, 20);
            this.textBoxNumero.TabIndex = 11;
            // 
            // textBoxGrau
            // 
            this.textBoxGrau.Location = new System.Drawing.Point(91, 28);
            this.textBoxGrau.Name = "textBoxGrau";
            this.textBoxGrau.Size = new System.Drawing.Size(152, 20);
            this.textBoxGrau.TabIndex = 10;
            // 
            // UserAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxGrau);
            this.Controls.Add(this.Grau);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.Sair);
            this.Name = "UserAreaForm";
            this.Text = "UserAreaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Grau;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxGrau;
    }
}