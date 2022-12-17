using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using org.pdfclown.documents.contents.xObjects;
using System.Drawing;
using Zion.NFe.Danfe;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp.Blocos
{
    internal class BlocoIdentificacaoEmitenteDacte : BlocoBaseDacte
    {
        public const float LarguraCampoChaveNFe = 93F;
        public const float AlturaLinha1 = 30;
        QuadroDacte qdDacte;
        IdentificacaoEmitente idEmitente;
        public const float AlturaColuna3Linha1 = 10F;
        private IndicadorGlobalizado indGlob;

        public BlocoIdentificacaoEmitenteDacte(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            var textoConsulta = new TextoSimples(Estilo, Strings.TextoConsulta)
            {
                Height = 6,
                AlinhamentoHorizontal = AlinhamentoHorizontal.Centro,
                AlinhamentoVertical = AlinhamentoVertical.Centro,
                TamanhoFonte = 9
            };

            var campoChaveAcesso = new Campo("Chave de Acesso", Formatador.FormatarChaveAcesso(ViewModel.ChaveAcesso), estilo, AlinhamentoHorizontal.Centro) { Height = Constantes.CampoAltura };
            var codigoBarras = new Barcode128C(viewModel.ChaveAcesso, Estilo) { Height = AlturaLinha1 - textoConsulta.Height - campoChaveAcesso.Height };

            qdDacte = new QuadroDacte(estilo, ViewModel);
            var el = AdicionarLinhaCamposTabelas(11)
             .ComElemento(qdDacte)
             .ComElemento(new Campo("Modal", Modal(viewModel.Modal), estilo, AlinhamentoHorizontal.Centro) { Height = 7 })
             .ComLarguras(62.8F, 37.2F);


            Estilo estiloTamanhoLabel = estilo;
            estiloTamanhoLabel.FonteTamanhoMinimo = 4;
            //if (viewModel.Destinatario == null)
            //viewModel.Destinatario = new TCTeInfCteDest();

            var descDacte = AdicionarLinhaCamposTabelas(AlturaColuna3Linha1)
            .ComElemento(new Campo("MODELO", Modelo(viewModel.Modelo), estilo, AlinhamentoHorizontal.Centro))
            .ComElemento(new Campo("SÉRIE", viewModel.Serie, estilo, AlinhamentoHorizontal.Centro))
            .ComElemento(new Campo("NÚMERO", viewModel.CTeNumero, estilo, AlinhamentoHorizontal.Centro))
            //.ComElemento(new Campo("FL", null, estilo, AlinhamentoHorizontal.Centro))
            .ComElemento(new Campo("DATA E HORA DE EMISSÃO", viewModel.DataHoraEmissao.ToString(), estiloTamanhoLabel, AlinhamentoHorizontal.Centro))
            .ComElemento(new Campo("INSC. SUFRAMA DO DESTINATÁRIO", viewModel.Destinatario.ISUF.ToString(), estiloTamanhoLabel, AlinhamentoHorizontal.Centro))
            .ComLarguras(10F, 8F, 21F, 23.8F, 37.2F);

            var coluna3 = new VerticalStack();
            coluna3.Add(el, descDacte, codigoBarras);
            idEmitente = new IdentificacaoEmitente(Estilo, ViewModel);
            FlexibleLine fl = new FlexibleLine() { Height = coluna3.Height }
            .ComElemento(idEmitente)
            .ComElemento(coluna3)
            .ComLarguras(0, 60F);
            MainVerticalStack.Add(fl);

            CarregaTipoServico(textoConsulta, campoChaveAcesso);

            AdicionarLinhaCamposTabelas(10, true)
                .ComCampo("CFOP - NATUREZA DA PRESTAÇÃO ", string.Concat(ViewModel.CFOP, "-", viewModel.NaturezaOperacao), AlinhamentoHorizontal.Centro)
                .ComCampo("PROTOCOLO DE AUTORIZAÇÃO DE USO", ViewModel.ProtocoloAutorizacao, AlinhamentoHorizontal.Centro)
                .ComLarguras(40F, 60F);
        }

        private void CarregaTipoServico(TextoSimples textoConsulta, Campo campoChaveAcesso)
        {
            if (ViewModel.Modal == TModTransp.Item01 && ViewModel.Modelo == TModCT.Item67)
            {

                var tipos = AdicionarLinhaCamposTabelas(16)
                   .ComCampo("TIPO DO CTE", TipoCte(ViewModel.TipoCte))
                   .ComCampo("TIPO DO SERVIÇO", TipoServico(ViewModel.TipoServico), AlinhamentoHorizontal.Centro)
                   .ComLargurasIguais();

                campoChaveAcesso.Height = 8;
                textoConsulta.Height = 8;
                var colunaS = new VerticalStack();
                colunaS.Add(campoChaveAcesso, textoConsulta);
                FlexibleLine flX = new FlexibleLine() { Height = tipos.Height }
                 .ComElemento(tipos)
                 .ComElemento(colunaS)
                 .ComLarguras(40, 60);
                MainVerticalStack.Add(flX);
            }
            else
            {
                AdicionarLinhaCampos()
              .ComCampo("TIPO DO CTE", TipoCte(ViewModel.TipoCte))
              .ComCampo("TIPO DO SERVIÇO", TipoServico(ViewModel.TipoServico), AlinhamentoHorizontal.Centro)
              .ComElemento(campoChaveAcesso)
              .ComLarguras(20F, 20F, 60F);
                float paddingHorizontal = ViewModel.Orientacao == Orientacao.Retrato ? 2.5F : 5F;
                var rp = BoundingBox.InflatedRetangle(0.75F);
                Fonte f2 = Estilo.CriarFonteNegrito(12);
                Fonte f3 = Estilo.CriarFonteNegrito(8);
                indGlob = new IndicadorGlobalizado(Estilo, ViewModel);
                var informacoesCte = AdicionarLinhaCamposTabelas(10)
                   .ComCampo("INFORMAÇÕES DO CT-E GLOBALIZADO", null, AlinhamentoHorizontal.Centro)
                   .ComLargurasIguais();
                AdicionarLinhaCamposTabelas(8, true)
                 .ComElemento(indGlob)
                 .ComElemento(informacoesCte)
                 .ComElemento(textoConsulta)
                 .ComLarguras(20F, 20F, 60F);
            }
        }

        public XObject Logo
        {
            get => idEmitente.Logo;
            set => idEmitente.Logo = value;
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Topo;

        public override bool VisivelSomentePrimeiraPagina => false;

        public RectangleF RetanguloNumeroFolhas => qdDacte.RetanguloNumeroFolhas;


        private string TipoCte(int tipo)
        {
            switch (tipo)
            {
                case 0:
                    return "NORMAL";
                case 1:
                    return "COMPLEMENTO";
                case 2:
                    return "ANULAÇÃO";
                default:
                    return "SUBSTITUTO";
            }
        }

        private string Modal(TModTransp modal)
        {
            switch (modal)
            {
                case TModTransp.Item01:
                    return "Rodoviário";
                case TModTransp.Item02:
                    return "Aéreo";
                case TModTransp.Item03:
                    return "Aquaviário";
                case TModTransp.Item04:
                    return "Ferroviário";
                case TModTransp.Item05:
                    return "Dutoviário";
                case TModTransp.Item06:
                    return "Multimodal";
                default:
                    return "";
            }
        }

        private string Modelo(TModCT model)
        {
            switch (model)
            {
                case TModCT.Item57:
                    return "57";
                case TModCT.Item67:
                    return "67";
                default:
                    return "";
            }
        }

        private string TipoServico(TCTeInfCteIdeTpServ tipoServico)
        {
            switch (tipoServico)
            {
                case TCTeInfCteIdeTpServ.Item0:
                    return "NORMAL";
                case TCTeInfCteIdeTpServ.Item1:
                    return "SUBCONTRATAÇÃO";
                case TCTeInfCteIdeTpServ.Item2:
                    return "REDESPACHO";
                case TCTeInfCteIdeTpServ.Item3:
                    return "REDESPACHO INTERMEDIÁRIO";
                case TCTeInfCteIdeTpServ.Item4:
                    return "SERV.VINC.MULTIMODAL";
                default:
                    return "";
            }
        }

    }
}
