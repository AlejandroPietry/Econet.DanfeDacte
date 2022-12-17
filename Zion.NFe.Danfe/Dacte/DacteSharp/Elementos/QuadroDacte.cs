using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System.Drawing;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    class QuadroDacte : ElementoBase
    {

        public RectangleF RetanguloNumeroFolhas { get; private set; }
        public DacteViewModel ViewModel { get; private set; }

        public QuadroDacte(Estilo estilo, DacteViewModel viewModel) : base(estilo)
        {
            ViewModel = viewModel;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            float paddingHorizontal = ViewModel.Orientacao == Orientacao.Retrato ? 2.5F : 5F;

            var rp1 = BoundingBox.InflatedRetangle(1F, 0.5F, paddingHorizontal);
            var rp2 = rp1;

            var f1 = Estilo.CriarFonteNegrito(10);
            var f1h = f1.AlturaLinha;
            gfx.DrawString("DACTE", rp2, f1, AlinhamentoHorizontal.Centro);

            rp2 = rp2.CutTop(f1h + 0.5F);

            var f2 = Estilo.CriarFonteNegrito(8F);
            var f2h = (float)f2.AlturaLinha;

            var ts = new TextStack(rp2)
            {
                AlinhamentoVertical = AlinhamentoVertical.Topo,
                AlinhamentoHorizontal = AlinhamentoHorizontal.Centro
            }
            .AddLine("Documento Auxiliar do Conhecimento", f2)
            .AddLine("de Transporte Eletrônico", f2);

            ts.Draw(gfx);

            float rectEsSize = 0.75F * f2h;
            var rectEs = new RectangleF(rp2.Right - rectEsSize, rp2.Y + (0.75F * f2h - rectEsSize) / 0.75F, rectEsSize, rectEsSize);

            var f4 = Estilo.FonteNumeroFolhas;
            var f4h = Estilo.FonteNumeroFolhas.AlturaLinha;

            rp2.Height = 2F * f4h * TextStack.DefaultLineHeightScale + f2h;
            rp2.Y = rp1.Bottom - rp2.Height;

            RetanguloNumeroFolhas = new RectangleF(rp1.Left, rp1.Bottom - Estilo.FonteNumeroFolhas.AlturaLinha, rp1.Width, Estilo.FonteNumeroFolhas.AlturaLinha);


        }
    }
}