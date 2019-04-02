using System;
using System.Collections.Generic;
using System.Text;

namespace Fenicio.Dados.Data.DAO
{
    public class NectarGeral
    {
        public class Id
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Descricao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Ativo
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataCriacao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Autor
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Cor
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Lista
        {
            public Id id { get; set; }
            public Nome nome { get; set; }
            public Descricao descricao { get; set; }
            public Ativo ativo { get; set; }
            public DataCriacao dataCriacao { get; set; }
            public Autor autor { get; set; }
            public Cor cor { get; set; }
        }

        public class Id2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome2
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Sigla
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Pais
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Estado
        {
            public Id2 id { get; set; }
            public Nome2 nome { get; set; }
            public Sigla sigla { get; set; }
            public Pais pais { get; set; }
        }

        public class Id3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataLimite
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataCriacao2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataAtualizacao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Titulo
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Descricao2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Status
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Responsavel
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Cliente
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Oportunidade
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Prioridade
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Tipo
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Checklist
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class TipoLigacao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataInicio
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataFim
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Atendida
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Justificativa
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class QuemAtendeu
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Telefone
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ContatoQuemAtendeu
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Classificacao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ResultadoLigacao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizados
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizadosObject
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ModeloFormulario
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Tarefa
        {
            public Id3 id { get; set; }
            public DataLimite dataLimite { get; set; }
            public DataCriacao2 dataCriacao { get; set; }
            public DataAtualizacao dataAtualizacao { get; set; }
            public Titulo titulo { get; set; }
            public Descricao2 descricao { get; set; }
            public Status status { get; set; }
            public Responsavel responsavel { get; set; }
            public Cliente cliente { get; set; }
            public Oportunidade oportunidade { get; set; }
            public Prioridade prioridade { get; set; }
            public Tipo tipo { get; set; }
            public Checklist checklist { get; set; }
            public TipoLigacao tipoLigacao { get; set; }
            public DataInicio dataInicio { get; set; }
            public DataFim dataFim { get; set; }
            public Atendida atendida { get; set; }
            public Justificativa justificativa { get; set; }
            public QuemAtendeu quemAtendeu { get; set; }
            public Telefone telefone { get; set; }
            public ContatoQuemAtendeu contatoQuemAtendeu { get; set; }
            public Classificacao classificacao { get; set; }
            public ResultadoLigacao resultadoLigacao { get; set; }
            public CamposPersonalizados camposPersonalizados { get; set; }
            public CamposPersonalizadosObject camposPersonalizadosObject { get; set; }
            public ModeloFormulario modeloFormulario { get; set; }
        }

        public class Id4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome3
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Estado2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Latitude
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Longitude
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CodigoUnidadeGeografica
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CodigoMunicipioIbge
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Municipio
        {
            public Id4 id { get; set; }
            public Nome3 nome { get; set; }
            public Estado2 estado { get; set; }
            public Latitude latitude { get; set; }
            public Longitude longitude { get; set; }
            public CodigoUnidadeGeografica codigoUnidadeGeografica { get; set; }
            public CodigoMunicipioIbge codigoMunicipioIbge { get; set; }
        }

        public class Id5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome4
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Municipio2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Bairro
        {
            public Id5 id { get; set; }
            public Nome4 nome { get; set; }
            public Municipio2 municipio { get; set; }
        }

        public class Id6
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome5
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Ativo2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Descricao3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IsCliente
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IsProspect
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IsSuspect
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IsLead
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IsDescarte
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Categoria
        {
            public Id6 id { get; set; }
            public Nome5 nome { get; set; }
            public Ativo2 ativo { get; set; }
            public Descricao3 descricao { get; set; }
            public IsCliente isCliente { get; set; }
            public IsProspect isProspect { get; set; }
            public IsSuspect isSuspect { get; set; }
            public IsLead isLead { get; set; }
            public IsDescarte isDescarte { get; set; }
        }

        public class Id7
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome6
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Descricao4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Ativo3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Origem
        {
            public Id7 id { get; set; }
            public Nome6 nome { get; set; }
            public Descricao4 descricao { get; set; }
            public Ativo3 ativo { get; set; }
        }

        public class Id8
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataCriacao3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Autor2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Descricao5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Comentario
        {
            public Id8 id { get; set; }
            public DataCriacao3 dataCriacao { get; set; }
            public Autor2 autor { get; set; }
            public Descricao5 descricao { get; set; }
        }

