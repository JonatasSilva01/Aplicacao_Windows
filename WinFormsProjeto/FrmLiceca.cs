using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsProjeto
{
    public partial class FrmLiceca : Form
    {
        public bool linkVisited { get; set; }

        public FrmLiceca()
        {
            InitializeComponent();
        }

        private void btnObterLicenca_Click(object sender, EventArgs e)
        {
            LinkExterno();
        }

        private void LinkExterno()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "http://www.google.com/",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Link não encontrado!!" + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Licença Registrada no Banco de Dados.");
        }

        private void txtChave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
