using System;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    class NumeroNfSerie : ElementoBase
    {
        public String ctNumero { get; private set; }
        public String ctSerie { get; private set; }

        public NumeroNfSerie(Estilo estilo, String _ctNumero, String _ctSerie) : base(estilo)
        {
            ctNumero = _ctNumero;
            ctSerie = _ctSerie;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            var r = BoundingBox.InflatedRetangle(1);

            var f2 = Estilo.CriarFonteNegrito(11F);
            var f3 = Estilo.CriarFonteRegular(9.25F);

            gfx.DrawString("CT-E", r, Estilo.CriarFonteNegrito(14), AlinhamentoHorizontal.Centro);

            r = r.CutTop(Estilo.CriarFonteNegrito(14).AlturaLinha);

            TextStack ts = new TextStack(r)
            {
                AlinhamentoHorizontal = AlinhamentoHorizontal.Centro,
                AlinhamentoVertical = AlinhamentoVertical.Centro,
                LineHeightScale = 1F
            }
            .AddLine($"Nº DOCUMENTO  {ctNumero}", f3)
            .AddLine(" ", f3)
            .AddLine($"SÉRIE  {ctSerie}", f3);

            ts.Draw(gfx);

        }
    }
}