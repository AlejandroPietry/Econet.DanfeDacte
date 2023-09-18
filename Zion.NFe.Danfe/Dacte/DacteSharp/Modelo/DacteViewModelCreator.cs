using DanfeSharp.Esquemas.NFe;
using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Tools;
using Zion.NFe.Danfe.Tools.Extensions;
using static ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo.DacteViewModel;
using cteIsolado = Zion.NFe.Danfe.Dacte.isolado;

namespace DacteSharp.Modelo
{
    public static class DacteViewModelCreator
    {

        /// <summary>
        /// Cria o modelo a partir de uma string xml.
        /// </summary>
        public static DacteViewModel Criar57DeStringXml(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            using (StringReader sr = new StringReader(str))
            {
                return Criar57DeArquivoXmlInternal(sr);
            }
        }

        /// <summary>
        /// Cria o modelo a partir de uma string xml.
        /// </summary>
        public static DacteViewModel Criar67DeStringXml(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            using (StringReader sr = new StringReader(str))
            {
                return Criar67DeArquivoXmlInternal(sr);
            }
        }

        private static DacteViewModel Criar57DeArquivoXmlInternal(TextReader reader)
        {
            try
            {
                cteProc cte = null;
                XmlSerializer serializer = new XmlSerializer(typeof(cteProc));
                cte = (cteProc)serializer.Deserialize(reader);
                return CreateFromXml(cte);
            }
            catch (System.InvalidOperationException e)
            {
                if (e.InnerException is XmlException)
                {
                    XmlException ex = (XmlException)e.InnerException;
                    throw new Exception(String.Format("Não foi possível interpretar o Xml. Linha {0} Posição {1}.", ex.LineNumber, ex.LinePosition));
                }

                throw new XmlException("O Xml não parece ser uma NF-e processada.", e);
            }
        }

        private static DacteViewModel Criar67DeArquivoXmlInternal(TextReader reader)
        {
            try
            {
                cteIsolado.cteOSProc cteOs = null;
                XmlSerializer serializerOs = new XmlSerializer(typeof(cteIsolado.cteOSProc));
                cteOs = (cteIsolado.cteOSProc)serializerOs.Deserialize(reader);
                return CreateFromXml(cteOs);
            }
            catch (System.InvalidOperationException e)
            {
                if (e.InnerException is XmlException)
                {
                    XmlException ex = (XmlException)e.InnerException;
                    throw new Exception(String.Format("Não foi possível interpretar o Xml. Linha {0} Posição {1}.", ex.LineNumber, ex.LinePosition));
                }

                throw new XmlException("O Xml não parece ser uma NF-e processada.", e);
            }
        }


        internal static void ExtrairDatas(DacteViewModel model, InfNFe infNfe)
        {
            var ide = infNfe.ide;

            if (infNfe.Versao.Maior >= 3)
            {
                if (ide.dhEmi.HasValue) model.DataHoraEmissao = ide.dhEmi.Value.DateTimeOffsetValue.DateTime;
                if (ide.dhSaiEnt.HasValue) model.DataSaidaEntrada = ide.dhSaiEnt.Value.DateTimeOffsetValue.DateTime;

                if (model.DataSaidaEntrada.HasValue)
                {
                    model.HoraSaidaEntrada = model.DataSaidaEntrada.Value.TimeOfDay;
                }
            }
            else
            {
                model.DataHoraEmissao = ide.dEmi;
                model.DataSaidaEntrada = ide.dSaiEnt;

                if (!String.IsNullOrWhiteSpace(ide.hSaiEnt))
                {
                    model.HoraSaidaEntrada = TimeSpan.Parse(ide.hSaiEnt);
                }

            }
        }

