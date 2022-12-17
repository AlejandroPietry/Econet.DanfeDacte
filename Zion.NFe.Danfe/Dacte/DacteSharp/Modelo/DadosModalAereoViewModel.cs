using System.Collections.Generic;

namespace ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo
{
    public class DadosModalAereoViewModel
    {
        public string InformacoesManuseio { get; set; }
        public string NumeroOperacional { get; set; }
        public string Origem { get; set; }
        public string Passagem { get; set; }
        public string Destino { get; set; }
        public string ClasseCL { get; set; }
        public string CodigoTarifa { get; set; }
        public string ValorTarifa { get; set; }
        public string NumeroMinuta { get; set; }
        public bool Retira { get; set; }
        public string DadosRelativosRetiradCarga { get; set; }
        public string CaracteristicaAdicionalServiço { get; set; }
        public string DataPrevista { get; set; }
        public string Dimensao { get; set; }
        public List<NaturezaCarga> NaturezaCarga { get; set; }
    }

    public partial class NaturezaCarga
    {
        public string Dimensao { get; set; }
        public string InformacoesManuseio { get; set; }
    }

}
