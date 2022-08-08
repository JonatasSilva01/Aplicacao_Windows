using System;
using FormEstado;
using DataGridViewFormulario;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HoraAtual();

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Abrir Texto", Image.FromFile(@"C:\Icons-Land-Vista-People-Office-Client-Male-Light.ico"),
                novoTextoToolStripMenuItem_Click);
            contextMenu.Items.Add("Cadastro", Image.FromFile(@"C:\Icons-Land-Vista-People-Office-Client-Male-Light.ico"),
                cadastroToolStripMenuItem_Click);
            contextMenu.Items.Add("Sair", Image.FromFile(@"C:\Icons-Land-Vista-People-Office-Client-Male-Light.ico"),
                sairToolStripMenuItem_Click);
            notifyIcon.ContextMenuStrip = contextMenu;

        }
        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newText = new FrmTexto();
            newText.MdiParent = MDISigleton.criarInstaciaMdiParent();
            newText.Show();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sobre = new FrmSobre();
            sobre.MdiParent = MDISigleton.criarInstaciaMdiParent();
            sobre.Show();
        }
        private void doacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var doacao = new FrmDoacao();
            doacao.MdiParent = MDISigleton.criarInstaciaMdiParent();
            doacao.Show();
        }
        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var licenca = new FrmLiceca();
            licenca.MdiParent = MDISigleton.criarInstaciaMdiParent();
            licenca.Show();
        }
        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabela = new FrmTabela();
            tabela.MdiParent = MDISigleton.criarInstaciaMdiParent();
            tabela.Show();
        }
        private void HoraAtual()
        {
            lblHoraAtual.Text =
                "Dia e hora atural: " +
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            // milesegundos em: 1000
            // enable = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraAtual();// mostra as horas em tempo real 
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastro = new FrmCadastro();
            cadastro.MdiParent = MDISigleton.criarInstaciaMdiParent();
            cadastro.Show();
        }
        
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Clicou");
        }

        private void btnNotificacao_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(10, "Alerta", "Hora de Codar", ToolTipIcon.Warning);
        }
    }
}