        private static TomadorViewModel DefineTomador(TCTeInfCte infCte)
        {

            int toma = 4;
            string strToma = String.Empty;
            TCTeInfCteIdeToma3 toma3;
            TCTeInfCteIdeToma4 toma4 = null;
            var tomadorModel = new TomadorViewModel();
            if (infCte.ide.Item != null)
            {
                if (infCte.ide.Item.GetType() == typeof(TCTeInfCteIdeToma3))
                {
                    toma3 = (TCTeInfCteIdeToma3)infCte.ide.Item;
                    strToma = toma3.toma.ToString();
                    toma = int.Parse(strToma.Replace("Item", ""));
                }
                else if (infCte.ide.Item.GetType() == typeof(TCTeInfCteIdeToma4))
                {
                    toma4 = (TCTeInfCteIdeToma4)infCte.ide.Item;
                    strToma = toma4.toma.ToString();
                    toma = int.Parse(strToma.Replace("Item", ""));
                }
            }
            switch (toma)
            {
                case 0: //REMETENTE
                    tomadorModel.Nome = infCte.rem.xNome ?? string.Empty;
                    tomadorModel.Municipio = infCte.rem.enderReme.xMun ?? string.Empty;
                    tomadorModel.Cep = Formatador.FormatarCEP(infCte.rem.enderReme.CEP);
                    tomadorModel.Endereco = Formatador.FormatarEnderecoLinha1(infCte.rem.enderReme.xLgr, infCte.rem.enderReme.nro, infCte.rem.enderReme.xCpl);
                    tomadorModel.Pais = infCte.rem.enderReme.xPais ?? string.Empty;
                    tomadorModel.Cnpj = Formatador.FormatarCpfCnpj(infCte.rem.Item);
                    tomadorModel.IE = infCte.rem.IE ?? string.Empty;
                    tomadorModel.Fone = Formatador.FormatarTelefone(infCte.receb.fone);
                    tomadorModel.Uf = infCte.rem.enderReme.ProxyUF ?? string.Empty;
                    tomadorModel.Bairro = infCte.rem.enderReme.xBairro;
                    break;
                case 1: //Expedidor
                    tomadorModel.Nome = infCte.exped.xNome ?? string.Empty;
                    tomadorModel.Municipio = infCte.exped.enderExped.xMun ?? string.Empty;
                    tomadorModel.Cep = Formatador.FormatarCEP(infCte.exped.enderExped.CEP);
                    tomadorModel.Endereco = Formatador.FormatarEnderecoLinha1(infCte.exped.enderExped.xLgr, infCte.exped.enderExped.nro, infCte.exped.enderExped.xCpl);
                    tomadorModel.Pais = infCte.exped.enderExped.xPais ?? string.Empty;
                    tomadorModel.Cnpj = Formatador.FormatarCpfCnpj(infCte.exped.Item);
                    tomadorModel.IE = infCte.exped.IE ?? string.Empty;
                    tomadorModel.Fone = Formatador.FormatarTelefone(infCte.receb.fone);
                    tomadorModel.Uf = infCte.exped.enderExped.ProxyUF ?? string.Empty;
                    tomadorModel.Bairro = infCte.receb.enderReceb.xBairro;
                    break;
                case 2: //Recebedor
                    tomadorModel.Nome = infCte.receb.xNome ?? string.Empty;
                    tomadorModel.Municipio = infCte.receb.enderReceb.xMun ?? string.Empty;
                    tomadorModel.Cep = Formatador.FormatarCEP(infCte.receb.enderReceb.CEP);
                    tomadorModel.Endereco = Formatador.FormatarEnderecoLinha1(infCte.receb.enderReceb.xLgr, infCte.receb.enderReceb.nro, infCte.receb.enderReceb.xCpl);
                    tomadorModel.Pais = infCte.receb.enderReceb.xPais ?? string.Empty;
                    tomadorModel.Cnpj = Formatador.FormatarCpfCnpj(infCte.receb.CNPJ != null ? infCte.receb.CNPJ : infCte.receb.CPF);
                    tomadorModel.IE = infCte.receb.IE ?? string.Empty;
                    tomadorModel.Fone = Formatador.FormatarTelefone(infCte.receb.fone);
                    tomadorModel.Uf = infCte.receb.enderReceb.ProxyUF ?? string.Empty;
                    tomadorModel.Bairro = infCte.receb.enderReceb.xBairro;
                    break;
                case 3: //Destinatário
                    tomadorModel.Nome = infCte.dest.xNome ?? string.Empty;
                    tomadorModel.Municipio = infCte.dest.enderDest.xMun ?? string.Empty;
                    tomadorModel.Cep = Formatador.FormatarCEP(infCte.dest.enderDest.CEP);
                    tomadorModel.Endereco = Formatador.FormatarEnderecoLinha1(infCte.dest.enderDest.xLgr, infCte.dest.enderDest.nro, infCte.dest.enderDest.xCpl);
                    tomadorModel.Pais = infCte.dest.enderDest.xPais ?? string.Empty;
                    tomadorModel.Cnpj = Formatador.FormatarCpfCnpj(infCte.dest.CNPJ != null ? infCte.dest.CNPJ : infCte.dest.CPF);
                    tomadorModel.IE = infCte.dest.IE ?? string.Empty;
                    tomadorModel.Fone = Formatador.FormatarTelefone(infCte.dest.fone);
                    tomadorModel.Uf = infCte.dest.enderDest.ProxyUF ?? string.Empty;
                    tomadorModel.Bairro = infCte.dest.enderDest.xBairro;
                    break;
                case 4: //Outros
                    tomadorModel.Nome = toma4 != null ? toma4.xNome : string.Empty;
                    tomadorModel.Municipio = toma4 != null ? toma4.enderToma.xMun : string.Empty;
                    tomadorModel.Cep = toma4 != null ? Formatador.FormatarCEP(toma4.enderToma.CEP) : string.Empty;
                    tomadorModel.Endereco = toma4 != null ? Formatador.FormatarEnderecoLinha1(toma4.enderToma.xLgr, toma4.enderToma.nro, toma4.enderToma.xCpl) : string.Empty;
                    tomadorModel.Pais = toma4 != null ? toma4.enderToma.xPais : string.Empty;
                    tomadorModel.Cnpj = toma4 != null ? Formatador.FormatarCpfCnpj(toma4.Item) : string.Empty;
                    tomadorModel.IE = toma4 != null ? toma4.IE ?? string.Empty : string.Empty;
                    tomadorModel.Fone = toma4 != null ? Formatador.FormatarTelefone(toma4.fone) : string.Empty;
                    tomadorModel.Uf = toma4 != null ? toma4.enderToma.ProxyUF : string.Empty;
                    tomadorModel.Bairro = toma4 != null ? toma4.enderToma.xBairro : string.Empty;
                    break;
            }

            return tomadorModel;
        }

