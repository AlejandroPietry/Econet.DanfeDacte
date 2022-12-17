using ECONET.EcoNFe2.Negocio.Dacte;
using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using org.pdfclown.documents.contents.xObjects;
using System;
using System.Drawing;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    internal class Rementente : ElementoBase
    {
        public DacteViewModel ViewModel { get; private set; }
        public XObject Logo { get; set; }

        public Rementente(Estilo estilo, DacteViewModel viewModel) : base(estilo)
        {
            ViewModel = viewModel;
            Logo = null;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            RectangleF rp = BoundingBox.InflatedRetangle(0.75F);
            Fonte f3 = Estilo.CriarFonteRegular(6);

            var rementente = ViewModel.Remetente;
            var ts = new TextStack(rp) { LineHeightScale = 1.5F }
                .AddLine($"{Strings.Remetente.PadRight(18, ' ')}{(!String.IsNullOrWhiteSpace(rementente.xNome) ? rementente.xNome.Trim() : rementente.xFant.Trim())}", f3)
                .AddLine($"{Strings.Endereco.PadRight(19, ' ')}{FormatadorDacte.LogradouroCompleto(rementente.enderReme.xLgr, rementente.enderReme.nro, rementente.enderReme.xCpl)}", f3)
                .AddLine($"{string.Empty.PadRight(33, ' ')} {rementente.enderReme.xBairro}", f3)
                .AddLine(rementente.xNome != null ? ($"{Strings.Municipio.PadRight(22, ' ')}{Formatador.FormatarMunicipioUf(rementente.enderReme.xMun, rementente.enderReme.UF.ToString())}{Strings.Cep.PadLeft(95, ' ')}{FormatadorDacte.Cep(rementente.enderReme.CEP, 18).PadLeft(5)}") : ($"{Strings.Municipio}{Strings.Cep.PadLeft(143, ' ')}"), f3)
                .AddLine(rementente.xNome != null ? ($"{Strings.CnpjCpf.PadRight(24, ' ')}{Formatador.FormatarCpfCnpj(rementente.Item)}{Strings.InscricaoEstadual.PadLeft(52, ' ')} {rementente.IE}") : ($"{Strings.CnpjCpf}{Strings.InscricaoEstadual.PadLeft(109, ' ')}"), f3)
                .AddLine($"{("PAÍS").PadRight(30, ' ')}{rementente.enderReme.xPais}{("FONE").PadLeft((rementente.enderReme.xPais != null ? 88 : 103), ' ')}{(rementente.fone != null ? Formatador.FormatarTelefone(rementente.fone).PadLeft(20, ' ') : string.Empty.PadLeft(20, ' '))}", f3);

            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda;
            ts.AlinhamentoVertical = AlinhamentoVertical.Centro;
            ts.Draw(gfx);
        }
    }
}