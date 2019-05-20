namespace ClientApplication.AdminArea
{
    partial class AdminVerUcForm
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
            this.textBoxUc = new System.Windows.Forms.TextBox();
            this.b_voltar = new System.Windows.Forms.Button();
            this.buttonVerUc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grau";
            // 
            // cb_grau
            // 
            this.cb_grau.FormattingEnabled = true;
            this.cb_grau.Location = new System.Drawing.Point(109, 51);
            this.cb_grau.Name = "cb_grau";
            this.cb_grau.Size = new System.Drawing.Size(295, 21);
            this.cb_grau.TabIndex = 1;
            // 
            // textBoxUc
            // 
            this.textBoxUc.Location = new System.Drawing.Point(47, 143);
            this.textBoxUc.Multiline = true;
            this.textBoxUc.Name = "textBoxUc";
            this.textBoxUc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUc.Size = new System.Drawing.Size(357, 272);
            this.textBoxUc.TabIndex = 2;
            // 
            // b_voltar
            // 
            this.b_voltar.Location = new System.Drawing.Point(660, 380);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(94, 34);
            this.b_voltar.TabIndex = 3;
            this.b_voltar.Text = "Voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.B_voltar_Click);
            // 
            // buttonVerUc
            // 
            this.buttonVerUc.Location = new System.Drawing.Point(530, 381);
            this.buttonVerUc.Name = "buttonVerUc";
            this.buttonVerUc.Size = new System.Drawing.Size(94, 34);
            this.buttonVerUc.TabIndex = 4;
            this.buttonVerUc.Text = "Ver Uc";
            this.buttonVerUc.UseVisualStyleBackColor = true;
            this.buttonVerUc.Click += new System.EventHandler(this.buttonVerUc_Click);
            // 
            // AdminVerUcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVerUc);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.textBoxUc);
            this.Controls.Add(this.cb_grau);
            this.Controls.Add(this.label1);
            this.Name = "AdminVerUcForm";
            this.Text = "AdminVerUcForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_grau;
        private System.Windows.Forms.TextBox textBoxUc;
        private System.Windows.Forms.Button b_voltar;
        private System.Windows.Forms.Button buttonVerUc;
    }
}