        public class Id9
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Responsavel2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Departamento
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Autor3
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class AutorAtualizacao
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class AutorConclusao
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome7
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Cliente2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Contato
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Codigo
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Status2
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Tarefas
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Compromissos
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class AtividadesAtrasadas
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataCriacao4
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataAtualizacao2
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataLimite2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataConclusao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Pipeline
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class FunilVenda
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Etapa
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class EtapaNome
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Observacao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Consideracoes
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IsProrrogada
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Probabilidade
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Temperatura
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ValorAvulso
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ValorMensal
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ValorTotal
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ValorTotalDescontos
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Produtos
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Origem2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizados2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizadosObject2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Justificativas
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class JustificativasOpcoes
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class VendaBase
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Oportunidade2
        {
            public Id9 id { get; set; }
            public Responsavel2 responsavel { get; set; }
            public Departamento departamento { get; set; }
            public Autor3 autor { get; set; }
            public AutorAtualizacao autorAtualizacao { get; set; }
            public AutorConclusao autorConclusao { get; set; }
            public Nome7 nome { get; set; }
            public Cliente2 cliente { get; set; }
            public Contato contato { get; set; }
            public Codigo codigo { get; set; }
            public Status2 status { get; set; }
            public Tarefas tarefas { get; set; }
            public Compromissos compromissos { get; set; }
            public AtividadesAtrasadas atividadesAtrasadas { get; set; }
            public DataCriacao4 dataCriacao { get; set; }
            public DataAtualizacao2 dataAtualizacao { get; set; }
            public DataLimite2 dataLimite { get; set; }
            public DataConclusao dataConclusao { get; set; }
            public Pipeline pipeline { get; set; }
            public FunilVenda funilVenda { get; set; }
            public Etapa etapa { get; set; }
            public EtapaNome etapaNome { get; set; }
            public Observacao observacao { get; set; }
            public Consideracoes consideracoes { get; set; }
            public IsProrrogada isProrrogada { get; set; }
            public Probabilidade probabilidade { get; set; }
            public Temperatura temperatura { get; set; }
            public ValorAvulso valorAvulso { get; set; }
            public ValorMensal valorMensal { get; set; }
            public ValorTotal valorTotal { get; set; }
            public ValorTotalDescontos valorTotalDescontos { get; set; }
            public Produtos produtos { get; set; }
            public Origem2 origem { get; set; }
            public CamposPersonalizados2 camposPersonalizados { get; set; }
            public CamposPersonalizadosObject2 camposPersonalizadosObject { get; set; }
            public Justificativas justificativas { get; set; }
            public JustificativasOpcoes justificativasOpcoes { get; set; }
            public VendaBase vendaBase { get; set; }
        }

        public class Id10
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome8
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Ativo4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Padrao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Tipo2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Sequencias
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Pipeline2
        {
            public Id10 id { get; set; }
            public Nome8 nome { get; set; }
            public Ativo4 ativo { get; set; }
            public Padrao padrao { get; set; }
            public Tipo2 tipo { get; set; }
            public Sequencias sequencias { get; set; }
        }

        public class Id11
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Autor4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class EmailThread
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataCriacao5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataAtualizacao3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataAviso
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class QtdeComentarios
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Importante
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Tarefa2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Compromisso
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Oportunidade3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Qualificacao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Contato2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Assunto
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Descricao6
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Comentarios
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Automatica
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Publicacao
        {
            public Id11 id { get; set; }
            public Autor4 autor { get; set; }
            public EmailThread emailThread { get; set; }
            public DataCriacao5 dataCriacao { get; set; }
            public DataAtualizacao3 dataAtualizacao { get; set; }
            public DataAviso dataAviso { get; set; }
            public QtdeComentarios qtdeComentarios { get; set; }
            public Importante importante { get; set; }
            public Tarefa2 tarefa { get; set; }
            public Compromisso compromisso { get; set; }
            public Oportunidade3 oportunidade { get; set; }
            public Qualificacao qualificacao { get; set; }
            public Contato2 contato { get; set; }
            public Assunto assunto { get; set; }
            public Descricao6 descricao { get; set; }
            public Comentarios comentarios { get; set; }
            public Automatica automatica { get; set; }
        }

        public class Id12
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome9
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Alias
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Tipo3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Obrigatorio
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Relacionado
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Opcoes
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class OpcoesPersonalizadas
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Sequencia
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Secao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class MostrarFiltro
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Escondido
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class RetornarOpcoesPai
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class RetornarOpcoesString
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CampoPersonalizado
        {
            public Id12 id { get; set; }
            public Nome9 nome { get; set; }
            public Alias alias { get; set; }
            public Tipo3 tipo { get; set; }
            public Obrigatorio obrigatorio { get; set; }
            public Relacionado relacionado { get; set; }
            public Opcoes opcoes { get; set; }
            public OpcoesPersonalizadas opcoesPersonalizadas { get; set; }
            public Sequencia sequencia { get; set; }
            public Secao secao { get; set; }
            public MostrarFiltro mostrarFiltro { get; set; }
            public Escondido escondido { get; set; }
            public RetornarOpcoesPai retornarOpcoesPai { get; set; }
            public RetornarOpcoesString retornarOpcoesString { get; set; }
        }

