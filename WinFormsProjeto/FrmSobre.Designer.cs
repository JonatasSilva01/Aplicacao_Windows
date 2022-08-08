namespace WinFormsProjeto
{
    partial class FrmSobre
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
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblSobre2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSobre.Location = new System.Drawing.Point(86, 40);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(617, 25);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = "Olá Mundo, Eu sou Jonatas o desenvolvedor que fez esse programa simples";
            // 
            // lblSobre2
            // 
            this.lblSobre2.AutoSize = true;
            this.lblSobre2.Location = new System.Drawing.Point(306, 407);
            this.lblSobre2.Name = "lblSobre2";
            this.lblSobre2.Size = new System.Drawing.Size(189, 15);
            this.lblSobre2.TabIndex = 1;
            this.lblSobre2.Text = "Linguagens:  C# e Windows Forms";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(86, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(617, 300);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "As principais funcionalidades desse programa é criação dos Dados, consultar table" +
    "as, criar janelas com criação de arquivos txt e muito mais...";
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSobre2);
            this.Controls.Add(this.lblSobre);
            this.Name = "FrmSobre";
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblSobre2;
        private System.Windows.Forms.TextBox textBox1;
    }
}