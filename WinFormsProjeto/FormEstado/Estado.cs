using System;
using System.Collections.Generic;
using System.Text;

namespace FormEstado
{
    public class Estado
    {
        public int Id { get; private set; }
        public string Name { get; private set; }


        // aprendi que sobrescrevendo o item consigo trabalhar com os ids
        // aprendi que sobrescrevendo eu posso manipular o objeto sem trazer
        // a referencia de sua classe
        public override string ToString() 
        {
            return this.Name;
        }


        // coleção em lista utilizada para agrupar um monte
        // de informações para um só lugar.
        public static List<Estado> Lista()
        {
            var lista = new List<Estado>();

            var e1 = new Estado();
            e1.Id = 1;
            e1.Name = "SP";
            lista.Add(e1);

            e1 = new Estado();
            e1.Id = 2;
            e1.Name = "MG";
            lista.Add(e1);

            e1 = new Estado();
            e1.Id = 3;
            e1.Name = "GO";
            lista.Add(e1);

            e1 = new Estado();
            e1.Id = 4;
            e1.Name = "AM";
            lista.Add(e1);

            return lista;
        }
    }
}
