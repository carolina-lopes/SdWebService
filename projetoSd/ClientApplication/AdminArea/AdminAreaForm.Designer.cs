namespace ClientApplication.AdminArea
{
    partial class AdminAreaForm
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
            this.sair = new System.Windows.Forms.Button();
            this.addUc = new System.Windows.Forms.Button();
            this.addAluno = new System.Windows.Forms.Button();
            this.verUc = new System.Windows.Forms.Button();
            this.verAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVerUcALuno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(640, 363);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(113, 40);
            this.sair.TabIndex = 3;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // addUc
            // 
            this.addUc.Location = new System.Drawing.Point(60, 125);
            this.addUc.Name = "addUc";
            this.addUc.Size = new System.Drawing.Size(113, 40);
            this.addUc.TabIndex = 4;
            this.addUc.Text = "Adicionar UC\'s";
            this.addUc.UseVisualStyleBackColor = true;
            this.addUc.Click += new System.EventHandler(this.Uc_Click);
            // 
            // addAluno
            // 
            this.addAluno.Location = new System.Drawing.Point(60, 311);
            this.addAluno.Name = "addAluno";
            this.addAluno.Size = new System.Drawing.Size(113, 42);
            this.addAluno.TabIndex = 5;
            this.addAluno.Text = "Adiconar Aluno(s)";
            this.addAluno.UseVisualStyleBackColor = true;
            this.addAluno.Click += new System.EventHandler(this.AddAluno_Click);
            // 
            // verUc
            // 
            this.verUc.Location = new System.Drawing.Point(60, 185);
            this.verUc.Name = "verUc";
            this.verUc.Size = new System.Drawing.Size(113, 40);
            this.verUc.TabIndex = 6;
            this.verUc.Text = "Ver UC\'s";
            this.verUc.UseVisualStyleBackColor = true;
            this.verUc.Click += new System.EventHandler(this.VerUc_Click);
            // 
            // verAluno
            // 
            this.verAluno.Location = new System.Drawing.Point(60, 374);
            this.verAluno.Name = "verAluno";
            this.verAluno.Size = new System.Drawing.Size(113, 40);
            this.verAluno.TabIndex = 7;
            this.verAluno.Text = "Ver Aluno(s)";
            this.verAluno.UseVisualStyleBackColor = true;
            this.verAluno.Click += new System.EventHandler(this.VerAluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin Area";
            // 
            // buttonVerUcALuno
            // 
            this.buttonVerUcALuno.Location = new System.Drawing.Point(60, 248);
            this.buttonVerUcALuno.Name = "buttonVerUcALuno";
            this.buttonVerUcALuno.Size = new System.Drawing.Size(113, 40);
            this.buttonVerUcALuno.TabIndex = 9;
            this.buttonVerUcALuno.Text = "Ver Uc\'s Aluno";
            this.buttonVerUcALuno.UseVisualStyleBackColor = true;
            this.buttonVerUcALuno.Click += new System.EventHandler(this.buttonVerUcALuno_Click);
            // 
            // AdminAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVerUcALuno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verAluno);
            this.Controls.Add(this.verUc);
            this.Controls.Add(this.addAluno);
            this.Controls.Add(this.addUc);
            this.Controls.Add(this.sair);
            this.Name = "AdminAreaForm";
            this.Text = "AdminAreaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button addUc;
        private System.Windows.Forms.Button addAluno;
        private System.Windows.Forms.Button verUc;
        private System.Windows.Forms.Button verAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVerUcALuno;
    }
}