        private static InformacoesProdutoCarga InformacaoCarga(TCTeInfCte infCte)
        {
            var informacoesCarga = new TCTeInfCteInfCTeNorm();
            InformacoesProdutoCarga inf = new InformacoesProdutoCarga();

            if (infCte.Item != null)
            {
                if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
                {
                    TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;

                    inf.ProdutoPredominante = norm.infCarga.proPred;
                    inf.OutrasCaracteristicasCarga = norm.infCarga.xOutCat;
                    var valorCarga = norm.infCarga.vCarga != null ? (double)norm.infCarga.vCarga : 0;
                    inf.ValorTotalCarga = Formatador.Formatar(valorCarga) ?? "0m";

                    if (norm.infCarga != null)
                    {
                        if (norm.infCarga.infQ != null)
                        {
                            foreach (var item in norm.infCarga.infQ)
                            {
                                switch (item.cUnid)
                                {
                                    case TCTeInfCteInfCTeNormInfCargaInfQCUnid.Item00:
                                        inf.TipoMedidaPesoCubado = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.PesoCubado = item.qCarga.ToString("N3");
                                        break;
                                    case TCTeInfCteInfCTeNormInfCargaInfQCUnid.Item01:
                                        inf.TipoMedidaPesoBruto = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.PesoBruto = item.qCarga.ToString("N3");
                                        inf.TipoMedidaPesoBaseCalculo = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.PesoBaseCalculo = item.qCarga.ToString("N3");
                                        inf.TipoMedidaPesoDeclarado = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.PesoDeclarado = item.qCarga.ToString("N3");
                                        inf.TipoMedidaPesoAferido = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.PesoAferido = item.qCarga.ToString("N3");

                                        break;
                                    case TCTeInfCteInfCTeNormInfCargaInfQCUnid.Item02:
                                        inf.TipoMedidaPesoBruto = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.PesoBruto = item.qCarga.ToString("N3");
                                        inf.TipoMedidaPesoBaseCalculo = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.PesoBaseCalculo = item.qCarga.ToString("N3");
                                        inf.TipoMedidaPesoDeclarado = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.PesoDeclarado = item.qCarga.ToString("N3");
                                        inf.TipoMedidaPesoAferido = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.PesoAferido = item.qCarga.ToString("N3");
                                        break;
                                    case TCTeInfCteInfCTeNormInfCargaInfQCUnid.Item03:
                                        inf.TipoMedidaQuantidade = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        inf.Quantidade = item.qCarga.ToString("N3");
                                        break;
                                    case TCTeInfCteInfCTeNormInfCargaInfQCUnid.Item04:
                                        //inf.TipoMedidaLitragem = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        //inf.Litragem = item.qCarga.ToString("N3");
                                        break;
                                    case TCTeInfCteInfCTeNormInfCargaInfQCUnid.Item05:
                                        //inf.TipoMedidaPesoAforado = ValidaTipoMedida(Convert.ToInt32(item.cUnid));
                                        //inf.PesoAforado = item.qCarga.ToString("N3");
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            return inf;
        }

        private static string ValidaTipoMedida(int tipoUnidade)
        {
            switch (tipoUnidade)
            {
                case 0:
                    return "(M³)";
                case 1:
                    return "(KG)";
                case 2:
                    return "(TON)";
                case 3:
                    return "(VOL)";
                case 4:
                    return "(LIT)";
                case 5:
                    return "(MMB)";
                default:
                    return null;
            }
        }

        private static InformacoesImpostosViewModel MontaInformacoesImposto(TCTeInfCteImp infCte)
        {
            var informacoesImpostosViewModel = new InformacoesImpostosViewModel();
            if (infCte != null)
            {
                if (infCte.ICMS != null)
                {
                    if (infCte.ICMS.Item != null)
                    {

                        if (infCte.ICMS.Item.GetType() == typeof(TImpICMSSN)) //Simples Nacional
                        {
                            informacoesImpostosViewModel.SituacaoTributaria = "SN - SIMPLES NACIONAL";
                        }
                        else if (infCte.ICMS.Item.GetType() == typeof(TImpICMS00))
                        {
                            TImpICMS00 icms00 = (TImpICMS00)infCte.ICMS.Item;
                            informacoesImpostosViewModel.SituacaoTributaria = "00 - TRIBUTAÇÃO NORMAL DO ICMS";
                            informacoesImpostosViewModel.BaseCalculo = icms00.vBC != null ? double.Parse(icms00.vBC.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.AliquotaIcms = icms00.pICMS != null ? double.Parse(icms00.pICMS.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.ValorIcms = icms00.vICMS != null ? double.Parse(icms00.vICMS.Replace(".", ",")) : 0;
                        }
                        else if (infCte.ICMS.Item.GetType() == typeof(TImpICMS20))
                        {
                            TImpICMS20 icms20 = (TImpICMS20)infCte.ICMS.Item;
                            informacoesImpostosViewModel.SituacaoTributaria = "20 - TRIBUTAÇÃO COM REDUÇÃO DE BC DO ICMS";
                            informacoesImpostosViewModel.BaseCalculo = icms20.vBC != null ? double.Parse(icms20.vBC.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.AliquotaIcms = icms20.pICMS != null ? double.Parse(icms20.pICMS.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.ValorIcms = icms20.vICMS != null ? double.Parse(icms20.vICMS.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.RedBcCalcIcms = icms20.pRedBC != null ? double.Parse(icms20.pRedBC.Replace(".", ",")) : 0;
                        }
                        else if (infCte.ICMS.Item.GetType() == typeof(TImpICMS45))
                        {
                            TImpICMS45 icms45 = (TImpICMS45)infCte.ICMS.Item;
                            if (icms45.CST == TImpICMSCST.Item40)
                                informacoesImpostosViewModel.SituacaoTributaria = "40 - ICMS ISENÇÃO";
                            if (icms45.CST == TImpICMSCST.Item41)
                                informacoesImpostosViewModel.SituacaoTributaria = "41 - ICMS NÃO TRIBUTADO";
                            if (icms45.CST == TImpICMSCST.Item51)
                                informacoesImpostosViewModel.SituacaoTributaria = "51 - ICMS DIFERIDO";
                        }
                        else if (infCte.ICMS.Item.GetType() == typeof(TImpICMS60))
                            informacoesImpostosViewModel.SituacaoTributaria = "60 - ICMS COBRADO ANTERIORMENTE POR SUBSTITUIÇÃO TRIBUTÁRIA";
                        else if (infCte.ICMS.Item.GetType() == typeof(TImpICMS90))
                        {
                            informacoesImpostosViewModel.SituacaoTributaria = "90 - ICMS OUTROS";
                            TImpICMS90 icms90 = (TImpICMS90)infCte.ICMS.Item;
                            informacoesImpostosViewModel.BaseCalculo = icms90.vBC != null ? double.Parse(icms90.vBC.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.AliquotaIcms = icms90.pICMS != null ? double.Parse(icms90.pICMS.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.ValorIcms = icms90.vICMS != null ? double.Parse(icms90.vICMS.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.RedBcCalcIcms = icms90.pRedBC != null ? double.Parse(icms90.pRedBC.Replace(".", ",")) : 0;
                        }
                        else if (infCte.ICMS.Item.GetType() == typeof(TImpICMSOutraUF))
                        {
                            informacoesImpostosViewModel.SituacaoTributaria = "ICMS OUTRA UF";
                            TImpICMSOutraUF icmsOUF = (TImpICMSOutraUF)infCte.ICMS.Item;
                            informacoesImpostosViewModel.BaseCalculo = icmsOUF.vBCOutraUF != null ? double.Parse(icmsOUF.vBCOutraUF.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.AliquotaIcms = icmsOUF.pICMSOutraUF != null ? double.Parse(icmsOUF.pICMSOutraUF.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.ValorIcms = icmsOUF.vICMSOutraUF != null ? double.Parse(icmsOUF.vICMSOutraUF.Replace(".", ",")) : 0;
                            informacoesImpostosViewModel.RedBcCalcIcms = icmsOUF.pRedBCOutraUF != null ? double.Parse(icmsOUF.pRedBCOutraUF.Replace(".", ",")) : 0;
                        }
                    }
                }
            }
            return informacoesImpostosViewModel;
        }

        private static rodo ModalRodoviario(TCTeInfCte infCte)
        {
            rodo rod = new rodo();
            if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
            {
                TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;
                if (norm.infModal.ContainerModal != null)
                {
                    if (norm.infModal.ContainerModal.GetType() == typeof(rodo))
                    {
                        rod = (rodo)norm.infModal.ContainerModal;
                    }
                }
            }
            return rod;
        }

        private static DadosModalRodoviarioOS ModalRodoviarioOS(TCTeInfCte infCte)
        {
            var model = new DadosModalRodoviarioOS();
            rodoOS rod = new rodoOS();
            SeguroViagem seg = new SeguroViagem();

            if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
            {
                TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;
                if (norm.infModal.ContainerModal != null)
                {

                    if (norm.infModal.ContainerModal.GetType() == typeof(rodoOS))
                    {
                        rod = (rodoOS)norm.infModal.ContainerModal;
                    }
                }
                model.DadosModal = rod;
                if (norm.seg.Count > 0)
                {
                    string respseg = null;
                    switch (norm.seg.FirstOrDefault().respSeg)
                    {
                        case Zion.NFe.Danfe.Dacte.ModelCte.TCTeOSInfCteInfCTeNormSegRespSeg.Item0:
                            respseg = "Emitente do CT-e";
                            break;
                        case Zion.NFe.Danfe.Dacte.ModelCte.TCTeOSInfCteInfCTeNormSegRespSeg.Item5:
                            respseg = "Emitente do CT-e";
                            break;
                    }
                    seg = new SeguroViagem
                    {
                        NomeSeguradora = norm.seg.FirstOrDefault().xSeg,
                        NroApolice = norm.seg.FirstOrDefault().nApol,
                        Responsavel = respseg
                    };
                }
            }
            //else if (infCte.Item.GetType() == typeof(TCTeInfCteInfCteComp))
            //{

            model.SeguroViagem = seg;
            return model;
        }

        private static DadosModalRodoviarioOS ModalRodoviarioOS(cteIsolado.TCTeOSInfCte infCte)
        {
            var model = new DadosModalRodoviarioOS();
            rodoOS rod = new rodoOS();
            SeguroViagem seg = new SeguroViagem();

            if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
            {
                TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;
                if (norm.infModal.ContainerModal != null)
                {

                    if (norm.infModal.ContainerModal.GetType() == typeof(rodoOS))
                    {
                        rod = (rodoOS)norm.infModal.ContainerModal;
                    }
                }
                model.DadosModal = rod;
                if (norm.seg.Count > 0)
                {
                    string respseg = null;
                    switch (norm.seg.FirstOrDefault().respSeg)
                    {
                        case Zion.NFe.Danfe.Dacte.ModelCte.TCTeOSInfCteInfCTeNormSegRespSeg.Item0:
                            respseg = "Emitente do CT-e";
                            break;
                        case Zion.NFe.Danfe.Dacte.ModelCte.TCTeOSInfCteInfCTeNormSegRespSeg.Item5:
                            respseg = "Emitente do CT-e";
                            break;
                    }
                    seg = new SeguroViagem
                    {
                        NomeSeguradora = norm.seg.FirstOrDefault().xSeg,
                        NroApolice = norm.seg.FirstOrDefault().nApol,
                        Responsavel = respseg
                    };
                }
            }
            //else if (infCte.Item.GetType() == typeof(TCTeInfCteInfCteComp))
            //{
            //}
            model.DadosModal = new rodoOS();
            model.SeguroViagem = seg;
            return model;
        }

        private static DadosModalAereoViewModel ModalAereo(TCTeInfCte infCte)
        {
            var modelAereo = new DadosModalAereoViewModel();
            if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
            {
                TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;

                var listaNaturezaCarga = new List<NaturezaCarga>();
                if (norm.infModal.ContainerModal != null)
                {
                    if (norm.infModal.ContainerModal.GetType() == typeof(aereo))
                    {
                        aereo aer = (aereo)norm.infModal.ContainerModal;
                        modelAereo.NumeroOperacional = aer.nOCA;
                        modelAereo.ClasseCL = aer.tarifa.CL;
                        modelAereo.CodigoTarifa = aer.tarifa.cTar;
                        modelAereo.ValorTarifa = aer.tarifa.vTar;
                        modelAereo.NumeroMinuta = aer.nMinu;
                        modelAereo.DataPrevista = aer.dPrevAereo;
                        modelAereo.Retira = (int)infCte.ide.retira == 1 ? true : false;
                        modelAereo.DadosRelativosRetiradCarga = infCte.ide.xDetRetira;
                        modelAereo.CaracteristicaAdicionalServiço = infCte.compl.xCaracSer;
                        if (aer.natCarga != null)
                        {
                            modelAereo.Dimensao = aer.natCarga.xDime;

                            if (aer.natCarga.cInfManu.Count > 0)
                            {
                                var naturezaCarga = new NaturezaCarga();
                                foreach (var item in aer.natCarga.cInfManu)
                                {
                                    var id = ObtemIDInformacoesManuseio(item.ToString());
                                    var descricao = ObtemDescricaoInformacoesManuseio(item.ToString());
                                    naturezaCarga.InformacoesManuseio += id + "-" + descricao + " ";

                                }
                            }
                        }
                    }
                }
            }

            return modelAereo;
        }

        private static DadosModalAquaviarioViewModel ModalAquaviario(TCTeInfCte infCte)
        {
            var modelAquaviario = new DadosModalAquaviarioViewModel();
            if (infCte.Item != null)
            {

                if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
                {
                    TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;

                    if (norm.infModal.ContainerModal != null)
                    {
                        if (norm.infModal.ContainerModal.GetType() == typeof(aquav))
                        {
                            aquav modal = (aquav)norm.infModal.ContainerModal;
                            modelAquaviario.ValorAfrmm = modal.vAFRMM;
                            modelAquaviario.IndentificacaoNavio = modal.xNavio;
                            modelAquaviario.TipoNavegacao = (int)modal.tpNav;
                            foreach (var item in modal.balsa)
                            {
                                modelAquaviario.IdentificacaoBalsa += item.xBalsa ?? "";
                            }

                            int qnt = 1;
                            foreach (var item in modal.detCont)
                            {
                                string nLacre = string.Empty;

                                foreach (var item2 in item.lacre)
                                    nLacre += item2.nLacre + "";

                                var detCont = new DetalhamentoContainer();
                                var a = item.infDoc.Items;
                                detCont.lacre += !string.IsNullOrEmpty(nLacre) ? nLacre + "\n" : "";
                                detCont.idContainer += !string.IsNullOrEmpty(item.nCont) ? item.nCont + "\n" : "";
                                qnt++;
                                modelAquaviario.listaContainer.Add(detCont);
                            }
                        }
                    }

                }
            }
            return modelAquaviario;
        }

        private static List<DocumentosOriginariosViewModel> CarregaDocumentosOriginarios(TCTeInfCte infCte)
        {
            var listDocumentos = new List<DocumentosOriginariosViewModel>();
            string texto = string.Empty;
            DocumentosOriginariosViewModel objetoDocInf;
            if (infCte.Item != null)
            {
                if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
                {
                    TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;
                    bool aux = true;
                    var paginacao = norm.infDoc.Items.Count > 20;

                    foreach (var item in norm.infDoc.Items)
                    {

                        if (item.GetType() == typeof(TCTeInfCteInfCTeNormInfDocInfNF))
                        {
                            TCTeInfCteInfCTeNormInfDocInfNF infNF = (TCTeInfCteInfCTeNormInfDocInfNF)item;
                            objetoDocInf = new DocumentosOriginariosViewModel
                            {
                                tipoDoc = "Nf",
                                cnpj = infCte.receb.CNPJ,
                                serie = infNF.serie ?? string.Empty,
                                doc = infNF.nDoc,
                                coluna = aux ? 1 : 2,
                                nfeChave = string.Empty,
                                chave = string.Empty
                            };

                            listDocumentos.Add(objetoDocInf);
                            aux = !aux;
                        }
                        if (item.GetType() == typeof(TCTeInfCteInfCTeNormInfDocInfNFe))
                        {
                            TCTeInfCteInfCTeNormInfDocInfNFe infNFe = (TCTeInfCteInfCTeNormInfDocInfNFe)item;
                            texto = string.Empty;

                            objetoDocInf = new DocumentosOriginariosViewModel
                            {
                                tipoDoc = "NF-e",
                                cnpj = infCte.receb.CNPJ,
                                serie = string.Empty,
                                doc = string.Empty,
                                coluna = aux ? 1 : 2,
                                nfeChave = infNFe.chave.Substring(25, 9),
                                chave = infNFe.chave,
                            };

                            listDocumentos.Add(objetoDocInf);
                            aux = !aux;
                        }

                        else if (item.GetType() == typeof(TCTeInfCteInfCTeNormInfDocInfOutros))
                        {
                            TCTeInfCteInfCTeNormInfDocInfOutros infOutros = (TCTeInfCteInfCTeNormInfDocInfOutros)item;
                            switch (Convert.ToInt32(infOutros.tpDoc))
                            {
                                case 0:
                                    objetoDocInf = new DocumentosOriginariosViewModel
                                    {
                                        tipoDoc = "DECLARAÇÃO Declaração Doc.:" ?? string.Empty,
                                        cnpj = infCte.receb.CNPJ,
                                        serie = string.Empty,
                                        doc = infOutros.nDoc ?? string.Empty,
                                        coluna = aux ? 1 : 2,
                                        nfeChave = string.Empty,
                                        chave = string.Empty
                                    };
                                    break;
                                case 10:
                                    objetoDocInf = new DocumentosOriginariosViewModel
                                    {
                                        tipoDoc = "DUTOVIÁRIO Dutoviário Doc.:" ?? string.Empty,
                                        cnpj = infCte.receb.CNPJ,
                                        serie = string.Empty,
                                        doc = infOutros.nDoc ?? string.Empty,
                                        coluna = aux ? 1 : 2,
                                        nfeChave = string.Empty,
                                        chave = string.Empty
                                    };
                                    break;
                                default:
                                    objetoDocInf = new DocumentosOriginariosViewModel
                                    {
                                        tipoDoc = "OUTROS Doc.:" + infOutros.nDoc ?? string.Empty,
                                        cnpj = infCte.receb.CNPJ,
                                        serie = string.Empty,
                                        doc = infOutros.nDoc ?? string.Empty,
                                        coluna = aux ? 1 : 2,
                                        nfeChave = string.Empty,
                                        chave = string.Empty
                                    };
                                    break;
                            }
                            listDocumentos.Add(objetoDocInf);
                            aux = !aux;
                        }
                    }
                }
            }
            return listDocumentos;
        }

        private static string ObtemIDInformacoesManuseio(string valor)
        {
            return string.IsNullOrEmpty(valor) ? "99" : valor.Replace("Item", "");
        }

        private static string ObtemDescricaoInformacoesManuseio(string valor)
        {
            if (valor == "Item01")
                return "Certificado do expedidor para embarque de animal vivo;";
            if (valor == "Item02")
                return "Artigo perigoso conforme Declaração do Expedidor anexa;";
            if (valor == "Item03")
                return "Somente em aeronave cargueira;";
            if (valor == "Item04")
                return "Artigo perigoso -declaração do expedidor não requerida;";
            if (valor == "Item05")
                return "Artigo perigoso em quantidade isenta;";
            if (valor == "Item06")
                return "Gelo seco para refrigeração;";
            if (valor == "Item07")
                return "Não restrito;";
            if (valor == "Item08")
                return "Artigo perigoso em carga consolidada;";
            if (valor == "Item09")
                return "Autorização da autoridade governamental anexa;";
            if (valor == "Item10")
                return "Baterias de íons de lítio em conformidade com a Seção II da PI965 – CAO;";
            if (valor == "Item11")
                return "Baterias de íons de lítio em conformidade com a Seção II da PI966;";
            if (valor == "Item12")
                return "Baterias de íons de lítio em conformidade com a Seção II da PI967;";
            if (valor == "Item13")
                return "Baterias de metal lítio em conformidade com a Seção II da PI968 — CAO;";
            if (valor == "Item14")
                return "Baterias de metal lítio em conformidade com a Seção II da PI969;";
            if (valor == "Item15")
                return "Baterias de metal lítio em conformidade com a Seção II da PI970;";

            return "Outro;";
        }

        private static string FormatarChave(string chave)
        {
            string retorno = string.Empty;
            if (!string.IsNullOrEmpty(chave))
            {
                chave = chave.Substring(3);

                for (int i = 0; i < chave.Length; i++)
                {
                    retorno += chave[i];
                    if ((i + 1) % 4 == 0)
                        retorno += "";
                }
            }
            return retorno;
        }

        private static DadosModalObs CarregaTextoObservacaoModal(TCTeInfCte infCte)
        {
            var model = new DadosModalObs();
            var texto = string.Empty;

            if (infCte.compl != null)
            {
                if (infCte.compl.ObsCont != null)
                {
                    foreach (var item in infCte.compl.ObsCont)
                        model.ObsUsoEmissor += item.xCampo;
                }

                if (infCte.compl.ObsFisco != null)
                {
                    foreach (var item in infCte.compl.ObsFisco)
                        model.ObsReservadoFisco += item.xCampo;
                }
            }
            return model;

        }

        private static DadosModalObs CarregaTextoObservacaoModal(cteIsolado.TCTeOSInfCte infCte)
        {
            var model = new DadosModalObs();
            var texto = string.Empty;

            if (infCte.compl != null)
            {
                if (infCte.compl.ObsCont != null)
                {
                    foreach (var item in infCte.compl.ObsCont)
                        model.ObsUsoEmissor += item.xCampo;
                }

                if (infCte.compl.ObsFisco != null)
                {
                    foreach (var item in infCte.compl.ObsFisco)
                        model.ObsReservadoFisco += item.xCampo;
                }
            }
            return model;

        }

        private static DadosModalFerroviarioViewModel ModalFerroviario(TCTeInfCte infCte)
        {
            var modelFerroviario = new DadosModalFerroviarioViewModel();
            if (infCte.Item != null)
            {
                if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
                {
                    TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;


                    if (norm.infModal.ContainerModal != null)
                    {
                        if (norm.infModal.ContainerModal.GetType() == typeof(ferrov))
                        {
                            ferrov modal = (ferrov)norm.infModal.ContainerModal;
                            modelFerroviario.TipoTrafego = modal.tpTraf.ToString();
                            modelFerroviario.FluxoFerroviario = modal.fluxo;
                            if (modal.trafMut != null)
                            {
                                if (Convert.ToInt32(modal.trafMut.respFat) == 1)
                                    modelFerroviario.FerroviaRespFaturamento = "1 - Ferrovia de origem";
                                else if (Convert.ToInt32(modal.trafMut.respFat) == 2)
                                    modelFerroviario.FerroviaRespFaturamento = "2 - Ferrovia de destino";
                                if (Convert.ToInt32(modal.trafMut.ferrEmi) == 1)
                                    modelFerroviario.FerroviaEmitente = "1 - Ferrovia de origem";
                                else if (Convert.ToInt32(modal.trafMut.ferrEmi) == 2)
                                    modelFerroviario.FerroviaEmitente = "2 - Ferrovia de destino";
                                modelFerroviario.ValorFrete = modal.trafMut.vFrete;





                                //            if (modal.trafMut.ferroEnv.Count > 0)
                                //            {
                                //                txtCnpjFerr1.Text = modal.trafMut.ferroEnv[0].CNPJ ?? &quot; &quot; ;
                                //                txtCodInter1.Text = modal.trafMut.ferroEnv[0].cInt ?? &quot; &quot; ;
                                //                txtIEFerr1.Text = modal.trafMut.ferroEnv[0].IE ?? &quot; &quot; ;
                                //                txtRSFerr1.Text = modal.trafMut.ferroEnv[0].xNome ?? &quot; &quot; ;
                                //            }

                                //            if (modal.trafMut.ferroEnv.Count> 1)
                                //{
                                //                txtCnpjFerr2.Text = modal.trafMut.ferroEnv[1].CNPJ ?? &quot; &quot; ;
                                //                txtCodInter2.Text = modal.trafMut.ferroEnv[1].cInt ?? &quot; &quot; ;
                                //                txtIEFerr2.Text = modal.trafMut.ferroEnv[1].IE ?? &quot; &quot; ;
                                //                txtRSFerr2.Text = modal.trafMut.ferroEnv[1].xNome ?? &quot; &quot; ;
                                //            }
                            }
                        }
                    }
                }
            }
            return modelFerroviario;
        }

        private static List<DadosModalDutoviarioViewModel> ModalDutoviario(TCTeInfCte infCte)
        {
            var model = new DadosModalDutoviarioViewModel();
            var listaModal = new List<DadosModalDutoviarioViewModel>();
            TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;
            TCTeInfCteInfCTeNormInfDocInfNF infNF = new TCTeInfCteInfCTeNormInfDocInfNF();
            var item = norm.infDoc.Items.FirstOrDefault();
            foreach (var ind in norm.infDoc.Items)
            {
                var modal = new DadosModalDutoviarioViewModel();
                if (item.GetType() == typeof(TCTeInfCteInfCTeNormInfDocInfNF))
                    infNF = (TCTeInfCteInfCTeNormInfDocInfNF)item;

                var imposto = MontaInformacoesImposto(infCte.imp);
                modal.BaseCalculo = imposto.BaseCalculo;
                modal.Aliquota = imposto.AliquotaIcms;
                modal.ValorImposto = imposto.ValorIcms;
                modal.Observacoes = infCte.compl != null ? infCte.compl.xObs : null;
                modal.Emitente = infCte.rem.Item;
                modal.Serie = infNF.serie;
                modal.Numero = infNF.nDoc;
                listaModal.Add(modal);
            }
            //if (item.GetType() == typeof(TCTeInfCteInfCTeNormInfDocInfNF))
            //    infNF = (TCTeInfCteInfCTeNormInfDocInfNF)item;
            //var impostos = MontaInformacoesImposto(infCte.imp);
            //model.BaseCalculo = impostos.BaseCalculo;
            //model.Aliquota = impostos.AliquotaIcms;
            //model.ValorImposto = impostos.ValorIcms;
            //model.Observacoes = infCte.compl != null ? infCte.compl.xObs : null;
            //model.Emitente = infCte.rem.Item;
            //model.Serie = infNF.serie;
            //model.Numero = infNF.nDoc;
            return listaModal;
        }

        private static multimodal MultiModal(TCTeInfCte infCte)
        {
            var modelo = new multimodal();
            if (infCte.Item != null)
            {
                if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
                {
                    TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;

                    if (norm.infModal.ContainerModal != null)
                    {
                        if (norm.infModal.ContainerModal.GetType() == typeof(multimodal))
                            modelo = (multimodal)norm.infModal.ContainerModal;
                    }
                }
            }
            return modelo;
        }

        private static DadosFluxoViewModel CarregaFluxo(TCTeInfCte infCte)
        {
            var model = new DadosFluxoViewModel();
            if (infCte.compl.fluxo != null)
            {
                model.Origem = infCte.compl.fluxo.xOrig;
                model.Destino = infCte.compl.fluxo.xDest;
                if (infCte.compl.fluxo.pass != null)
                {
                    foreach (var item in infCte.compl.fluxo.pass)
                    {
                        model.Passagem += item.xPass ?? "";
                    }
                }
            }
            return model;
        }

        private static TCTeInfCteVPrest ConvertCompOsToComp(cteIsolado.TCTeOSInfCteVPrest componenteOs)
        {
            var modeloComponente = new TCTeInfCteVPrest();
            var listaComp = new List<TCTeInfCteVPrestComp>();

            foreach (var el in componenteOs.Comp)
            {
                var comp = new TCTeInfCteVPrestComp();
                comp.vComp = el.vComp;
                comp.xNome = el.xNome;
                listaComp.Add(comp);
            }
            modeloComponente.Comp = listaComp;
            modeloComponente.vRec = componenteOs.vRec;
            modeloComponente.vTPrest = componenteOs.vTPrest;
            return modeloComponente;
        }

        private static PrestacaoServico CarregaPrestacaoServico(TCTeInfCte infCte)
        {
            var prestacao = new PrestacaoServico();
            if (infCte.Item != null)
            {
                if (infCte.Item.GetType() == typeof(TCTeInfCteInfCTeNorm))
                {
                    TCTeInfCteInfCTeNorm norm = (TCTeInfCteInfCTeNorm)infCte.Item;
                    if (norm.infServVinc != null)
                    {

                        prestacao.DescricaoServico = string.Empty;
                        prestacao.Quantidade = string.Empty;
                    }
                }
            }
            return prestacao;
        }

        private static PrestacaoServico CarregaPrestacaoServico(cteIsolado.TCTeOSInfCte infCte)
        {
            var prestacao = new PrestacaoServico();
            if (infCte.Item != null)
            {
                if (infCte.Item.GetType() == typeof(Zion.NFe.Danfe.Dacte.ModelCte.TCTeOSInfCteInfCTeNorm))
                {
                    Zion.NFe.Danfe.Dacte.ModelCte.TCTeOSInfCteInfCTeNorm norm = (Zion.NFe.Danfe.Dacte.ModelCte.TCTeOSInfCteInfCTeNorm)infCte.Item;
                    if (norm.infServico != null)
                    {

                        prestacao.DescricaoServico = norm.infServico.xDescServ;
                        prestacao.Quantidade = norm.infServico.infQ.qCarga;
                    }
                }
            }
            return prestacao;
        }

        public static DacteViewModel CreateFromXml(cteProc proc)
        {
            var cte = proc.CTe.infCte.ide.nCT;
            var infCte = proc.CTe.infCte;
            var ide = infCte.ide;
            var infProt = proc.protCTe.infProt;
            //ECONET.EcoNFe2.Entidade.Entidade.NFE.CTE.TCTeOSInfCte

            DacteViewModel model = new DacteViewModel
            {
                Orientacao = (int)ide.tpImp == 1 ? Orientacao.Retrato : Orientacao.Paisagem,
                CodigoStatusReposta = infProt.cStat,
                DescricaoStatusReposta = infProt.xMotivo,
                TipoAmbiente = (int)ide.tpAmb,
                CTeNumero = ide.nCT,
                Serie = ide.serie,
                NaturezaOperacao = ide.natOp,
                ChaveAcesso = infCte.Id.Substring(3),
                TipoCte = (int)ide.tpCTe,
                Emitente = infCte.emit,
                Destinatario = infCte.dest,
                Modal = ide.modal,
                DataHoraEmissao = Convert.ToDateTime(ide.dhEmi),
                TipoServico = ide.tpServ,
                FormaPagamento = ide.forPag.ToString(),
                NotasFiscaisReferenciadas = ide.refCTE != null ? ide.refCTE.Select(x => x.ToString()).ToList() : null,
                Modelo = ide.mod,
                CFOP = ide.CFOP,
                ProtocoloAutorizacao = infProt.cStat == "100" ? infProt.nProt + "-" + Convert.ToDateTime(infProt.dhRecbto).ToString("dd/MM/yyyy HH:mm:ss") : null,
                OrigemPrestacao = string.Concat(ide.xMunIni, "-", ide.UFIni.ToString(), "-", ide.cMunIni),
                DestinoPrestacao = string.Concat(ide.xMunFim, "-", ide.UFFim.ToString(), "-", ide.cMunFim),
                IndicadorGlobalizado = ide.indGlobalizadoSpecified,
                Expedidor = infCte.exped,
                Recebedor = infCte.receb,
                Remetente = infCte.rem,
                Tomador = DefineTomador(infCte),
                InformacaoCteNorm = InformacaoCarga(infCte),
                Componente = infCte.vPrest,
                InformacoesImposto = MontaInformacoesImposto(infCte.imp),
                Observacoes = infCte.compl != null ? infCte.compl.xObs : null,
                DadosModalRodoviario = ide.modal.Equals(TModTransp.Item01) && ide.mod.Equals(TModCT.Item57) ? ModalRodoviario(infCte) : null,
                DadosInformacoesOS = ide.modal.Equals(TModTransp.Item01) && ide.mod.Equals(TModCT.Item67) ? ModalRodoviarioOS(infCte) : null,
                DocumentosOriginarios = CarregaDocumentosOriginarios(proc.CTe.infCte),
                InformacoesDadosModalAereo = ide.modal.Equals(TModTransp.Item02) ? ModalAereo(infCte) : null,
                InformacoesModalAquaviario = ide.modal.Equals(TModTransp.Item03) ? ModalAquaviario(infCte) : null,
                InformacoesModalFerroviario = ide.modal.Equals(TModTransp.Item04) ? ModalFerroviario(infCte) : null,
                InformacoesModalDutoviario = ide.modal.Equals(TModTransp.Item05) ? ModalDutoviario(infCte) : null,
                InformacoesMultiModal = ide.modal.Equals(TModTransp.Item06) ? MultiModal(infCte) : null,
                DadosFluxoViewModel = CarregaFluxo(infCte),
                DadosModalObservacao = CarregaTextoObservacaoModal(infCte),
                PrestacoesServicosOS = CarregaPrestacaoServico(infCte),

            };
            return model;
        }

        #region TODO 
        /// <summary>
        /// ToDo - Informações da doc incompletas
        /// </summary>
        /// <param name="proc"></param>
        /// <returns></returns>
        private static DacteViewModel CreateFromXml(cteIsolado.cteOSProc proc)
        {
            var cte = proc.CTeOS.infCte.ide.nCT;
            var infCte = proc.CTeOS.infCte;
            var ide = infCte.ide;
            var infProt = proc.protCTe.infProt;
            var emitOS = proc.CTeOS.infCte.emit;
            var destOS = proc.CTeOS.infCte.Item;

            TCTeInfCteEmit emit = new TCTeInfCteEmit();
            emit.CNPJ = emitOS.CNPJ;
            emit.enderEmit.CopiarPropriedades(emitOS.enderEmit);
            emit.IE = emitOS.IE;
            emit.IEST = emitOS.IEST;
            emit.xFant = emitOS.xFant;
            emit.xNome = emitOS.xNome;

            TCTeInfCteDest dest = new TCTeInfCteDest();

            DadosModalObs modeloModal = CarregaTextoObservacaoModal(proc.CTeOS.infCte);

            var prestServOS = new PrestacaoServico();
            prestServOS = CarregaPrestacaoServico(proc.CTeOS.infCte);

            DadosModalRodoviarioOS dadosInformacoesOS = ModalRodoviarioOS(proc.CTeOS.infCte);

            DacteViewModel model = new DacteViewModel
            {
                Orientacao = (int)ide.tpImp == 1 ? Orientacao.Retrato : Orientacao.Paisagem,
                Emitente = emit,
                Destinatario = dest,
                DadosModalObservacao = modeloModal,
                DadosInformacoesOS = dadosInformacoesOS,
                CodigoStatusReposta = infProt.cStat,
                DescricaoStatusReposta = infProt.xMotivo,
                TipoAmbiente = (int)ide.tpAmb,
                CTeNumero = ide.nCT,
                Serie = ide.serie,
                NaturezaOperacao = ide.natOp,
                ChaveAcesso = infCte.Id.Substring(3),
                TipoCte = (int)ide.tpCTe,
                Modal = TModTransp.Item01,
                DataHoraEmissao = Convert.ToDateTime(ide.dhEmi),
                TipoServico = (TCTeInfCteIdeTpServ)ide.tpServ,
                CFOP = ide.CFOP,
                ProtocoloAutorizacao = infProt.cStat == "100" ? infProt.nProt + "-" + Convert.ToDateTime(infProt.dhRecbto).ToString("dd/MM/yyyy hh:mm:ss") : null,
                OrigemPrestacao = string.Concat(ide.xMunIni, "-", ide.UFIni.ToString(), "-", ide.cMunIni),
                DestinoPrestacao = string.Concat(ide.xMunFim, "-", ide.UFFim.ToString(), "-", ide.cMunFim),
                Tomador = DefineTomador(infCte),
                Componente = ConvertCompOsToComp(infCte.vPrest),
                InformacoesImposto = MontaInformacoesImposto(infCte.imp),
                Observacoes = proc.CTeOS.infCte.compl != null ? infCte.compl.xObs : null,
                Modelo = TModCT.Item67,
                PrestacoesServicosOS = prestServOS
            };
            return model;
        }

        private static InformacoesImpostosViewModel MontaInformacoesImposto(cteIsolado.TCTeOSInfCteImp infCte)
        {
            var informacoesImpostosViewModel = new InformacoesImpostosViewModel();
            if (infCte != null)
            {
                if (infCte.ICMS != null)
                {
                    if (infCte.ICMS.Item != null)
                    {

                        if (infCte.ICMS.Item.GetType() == typeof(cteIsolado.TImpOSICMSSN)) //Simples Nacional
                        {
                            informacoesImpostosViewModel.SituacaoTributaria = "SN - SIMPLES NACIONAL";
                        }
                        else if (infCte.ICMS.Item.GetType() == typeof(cteIsolado.TImpOSICMS00))
                        {
                            cteIsolado.TImpOSICMS00 icms00 = (cteIsolado.TImpOSICMS00)infCte.ICMS.Item;
                            informacoesImpostosViewModel.SituacaoTributaria = "00 - TRIBUTAÇÃO NORMAL DO ICMS";
                            informacoesImpostosViewModel.BaseCalculo = double.Parse(icms00.vBC.Replace(".", ","));
                            informacoesImpostosViewModel.AliquotaIcms = double.Parse(icms00.pICMS.Replace(".", ","));
                            informacoesImpostosViewModel.ValorIcms = double.Parse(icms00.vICMS.Replace(".", ","));
                        }

                        else if (infCte.ICMS.Item.GetType() == typeof(cteIsolado.TImpOSICMS45))
                        {
                            cteIsolado.TImpOSICMS45 icms45 = (cteIsolado.TImpOSICMS45)infCte.ICMS.Item;
                            if (icms45.CST == cteIsolado.TImpOSICMS45CST.Item40)
                                informacoesImpostosViewModel.SituacaoTributaria = "40 - ICMS ISENÇÃO";
                            if (icms45.CST == cteIsolado.TImpOSICMS45CST.Item41)
                                informacoesImpostosViewModel.SituacaoTributaria = "41 - ICMS NÃO TRIBUTADO";
                            if (icms45.CST == cteIsolado.TImpOSICMS45CST.Item51)
                                informacoesImpostosViewModel.SituacaoTributaria = "51 - ICMS DIFERIDO";
                        }
                        else if (infCte.ICMS.Item.GetType() == typeof(cteIsolado.TImpOSICMS90))
                        {
                            informacoesImpostosViewModel.SituacaoTributaria = "90 - ICMS OUTROS";
                            cteIsolado.TImpOSICMS90 icms90 = (cteIsolado.TImpOSICMS90)infCte.ICMS.Item;
                            informacoesImpostosViewModel.BaseCalculo = double.Parse(icms90.vBC.Replace(".", ","));
                            informacoesImpostosViewModel.AliquotaIcms = double.Parse(icms90.pICMS.Replace(".", ","));
                            informacoesImpostosViewModel.ValorIcms = string.IsNullOrEmpty(icms90.pRedBC) ? 0 : double.Parse(icms90.pRedBC.Replace(".", ","));
                            informacoesImpostosViewModel.RedBcCalcIcms = double.Parse(icms90.pICMS.Replace(".", ","));
                        }
                        else if (infCte.ICMS.Item.GetType() == typeof(cteIsolado.TImpOSICMSOutraUF))
                        {
                            informacoesImpostosViewModel.SituacaoTributaria = "ICMS OUTRA UF";
                            cteIsolado.TImpOSICMSOutraUF icmsOUF = (cteIsolado.TImpOSICMSOutraUF)infCte.ICMS.Item;
                            informacoesImpostosViewModel.BaseCalculo = double.Parse(icmsOUF.vBCOutraUF.Replace(".", ","));
                            informacoesImpostosViewModel.AliquotaIcms = double.Parse(icmsOUF.pICMSOutraUF.Replace(".", ","));
                            informacoesImpostosViewModel.ValorIcms = double.Parse(icmsOUF.vICMSOutraUF.Replace(".", ","));
                            informacoesImpostosViewModel.RedBcCalcIcms = double.Parse(icmsOUF.pRedBCOutraUF.Replace(".", ","));
                        }
                    }
                }
            }
            return informacoesImpostosViewModel;
        }

        private static TomadorViewModel DefineTomador(cteIsolado.TCTeOSInfCte infCte)
        {
            var tomadorModel = new TomadorViewModel();
            tomadorModel.Nome = infCte.toma.xNome ?? string.Empty;
            tomadorModel.Municipio = infCte.toma.enderToma.cMun ?? string.Empty;
            tomadorModel.Cep = Formatador.FormatarCEP(infCte.toma.enderToma.CEP);
            tomadorModel.Endereco = Formatador.FormatarEnderecoLinha1(infCte.toma.enderToma.xLgr, infCte.toma.enderToma.nro, infCte.toma.enderToma.xCpl);
            tomadorModel.Pais = infCte.toma.enderToma.xPais ?? string.Empty;
            tomadorModel.Cnpj = Formatador.FormatarCpfCnpj(infCte.toma.Item);
            tomadorModel.IE = infCte.toma.IE ?? string.Empty;
            tomadorModel.Fone = Formatador.FormatarTelefone(infCte.toma.fone);
            tomadorModel.Uf = infCte.toma.enderToma.UF.ToString();
            tomadorModel.Bairro = infCte.toma.enderToma.xBairro;

            return tomadorModel;
        }
        #endregion

    }
}