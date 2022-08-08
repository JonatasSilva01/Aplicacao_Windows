namespace WinFormsProjeto
{
    partial class FrmDoacao
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
            this.btn_doarPayPal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_doarPayPal
            // 
            this.btn_doarPayPal.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_doarPayPal.Location = new System.Drawing.Point(309, 153);
            this.btn_doarPayPal.Name = "btn_doarPayPal";
            this.btn_doarPayPal.Size = new System.Drawing.Size(147, 88);
            this.btn_doarPayPal.TabIndex = 0;
            this.btn_doarPayPal.Text = "PayPal";
            this.btn_doarPayPal.UseVisualStyleBackColor = true;
            this.btn_doarPayPal.Click += new System.EventHandler(this.btn_doarPayPal_Click);
            // 
            // FrmDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_doarPayPal);
            this.Name = "FrmDoacao";
            this.Text = "Doacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_doarPayPal;
    }
}