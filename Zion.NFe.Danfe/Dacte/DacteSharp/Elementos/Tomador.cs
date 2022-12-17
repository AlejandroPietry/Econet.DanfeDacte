using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using org.pdfclown.documents.contents.xObjects;
using System.Drawing;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    internal class Tomador : ElementoBase
    {
        public DacteViewModel ViewModel { get; private set; }
        public XObject Logo { get; set; }

        public Tomador(Estilo estilo, DacteViewModel viewModel) : base(estilo)
        {
            ViewModel = viewModel;
            Logo = null;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            RectangleF rp = BoundingBox.InflatedRetangle(0.75F);
            Fonte f2 = Estilo.CriarFonteNegrito(6);
            Fonte f3 = Estilo.CriarFonteRegular(6);

            var tomador = ViewModel.Tomador;
            var ts = new TextStack(rp) { LineHeightScale = 1.3F, AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda }
                .AddLine($"TOMADOR DO SERVIÇO     {tomador.Nome}{Strings.Municipio.PadLeft(22, ' ')}{(tomador.Municipio != null ? tomador.Municipio.PadLeft(15, ' ') : null)}{Strings.UF.PadLeft(25, ' ')}{(tomador != null && tomador.Uf != null ? tomador.Uf.PadLeft(3, ' ') : null)}{Strings.Cep.PadLeft(38, ' ')}{(tomador.Cep != null ? tomador.Cep.PadLeft(16, ' ') : null)}", f3)
                .AddLine($"ENDEREÇO     {tomador.Endereco} {tomador.Bairro}", f3)
                .AddLine($"CNPJ/CPJ     {tomador.Cnpj}{Strings.InscricaoEstadual.PadLeft(57, ' ')}{(tomador.IE != null ? tomador.IE.PadLeft(15, ' ') : null)}{Strings.Pais.PadLeft(47, ' ')}{(tomador != null && tomador.Pais != null ? tomador.Pais.PadLeft(15, ' ') : null)}{Strings.Telefone.PadLeft(25, ' ')}{(tomador.Fone != null ? tomador.Fone.PadLeft(35, ' ') : null)}", f3);

            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda;
            ts.AlinhamentoVertical = AlinhamentoVertical.Centro;
            ts.Draw(gfx);
        }
    }
}