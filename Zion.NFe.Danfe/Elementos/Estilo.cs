using Zion.NFe.Danfe.Graphics;
using pcf = org.pdfclown.documents.contents.fonts;

namespace Zion.NFe.Danfe.Elementos
{
    /// <summary>
    /// Coleção de fontes e medidas a serem compartilhadas entre os elementos básicos.
    /// </summary>
    internal class Estilo
    {
        public float PaddingSuperior { get; set; }
        public float PaddingInferior { get; set; }
        public float PaddingHorizontal { get; set; }
        public float FonteTamanhoMinimo { get; set; }
        public float OffsetCabecalhoCampo { get; set; }
        public float OffsetConteudoCampo { get; set; }
        public float OffsetConteudoCampoMultilinha { get; set; }
        public float OffsetTextoSimples { get; set; }
        public float OffsetCabecalhoBloco { get; set; }
        public float OffsetCabecalhoBlocoDanfe { get; set; }
        public float OffsetCabecalhoCampoCentralizado { get; set; }
        public float OffsetSiglaDocumento { get; set; }
        public float OffsetTituloDocumentoPrincipal { get; set; }
        public float OffsetSubtituloDocumentoPrincipal { get; set; }
        public float OffsetIdentificacaoEmitente { get; set; }
        public float OffsetCreditosDanfe { get; set; }
        public float OffsetNumeroFolhasDanfe { get; set; }
        public float OffsetTituloDanfePrincipal { get; set; }
        public float OffsetTipoNfDanfe { get; set; }
        public float OffsetNumeroSerieDanfe { get; set; }

        public pcf.Font FonteInternaRegular { get; set; }
        public pcf.Font FonteInternaNegrito { get; set; }
        public pcf.Font FonteInternaItalico { get; set; }

        public Fonte FonteCampoCabecalho { get; private set; }
        public Fonte FonteCampoConteudo { get; private set; }
        public Fonte FonteCampoConteudoNegrito { get; private set; }
        public Fonte FonteBlocoCabecalho { get; private set; }
        public Fonte FonteNumeroFolhas { get; private set; }

        public Estilo(pcf.Font fontRegular, pcf.Font fontBold, pcf.Font fontItalic, float tamanhoFonteCampoCabecalho = 6, float tamanhoFonteConteudo = 10)
        {
            PaddingHorizontal = 0.75F;
            PaddingSuperior = 0.9F;
            PaddingInferior = 0.2F;
            OffsetCabecalhoCampo = 1.2F;
            OffsetConteudoCampo = 3.0F;
            OffsetConteudoCampoMultilinha = 1.2F;
            OffsetTextoSimples = 3.2F;
            OffsetCabecalhoBloco = 0.9F;
            OffsetCabecalhoBlocoDanfe = 1.6F;
            OffsetCabecalhoCampoCentralizado = 0.9F;
            OffsetSiglaDocumento = 3.0F;
            OffsetTituloDocumentoPrincipal = 0.9F;
            OffsetSubtituloDocumentoPrincipal = 0.9F;
            OffsetIdentificacaoEmitente = 0.9F;
            OffsetCreditosDanfe = 0.9F;
            OffsetNumeroFolhasDanfe = 4.2F;
            OffsetTituloDanfePrincipal = 2.0F;
            OffsetTipoNfDanfe = 3.0F;
            OffsetNumeroSerieDanfe = 6.0F;

            FonteInternaRegular = fontRegular;
            FonteInternaNegrito = fontBold;
            FonteInternaItalico = fontItalic;

            FonteCampoCabecalho = CriarFonteRegular(tamanhoFonteCampoCabecalho);
            FonteCampoConteudo = CriarFonteRegular(tamanhoFonteConteudo);
            FonteCampoConteudoNegrito = CriarFonteNegrito(tamanhoFonteConteudo);
            FonteBlocoCabecalho = CriarFonteRegular(7);
            FonteNumeroFolhas = CriarFonteNegrito(10F);
            FonteTamanhoMinimo = 5.75F;
        }

        public Fonte CriarFonteRegular(float emSize) => new Fonte(FonteInternaRegular, emSize);
        public Fonte CriarFonteNegrito(float emSize) => new Fonte(FonteInternaNegrito, emSize);
        public Fonte CriarFonteItalico(float emSize) => new Fonte(FonteInternaItalico, emSize);

    }
}
