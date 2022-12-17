using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using org.pdfclown.documents.contents.fonts;
using System.Text;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoObservacoes : BlocoBaseDacte
    {
        public BlocoObservacoes(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            org.pdfclown.files.File File = new org.pdfclown.files.File();
            org.pdfclown.documents.Document PdfDocument = File.Document;
            StandardType1Font.FamilyEnum _FonteFamilia;
            StandardType1Font _FonteRegular;
            StandardType1Font _FonteNegrito;
            StandardType1Font _FonteItalico;
            _FonteFamilia = StandardType1Font.FamilyEnum.Times;
            _FonteRegular = new StandardType1Font(PdfDocument, _FonteFamilia, false, false);
            _FonteNegrito = new StandardType1Font(PdfDocument, _FonteFamilia, true, false);
            _FonteItalico = new StandardType1Font(PdfDocument, _FonteFamilia, false, true);
            var estilo = new Estilo(_FonteRegular, _FonteNegrito, _FonteItalico, 1, 5);
            Estilo = estilo;
            StringBuilder sb = new StringBuilder();
            sb.Append(viewModel.Observacoes).Replace(";", "\r\n");
            AdicionarLinhaCamposTabelas(10, true)
                .ComElemento(new CampoMultilinha(null, sb.ToString(), Estilo))
                .ComLarguras(100);
        }
        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override string Cabecalho => "OBSERVAÇÕES";

    }
}
