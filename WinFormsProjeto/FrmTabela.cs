using DataGridViewFormulario;
using FormEstado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsProjeto
{
    public partial class FrmTabela : Form
    {
        public FrmTabela()
        {
            InitializeComponent();
        }

        private void FrmTabela_Load(object sender, EventArgs e)
        {
            try
            {
                VerTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Janela não encontrada!" + ex.Message);
            }
        }

        private void VerTabela()
        {
            //var data = from estado in Estado.Lista()
            var data = from p in TabelaDDP.TabelaDDPs()
                           //where estado.Id == 1
                           //orderby estado.Id
                       select new
                       {
                           Id = p.Id,
                           Name = p.Nome,
                           Telefone = p.Telefone,
                           CPF = p.CPF,
                       };
            dataGridView.DataSource = data.ToList();
        }
    }
}
