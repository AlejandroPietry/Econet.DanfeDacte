using System;
using System.Collections.Generic;
using System.Text;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Modelo;
using Zion.NFe.Danfe.Tools;
using Zion.NFe.Danfe.Tools.Extensions;

namespace ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo
{
    public class DacteViewModel
    {
        private int _QuantidadeCanhoto;

        /// <summary>
        /// Quantidade de canhotos a serem impressos.
        /// </summary>
        public int QuantidadeCanhotos
        {
            get => _QuantidadeCanhoto;
            set
            {
                if (value >= 0 && value <= 2)
                    _QuantidadeCanhoto = value;
                else
                    throw new ArgumentOutOfRangeException("A quantidade de canhotos deve de 0 a 2.");
            }
        }

        private float _Margem;

        /// <summary>
        /// Magens horizontais e verticais do DANFE.
        /// </summary>
        public float Margem
        {
            get => _Margem;
            set
            {
                if (value >= 2 && value <= 5)
                    _Margem = value;
                else
                    throw new ArgumentOutOfRangeException("A margem deve ser entre 2 e 5.");
            }
        }

        /// <summary>
        /// <para>Número do Documento Fiscal</para>
        /// <para>Tag nNF</para>
        /// </summary>
        public string CTeNumero { get; set; }

        /// <summary>
        /// <para>Série do Documento Fiscal</para>
        /// <para>Tag serie</para>
        /// </summary>
        public string Serie { get; set; }

        public Orientacao Orientacao { get; set; }

        /// <summary>
        /// Chave de Acesso
        /// </summary>
        public String ChaveAcesso { get; set; }


        /// <summary>
        /// <para>Descrição da Natureza da Operação</para>
        /// <para>Tag natOp</para>
        /// </summary>
        public String NaturezaOperacao { get; set; }

        /// <summary>
        /// <para>Informações Complementares de interesse do Contribuinte</para>
        /// <para>Tag infCpl</para>
        /// </summary>
        public String InformacoesComplementares { get; set; }

        /// <summary>
        /// <para>Informações adicionais de interesse do Fisco</para>
        /// <para>Tag infAdFisco</para>
        /// </summary>
        public String InformacoesAdicionaisFisco { get; set; }

        /// <summary>
        /// <para>Data e Hora de emissão do Documento Fiscal</para>
        /// <para>Tag dhEmi ou dEmi</para>
        /// </summary>
        public DateTime? DataHoraEmissao { get; set; }

        /// <summary>
        /// <para>Data de Saída ou da Entrada da Mercadoria/Produto</para>
        /// <para>Tag dSaiEnt e dhSaiEnt</para>
        /// </summary>
        public DateTime? DataSaidaEntrada { get; set; }

        /// <summary>
        /// <para>Hora de Saída ou da Entrada da Mercadoria/Produto</para>
        /// <para>Tag dSaiEnt e hSaiEnt</para>
        /// </summary>
        public TimeSpan? HoraSaidaEntrada { get; set; }

        /// <summary>

        /// <para>Tag tpNF</para>
        /// </summary>
        public int TipoCte { get; set; }

        /// Dados do Emitente
        /// </summary>
        public TCTeInfCteEmit Emitente { get; set; }

        /// <summary>
        /// Dados do Destinatário
        /// </summary>
        public TCTeInfCteDest Destinatario { get; set; }

        /// <summary>
        /// Numero do protocolo com sua data e hora
        /// </summary>
        public String ProtocoloAutorizacao { get; set; }

        /// <summary>
        /// Faturas da Nota Fiscal
        /// </summary>
        public List<DuplicataViewModel> Duplicatas { get; set; }

        /// <summary>
        /// Tipo da Modal
        /// </summary>
        public TModTransp Modal { get; set; }


        /// <summary>
        /// Tipo de Ambiente
        /// </summary>
        public int TipoAmbiente { get; set; }

        /// <summary>
        /// Código do status da resposta, cStat, do elemento infProt.
        /// </summary>
        public string CodigoStatusReposta { get; set; }

