using System;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    class TextoCanhotoAereo : ElementoBase
    {

        public TextoCanhotoAereo(Estilo estilo) : base(estilo)
        {

        }

        public override void Draw(Gfx gfx)
        {
            try
            {
                base.Draw(gfx);
                var r = BoundingBox.InflatedRetangle(1);
                Fonte f2 = Estilo.CriarFonteRegular(5);
                gfx.DrawString("O transporte coberto por este conhecimento de transporte rege - se pelo Código Brasileiro de Aeronáutica - Lei n° 7.565, de 19 / 12 / 1986 - e pelas regulamentações da ANAC, de cujo teor o expedidor / remetente declara ter plena ciência.", r, f2, AlinhamentoHorizontal.Centro);
                var ts = new TextStack(r) { LineHeightScale = 1 }
                .AddLine("O expedidor/remetente aceita como corretas todas as especificações contidas neste documento, certificando que a carga, incluíndo o artigo perigoso, foi devidamente declarada e acondicionada para o transporte aéreo.", f2);
                ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Centro;
                ts.AlinhamentoVertical = AlinhamentoVertical.Centro;
                ts.Height = 8;
                ts.Draw(gfx);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                gfx.Flush();
            }

        }
    }
}