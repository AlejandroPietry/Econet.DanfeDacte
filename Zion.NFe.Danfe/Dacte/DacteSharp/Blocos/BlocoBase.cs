using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using org.pdfclown.documents;
using org.pdfclown.documents.contents.fonts;
using org.pdfclown.files;
using System;
using Zion.NFe.Danfe;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;

namespace DacteSharp.Blocos
{
    internal abstract class BlocoBaseDacte : ElementoBase
    {
        /// <summary>
        /// Constante de proporção dos campos para o formato retrato A4, porcentagem dividida pela largura desenhável.
        /// </summary>
        public const float Proporcao = 100F / 200F;

        public DacteViewModel ViewModel { get; private set; }

        public abstract PosicaoBloco Posicao { get; }

        /// <summary>
        /// Pilha principal.
        /// </summary>
        public VerticalStack MainVerticalStack { get; private set; }

        /// <summary>
        /// Quando verdadeiro, o bloco é mostrado apenas na primeira página, caso contário é mostrado em todas elas.
        /// </summary>
        public virtual Boolean VisivelSomentePrimeiraPagina => true;

        public virtual String Cabecalho => null;

        public BlocoBaseDacte(DacteViewModel viewModel, Estilo estilo) : base(estilo)
        {
            MainVerticalStack = new VerticalStack();
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));

            if (!String.IsNullOrWhiteSpace(Cabecalho))
            {
                MainVerticalStack.Add(new CabecalhoBloco(estilo, Cabecalho));
            }
        }

        public LinhaCampos AdicionarLinhaCampos(bool tamanhoFonte = false)
        {
            File File = new File();
            Document PdfDocument = File.Document;
            StandardType1Font.FamilyEnum _FonteFamilia;
            StandardType1Font _FonteRegular;
            StandardType1Font _FonteNegrito;
            StandardType1Font _FonteItalico;
            if (tamanhoFonte)
            {
                _FonteFamilia = StandardType1Font.FamilyEnum.Times;
                _FonteRegular = new StandardType1Font(PdfDocument, _FonteFamilia, false, false);
                _FonteNegrito = new StandardType1Font(PdfDocument, _FonteFamilia, true, false);
                _FonteItalico = new StandardType1Font(PdfDocument, _FonteFamilia, false, true);
                var estilo = new Estilo(_FonteRegular, _FonteNegrito, _FonteItalico, 5, 10);
                Estilo = estilo;
            }
            var l = new LinhaCampos(Estilo, Width);
            l.Width = Width;
            l.Height = Constantes.CampoAltura;

            MainVerticalStack.Add(l);
            return l;
        }

        public LinhaCampos AdicionarLinhaCamposTabelas(float altura, bool printarLinha = false)
        {
            var l = new LinhaCampos(Estilo, Width);
            l.Width = Width;
            l.Height = altura;
            if (printarLinha)
                MainVerticalStack.Add(l);

            return l;
        }

        public LinhaCampos AdicionarLinhaCamposTabelas()
        {
            var l = new LinhaCampos(Estilo, Width);
            l.Width = Width;
            l.Height = Constantes.CampoAltura;
            return l;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);
            MainVerticalStack.SetPosition(X, Y);
            MainVerticalStack.Width = Width;
            MainVerticalStack.Draw(gfx);
        }

        public override float Height { get => MainVerticalStack.Height; set => throw new NotSupportedException(); }
        public override bool PossuiContono => false;
    }
}
