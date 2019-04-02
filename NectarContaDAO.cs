using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fenicio.Dados.Data.DAO
{
   public class NectarContaDAO
    {
        public class Autor
        {
            public string id { get; set; }
            public string login { get; set; }
            public string nome { get; set; }
        }

        public class AutorAtualizacao
        {
            public string id { get; set; }
            public string login { get; set; }
            public string nome { get; set; }
        }

        public class Responsavel
        {
            public string id { get; set; }
            public string login { get; set; }
            public string nome { get; set; }
        }

        public class RegiaoPais
        {
            public string id { get; set; }
            public string nome { get; set; }
        }

        public class Pais
        {
            public string id { get; set; }
            public string nome { get; set; }
        }

        public class RegiaoEstado
        {
            public string id { get; set; }
            public string nome { get; set; }
            public string sigla { get; set; }
            public Pais pais { get; set; }
        }

        public class Pais2
        {
            public string id { get; set; }
            public string nome { get; set; }
        }

        public class Estado
        {
            public string id { get; set; }
            public string nome { get; set; }
            public string sigla { get; set; }
            public Pais2 pais { get; set; }
        }

        public class RegiaoMunicipio
        {
            public string id { get; set; }
            public string nome { get; set; }
            public Estado estado { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public int codigoUnidadeGeografica { get; set; }
            public int codigoMunicipioIbge { get; set; }
            public bool isCapital { get; set; }
        }

        public class Pais3
        {
            public string id { get; set; }
            public string nome { get; set; }
        }

        public class EstadoObject
        {
            public string id { get; set; }
            public string nome { get; set; }
            public string sigla { get; set; }
            public Pais3 pais { get; set; }
        }

        public class PaisObject
        {
            public string id { get; set; }
            public string nome { get; set; }
        }

        public class Pais4
        {
            public string id { get; set; }
            public string nome { get; set; }
        }

        public class Estado2
        {
            public string id { get; set; }
            public string nome { get; set; }
            public string sigla { get; set; }
            public Pais4 pais { get; set; }
        }

        public class MunicipioObject
        {
            public string id { get; set; }
            public string nome { get; set; }
            public Estado2 estado { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public int codigoUnidadeGeografica { get; set; }
            public int codigoMunicipioIbge { get; set; }
            public bool isCapital { get; set; }
        }

        public class Endereco
        {
            public string id { get; set; }
            public string cep { get; set; }
            public string complemento { get; set; }
            public string tipo { get; set; }
            public string numero { get; set; }
            public bool principal { get; set; }
            public string estado { get; set; }
            public EstadoObject estadoObject { get; set; }
            public string pais { get; set; }
            public PaisObject paisObject { get; set; }
            public string bairro { get; set; }
            public string municipio { get; set; }
            public MunicipioObject municipioObject { get; set; }
            public int codigoMunicipioIbge { get; set; }
            public string logradouro { get; set; }
            public string endereco { get; set; }

            public Endereco() {
                this.estadoObject = new EstadoObject();
                this.paisObject = new PaisObject();
                this.municipioObject = new MunicipioObject();

            }

        }

        //public class CamposPersonalizados
        //{
           
        //}

        //public class CamposPersonalizadosObject
        //{
        //}

        public class RootObject
        {
            public string id { get; set; }
            public Autor autor { get; set; }
            public AutorAtualizacao autorAtualizacao { get; set; }
            public Responsavel responsavel { get; set; }
            public string codigo { get; set; }
            public string nome { get; set; }
            public string razaoSocial { get; set; }
            //public DateTime dataCriacao { get; set; }
            //public DateTime dataAtualizacao { get; set; }
            public string observacao { get; set; }
            public string site { get; set; }
            public string facebook { get; set; }
            public string linkedin { get; set; }
            public string twitter { get; set; }
            public string skype { get; set; }
            public string origem { get; set; }
            public string cnpj { get; set; }
            public string segmento { get; set; }
            public string categoria { get; set; }
            public string cpf { get; set; }
            public RegiaoPais regiaoPais { get; set; }
            public RegiaoEstado regiaoEstado { get; set; }
            public RegiaoMunicipio regiaoMunicipio { get; set; }
            public int quantidadeFuncionarios { get; set; }
            public double receitaAnual { get; set; }
            public bool ativo { get; set; }
            public bool empresa { get; set; }
            public int constante { get; set; }
            public int tarefas { get; set; }
            public int compromissos { get; set; }
            public int oportunidades { get; set; }
            public List<string> telefones { get; set; }
            public string telefonePrincipal { get; set; }
            public string telefone { get; set; }
            public List<string> emails { get; set; }
            public string emailPrincipal { get; set; }
            public string email { get; set; }
            public List<contato> contatos { get; set; }
            //public string endereco { get; set; }
            public List<Endereco> enderecos { get; set; }
            public dynamic camposPersonalizados { get; set; }
            //public string[] camposPersonalizadosObject { get; set; }
            public List<Listas> listas { get; set; }
            public bool integradoRD { get; set; }
            public bool isEmpresa { get; set; }

            public RootObject() {
                //telefones = new List<string>();
                //contatos = new List<contato>();
                //enderecos = new List<Endereco>();
                //emails = new List<string>();


            }

            public class contato {
                public string nome { get; set; }
                public string cargo { get; set; }
                public List<string> emails { get; set; }
                public List<string> telefones { get; set; }
                public Responsavel responsavel { get; set; }

            }


            public class Listas {
              public  string nome { get; set; }
              public  bool ativo { get; set; }

            }
            //Campos em comum com a conta: 
            //Nome,
            //Endereços,
            //codigo,
            //Emails,
            //Contatos,
            //Campospersonalizados,
            //Telefone Principal = Telefone1,
            


        }




    }
}
