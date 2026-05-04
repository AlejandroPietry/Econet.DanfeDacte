using System;
using Zion.NFe.Danfe.Modelo;

namespace Zion.NFe.Danfe.Nfse.Modelo
{
    /// <summary>
    /// Modelo de dados para renderização da NFS-e.
    /// </summary>
    public class NfseViewModel
    {
        public string Numero { get; set; }
        public string Serie { get; set; }
        public string ChaveAcesso { get; set; }
        public string CodigoVerificacao { get; set; }
        public DateTime? DataHoraEmissao { get; set; }
        public int TipoAmbiente { get; set; } = 1;

        public EmpresaViewModel Prestador { get; set; } = new EmpresaViewModel();
        public EmpresaViewModel Tomador { get; set; } = new EmpresaViewModel();

        public string MunicipioPrestacao { get; set; }
        public string MunicipioIncidencia { get; set; }
        public string PaisPrestacao { get; set; }
        public string PaisTomador { get; set; }
        public string NumeroDps { get; set; }
        public string SerieDps { get; set; }
        public DateTime? Competencia { get; set; }
        public string NaturezaTributacaoMunicipal { get; set; }
        public string DiscriminacaoServico { get; set; }
        public string InformacoesComplementares { get; set; }
        public string DescricaoTributacaoNacional { get; set; }
        public string DescricaoTributacaoMunicipal { get; set; }
        public string DescricaoSimplesNacional { get; set; }
        public string DescricaoRegimeEspecial { get; set; }

        public decimal? ValorServico { get; set; }
        public decimal? ValorDescontoCondicionado { get; set; }
        public decimal? ValorDescontoIncondicionado { get; set; }
        public decimal? ValorDeducoes { get; set; }
        public decimal? ValorLiquido { get; set; }
        public decimal? ValorIssqn { get; set; }
        public decimal? AliquotaIssqn { get; set; }
        public decimal? BaseCalculo { get; set; }
        public decimal? BaseCalculoBm { get; set; }
        public decimal? ValorCalcBm { get; set; }
        public decimal? ValorIrff { get; set; }
        public decimal? ValorContribuicoes { get; set; }
        public decimal? ValorPisCofins { get; set; }
        public decimal? ValorRetencoes { get; set; }
        public decimal? ValorTotalTributosFederais { get; set; }
        public decimal? ValorTotalTributosEstaduais { get; set; }
        public decimal? ValorTotalTributosMunicipais { get; set; }
        public string DescricaoRetencaoIssqn { get; set; }
        public string DescricaoRetencaoFederal { get; set; }

        public float Margem { get; set; } = 4;

        public bool Cancelada { get; set; }
        public bool ExibirMarcaDaguaModelo { get; set; } = true;

        public string ProtocoloAutorizacao { get; set; }

        public bool IsHomologacao => TipoAmbiente == 2;
    }
}
