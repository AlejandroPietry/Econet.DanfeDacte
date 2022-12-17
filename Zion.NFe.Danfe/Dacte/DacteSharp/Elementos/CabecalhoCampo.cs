using System;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;

namespace DacteSharp
{
    /// <summary>
    /// Cabeçalho do bloco, normalmente um texto em caixa alta.
    /// </summary>
    internal class CabecalhoCampo : ElementoBase
    {
        public const float MargemSuperior = 0.8F;
        public String Cabecalho { get; set; }

        public CabecalhoCampo(Estilo estilo, String cabecalho) : base(estilo)
        {
            Cabecalho = cabecalho ?? throw new ArgumentNullException(cabecalho);
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);
            gfx.DrawString(Cabecalho.ToUpper(), BoundingBox, Estilo.FonteBlocoCabecalho,
                AlinhamentoHorizontal.Centro, AlinhamentoVertical.Base);
        }
    }
}