        public class Id13
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome10
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Descricao7
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Ativo5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Segmento
        {
            public Id13 id { get; set; }
            public Nome10 nome { get; set; }
            public Descricao7 descricao { get; set; }
            public Ativo5 ativo { get; set; }
        }

        public class Id14
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome11
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Contador
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Descricao8
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Ativo6
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ValorBase
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Recorrencia
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class PermiteDesconto
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Codigo2
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Moeda
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DescontoMaximo
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IsDescontoPorcentual
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Comissao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IsComissaoPorcentual
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class QuantidadeEstoque
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class PossuiEstoque
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Categoria2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class SubCategoria
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizados3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizadosObject3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Produto
        {
            public Id14 id { get; set; }
            public Nome11 nome { get; set; }
            public Contador contador { get; set; }
            public Descricao8 descricao { get; set; }
            public Ativo6 ativo { get; set; }
            public ValorBase valorBase { get; set; }
            public Recorrencia recorrencia { get; set; }
            public PermiteDesconto permiteDesconto { get; set; }
            public Codigo2 codigo { get; set; }
            public Moeda moeda { get; set; }
            public DescontoMaximo descontoMaximo { get; set; }
            public IsDescontoPorcentual isDescontoPorcentual { get; set; }
            public Comissao comissao { get; set; }
            public IsComissaoPorcentual isComissaoPorcentual { get; set; }
            public QuantidadeEstoque quantidadeEstoque { get; set; }
            public PossuiEstoque possuiEstoque { get; set; }
            public Categoria2 categoria { get; set; }
            public SubCategoria subCategoria { get; set; }
            public CamposPersonalizados3 camposPersonalizados { get; set; }
            public CamposPersonalizadosObject3 camposPersonalizadosObject { get; set; }
        }

        public class Id15
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataCriacao6
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataFeedback
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataAtualizacao4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataInicio2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataFim2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Assunto2
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Feedback
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Descricao9
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Endereco
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Latitude2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Longitude2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DiaInteiro
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Local
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Status3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class AutorAtualizacao2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Autor5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Responsavel3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class AutorFeedback
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class EmailsConvidados
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class NotificarParticipantes
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizados4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizadosObject4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Participantes
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Tipo4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Oportunidade4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Cliente3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Compromisso2
        {
            public Id15 id { get; set; }
            public DataCriacao6 dataCriacao { get; set; }
            public DataFeedback dataFeedback { get; set; }
            public DataAtualizacao4 dataAtualizacao { get; set; }
            public DataInicio2 dataInicio { get; set; }
            public DataFim2 dataFim { get; set; }
            public Assunto2 assunto { get; set; }
            public Feedback feedback { get; set; }
            public Descricao9 descricao { get; set; }
            public Endereco endereco { get; set; }
            public Latitude2 latitude { get; set; }
            public Longitude2 longitude { get; set; }
            public DiaInteiro diaInteiro { get; set; }
            public Local local { get; set; }
            public Status3 status { get; set; }
            public AutorAtualizacao2 autorAtualizacao { get; set; }
            public Autor5 autor { get; set; }
            public Responsavel3 responsavel { get; set; }
            public AutorFeedback autorFeedback { get; set; }
            public EmailsConvidados emailsConvidados { get; set; }
            public NotificarParticipantes notificarParticipantes { get; set; }
            public CamposPersonalizados4 camposPersonalizados { get; set; }
            public CamposPersonalizadosObject4 camposPersonalizadosObject { get; set; }
            public Participantes participantes { get; set; }
            public Tipo4 tipo { get; set; }
            public Oportunidade4 oportunidade { get; set; }
            public Cliente3 cliente { get; set; }
        }

        public class Id16
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome12
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Ativo7
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class OpcaoSelecionada
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Opcoes2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Justificativa2
        {
            public Id16 id { get; set; }
            public Nome12 nome { get; set; }
            public Ativo7 ativo { get; set; }
            public OpcaoSelecionada opcaoSelecionada { get; set; }
            public Opcoes2 opcoes { get; set; }
        }

        public class Id17
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Login
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class UsuarioMasterId
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class FilialId
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome13
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Email
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Foto
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Ativo8
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataAtualizacao5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataCriacao7
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Usuario
        {
            public Id17 id { get; set; }
            public Login login { get; set; }
            public UsuarioMasterId usuarioMasterId { get; set; }
            public FilialId filialId { get; set; }
            public Nome13 nome { get; set; }
            public Email email { get; set; }
            public Foto foto { get; set; }
            public Ativo8 ativo { get; set; }
            public DataAtualizacao5 dataAtualizacao { get; set; }
            public DataCriacao7 dataCriacao { get; set; }
        }

