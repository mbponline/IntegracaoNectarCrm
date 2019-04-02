using System;
using System.Collections.Generic;
using System.Text;

namespace Fenicio.Dados.Data.DAO
{
   public class NectarUsuario
    {
        public class RootObject
        {
            public int id { get; set; }
            public string login { get; set; }
            public int usuarioMasterId { get; set; }
            public string nome { get; set; }
            public string email { get; set; }
            public bool ativo { get; set; }
            public DateTime dataAtualizacao { get; set; }
            public DateTime dataCriacao { get; set; }
        }


    }
}
