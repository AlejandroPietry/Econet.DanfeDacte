using ECONET.EcoNFe2.Negocio.Dacte;
using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using org.pdfclown.documents.contents.xObjects;
using System.Drawing;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools;
using Zion.NFe.Danfe.Tools.Extensions;
namespace DacteSharp
{
    internal class Expedidor : ElementoBase
    {
        public DacteViewModel ViewModel { get; private set; }
        public XObject Logo { get; set; }

        public Expedidor(Estilo estilo, DacteViewModel viewModel) : base(estilo)
        {
            ViewModel = viewModel;
            Logo = null;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            RectangleF rp = BoundingBox.InflatedRetangle(0.75F);
            Fonte f3 = Estilo.CriarFonteRegular(6);

            var expedidor = ViewModel.Expedidor;
            var ts = new TextStack(rp) { LineHeightScale = 1.5F }
                .AddLine($"{Strings.Expedidor.PadRight(18, ' ')}{expedidor.xNome}", f3)
                .AddLine($"{Strings.Endereco.PadRight(21, ' ')}{FormatadorDacte.LogradouroCompleto(expedidor.enderExped.xLgr, expedidor.enderExped.nro, expedidor.enderExped.xCpl)}", f3)
                .AddLine($"{string.Empty.PadRight(35, ' ')}{expedidor.enderExped.xBairro}", f3)
                .AddLine(expedidor.xNome != null ? ($"{Strings.Municipio.PadRight(22, ' ')}{Formatador.FormatarMunicipioUf(expedidor.enderExped.xMun, expedidor.enderExped.UF.ToString())}{Strings.Cep.PadLeft(100, ' ')}{FormatadorDacte.Cep(expedidor.enderExped.CEP, 18)}") : ($"{Strings.Municipio}{Strings.Cep.PadLeft(135, ' ')}"), f3)
                .AddLine(expedidor.xNome != null ? ($"{Strings.CnpjCpf.PadRight(24, ' ')}{Formatador.FormatarCpfCnpj(expedidor.CNPJ)}{Strings.InscricaoEstadual.PadLeft(52, ' ')} {expedidor.IE}") : ($"{Strings.CnpjCpf}{Strings.InscricaoEstadual.PadLeft(95, ' ')}"), f3)
                .AddLine($"{("PAÍS").PadRight(30, ' ')}{expedidor.enderExped.xPais}{("FONE").PadLeft((expedidor.enderExped.xPais != null ? 88 : 103), ' ')}{(expedidor.fone != null ? Formatador.FormatarTelefone(expedidor.fone).PadLeft(20, ' ') : string.Empty.PadLeft(20, ' '))}", f3);

            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda;
            ts.AlinhamentoVertical = AlinhamentoVertical.Centro;
            ts.Draw(gfx);
        }
    }
}