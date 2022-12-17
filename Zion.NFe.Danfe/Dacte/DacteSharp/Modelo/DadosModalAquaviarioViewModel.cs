using System.Collections.Generic;

namespace ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo
{
    public class DadosModalAquaviarioViewModel
    {
        public string PortoEmbarque { get; set; }
        public string PortoDestino { get; set; }
        public string IndentificacaoNavio { get; set; }
        public string VrACalcFrmm { get; set; }
        public string ValorAfrmm { get; set; }
        public int TipoNavegacao { get; set; }
        public string IdentificacaoBalsa { get; set; }
        public string Seguradora { get; set; }
        public List<DetalhamentoContainer> listaContainer { get; set; }
    }
    public partial class DetalhamentoContainer
    {
        public string tipoDocumento { get; set; }
        public string cnpjEmit { get; set; }
        public string SerieNro { get; set; }
        public string lacre { get; set; }
        public string idContainer { get; set; }
    }

}
