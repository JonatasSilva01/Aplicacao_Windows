using System;
using System.Collections.Generic;
using System.Text;

namespace DataGridViewFormulario
{
    // DDP = Dados de Pessoas
    public class TabelaDDP
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Telefone { get; private set; }


        public override string ToString()
        {
            return this.Nome;
        }

        public static List<TabelaDDP> TabelaDDPs()
        {
            var tabela = new List<TabelaDDP>();

            var P = new TabelaDDP();
            P.Id = 1;
            P.CPF = "12334567";
            P.Nome = "JONATAS SILVA DOS SANTOS";
            P.Telefone = "5622-7332";
            tabela.Add(P);

            P = new TabelaDDP();
            P.Id = 2;
            P.CPF = "123453466";
            P.Nome = "HENRIQUE ALMEIDA SILVA";
            P.Telefone = "5673-5521";
            tabela.Add(P);

            return tabela;
        }
    }
}
