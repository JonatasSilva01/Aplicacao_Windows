using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsProjeto
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var Name = txtName.Text;
            try
            {
                int Telefone = int.Parse(txtTelefone.Text);
                MessageBox.Show($"Nome: {Name} e Telefone: {Telefone}");
            }
            catch(FormatException err)
            {
                MessageBox.Show("Voce Digitou letra em vez de Numeros!" + err.Message);
                txtTelefone.Focus();
            }
            catch(Exception err)
            {
                MessageBox.Show("erro ao cadastrar!"+ err.Message);
            }
        }
    }
}
