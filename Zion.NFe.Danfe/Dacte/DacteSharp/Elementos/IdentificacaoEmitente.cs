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
    internal class IdentificacaoEmitente : ElementoBase
    {
        public DacteViewModel ViewModel { get; private set; }
        public XObject Logo { get; set; }

        public IdentificacaoEmitente(Estilo estilo, DacteViewModel viewModel) : base(estilo)
        {
            ViewModel = viewModel;
            Logo = null;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            // 7.7.6 Conteúdo do Quadro Dados do Emitente
            // Deverá estar impresso em negrito.A razão social e/ ou nome fantasia deverá ter tamanho
            // mínimo de doze(12) pontos, ou 17 CPP e os demais dados do emitente, endereço,
            // município, CEP, fone / fax deverão ter tamanho mínimo de oito(8) pontos, ou 17 CPP.

            var rp = BoundingBox.InflatedRetangle(0.75F);
            float alturaMaximaLogoHorizontal = 14F;

            Fonte f2 = Estilo.CriarFonteNegrito(12);
            Fonte f3 = Estilo.CriarFonteRegular(8);

            if (Logo == null)
            {
                var f1 = Estilo.CriarFonteRegular(6);
                gfx.DrawString("IDENTIFICAÇÃO DO EMITENTE", rp, f1, AlinhamentoHorizontal.Centro);
                rp = rp.CutTop(f1.AlturaLinha);
            }
            else
            {
                RectangleF rLogo;

                if (Logo.Size.Width >= Logo.Size.Height)
                {
                    rLogo = new RectangleF(rp.X, rp.Y, rp.Width, alturaMaximaLogoHorizontal);
                    rp = rp.CutTop(alturaMaximaLogoHorizontal);
                }
                else
                {
                    float lw = rp.Height * Logo.Size.Width / Logo.Size.Height;
                    rLogo = new RectangleF(rp.X, rp.Y, lw, rp.Height);
                    rp = rp.CutLeft(lw);
                }

                gfx.ShowXObject(Logo, rLogo);
            }

            var emitente = ViewModel.Emitente;
            var nome = !String.IsNullOrWhiteSpace(emitente.xNome) ? emitente.xNome : emitente.xFant;
            var logradouroCompleto = string.Concat(emitente.enderEmit.xLgr, ", ", emitente.enderEmit.nro, ", ", emitente.enderEmit.xCpl);
            var bairroMunUF = string.Concat(emitente.enderEmit.xBairro, " - ", " CEP: ", Formatador.FormatarCEP(emitente.enderEmit.CEP), " - ", Formatador.FormatarMunicipioUf(emitente.enderEmit.xMun, emitente.enderEmit.UF.ToString()));
            var foneCep = string.Concat("Fone/Fax: ", Formatador.FormatarTelefone(emitente.enderEmit.fone));
            var cnpjCpf = string.Concat("CNPJ / CPF: ", Formatador.FormatarCpfCnpj(emitente.CNPJ), " ", "Insc.Estadual: ", emitente.IE);
            var ts = new TextStack(rp) { LineHeightScale = 1 }
                .AddLine(nome, f2)
                .AddLine(" ", f2)
                .AddLine(logradouroCompleto.Trim(), f3)
                .AddLine(bairroMunUF.Trim(), f3)
                .AddLine(foneCep.Trim(), f3)
                .AddLine(" ", f2)
                .AddLine(cnpjCpf, f3)
                .AddLine(" ", f3);

            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Centro;
            ts.AlinhamentoVertical = AlinhamentoVertical.Centro;
            ts.Draw(gfx);
        }
    }
}