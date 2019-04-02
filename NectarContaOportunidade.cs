using System;
using System.Collections.Generic;
using System.Text;

namespace Fenicio.Dados.Data.DAO
{
    public class NectarOportunidadeDAO
    {
        public class Responsavel
        {
            public int id { get; set; }
            public string login { get; set; }
            public string nome { get; set; }
        }

        public class Autor
        {
            public int id { get; set; }
            public string login { get; set; }
            public string nome { get; set; }
        }

        public class AutorAtualizacao
        {
            public int id { get; set; }
            public string login { get; set; }
            public string nome { get; set; }
        }

        public class Cliente
        {
            public string id { get; set; }
            public string codigo { get; set; }
            public string nome { get; set; }
            public string razaoSocial { get; set; }
            public string emailPrincipal { get; set; }
            public string email { get; set; }
        }

        public class Contato
        {
            public int id { get; set; }
            public string nome { get; set; }
        }

        public class FunilVenda
        {
            public int id { get; set; }
            public string nome { get; set; }
            public bool padrao { get; set; }
        }

        public class Origem
        {
            public int id { get; set; }
            public string nome { get; set; }
            public bool ativo { get; set; }
        }

        public class CamposPersonalizados
        {
        }

        public class CamposPersonalizadosObject
        {
        }

        public class RootObject
        {
            public int id { get; set; }
            public Responsavel responsavel { get; set; }
            public Autor autor { get; set; }
            public AutorAtualizacao autorAtualizacao { get; set; }
            public string nome { get; set; }
            public Cliente cliente { get; set; }
            public Contato contato { get; set; }
            public string codigo { get; set; }
            public int status { get; set; }
            public int tarefas { get; set; }
            public int compromissos { get; set; }
            public int atividadesAtrasadas { get; set; }
            //public DateTime dataCriacao { get; set; }
            //public DateTime dataAtualizacao { get; set; }
            //public DateTime dataLimite { get; set; }
            public string pipeline { get; set; }
            public FunilVenda funilVenda { get; set; }
            public int etapa { get; set; }
            public string etapaNome { get; set; }
            public int probabilidade { get; set; }
            public string temperatura { get; set; }
            public double valorAvulso { get; set; }
            public double valorMensal { get; set; }
            public double valorTotal { get; set; }
            public double valorTotalDescontos { get; set; }
            public List<object> produtos { get; set; }
            public Origem origem { get; set; }
            public dynamic camposPersonalizados { get; set; }
            public CamposPersonalizadosObject camposPersonalizadosObject { get; set; }
            public List<object> justificativas { get; set; }
            public List<object> justificativasOpcoes { get; set; }
            public bool vendaBase { get; set; }
        }
    }
}
