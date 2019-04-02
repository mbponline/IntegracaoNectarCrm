using System;
using System.Collections.Generic;
using System.Text;

namespace Fenicio.Dados.Data.DAO
{
    public class NectarFunilDAO
    {

        public class Sequencia
        {
            public int id { get; set; }
            public string nome { get; set; }
            public int sequencia { get; set; }
            public bool gerarProposta { get; set; }
        }

        public class Funil
        {
            public int id { get; set; }
            public string nome { get; set; }
            public bool ativo { get; set; }
            public bool padrao { get; set; }
            public int tipo { get; set; }
            public List<Sequencia> sequencias { get; set; }
        }




    }
}
