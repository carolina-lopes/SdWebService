namespace ClientApplication.AdminArea
{
    partial class AdminVerUcAlunoForm
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
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxUc = new System.Windows.Forms.TextBox();
            this.buttonVerUc = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGrau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(95, 106);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum.TabIndex = 1;
            // 
            // textBoxUc
            // 
            this.textBoxUc.Location = new System.Drawing.Point(48, 155);
            this.textBoxUc.Multiline = true;
            this.textBoxUc.Name = "textBoxUc";
            this.textBoxUc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUc.Size = new System.Drawing.Size(357, 272);
            this.textBoxUc.TabIndex = 3;
            // 
            // buttonVerUc
            // 
            this.buttonVerUc.Location = new System.Drawing.Point(506, 392);
            this.buttonVerUc.Name = "buttonVerUc";
            this.buttonVerUc.Size = new System.Drawing.Size(91, 35);
            this.buttonVerUc.TabIndex = 4;
            this.buttonVerUc.Text = "Ver Uc";
            this.buttonVerUc.UseVisualStyleBackColor = true;
            this.buttonVerUc.Click += new System.EventHandler(this.buttonVerUc_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(679, 392);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 32);
            this.buttonVoltar.TabIndex = 5;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grau";
            // 
            // comboBoxGrau
            // 
            this.comboBoxGrau.FormattingEnabled = true;
            this.comboBoxGrau.Location = new System.Drawing.Point(91, 24);
            this.comboBoxGrau.Name = "comboBoxGrau";
            this.comboBoxGrau.Size = new System.Drawing.Size(299, 21);
            this.comboBoxGrau.TabIndex = 7;
            // 
            // AdminVerUcAlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxGrau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonVerUc);
            this.Controls.Add(this.textBoxUc);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label1);
            this.Name = "AdminVerUcAlunoForm";
            this.Text = "AdminVerUcAlunoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxUc;
        private System.Windows.Forms.Button buttonVerUc;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGrau;
    }
}