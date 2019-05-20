namespace ClientApplication.AdminArea
{
    partial class AdminAddAlunosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_grau = new System.Windows.Forms.ComboBox();
            this.b_voltar = new System.Windows.Forms.Button();
            this.b_add_alunos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grau";
            // 
            // cb_grau
            // 
            this.cb_grau.FormattingEnabled = true;
            this.cb_grau.Location = new System.Drawing.Point(171, 30);
            this.cb_grau.Name = "cb_grau";
            this.cb_grau.Size = new System.Drawing.Size(155, 21);
            this.cb_grau.TabIndex = 1;
            // 
            // b_voltar
            // 
            this.b_voltar.Location = new System.Drawing.Point(646, 382);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(102, 31);
            this.b_voltar.TabIndex = 5;
            this.b_voltar.Text = "Voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.B_voltar_Click);
            // 
            // b_add_alunos
            // 
            this.b_add_alunos.Location = new System.Drawing.Point(646, 298);
            this.b_add_alunos.Name = "b_add_alunos";
            this.b_add_alunos.Size = new System.Drawing.Size(102, 31);
            this.b_add_alunos.TabIndex = 6;
            this.b_add_alunos.Text = "Adicionar";
            this.b_add_alunos.UseVisualStyleBackColor = true;
            this.b_add_alunos.Click += new System.EventHandler(this.B_add_alunos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(171, 173);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(155, 20);
            this.textBoxNum.TabIndex = 9;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(171, 252);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(263, 20);
            this.textBoxNome.TabIndex = 10;
            // 
            // AdminAddAlunosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_add_alunos);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.cb_grau);
            this.Controls.Add(this.label1);
            this.Name = "AdminAddAlunosForm";
            this.Text = "AdminAddAlunosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_grau;
        private System.Windows.Forms.Button b_voltar;
        private System.Windows.Forms.Button b_add_alunos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}