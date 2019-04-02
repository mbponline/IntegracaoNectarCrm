using System;
using System.Collections.Generic;
using System.Text;

namespace Fenicio.Dados.Data.DAO.FeedBack
{

    public class Autor
    {
        public int id { get; set; }
        public string login { get; set; }
        public string nome { get; set; }
    }

    public class Cliente
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
    }

    public class FunilVenda
    {
    }

    public class Origem
    {
    }

    public class Oportunidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Cliente cliente { get; set; }
        public FunilVenda funilVenda { get; set; }
        public string temperatura { get; set; }
        public double valorTotalDescontos { get; set; }
        public Origem origem { get; set; }
    }

    public class Contato
    {
        public int id { get; set; }
        public string nome { get; set; }
    }

    public class RootObject
    {
        public int id { get; set; }
        //public Autor autor { get; set; }
        //public DateTime dataCriacao { get; set; }
        //public DateTime dataAtualizacao { get; set; }
        //public int qtdeComentarios { get; set; }
        public Oportunidade oportunidade { get; set; }
        //public Contato contato { get; set; }
        public string descricao { get; set; }
        //public bool automatica { get; set; }
        public string assunto { get; set; }
    }
}
