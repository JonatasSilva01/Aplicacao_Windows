using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsProjeto
{
    public partial class FrmImportador : Form
    {
        private string[] lines;

        public FrmImportador()
        {
            InitializeComponent();
        }

        private void FrmImportador_Load(object sender, EventArgs e)
        {
            string fileName = @"C:\db\APLICATION_Win\Nomes.txt";
            using (var streamReader = File.OpenText(fileName))
            {
                lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                progressBar.Maximum = lines.Length;
                progressBar.Minimum = 0;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            for(var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                progressBar.Value = (i + 1);

                //txtLogs.Text = line + " - " + i + " - Importado!";
                //txtLogs.Update(); Tras perca de performace.

                /*
                 * Simulado como pegaria dados no Banco de dados.
                  var user = new Usuario();
                  user.nome = line;
                  user.Save();
                 */
            }
            //txtLogs.Text = string.Join("\n", lines); --> saida de todos os dados do arquivo que
            // é menos performatico.
            txtLogs.Text = "Todos os Dados importados!";// Mais performatico e simples
        }
    }
}
