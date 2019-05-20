namespace ClientApplication.AdminArea
{
    partial class AdminAddUcForm
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
            this.b_add_uc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNomeUc = new System.Windows.Forms.TextBox();
            this.textBoxNumeroUc = new System.Windows.Forms.TextBox();
            this.textBoxNumAluno = new System.Windows.Forms.TextBox();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grau";
            // 
            // cb_grau
            // 
            this.cb_grau.FormattingEnabled = true;
            this.cb_grau.Location = new System.Drawing.Point(174, 50);
            this.cb_grau.Name = "cb_grau";
            this.cb_grau.Size = new System.Drawing.Size(204, 21);
            this.cb_grau.TabIndex = 1;
            // 
            // b_voltar
            // 
            this.b_voltar.Location = new System.Drawing.Point(652, 388);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(103, 32);
            this.b_voltar.TabIndex = 3;
            this.b_voltar.Text = "Voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.B_voltar_Click);
            // 
            // b_add_uc
            // 
            this.b_add_uc.Location = new System.Drawing.Point(652, 270);
            this.b_add_uc.Name = "b_add_uc";
            this.b_add_uc.Size = new System.Drawing.Size(103, 32);
            this.b_add_uc.TabIndex = 4;
            this.b_add_uc.Text = "Adicionar";
            this.b_add_uc.UseVisualStyleBackColor = true;
            this.b_add_uc.Click += new System.EventHandler(this.B_add_uc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da Uc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero da Uc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero do Aluno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota Final";
            // 
            // textBoxNomeUc
            // 
            this.textBoxNomeUc.Location = new System.Drawing.Point(174, 161);
            this.textBoxNomeUc.Name = "textBoxNomeUc";
            this.textBoxNomeUc.Size = new System.Drawing.Size(257, 20);
            this.textBoxNomeUc.TabIndex = 10;
            // 
            // textBoxNumeroUc
            // 
            this.textBoxNumeroUc.Location = new System.Drawing.Point(174, 211);
            this.textBoxNumeroUc.Name = "textBoxNumeroUc";
            this.textBoxNumeroUc.Size = new System.Drawing.Size(257, 20);
            this.textBoxNumeroUc.TabIndex = 11;
            // 
            // textBoxNumAluno
            // 
            this.textBoxNumAluno.Location = new System.Drawing.Point(174, 267);
            this.textBoxNumAluno.Name = "textBoxNumAluno";
            this.textBoxNumAluno.Size = new System.Drawing.Size(257, 20);
            this.textBoxNumAluno.TabIndex = 12;
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(174, 315);
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(257, 20);
            this.textBoxNota.TabIndex = 13;
            // 
            // AdminAddUcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNota);
            this.Controls.Add(this.textBoxNumAluno);
            this.Controls.Add(this.textBoxNumeroUc);
            this.Controls.Add(this.textBoxNomeUc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_add_uc);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.cb_grau);
            this.Controls.Add(this.label1);
            this.Name = "AdminAddUcForm";
            this.Text = "AdminAddUcForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_grau;
        private System.Windows.Forms.Button b_voltar;
        private System.Windows.Forms.Button b_add_uc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNomeUc;
        private System.Windows.Forms.TextBox textBoxNumeroUc;
        private System.Windows.Forms.TextBox textBoxNumAluno;
        private System.Windows.Forms.TextBox textBoxNota;
    }
}