        /// <summary>
        /// Descrição do status da resposta, xMotivo, do elemento infProt.
        /// </summary>
        public String DescricaoStatusReposta { get; set; }

        /// <summary>
        /// Informações de Notas Fiscais referenciadas que serão levadas no texto adicional.
        /// </summary>
        public List<String> NotasFiscaisReferenciadas { get; set; }

        /// <summary>
        /// Tipo de Serviço 
        /// </summary>
        public TCTeInfCteIdeTpServ TipoServico { get; set; }

        public TModCT Modelo { get; set; }

        public string CFOP { get; set; }

        public string OrigemPrestacao { get; set; }

        public string DestinoPrestacao { get; set; }

        /// <summary>
        /// Forma de Pagamento
        /// </summary>
        public string FormaPagamento { get; set; }


        #region Informações adicionais de compra

        /// <summary>
        /// Tag xNEmp
        /// </summary>
        public String NotaEmpenho { get; set; }

        /// <summary>
        /// Tag xPed
        /// </summary>
        public String Pedido { get; set; }

        /// <summary>
        /// Tag xCont
        /// </summary>
        public String Contrato { get; set; }

        #endregion


        #region Opções de exibição

        /// <summary>
        /// Exibi os valores do ICMS Interestadual e Valor Total dos Impostos no bloco Cálculos do Imposto.
        /// </summary>
        public bool ExibirIcmsInterestadual { get; set; }

        /// <summary>
        /// Exibi os valores do PIS e COFINS no bloco Cálculos do Imposto.
        /// </summary>
        public bool ExibirPisConfins { get; set; }

        public bool IndicadorGlobalizado { get; set; }

        public TCTeInfCteExped Expedidor { get; set; }

        public TCTeInfCteReceb Recebedor { get; set; }

        public TomadorViewModel Tomador { get; set; }

        public TCTeInfCteRem Remetente { get; set; }

        public TCTeOSInfCte infCteOS { get; set; }
        #endregion

        public DacteViewModel()
        {
            QuantidadeCanhotos = 1;
            Margem = 4;
            Orientacao = Orientacao.Retrato;

            Duplicatas = new List<DuplicataViewModel>();

            NotasFiscaisReferenciadas = new List<string>();

            ExibirIcmsInterestadual = true;
            ExibirPisConfins = true;
        }


        public Boolean MostrarCalculoIssqn { get; set; }


        /// <summary>
        /// Substitui o ponto e vírgula (;) por uma quebra de linha.
        /// </summary>
        private String BreakLines(String str)
        {
            return str == null ? String.Empty : str.Replace(';', '\n');
        }


        public virtual String TextoRecebimento
        {
            get
            {
                return $"DECLARO QUE RECEBI OS VOLUMES DESTE CONHECIMENTO EM PERFEITO ESTADO PELO QUE DOU POR CUMPRIDO O PRESENTE CONTRATO DE TRANSPORTE";
            }
        }

        public virtual String TextoAdicional()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(InformacoesComplementares))
                sb.AppendChaveValor("Inf. Contribuinte", InformacoesComplementares).Replace(";", "\r\n");


            if (!String.IsNullOrEmpty(InformacoesAdicionaisFisco))
                sb.AppendChaveValor("Inf. fisco", InformacoesAdicionaisFisco);

            if (!String.IsNullOrEmpty(Pedido) && !Utils.StringContemChaveValor(InformacoesComplementares, "Pedido", Pedido))
                sb.AppendChaveValor("Pedido", Pedido);

            if (!String.IsNullOrEmpty(Contrato) && !Utils.StringContemChaveValor(InformacoesComplementares, "Contrato", Contrato))
                sb.AppendChaveValor("Contrato", Contrato);

            if (!String.IsNullOrEmpty(NotaEmpenho))
                sb.AppendChaveValor("Nota de Empenho", NotaEmpenho);


            foreach (var nfref in NotasFiscaisReferenciadas)
            {
                if (sb.Length > 0) sb.Append(" ");
                sb.Append(nfref);
            }


