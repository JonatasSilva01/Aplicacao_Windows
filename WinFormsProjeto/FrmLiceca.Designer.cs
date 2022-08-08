namespace WinFormsProjeto
{
    partial class FrmLiceca
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
            this.btnObterLicenca = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObterLicenca
            // 
            this.btnObterLicenca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnObterLicenca.Location = new System.Drawing.Point(87, 174);
            this.btnObterLicenca.Name = "btnObterLicenca";
            this.btnObterLicenca.Size = new System.Drawing.Size(164, 46);
            this.btnObterLicenca.TabIndex = 0;
            this.btnObterLicenca.Text = "Obter Licença";
            this.btnObterLicenca.UseVisualStyleBackColor = true;
            this.btnObterLicenca.Click += new System.EventHandler(this.btnObterLicenca_Click);
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(87, 226);
            this.txtChave.Name = "txtChave";
            this.txtChave.PlaceholderText = "coloque a chave de acesso de sua licença";
            this.txtChave.Size = new System.Drawing.Size(489, 23);
            this.txtChave.TabIndex = 1;
            this.txtChave.TextChanged += new System.EventHandler(this.txtChave_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(601, 226);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmLiceca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btnObterLicenca);
            this.Name = "FrmLiceca";
            this.Text = "Licença";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObterLicenca;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Button btnRegistrar;
    }
}