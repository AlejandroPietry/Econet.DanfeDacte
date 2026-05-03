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
        public string DiscriminacaoServico { get; set; }
        public string InformacoesComplementares { get; set; }

        public decimal? ValorServico { get; set; }
        public decimal? ValorDeducoes { get; set; }
        public decimal? ValorLiquido { get; set; }
        public decimal? ValorIssqn { get; set; }
        public decimal? AliquotaIssqn { get; set; }

        public float Margem { get; set; } = 4;

        public bool Cancelada { get; set; }

        public string ProtocoloAutorizacao { get; set; }

        public bool IsHomologacao => TipoAmbiente == 2;
    }
}