            #region NT 2013.003 Lei da Transparência

            //if (CalculoImposto.ValorAproximadoTributos.HasValue && (String.IsNullOrEmpty(InformacoesComplementares) ||
            //   !Regex.IsMatch(InformacoesComplementares, @"((valor|vlr?\.?)\s+(aprox\.?|aproximado)\s+(dos\s+)?(trib\.?|tributos))|((trib\.?|tributos)\s+(aprox\.?|aproximado))", RegexOptions.IgnoreCase)))
            //{
            //    if (sb.Length > 0) sb.Append("\r\n");
            //    sb.Append("Valor Aproximado dos Tributos: ");
            //    sb.Append(CalculoImposto.ValorAproximadoTributos.FormatarMoeda());
            //}

            #endregion


            return sb.ToString();
        }

        public Boolean IsRetrato => Orientacao == Orientacao.Retrato;
        public Boolean IsPaisagem => Orientacao == Orientacao.Paisagem;
        public InformacoesProdutoCarga InformacaoCteNorm { get; set; }
        public TCTeInfCteVPrest Componente { get; set; }
        public InformacoesImpostosViewModel InformacoesImposto { get; set; }
        public string Observacoes { get; set; }
        public int NumeroPaginas { get; set; }

        public partial class InformacoesProdutoCarga
        {
            public string ProdutoPredominante { get; set; }
            public string OutrasCaracteristicasCarga { get; set; }
            public string ValorTotalCarga { get; set; }
            public string TipoMedidaPesoBruto { get; set; }
            public string PesoBruto { get; set; }
            public string TipoMedidaPesoBaseCalculo { get; set; }
            public string PesoBaseCalculo { get; set; }
            public string TipoMedidaPesoAferido { get; set; }
            public string PesoAferido { get; set; }
            public string TipoMedidaPesoDeclarado { get; set; }
            public string PesoDeclarado { get; set; }
            public string TipoMedidaPesoCubado { get; set; }
            public string PesoCubado { get; set; }
            public string TipoMedidaLitragem { get; set; }
            public string Litragem { get; set; }
            public string TipoMedidaPesoAforado { get; set; }
            public string PesoAforado { get; set; }
            public string Cubagem { get; set; }
            public string TipoMedidaQuantidade { get; set; }
            public string Quantidade { get; set; }

        }
        public string RNTRC { get; set; }
        public rodo DadosModalRodoviario { get; set; }
        //public rodoOS DadosModalRodoviarioOS { get; set; }
        public List<DocumentosOriginariosViewModel> DocumentosOriginarios { get; internal set; }
        public DadosModalObs DadosModalObservacao { get; set; }
        public DadosModalAereoViewModel InformacoesDadosModalAereo { get; set; }
        public DadosModalAquaviarioViewModel InformacoesModalAquaviario { get; set; }
        public DadosModalFerroviarioViewModel InformacoesModalFerroviario { get; internal set; }
        public List<DadosModalDutoviarioViewModel> InformacoesModalDutoviario { get; internal set; }
        public multimodal InformacoesMultiModal { get; internal set; }
        public DadosFluxoViewModel DadosFluxoViewModel { get; internal set; }
        public PrestacaoServico PrestacoesServicosOS { get; internal set; }
        public DadosModalRodoviarioOS DadosInformacoesOS { get; set; }

        public partial class PrestacaoServico
        {
            public string DescricaoServico { get; set; }
            public string Quantidade { get; set; }

        }

        public partial class DadosModalObs
        {
            public string ObsUsoEmissor { get; set; }
            public string ObsReservadoFisco { get; set; }
        }

        public partial class SeguroViagem
        {
            public string Responsavel { get; set; }
            public string NomeSeguradora { get; set; }
            public string NroApolice { get; set; }
        }

        public class DadosModalRodoviarioOS
        {
            public rodoOS DadosModal { get; set; }
            public SeguroViagem SeguroViagem { get; set; }
        }
    }
}