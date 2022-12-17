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
    internal class Recebedor : ElementoBase
    {
        public DacteViewModel ViewModel { get; private set; }
        public XObject Logo { get; set; }

        public Recebedor(Estilo estilo, DacteViewModel viewModel) : base(estilo)
        {
            ViewModel = viewModel;
            Logo = null;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            RectangleF rp = BoundingBox.InflatedRetangle(0.75F);
            Fonte f3 = Estilo.CriarFonteRegular(6);

            var recebedor = ViewModel.Recebedor;
            var ts = new TextStack(rp) { LineHeightScale = 1.5F }
                .AddLine($"{Strings.Recebedor.PadRight(18, ' ')}{recebedor.xNome}", f3)
                .AddLine($"{Strings.Endereco.PadRight(19, ' ')}{FormatadorDacte.LogradouroCompleto(recebedor.enderReceb.xLgr, recebedor.enderReceb.nro, recebedor.enderReceb.xCpl)}", f3)
                .AddLine($"{string.Empty.PadRight(33, ' ')}{recebedor.enderReceb.xBairro}", f3)
                .AddLine(recebedor.xNome != null ? ($"{Strings.Municipio.PadRight(22, ' ')}{Formatador.FormatarMunicipioUf(recebedor.enderReceb.xMun, recebedor.enderReceb.UF.ToString())}{Strings.Cep.PadLeft(100, ' ')}{FormatadorDacte.Cep(recebedor.enderReceb.CEP, 18)}") : ($"{Strings.Municipio}{Strings.Cep.PadLeft(135, ' ')}"), f3)
                .AddLine(recebedor.xNome != null ? ($"{Strings.CnpjCpf.PadRight(24, ' ')}{Formatador.FormatarCpfCnpj(recebedor.CNPJ)}{Strings.InscricaoEstadual.PadLeft(52, ' ')} {recebedor.IE}") : ($"{Strings.CnpjCpf}{Strings.InscricaoEstadual.PadLeft(104, ' ')}"), f3)
                .AddLine($"{("PAÍS").PadRight(30, ' ')}{recebedor.enderReceb.xPais}{("FONE").PadLeft((recebedor.enderReceb.xPais != null ? 88 : 103), ' ')}{(recebedor.fone != null ? Formatador.FormatarTelefone(recebedor.fone).PadLeft(20, ' ') : string.Empty.PadLeft(20, ' '))}", f3);

            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda;
            ts.AlinhamentoVertical = AlinhamentoVertical.Centro;
            ts.Draw(gfx);
        }
    }
}