        public class Id18
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Autor6
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class AutorAtualizacao3
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Responsavel4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Departamento2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Codigo3
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Nome14
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class RazaoSocial
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Cnpj
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Rg
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Cpf
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Foto2
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataCriacao8
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataAtualizacao6
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataFundacao
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class DataNascimento
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class InscricaoEstadual
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class InscricaoMunicipal
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Observacao2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Cargo
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IndicadoPor
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Site
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Facebook
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Linkedin
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Twitter
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Skype
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Origem3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Segmento2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Categoria3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Lista2
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class RegiaoPais
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class RegiaoEstado
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class RegiaoMunicipio
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class QuantidadeFuncionarios
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ReceitaAnual
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Ativo9
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Empresa
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class EmpresaAtual
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ContaPai
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Constante
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Tarefas2
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Compromissos2
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Oportunidades
        {
            public bool @readonly { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Telefones
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class TelefonePrincipal
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Telefone2
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Emails
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class EmailPrincipal
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Email2
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Contatos
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Enderecos
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizados5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class CamposPersonalizadosObject5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Listas
        {
            public string name { get; set; }
            public int length { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class IntegradoRD
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Blocked
        {
            public string name { get; set; }
            public string description { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Contato3
        {
            public Id18 id { get; set; }
            public Autor6 autor { get; set; }
            public AutorAtualizacao3 autorAtualizacao { get; set; }
            public Responsavel4 responsavel { get; set; }
            public Departamento2 departamento { get; set; }
            public Codigo3 codigo { get; set; }
            public Nome14 nome { get; set; }
            public RazaoSocial razaoSocial { get; set; }
            public Cnpj cnpj { get; set; }
            public Rg rg { get; set; }
            public Cpf cpf { get; set; }
            public Foto2 foto { get; set; }
            public DataCriacao8 dataCriacao { get; set; }
            public DataAtualizacao6 dataAtualizacao { get; set; }
            public DataFundacao dataFundacao { get; set; }
            public DataNascimento dataNascimento { get; set; }
            public InscricaoEstadual inscricaoEstadual { get; set; }
            public InscricaoMunicipal inscricaoMunicipal { get; set; }
            public Observacao2 observacao { get; set; }
            public Cargo cargo { get; set; }
            public IndicadoPor indicadoPor { get; set; }
            public Site site { get; set; }
            public Facebook facebook { get; set; }
            public Linkedin linkedin { get; set; }
            public Twitter twitter { get; set; }
            public Skype skype { get; set; }
            public Origem3 origem { get; set; }
            public Segmento2 segmento { get; set; }
            public Categoria3 categoria { get; set; }
            public Lista2 lista { get; set; }
            public RegiaoPais regiaoPais { get; set; }
            public RegiaoEstado regiaoEstado { get; set; }
            public RegiaoMunicipio regiaoMunicipio { get; set; }
            public QuantidadeFuncionarios quantidadeFuncionarios { get; set; }
            public ReceitaAnual receitaAnual { get; set; }
            public Ativo9 ativo { get; set; }
            public Empresa empresa { get; set; }
            public EmpresaAtual empresaAtual { get; set; }
            public ContaPai contaPai { get; set; }
            public Constante constante { get; set; }
            public Tarefas2 tarefas { get; set; }
            public Compromissos2 compromissos { get; set; }
            public Oportunidades oportunidades { get; set; }
            public Telefones telefones { get; set; }
            public TelefonePrincipal telefonePrincipal { get; set; }
            public Telefone2 telefone { get; set; }
            public Emails emails { get; set; }
            public EmailPrincipal emailPrincipal { get; set; }
            public Email2 email { get; set; }
            public Contatos contatos { get; set; }
            public Enderecos enderecos { get; set; }
            public CamposPersonalizados5 camposPersonalizados { get; set; }
            public CamposPersonalizadosObject5 camposPersonalizadosObject { get; set; }
            public Listas listas { get; set; }
            public IntegradoRD integradoRD { get; set; }
            public Blocked blocked { get; set; }
        }

        public class RootObject
        {
            public List<Lista> lista { get; set; }
            public List<Estado> estado { get; set; }
            public List<Tarefa> tarefa { get; set; }
            public List<Municipio> municipio { get; set; }
            public List<Bairro> bairro { get; set; }
            public List<Categoria> categoria { get; set; }
            public List<Origem> origem { get; set; }
            public List<Comentario> comentario { get; set; }
            public List<Oportunidade2> oportunidade { get; set; }
            public List<Pipeline2> pipeline { get; set; }
            public List<Publicacao> publicacao { get; set; }
            public List<CampoPersonalizado> campoPersonalizado { get; set; }
            public List<Segmento> segmento { get; set; }
            public List<Produto> produto { get; set; }
            public List<Compromisso2> compromisso { get; set; }
            public List<Justificativa2> justificativa { get; set; }
            public List<Usuario> usuario { get; set; }
            public List<Contato3> contato { get; set; }
        }

    }
}
