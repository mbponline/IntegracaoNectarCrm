using Microsoft.AspNetCore.Mvc;
using Fenicio.Dados.Data;
using Fenicio.Services;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Options;
using Fenicio.Dados.Repositories;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Fenicio.ViewModels.Meta;
using System.Net.Http;
using Newtonsoft.Json;
using System.Dynamic;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace Fenicio.Controllers.Api.Nectar
{
    [Route("api/Nectar")]
    public class NectarController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private IOptions<AuthMessageSenderOptionsDAO> _appSettings;
        private readonly IDataProtectionProvider _dataProtectionProvider;
        //private EfRepository<Dados.Models.NectarConfiguracoes> nectarEfRepositorio;
        //private EfRepository<Dados.Models.DeParaFenicioNectar> deParaNectarRepositorio;
        private EfRepository<Dados.Models.IntegracoesConfiguracao> integracoesConfiguracao;
        private EfRepository<Dados.Models.ControleChaveValor> ControleChaveValor;
        private EfRepository<Dados.Models.Oportunidade> oportunidadeRep;
        private EfRepository<Dados.Models.LogCRM> LogsIntegracao;
        public NectarController(ApplicationDbContext context,
            IDataProtectionProvider dataProtectionProvider,
            IOptions<AuthMessageSenderOptionsDAO> optionsAccessor,
            IEmailSender emailSender) : base(dataProtectionProvider)
        {
            _context = context;
            _dataProtectionProvider = dataProtectionProvider;
            _appSettings = optionsAccessor;




        }



        [HttpGet("VerificarUsoNectar")]
        public async Task<JsonResult> VerificarUsoNectar(Guid? oportunidadeId)
        {
            oportunidadeRep = new EfRepository<Dados.Models.Oportunidade>(_context);
            var oportunidade = await oportunidadeRep.Where(x => x.Id == oportunidadeId).FirstOrDefaultAsync();
            integracoesConfiguracao = new EfRepository<Dados.Models.IntegracoesConfiguracao>(_context);
            var integracoesConfig = await integracoesConfiguracao.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId && x.EmpresaId == UsuarioLogado.EstabelecimentoId).FirstOrDefaultAsync();
            if (integracoesConfig != null)
            {
                var NectarConfigs = JsonConvert.DeserializeObject<Negocio.IntegracoesConfiguracaoNectar>(integracoesConfig.Configuracao);
                if (NectarConfigs.faseId.ToUpper() == oportunidade.FaseAtualId.ToString().ToUpper())
                {
                    var usuariosNectar = await userNectar();

                    return Json(new { sucesso = true , usuariosNectar });


                }

            }
            else {
                return Json(new { sucesso = false });
            }



            return Json(new { sucesso = false });
        }




        [HttpPost("AdicionarContaOportunidadeNectar")]
        public async Task<JsonResult> EndPoint_AdicionarContaNectar(string vendedorNectarId, Guid oportunidadeId)
        {
            try
            {
                ControleChaveValor = new EfRepository<Dados.Models.ControleChaveValor>(_context);
                //TODO: MULTIEMPRESA
                if (string.IsNullOrEmpty(vendedorNectarId)) {
                    vendedorNectarId = string.Empty;
                }
                integracoesConfiguracao = new EfRepository<Dados.Models.IntegracoesConfiguracao>(_context);
                oportunidadeRep = new EfRepository<Dados.Models.Oportunidade>(_context);

               var integracoesConfig = integracoesConfiguracao.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId && x.EmpresaId == UsuarioLogado.EstabelecimentoId).FirstOrDefault();
                Dados.Models.Oportunidade oportunidade =
                        oportunidadeRep.Where(x => x.Id == oportunidadeId)
                       .Include(c => c.Conta)
                       .Include($"{nameof(Dados.Models.Conta)}.{nameof(Dados.Models.Conta.ContatosContas)}.{nameof(Dados.Models.ContatoConta.Contato)}")
                       .Include($"{nameof(Dados.Models.Conta)}.{nameof(Dados.Models.Conta.ContaSegmento)}.{nameof(Dados.Models.Segmento)}")
                       .Include(c => c.Conta.Tags)
                       .Include(u => u.Conta)
                       .ThenInclude(u => u.Cidade)
                       .ThenInclude(u => u.UnidadeFederativa)
                       .Include($"{nameof(Dados.Models.Conta)}.{nameof(Dados.Models.Conta.ContaCampoPersonalizadoRespostas)}.{nameof(Dados.Models.ContaCampoPersonalizadoOpcao)}")
                       .FirstOrDefault();
                if (integracoesConfig != null)
                {
                    //TODO: Multiempresa
                    var NectarConfigs = JsonConvert.DeserializeObject<Negocio.IntegracoesConfiguracaoNectar>(integracoesConfig.Configuracao);
                    var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/");

                    using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                    {

                        var ContaNectar = new Dados.Data.DAO.NectarContaDAO.RootObject();
                        #region IfExistsConta 
                        ContaNectar.nome = oportunidade.Conta.Nome;
                        ContaNectar.constante = 0;
                        switch (oportunidade.Conta.ContaEntidade)
                        {
                            case Dados.Data.Enum.EmunContaEntidade.Custumer: // = 0
                                ContaNectar.constante = 0;
                                break;

                            case Dados.Data.Enum.EmunContaEntidade.Prospect: // = 1
                                ContaNectar.constante = 1;
                                break;

                            case Dados.Data.Enum.EmunContaEntidade.Suspect: // = 2
                                ContaNectar.constante = 2;
                                break;

                        }
                        ContaNectar.enderecos = new List<Dados.Data.DAO.NectarContaDAO.Endereco>();
                        ContaNectar.enderecos.Add(new Dados.Data.DAO.NectarContaDAO.Endereco
                        {
                            bairro = oportunidade.Conta.Bairro,
                            cep = oportunidade.Conta.Cep,
                            numero = oportunidade.Conta.Numero.ToString(),
                            endereco = oportunidade.Conta.Endereco,
                            logradouro = oportunidade.Conta.Endereco,
                        });
                        ContaNectar.responsavel = new Dados.Data.DAO.NectarContaDAO.Responsavel();
                        ContaNectar.responsavel.id = vendedorNectarId;
                        if (oportunidade.Conta.Email != null)
                        {
                            ContaNectar.emails = new List<string>();
                            ContaNectar.emails.Add(oportunidade.Conta.Email);
                        }
                        if (oportunidade.Conta.Telefone1 != null)
                        {
                            ContaNectar.telefonePrincipal = oportunidade.Conta.Telefone1;
                        }
                        if (oportunidade.Conta.Email != null)
                        {
                            ContaNectar.emailPrincipal = oportunidade.Conta.Email;
                        }
                        if (oportunidade.Conta.CnpjCpf != null)
                        {
                            if (oportunidade.Conta.CnpjCpf != null)
                            {
                                var param = Regex.Replace(oportunidade.Conta.CnpjCpf, @"[^0-9]", string.Empty);
                                param = string.Join("", param.Where(Char.IsDigit)).Trim();
                                oportunidade.Conta.CnpjCpf = param;

                                if (oportunidade.Conta.CnpjCpf.Count() == 14)
                                {
                                    ContaNectar.empresa = true;
                                    oportunidade.Conta.CnpjCpf = Convert.ToUInt64(oportunidade.Conta.CnpjCpf).ToString(@"00\.000\.000\/0000\-00");
                                    ContaNectar.cnpj = oportunidade.Conta.CnpjCpf;
                                }
                                if (oportunidade.Conta.CnpjCpf.Count() == 11)
                                {
                                    ContaNectar.empresa = false;
                                    oportunidade.Conta.CnpjCpf = Convert.ToUInt64(oportunidade.Conta.CnpjCpf).ToString(@"000\.000\.000\-00");
                                    ContaNectar.cpf = oportunidade.Conta.CnpjCpf;
                                }
                            }
                            else {
                                ContaNectar.empresa = true;

                            }
                        }
                        if (oportunidade.Conta.ContaSegmento != null)
                        {
                            ContaNectar.segmento = oportunidade.Conta.ContaSegmento.Segmento.Descricao;
                        }
                        ContaNectar.site = oportunidade.Conta.Site;
                        ContaNectar.quantidadeFuncionarios = oportunidade.Conta.Empregados.GetValueOrDefault();
                        ContaNectar.razaoSocial = oportunidade.Conta.NomeFantasia; // nome fantasia = razao social msm coisa.
                        if (oportunidade.Conta.Telefone1 != null)
                        {
                            ContaNectar.telefones = new List<string>();
                            ContaNectar.telefones.Add(oportunidade.Conta.Telefone1);
                        }
                        if (oportunidade.Conta.Telefone2 != null)
                        {
                            ContaNectar.telefones.Add(oportunidade.Conta.Telefone2);
                        }
                        if (oportunidade.Conta.Telefone3 != null)
                        {
                            ContaNectar.telefones.Add(oportunidade.Conta.Telefone3);
                        }
                        if (oportunidade.Conta.Tags.Count > 0)
                        {
                            ContaNectar.listas = new List<Dados.Data.DAO.NectarContaDAO.RootObject.Listas>();
                            foreach (var tagindex in oportunidade.Conta.Tags)
                            {
                                ContaNectar.listas.Add(new Dados.Data.DAO.NectarContaDAO.RootObject.Listas { ativo = true, nome = tagindex.Descricao });
                            }
                        }
                        if (oportunidade.Conta.Cidade != null)
                        {
                            ContaNectar.enderecos[0].municipio = oportunidade.Conta.Cidade.Nome;
                            ContaNectar.enderecos[0].estado = oportunidade.Conta.Cidade.UnidadeFederativa.Nome;
                        }



                        List<string> listaemailsAux = new List<string>();

                        List<string> listatelefonesAux = new List<string>();
                        if (oportunidade.Conta.ContatosContas.Count > 0)
                        {
                            ContaNectar.contatos = new List<Dados.Data.DAO.NectarContaDAO.RootObject.contato>();
                            foreach (var indexContato in oportunidade.Conta.ContatosContas)
                            {
                                if (indexContato.Contato.Email != null && indexContato.Contato.Telefone != null)
                                {
                                    if (indexContato.Contato.Email != null)
                                    {
                                        listaemailsAux.Add(indexContato.Contato.Email);
                                    }
                                    if (indexContato.Contato.Telefone != null)
                                    {
                                        listatelefonesAux.Add(indexContato.Contato.Telefone);
                                    }


                                    if (indexContato.Contato.Email != null && indexContato.Contato.Telefone != null)
                                    {
                                        ContaNectar.contatos.Add(new Dados.Data.DAO.NectarContaDAO.RootObject.contato
                                        {
                                            nome = indexContato.Contato.NomeCompleto,
                                            cargo = indexContato.Contato.Cargo,
                                            emails = listaemailsAux,
                                            telefones = listatelefonesAux,
                                            responsavel = new Dados.Data.DAO.NectarContaDAO.Responsavel { id = vendedorNectarId }
                                        });
                                    }
                                    listaemailsAux = new List<string>();
                                    listatelefonesAux = new List<string>();

                                }
                            }
                        }
                        #region CamposPersonalizados Oportunidade
                        dynamic CampoPersonalizado = new JObject();
                        foreach (var item in NectarConfigs.ContaDePara)
                        {
                            if (item.CampoCombinadoFenicio == item.CampoCombinadoFenicioId)
                            {
                                var st = oportunidade.Conta.GetType().GetProperty(item.CampoCombinadoFenicio).GetValue(oportunidade.Conta);

                                CampoPersonalizado[item.CampoCombinadoNectar] = st.ToString();
                            }
                            else
                            {
                                var listaRespostasCamposPersonalizados = oportunidade.Conta.ContaCampoPersonalizadoRespostas.Where(x => x.ContaCampoPersonalizadoId.ToString().ToUpper() == item.CampoCombinadoFenicioId.ToString().ToUpper()).ToList();
                                foreach (var itemListaIndex in listaRespostasCamposPersonalizados)
                                {
                                    if (itemListaIndex.ContaCampoPersonalizadoOpcao != null)
                                    {
                                        CampoPersonalizado[item.CampoCombinadoNectar] = itemListaIndex.ContaCampoPersonalizadoOpcao.Descricao;

                                    }
                                    else
                                    {
                                        if (itemListaIndex.Resposta != null)
                                        {
                                            CampoPersonalizado[item.CampoCombinadoNectar] = itemListaIndex.Resposta;
                                        }
                                    }

                                }
                            }





                        }
                        ContaNectar.camposPersonalizados = CampoPersonalizado;
                        #endregion
                        var verificaChavevalor = ControleChaveValor.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId
                     && x.EmpresaId == UsuarioLogado.EstabelecimentoId && x.Valor == ContaNectar.nome && x.Integracao == Dados.Data.Enum.EnumQualCrm.Nectar && x.Entidades == Dados.Data.Enum.EnumEntidadeIntegrador.Conta).FirstOrDefault();

                        //if (verificaChavevalor != null) {
                        //    ContaNectar.id = verificaChavevalor.Chave;

                        //}
                        #region Envio Http
                        var conteudo_serializado = JsonConvert.SerializeObject(ContaNectar, Newtonsoft.Json.Formatting.Indented,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                                DefaultValueHandling = DefaultValueHandling.Ignore

                            });

                        var contatoCriado = new Dados.Data.DAO.NectarContaDAO.RootObject();
                        var ConteudoJsonParaSerEnviada = new StringContent(conteudo_serializado, System.Text.Encoding.Default, "application/json");

                    
                        //using (var response = await httpClient.PostAsync("contatos/?api_token=" + NectarConfigs.TokenPrivado, ConteudoJsonParaSerEnviada))
                        HttpResponseMessage response;
                        string responseData;
                        if (verificaChavevalor == null)
                        {
                            using (response = await httpClient.PostAsync("contatos/?api_token=" + NectarConfigs.TokenPrivado, ConteudoJsonParaSerEnviada)) {
                                 responseData = await response.Content.ReadAsStringAsync();

                            }

                        }
                        else {
                            using (response = await httpClient.PutAsync("contatos/"+verificaChavevalor.Chave +"?api_token=" + NectarConfigs.TokenPrivado, ConteudoJsonParaSerEnviada)) {
                                 responseData = await response.Content.ReadAsStringAsync();
                            }
                        }
                      
                                
                                LogsIntegracao = new EfRepository<Dados.Models.LogCRM>(_context);


                                #region Log
                                var log = new Dados.Models.LogCRM();
                                log.JsonEnviado = conteudo_serializado;
                                log.JsonRecebido = responseData;
                                log.Data = DateTime.Now;
                                log.EnumQualCrm = Dados.Data.Enum.EnumQualCrm.Nectar;
                                log.Mensagem = response.ReasonPhrase;
                                log.Sucesso = response.IsSuccessStatusCode;
                                log.AssinaturaId = UsuarioLogado.AssinaturaPadraoId;
                                LogsIntegracao.AddAndSave(log);
                                contatoCriado = JsonConvert.DeserializeObject<Dados.Data.DAO.NectarContaDAO.RootObject>(responseData);
                        #endregion

                        #endregion
                        #region ControleChaveValor
                        if (verificaChavevalor == null) {
                            var KeyAndValue = new Dados.Models.ControleChaveValor
                            {
                                AssinaturaId = UsuarioLogado.AssinaturaPadraoId,
                                EmpresaId = UsuarioLogado.EstabelecimentoId,
                                Chave = contatoCriado.id.ToString(),
                                Valor = contatoCriado.nome,
                                Entidades = Dados.Data.Enum.EnumEntidadeIntegrador.Conta,
                                Integracao = Dados.Data.Enum.EnumQualCrm.Nectar
                            };



                            ControleChaveValor.AddAndSave(KeyAndValue);
                        }
                        #endregion
                        #region Dados da Oportunidade
                        var oportunidadeNectar = new Dados.Data.DAO.NectarOportunidadeDAO.RootObject();
                        oportunidadeNectar.cliente = new Dados.Data.DAO.NectarOportunidadeDAO.Cliente();
                        oportunidadeNectar.responsavel = new Dados.Data.DAO.NectarOportunidadeDAO.Responsavel();
                        oportunidadeNectar.responsavel.id = int.Parse(vendedorNectarId);
                        oportunidadeNectar.cliente.id = contatoCriado.id;
                        oportunidadeNectar.cliente.nome = contatoCriado.nome;
                        oportunidadeNectar.cliente.email = contatoCriado.email;
                        oportunidadeNectar.cliente.emailPrincipal = contatoCriado.email;
                        oportunidadeNectar.cliente.razaoSocial = contatoCriado.razaoSocial;
                        oportunidadeNectar.nome = contatoCriado.nome;
                        oportunidadeNectar.pipeline = NectarConfigs.idFunil;
                        oportunidadeNectar.etapa = int.Parse(NectarConfigs.idEtapa);
                        #endregion
                        #region camposPersonalizados Oportunidade
                        dynamic CampoPersonalizadoOportunidade = new JObject();
                        foreach (var item in NectarConfigs.OportunidadeDePara)
                        {
                            if (item.CampoCombinadoFenicio == "ValorOportunidade")
                            {
                                

                                CampoPersonalizadoOportunidade[item.CampoCombinadoNectar] = oportunidade.ValorOportunidade;
                            }
                            if (item.CampoCombinadoFenicio  == "DataPossivelFechamento")
                            {

                                CampoPersonalizadoOportunidade[item.CampoCombinadoNectar] = oportunidade.DataPossivelFechamento;




                            }
                            if (item.CampoCombinadoFenicio == "Passiva") {
                                if (oportunidade.Passiva == false)
                                {
                                    CampoPersonalizadoOportunidade[item.CampoCombinadoNectar] = "Passiva";

                                }
                                else {
                                    CampoPersonalizadoOportunidade[item.CampoCombinadoNectar] = "Ativa";



                                }





                            }



                            if (item.CampoCombinadoFenicio == "Historico da Oportunidade") {

                                var host = Request.Host;
                                var linkBotao = "http://" + host + "/public/Index?id=" + oportunidade.Id;

                                CampoPersonalizadoOportunidade[item.CampoCombinadoNectar] = linkBotao;



                            }



                           


                        }
                        #endregion 
                        #region Envio Http e parametrizações
                        oportunidadeNectar.camposPersonalizados = CampoPersonalizadoOportunidade;
                        var OportunidadeSerializada = JsonConvert.SerializeObject(oportunidadeNectar, Newtonsoft.Json.Formatting.Indented,
                           new JsonSerializerSettings
                           {
                               NullValueHandling = NullValueHandling.Ignore,
                               DefaultValueHandling = DefaultValueHandling.Ignore
                           });
                        var ConteudoJsonOportunidade = new StringContent(OportunidadeSerializada, System.Text.Encoding.Default, "application/json");


                        var verificaOportunidade = ControleChaveValor.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId
                    && x.EmpresaId == UsuarioLogado.EstabelecimentoId && x.Valor == ContaNectar.nome && x.Integracao == Dados.Data.Enum.EnumQualCrm.Nectar && x.Entidades == Dados.Data.Enum.EnumEntidadeIntegrador.Oportunidade).FirstOrDefault();




                        if (verificaOportunidade == null) {

                            using (var responseOportunidade = await httpClient.PostAsync("oportunidades/?api_token=" + NectarConfigs.TokenPrivado, ConteudoJsonOportunidade)) {
                                string stringResponseOportunidadeCriada = await responseOportunidade.Content.ReadAsStringAsync();

                                var responseOportunidadeCriada = JsonConvert.DeserializeObject<Dados.Data.DAO.NectarOportunidadeDAO.RootObject>(stringResponseOportunidadeCriada);

                                var KeyAndValue = new Dados.Models.ControleChaveValor
                                {
                                    AssinaturaId = UsuarioLogado.AssinaturaPadraoId,
                                    EmpresaId = UsuarioLogado.EstabelecimentoId,
                                    Chave = responseOportunidadeCriada.id.ToString(),
                                    Valor = responseOportunidadeCriada.nome,
                                    Entidades = Dados.Data.Enum.EnumEntidadeIntegrador.Oportunidade,
                                    Integracao = Dados.Data.Enum.EnumQualCrm.Nectar
                                };
                                ControleChaveValor.AddAndSave(KeyAndValue);
                                log = new Dados.Models.LogCRM();
                                log.JsonEnviado = OportunidadeSerializada;
                                log.JsonRecebido = stringResponseOportunidadeCriada;
                                log.Data = DateTime.Now;
                                log.EnumQualCrm = Dados.Data.Enum.EnumQualCrm.Nectar;
                                log.Mensagem = response.ReasonPhrase;
                                log.Sucesso = response.IsSuccessStatusCode;
                                log.AssinaturaId = UsuarioLogado.AssinaturaPadraoId;
                                LogsIntegracao.AddAndSave(log);
                                //contatoCriado = JsonConvert.DeserializeObject<Dados.Data.DAO.NectarContaDAO.RootObject>(responseData);
                              

                                return Json(new { sucesso = true });
                            }

                        }
                        else {

                            using (var responseOportunidade = await httpClient.PutAsync("oportunidades/"+verificaOportunidade.Chave+"?api_token=" + NectarConfigs.TokenPrivado, ConteudoJsonOportunidade))
                            {
                                string stringResponseOportunidadeCriada = await responseOportunidade.Content.ReadAsStringAsync();

                                var responseOportunidadeCriada = JsonConvert.DeserializeObject<Dados.Data.DAO.NectarOportunidadeDAO.RootObject>(stringResponseOportunidadeCriada);

                                 log = new Dados.Models.LogCRM();
                                log.JsonEnviado = OportunidadeSerializada;
                                log.JsonRecebido = stringResponseOportunidadeCriada;
                                log.Data = DateTime.Now;
                                log.EnumQualCrm = Dados.Data.Enum.EnumQualCrm.Nectar;
                                log.Mensagem = response.ReasonPhrase;
                                log.Sucesso = response.IsSuccessStatusCode;
                                log.AssinaturaId = UsuarioLogado.AssinaturaPadraoId;
                                LogsIntegracao.AddAndSave(log);
                          

                                    return Json(new { sucesso = true });
                            }


                        }

                      







                        //using (var responseOportunidade = await httpClient.PostAsync("oportunidades/?api_token=" + NectarConfigs.TokenPrivado, ConteudoJsonOportunidade))
                        //{
                          
                          


                        //    return Json(new { sucesso = true });

                        //}
                        #endregion









                        #endregion

                    }




                }
                else {

                    return Json(new { sucesso = false });
                }
            }
            catch (Exception e)
            {

                throw e;
            }


        }


        [HttpPost("AdicionarConfiguracoesNectar")]
        public JsonResult RemoverMeta(Negocio.IntegracoesConfiguracaoNectar NectarModel)
        {
            try
            {

                //nectarEfRepositorio = new EfRepository<Dados.Models.NectarConfiguracoes>(_context);
                integracoesConfiguracao = new EfRepository<Dados.Models.IntegracoesConfiguracao>(_context);
                var integracoesConfig = integracoesConfiguracao.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId && x.EmpresaId == UsuarioLogado.EstabelecimentoId && x.Sistema == Dados.Data.Enum.EnumQualCrm.Nectar).FirstOrDefault();
                if (integracoesConfig != null)
                {
                    //TODO: Multiempresa
                    var serializeObject = JsonConvert.SerializeObject(NectarModel);
                    integracoesConfig.AssinaturaId = UsuarioLogado.AssinaturaPadraoId;
                    integracoesConfig.EmpresaId = UsuarioLogado.EstabelecimentoId;
                    integracoesConfig.Sistema = Dados.Data.Enum.EnumQualCrm.Nectar;
                    integracoesConfig.Configuracao = serializeObject;
                    integracoesConfiguracao.UpdateAndSave(integracoesConfig);

                }
                else {
                    //TODO: Multiempresa
                    integracoesConfig = new Dados.Models.IntegracoesConfiguracao();
                    var serializeObject = JsonConvert.SerializeObject(NectarModel);
                    integracoesConfig.AssinaturaId = UsuarioLogado.AssinaturaPadraoId;
                    integracoesConfig.EmpresaId = UsuarioLogado.EstabelecimentoId;
                    integracoesConfig.Sistema = Dados.Data.Enum.EnumQualCrm.Nectar;
                    integracoesConfig.Configuracao = serializeObject;
               
                    integracoesConfiguracao.AddAndSave(integracoesConfig);

                }






                return Json(new { sucesso = true });
            }
            catch (Exception e)
            {

                throw e;
            }
           

        }

        [HttpGet("AdicionarOpt")]
        public async Task<JsonResult> adicionarxxxAsync(Negocio.IntegracoesConfiguracaoNectar NectarModel)
        {
            try
            {
                var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/");

                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {
                 
                    using (var content = new StringContent("{  \"nome\": \"Minha primeira oportunidade do contato 1\",  \"dataLimite\": \"2016-04-30T00:00:00-03:00\",  \"pipeline\": \"Pipeline padrão\",  \"etapa\": 2,  \"probabilidade\": 50,  \"status\": 1,  \"valorAvulso\": 500000,  \"valorMensal\": 1000,  \"observacao\": \"Uma Observação qualquer\",  \"cliente\": {    \"id\": 13777427  },  \"responsavel\": {    \"id\": 12,    \"nome\": \"Usuario 1\"  },  \"produtos\": [    {      \"comissaoPorcentual\": false,      \"desconto\": 0,      \"descontoPorcentual\": false,      \"nome\": \"Produto 1\",      \"quantidade\": 6,      \"recorrencia\": 1,      \"valor\": 69,      \"valorTotal\": 414    }  ],  \"camposPersonalizados\": {    \"Campo 1\": \"Valor 1\",    \"Campo 2\": \"Valor 2\"  }}", System.Text.Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("oportunidades/?api_token=f84d33f6bd20456eb3c768e213feffde", content))
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                        }
                    }
                }



                return Json(new { sucesso = true });
            }
            catch (Exception e)
            {

                throw e;
            }


        }

        [HttpGet("CarregarConfiguracoesNectar")]
        public async Task<JsonResult> CarregarConfiguracoes(string token)
        {
            //nectarEfRepositorio = new EfRepository<Dados.Models.NectarConfiguracoes>(_context);
            //Dados.Models.NectarConfiguracoes Nectar = nectarEfRepositorio.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId).FirstOrDefault();

            //var Funil = new List<Dados.Data.DAO.NectarFunilDAO.Funil>();
            if (token != null) {
                var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/");


                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {
                    //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api_token", Nectar.TokenPrivado);
                    using (var response = await httpClient.GetAsync("pipeline/?api_token=" + token))
                    {

                        var responseData = response.Content.ReadAsStringAsync().Result;
                        if (responseData == "Invalid token") {
                            return Json(new { sucesso = false });

                        }
                        var nectarFunil = JsonConvert.DeserializeObject<List<Dados.Data.DAO.NectarFunilDAO.Funil>>(responseData);
                        using (var response2 = await httpClient.GetAsync("customField/?api_token=" + token))
                        {

                            var responseData2 = response2.Content.ReadAsStringAsync().Result;
                            var CamposPersonalizados = JsonConvert.DeserializeObject<List<Dados.Data.DAO.CamposPersonalizados.CamposPersonalizadosGeral>>(responseData2);

                            if (CamposPersonalizados != null && nectarFunil != null) {

                                return Json(new { sucesso = true, nectarFunil, CamposPersonalizados });
                            }
                            else {

                                return Json(new { sucesso = false });

                            }





                        }


                    }


                }


            }
            else {
                return Json(new { sucesso = false });

            }
        }




        [HttpGet("CarregarConfiguracoesGeraisNectar")]
        public async Task<JsonResult> CarregarConfiguracoesGeraisNectar()
        {
            integracoesConfiguracao = new EfRepository<Dados.Models.IntegracoesConfiguracao>(_context);
            var integracoesConfig = integracoesConfiguracao.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId && x.EmpresaId == UsuarioLogado.EstabelecimentoId && x.Sistema == Dados.Data.Enum.EnumQualCrm.Nectar).FirstOrDefault();
            if (integracoesConfig != null)
            {
                var Nectar = JsonConvert.DeserializeObject<Negocio.IntegracoesConfiguracaoNectar>(integracoesConfig.Configuracao);
                return Json(new { sucesso = true, Nectar });
            }
            else {
                var Nectar = new Negocio.IntegracoesConfiguracaoNectar();
                return Json(new { sucesso = true, Nectar });
            }
        }








        [HttpGet("CarregarDadosDaContaNectar")]
        public async Task<JsonResult> CarregarDadosDaContaNectar(string token)
        {

            integracoesConfiguracao = new EfRepository<Dados.Models.IntegracoesConfiguracao>(_context);
            var integracoesConfig = integracoesConfiguracao.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId && x.EmpresaId == UsuarioLogado.EstabelecimentoId && x.Sistema == Dados.Data.Enum.EnumQualCrm.Nectar).FirstOrDefault();
         
                var Nectar = JsonConvert.DeserializeObject<Negocio.IntegracoesConfiguracaoNectar>(integracoesConfig.Configuracao);
                
            
            var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/");


            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api_token", Nectar.TokenPrivado);
                using (var response = await httpClient.GetAsync("contatos/?api_token=" + Nectar.TokenPrivado))
                {

                    var responseData = response.Content.ReadAsStringAsync().Result;
                    var nectarContato = JsonConvert.DeserializeObject<List<Dados.Data.DAO.NectarContaDAO.RootObject>>(responseData);
                    //var szr = JsonConvert.SerializeObject(responseData); // teste 2
                    //var nectarContato = JsonConvert.DeserializeObject<Dados.Data.DAO.NectarDAO.RootObject>(szr);


                    return Json(new { sucesso = true });
                }


            }


        }

      
        public async Task<List<Dados.Data.DAO.NectarUsuario.RootObject>> userNectar()
        {

            integracoesConfiguracao = new EfRepository<Dados.Models.IntegracoesConfiguracao>(_context);
            var integracoesConfig = integracoesConfiguracao.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId && x.EmpresaId == UsuarioLogado.EstabelecimentoId && x.Sistema == Dados.Data.Enum.EnumQualCrm.Nectar).FirstOrDefault();

            var Nectar = JsonConvert.DeserializeObject<Negocio.IntegracoesConfiguracaoNectar>(integracoesConfig.Configuracao);


            var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/");


            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api_token", Nectar.TokenPrivado);
                using (var response = await httpClient.GetAsync("usuario/?api_token=" + Nectar.TokenPrivado))
                {

                    var responseData = response.Content.ReadAsStringAsync().Result;
                    var nectarContato = JsonConvert.DeserializeObject<List<Dados.Data.DAO.NectarUsuario.RootObject>>(responseData);
                    return nectarContato;
               
                }


            }


        }

        [HttpGet("CarregarDadosDaOportunidadeNectar")]
        public async Task<JsonResult> CarregarDadosDaOportunidadeNectar(string token)
        {

            integracoesConfiguracao = new EfRepository<Dados.Models.IntegracoesConfiguracao>(_context);
            var integracoesConfig = integracoesConfiguracao.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId && x.EmpresaId == UsuarioLogado.EstabelecimentoId && x.Sistema == Dados.Data.Enum.EnumQualCrm.Nectar).FirstOrDefault();

            var NectarConfigs = JsonConvert.DeserializeObject<Negocio.IntegracoesConfiguracaoNectar>(integracoesConfig.Configuracao);

            var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/");


            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api_token", Nectar.TokenPrivado);
                using (var response = await httpClient.GetAsync("publicacao/?api_token=" + NectarConfigs.TokenPrivado))
                {

                    var responseData = response.Content.ReadAsStringAsync().Result;
                    var nectarOportunidade = JsonConvert.DeserializeObject<List<Dados.Data.DAO.NectarOportunidadeDAO.RootObject>>(responseData);



                    return Json(new { sucesso = true, nectarOportunidade });
                }


            }


        }

        //[HttpGet("CarregarDadosFunil")]
        public async Task<ICollection<Dados.Data.DAO.NectarFunilDAO.Funil>> CarregarDadosFunil(string token)
        {

            //nectarEfRepositorio = new EfRepository<Dados.Models.NectarConfiguracoes>(_context);
            //Dados.Models.NectarConfiguracoes Nectar = nectarEfRepositorio.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId).FirstOrDefault();

            /* var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/?")*/
            var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/");


            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api_token", Nectar.TokenPrivado);
                using (var response = await httpClient.GetAsync("pipeline/?api_token=" + token))
                {

                    var responseData = response.Content.ReadAsStringAsync().Result;
                    var nectarFunil =  JsonConvert.DeserializeObject<List<Dados.Data.DAO.NectarFunilDAO.Funil>>(responseData);



                    //return Json(new { sucesso = true, nectarFunil });
                    return  nectarFunil;
                }


            }
        }


        [HttpGet("CarregarDadosCamposPersonalizados")]
        public async Task<JsonResult> CarregarDadosCamposPersonalizados(string token)
        {

            //nectarEfRepositorio = new EfRepository<Dados.Models.NectarConfiguracoes>(_context);
            //Dados.Models.NectarConfiguracoes Nectar = nectarEfRepositorio.Where(x => x.AssinaturaId == UsuarioLogado.AssinaturaPadraoId).FirstOrDefault();

            /* var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/?")*/
            var baseAddress = new Uri("https://app.nectarcrm.com.br/crm/api/1/");


            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api_token", Nectar.TokenPrivado);
                using (var response = await httpClient.GetAsync("customField/?api_token=" + token))
                {

                    var responseData = response.Content.ReadAsStringAsync().Result;
                    var nectarFunil = JsonConvert.DeserializeObject<List<Dados.Data.DAO.CamposPersonalizados.CamposPersonalizadosGeral>>(responseData);



                    return Json(new { sucesso = true, nectarFunil });
                }


            }

        }
    }




        }

