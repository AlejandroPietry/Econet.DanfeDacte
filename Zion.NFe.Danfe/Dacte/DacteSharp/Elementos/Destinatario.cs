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
    internal class Destinatario : ElementoBase
    {
        public DacteViewModel ViewModel { get; private set; }
        public XObject Logo { get; set; }

        public Destinatario(Estilo estilo, DacteViewModel viewModel) : base(estilo)
        {
            ViewModel = viewModel;
            Logo = null;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            RectangleF rp = BoundingBox.InflatedRetangle(0.75F);
            Fonte f3 = Estilo.CriarFonteRegular(6);

            var destinatario = ViewModel.Destinatario;
            var ts = new TextStack(rp) { LineHeightScale = 1.5F }
                .AddLine($"{Strings.Destinatario.PadRight(18, ' ')}{destinatario.xNome.Trim()}", f3)
                .AddLine($"{Strings.Endereco.PadRight(19, ' ')}{FormatadorDacte.LogradouroCompleto(destinatario.enderDest.xLgr, destinatario.enderDest.nro, destinatario.enderDest.xCpl)}", f3)
                .AddLine($"{string.Empty.PadRight(34, ' ')}{destinatario.enderDest.xBairro.Trim()}", f3)
                .AddLine(destinatario.xNome != null ? ($"{Strings.Municipio.PadRight(22, ' ')}{Formatador.FormatarMunicipioUf(destinatario.enderDest.xMun, destinatario.enderDest.UF.ToString())}{Strings.Cep.PadLeft(100, ' ')}{FormatadorDacte.Cep(destinatario.enderDest.CEP, 18)}") : ($"{Strings.Municipio}{Strings.Cep.PadLeft(135, ' ')}"), f3)
                .AddLine(destinatario.xNome != null ? ($"{Strings.CnpjCpf.PadRight(24, ' ')}{Formatador.FormatarCpfCnpj(destinatario.CNPJ)}{Strings.InscricaoEstadual.PadLeft(52, ' ')} {destinatario.IE}") : ($"{Strings.CnpjCpf}{Strings.InscricaoEstadual.PadLeft(104, ' ')}"), f3)
                .AddLine($"{("PAÍS").PadRight(30, ' ')}{destinatario.enderDest.xPais}{("FONE").PadLeft((destinatario.enderDest.xPais != null ? 88 : 103), ' ')}{(destinatario.fone != null ? Formatador.FormatarTelefone(destinatario.fone).PadLeft(20, ' ') : string.Empty.PadLeft(20, ' '))}", f3);

            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda;
            ts.AlinhamentoVertical = AlinhamentoVertical.Centro;
            ts.Draw(gfx);
        }
    }
}