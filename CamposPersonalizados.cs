using System;
using System.Collections.Generic;
using System.Text;

namespace Fenicio.Dados.Data.DAO
{
   public class CamposPersonalizados
    {
        public class CamposPersonalizadosGeral
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string alias { get; set; }
            public int tipo { get; set; }
            public bool obrigatorio { get; set; }
            public string relacionado { get; set; }
            public List<object> opcoes { get; set; }
            public List<object> opcoesPersonalizadas { get; set; }
            //public Secao secao { get; set; }
            public bool mostrarFiltro { get; set; }
            public bool escondido { get; set; }
        }







    }
}
