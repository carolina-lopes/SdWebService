namespace ClientApplication.AdminArea
{
    partial class AdminVerAlunosForm
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
            this.comboBoxGrau = new System.Windows.Forms.ComboBox();
            this.textBoxAlunos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VerAlunos = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxGrau
            // 
            this.comboBoxGrau.FormattingEnabled = true;
            this.comboBoxGrau.Location = new System.Drawing.Point(133, 74);
            this.comboBoxGrau.Name = "comboBoxGrau";
            this.comboBoxGrau.Size = new System.Drawing.Size(217, 21);
            this.comboBoxGrau.TabIndex = 0;
            // 
            // textBoxAlunos
            // 
            this.textBoxAlunos.Location = new System.Drawing.Point(63, 145);
            this.textBoxAlunos.Multiline = true;
            this.textBoxAlunos.Name = "textBoxAlunos";
            this.textBoxAlunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlunos.Size = new System.Drawing.Size(359, 272);
            this.textBoxAlunos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grau";
            // 
            // VerAlunos
            // 
            this.VerAlunos.Location = new System.Drawing.Point(509, 407);
            this.VerAlunos.Name = "VerAlunos";
            this.VerAlunos.Size = new System.Drawing.Size(75, 31);
            this.VerAlunos.TabIndex = 5;
            this.VerAlunos.Text = "Ver Alunos";
            this.VerAlunos.UseVisualStyleBackColor = true;
            this.VerAlunos.Click += new System.EventHandler(this.VerAlunos_Click_1);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(643, 407);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 31);
            this.Voltar.TabIndex = 6;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click_1);
            // 
            // AdminVerAlunosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.VerAlunos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAlunos);
            this.Controls.Add(this.comboBoxGrau);
            this.Name = "AdminVerAlunosForm";
            this.Text = "AdminVerAlunosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGrau;
        private System.Windows.Forms.TextBox textBoxAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VerAlunos;
        private System.Windows.Forms.Button Voltar;
    }
}