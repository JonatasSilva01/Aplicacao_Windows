using System;

namespace WpfLibrary
{
    public class Componentes
    {
        public void Metodos()
        {
            // uso essa function para não duplicar os dados
            // (cboEstados.Items.Clear(); foreach (Estados estados in Estados.Lista()))

            /** Maneira simples de usar dataSourse com Tabelas **/
            //dataGridView.DataSource = TabelaDDP.TabelaDDPs();

            /** Maneira Intermediaria de usar datasorce com tabelas (Link) **/

            /*var data = from estado in Estado.Lista()
                       //where estado.Id == 1
                       //orderby estado.Id
                       select new
                       {
                           Id = estado.Id,
                           Name = estado.Name
                       };
            dataGridView.DataSource = data.ToList();
            */

            /** Maneira mais complexa de usar datasorce com tabelas **/
            /*
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Nome";


            var rows = new List<string[]>();

            foreach(Estado estado in Estado.Lista())
            {
                string[] row1 = new string[] { estado.Id.ToString(), estado.Name };
                rows.Add(row1);
            }
            /*
            foreach (TabelaDDP tabela in TabelaDDP.TabelaDDPs())
            {
                string[] row1 = new string[] { tabela.Id.ToString(), tabela.Nome };
                rows.Add(row1);
            }
            


            foreach (string[] rowArray in rows)
            {
                dataGridView.Rows.Add(rowArray);
            }
             
            
            dataGridView.DataSource = TabelaDDP.TabelaDDPs();
            cboEstados.DataSource = TabelaDDP.TabelaDDPs();
            cboEstados.Text = "[Selecione]";
            */
        }

        private void btnAssincrono()
        {
            // Aqui quando a pessoa digitar e clicar no botao,
            // irá ativar o metodo de abrir uma nova janela,
            // e terá os dados que ela digitou e o estado que
            // selecionou.

            //var form = new FrmShow();
            //form.lblMenssagem.Text = txtResultado.Text + " " + ((Estado)cboEstados.SelectedItem).Id;
            //form.lblMenssagem.Text = txtResultado.Text + " " + ((TabelaDDP)cboEstados.SelectedItem).Id;
            //form.Show();
        }

        // Aqui será o botão de cadastro do Formulario do windows form
        private void btnAbriNovaJanela_Click(object sender, EventArgs e)
        {

        }

        // Posso fazer um programa para salvar informações de um "txt" ou "xls" ou "banco de dados"
        // com o timer do windows
    }
}
