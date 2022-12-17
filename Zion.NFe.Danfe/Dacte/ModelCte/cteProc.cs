using System;
using System.Collections.Generic;
using Zion.NFe.Danfe.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Tools.Extensions;

namespace Zion.NFe.Danfe.Dacte.ModelCte
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public class cteProc
    {

        #region Private fields
        private TCTe _cTe;

        private TProtCTe _protCTe;

        private string _versao;

        private string _ipTransmissor;
        #endregion

        public cteProc()
        {
            this._protCTe = new TProtCTe();
            this._cTe = new TCTe();
        }

        public TCTe CTe
        {
            get
            {
                return this._cTe;
            }
            set
            {
                this._cTe = value;
            }
        }

        public TProtCTe protCTe
        {
            get
            {
                return this._protCTe;
            }
            set
            {
                this._protCTe = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this._versao;
            }
            set
            {
                this._versao = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ipTransmissor
        {
            get
            {
                return this._ipTransmissor;
            }
            set
            {
                this._ipTransmissor = value;
            }
        }

        public string ProxyVersao
        {
            get
            {
                return versao;
            }
            set
            {
                if (value.Equals("2.00"))
                    versao = "2.00";

                if (value.Equals("3.00"))
                    versao = "3.00";
            }
        }

        public bool versaoSpecified { get { return !string.IsNullOrEmpty(versao); } }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTe
    {

        #region Private fields
        private TCTeInfCte _infCte;

        private SignatureType _signature;

        private string _versao;
        #endregion

        public TCTe()
        {
            this._signature = new SignatureType();
            this._infCte = new TCTeInfCte();
        }

        public TCTeInfCte infCte
        {
            get
            {
                return this._infCte;
            }
            set
            {
                this._infCte = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this._signature;
            }
            set
            {
                this._signature = value;
            }
        }

        public string versao
        {
            get
            {
                return this._versao;
            }
            set
            {
                this._versao = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCte
    {

        #region Private fields
        private TCTeInfCteIde _ide;

        private TCTeInfCteCompl _compl;

        private TCTeInfCteEmit _emit;

        private TCTeInfCteRem _rem;

        private TCTeInfCteExped _exped;

        private TCTeInfCteReceb _receb;

        private TCTeInfCteDest _dest;

        private TCTeInfCteVPrest _vPrest;

        private TCTeInfCteImp _imp;

        private object _item;

        private List<TCTeInfCteAutXML> _autXML;

        private string _versao;

        private string _id;
        #endregion

        public TCTeInfCte()
        {
            this._autXML = new List<TCTeInfCteAutXML>();
            this._imp = new TCTeInfCteImp();
            this._vPrest = new TCTeInfCteVPrest();
            this._dest = new TCTeInfCteDest();
            this._receb = new TCTeInfCteReceb();
            this._exped = new TCTeInfCteExped();
            this._rem = new TCTeInfCteRem();
            this._emit = new TCTeInfCteEmit();
            this._compl = new TCTeInfCteCompl();
            this._ide = new TCTeInfCteIde();
        }

        public TCTeInfCteIde ide
        {
            get
            {
                return this._ide;
            }
            set
            {
                this._ide = value;
            }
        }

        public TCTeInfCteCompl compl
        {
            get
            {
                return this._compl;
            }
            set
            {
                this._compl = value;
            }
        }

        public TCTeInfCteEmit emit
        {
            get
            {
                return this._emit;
            }
            set
            {
                this._emit = value;
            }
        }

        public TCTeInfCteRem rem
        {
            get
            {
                return this._rem;
            }
            set
            {
                this._rem = value;
            }
        }

        public TCTeInfCteExped exped
        {
            get
            {
                return this._exped;
            }
            set
            {
                this._exped = value;
            }
        }

        public TCTeInfCteReceb receb
        {
            get
            {
                return this._receb;
            }
            set
            {
                this._receb = value;
            }
        }

        public TCTeInfCteDest dest
        {
            get
            {
                return this._dest;
            }
            set
            {
                this._dest = value;
            }
        }

        public TCTeInfCteVPrest vPrest
        {
            get
            {
                return this._vPrest;
            }
            set
            {
                this._vPrest = value;
            }
        }

        public TCTeInfCteImp imp
        {
            get
            {
                return this._imp;
            }
            set
            {
                this._imp = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("infCTeNorm", typeof(TCTeInfCteInfCTeNorm))]
        [System.Xml.Serialization.XmlElementAttribute("infCteAnu", typeof(TCTeInfCteInfCteAnu))]
        [System.Xml.Serialization.XmlElementAttribute("infCteComp", typeof(TCTeInfCteInfCteComp))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("autXML")]
        public List<TCTeInfCteAutXML> autXML
        {
            get
            {
                return this._autXML;
            }
            set
            {
                this._autXML = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this._versao;
            }
            set
            {
                this._versao = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteIde
    {

        #region Private fields
        private TCodUfIBGE _cUF;

        private string _cCT;

        private string _cFOP;

        private string _natOp;

        private TModCT _mod;

        private string _serie;

        private string _nCT;

        private string _dhEmi;

        private TCTeInfCteIdeTpImp _tpImp;

        private TCTeInfCteIdeTpEmis _tpEmis;

        private string _cDV;

        private TAmb _tpAmb;

        private TFinCTe _tpCTe;

        private respSeg _respSeg;

        private TProcEmi _procEmi;

        private string _verProc;

        private TCTeInfCteIdeIndGlobalizado? _indGlobalizado;

        private string _cMunEnv;

        private string _xMunEnv;

        private TUf _uFEnv;

        private TModTransp _modal;

        private TCTeInfCteIdeTpServ _tpServ;

        private string _cMunIni;

        private string _xMunIni;

        private TUf _uFIni;

        private string _cMunFim;

        private string _xMunFim;

        private TUf _uFFim;

        private TCTeInfCteIdeRetira _retira;

        private string _xDetRetira;

        private TCTeInfCteIdeIndIEToma _indIEToma;

        private object _item;

        private DateTime? _dhCont;

        private string _xJust;

        private string _refCTE;

        #endregion

        public forPag? forPag { get; set; }

        public bool forPagSpecified { get { return forPag.HasValue; } }

        public TCodUfIBGE cUF
        {
            get
            {
                return this._cUF;
            }
            set
            {
                this._cUF = value;
            }
        }

        public string cCT
        {
            get
            {
                return this._cCT;
            }
            set
            {
                this._cCT = value;
            }
        }

        public string CFOP
        {
            get
            {
                return this._cFOP;
            }
            set
            {
                this._cFOP = value;
            }
        }

        public string natOp
        {
            get
            {
                return this._natOp;
            }
            set
            {
                this._natOp = value;
            }
        }

        public TModCT mod
        {
            get
            {
                return this._mod;
            }
            set
            {
                this._mod = value;
            }
        }

        public string serie
        {
            get
            {
                return this._serie;
            }
            set
            {
                this._serie = value;
            }
        }

        public string nCT
        {
            get
            {
                return this._nCT;
            }
            set
            {
                this._nCT = value;
            }
        }

        public string dhEmi
        {
            get
            {
                return this._dhEmi;
            }
            set
            {
                this._dhEmi = value;
            }
        }

        public TCTeInfCteIdeTpImp tpImp
        {
            get
            {
                return this._tpImp;
            }
            set
            {
                this._tpImp = value;
            }
        }

        public TCTeInfCteIdeTpEmis tpEmis
        {
            get
            {
                return this._tpEmis;
            }
            set
            {
                this._tpEmis = value;
            }
        }

        public string cDV
        {
            get
            {
                return this._cDV;
            }
            set
            {
                this._cDV = value;
            }
        }

        public TAmb tpAmb
        {
            get
            {
                return this._tpAmb;
            }
            set
            {
                this._tpAmb = value;
            }
        }

        public TFinCTe tpCTe
        {
            get
            {
                return this._tpCTe;
            }
            set
            {
                this._tpCTe = value;
            }
        }

        public respSeg respSeg
        {
            get
            {
                return this._respSeg;
            }
            set
            {
                this._respSeg = value;
            }
        }

        public TProcEmi procEmi
        {
            get
            {
                return this._procEmi;
            }
            set
            {
                this._procEmi = value;
            }
        }

        public string verProc
        {
            get
            {
                return this._verProc;
            }
            set
            {
                this._verProc = value;
            }
        }

        public TCTeInfCteIdeIndGlobalizado? indGlobalizado
        {
            get
            {
                return this._indGlobalizado;
            }
            set
            {
                this._indGlobalizado = value;
            }
        }

        public bool indGlobalizadoSpecified { get { return indGlobalizado.HasValue; } }

        public string refCTE
        {
            get
            {
                return this._refCTE;
            }
            set
            {
                this._refCTE = value;
            }
        }

        public string cMunEnv
        {
            get
            {
                return this._cMunEnv;
            }
            set
            {
                this._cMunEnv = value;
            }
        }

        public string xMunEnv
        {
            get
            {
                return this._xMunEnv;
            }
            set
            {
                this._xMunEnv = value;
            }
        }

        public TUf UFEnv
        {
            get
            {
                return this._uFEnv;
            }
            set
            {
                this._uFEnv = value;
            }
        }

        public string ProxyUFEnv { get; set; }

        public TModTransp modal
        {
            get
            {
                return this._modal;
            }
            set
            {
                this._modal = value;
            }
        }

        public TCTeInfCteIdeTpServ tpServ
        {
            get
            {
                return this._tpServ;
            }
            set
            {
                this._tpServ = value;
            }
        }

        public string cMunIni
        {
            get
            {
                return this._cMunIni;
            }
            set
            {
                this._cMunIni = value;
            }
        }

        public string xMunIni
        {
            get
            {
                return this._xMunIni;
            }
            set
            {
                this._xMunIni = value;
            }
        }

        public TUf UFIni
        {
            get
            {
                return this._uFIni;
            }
            set
            {
                this._uFIni = value;
            }
        }

        public string ProxyUFIni
        {
            get { return UFIni.ToString(); }
        }

        public string cMunFim
        {
            get
            {
                return this._cMunFim;
            }
            set
            {
                this._cMunFim = value;
            }
        }

        public string xMunFim
        {
            get
            {
                return this._xMunFim;
            }
            set
            {
                this._xMunFim = value;
            }
        }

        public TUf UFFim
        {
            get
            {
                return this._uFFim;
            }
            set
            {
                this._uFFim = value;
            }
        }

        public string ProxyUFFim
        {
            get { return UFFim.ToString(); }
        }

        public TCTeInfCteIdeRetira retira
        {
            get
            {
                return this._retira;
            }
            set
            {
                this._retira = value;
            }
        }

        public string xDetRetira
        {
            get
            {
                return this._xDetRetira;
            }
            set
            {
                this._xDetRetira = value;
            }
        }

        public TCTeInfCteIdeIndIEToma? indIEToma { get; set; }

        public bool indIETomaSpecified { get { return indIEToma.HasValue; } }

        [System.Xml.Serialization.XmlElementAttribute("toma3", typeof(TCTeInfCteIdeToma3))]
        [System.Xml.Serialization.XmlElementAttribute("toma4", typeof(TCTeInfCteIdeToma4))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        public DateTime? dhCont { get; set; }

        public string xJust
        {
            get
            {
                return this._xJust;
            }
            set
            {
                this._xJust = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCodUfIBGE
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModCT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("57")]
        Item57,

        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeTpImp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeTpEmis
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TAmb
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TFinCTe
    {
        [System.Xml.Serialization.XmlEnum("0")]
        Normal,
        [System.Xml.Serialization.XmlEnum("1")]
        Complemento,
        [System.Xml.Serialization.XmlEnum("2")]
        Anulacao,
        [System.Xml.Serialization.XmlEnum("3")]
        Substituto
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum respSeg
    {
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Remetente = 0,

        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Expedidor = 1,

        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Recebedor = 2,

        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Destinatario = 3,

        [System.Xml.Serialization.XmlEnumAttribute("4")]
        EmitenteDoCTe = 4,

        [System.Xml.Serialization.XmlEnumAttribute("5")]
        TomadorDoServico = 5
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TProcEmi
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeIndGlobalizado
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModTransp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeTpServ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeRetira
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeIndIEToma
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteIdeToma3
    {

        #region Private fields
        private TCTeInfCteIdeToma3Toma _toma;
        #endregion

        public TCTeInfCteIdeToma3Toma toma
        {
            get
            {
                return this._toma;
            }
            set
            {
                this._toma = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeToma3Toma
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TProtCTe
    {

        #region Private fields
        private TProtCTeInfProt _infProt;

        private SignatureType _signature;

        private string _versao;
        #endregion

        public TProtCTe()
        {
            this._signature = new SignatureType();
            this._infProt = new TProtCTeInfProt();
        }

        public TProtCTeInfProt infProt
        {
            get
            {
                return this._infProt;
            }
            set
            {
                this._infProt = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this._signature;
            }
            set
            {
                this._signature = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this._versao;
            }
            set
            {
                this._versao = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TProtCTeInfProt
    {

        #region Private fields
        private TAmb _tpAmb;

        private string _verAplic;

        private string _chCTe;

        private string _dhRecbto;

        private string _nProt;

        private string _digVal;

        private string _cStat;

        private string _xMotivo;

        private string _id;
        #endregion

        public TAmb tpAmb
        {
            get
            {
                return this._tpAmb;
            }
            set
            {
                this._tpAmb = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this._verAplic;
            }
            set
            {
                this._verAplic = value;
            }
        }

        public string chCTe
        {
            get
            {
                return this._chCTe;
            }
            set
            {
                this._chCTe = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this._dhRecbto;
            }
            set
            {
                this._dhRecbto = value;
            }
        }

        public string nProt
        {
            get
            {
                return this._nProt;
            }
            set
            {
                this._nProt = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public string digVal
        {
            get
            {
                return this._digVal;
            }
            set
            {
                this._digVal = value;
            }
        }

        public string cStat
        {
            get
            {
                return this._cStat;
            }
            set
            {
                this._cStat = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this._xMotivo;
            }
            set
            {
                this._xMotivo = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureType
    {

        #region Private fields
        private SignedInfoType _signedInfo;

        private SignatureValueType _signatureValue;

        private KeyInfoType _keyInfo;

        private string _id;
        #endregion

        public SignatureType()
        {
            this._keyInfo = new KeyInfoType();
            this._signatureValue = new SignatureValueType();
            this._signedInfo = new SignedInfoType();
        }

        public SignedInfoType SignedInfo
        {
            get
            {
                return this._signedInfo;
            }
            set
            {
                this._signedInfo = value;
            }
        }

        public SignatureValueType SignatureValue
        {
            get
            {
                return this._signatureValue;
            }
            set
            {
                this._signatureValue = value;
            }
        }

        public KeyInfoType KeyInfo
        {
            get
            {
                return this._keyInfo;
            }
            set
            {
                this._keyInfo = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {

        #region Private fields
        private SignedInfoTypeCanonicalizationMethod _canonicalizationMethod;

        private SignedInfoTypeSignatureMethod _signatureMethod;

        private ReferenceType _reference;

        private string _id;
        #endregion

        public SignedInfoType()
        {
            this._reference = new ReferenceType();
            this._signatureMethod = new SignedInfoTypeSignatureMethod();
            this._canonicalizationMethod = new SignedInfoTypeCanonicalizationMethod();
        }

        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this._canonicalizationMethod;
            }
            set
            {
                this._canonicalizationMethod = value;
            }
        }

        public SignedInfoTypeSignatureMethod SignatureMethod
        {
            get
            {
                return this._signatureMethod;
            }
            set
            {
                this._signatureMethod = value;
            }
        }

        public ReferenceType Reference
        {
            get
            {
                return this._reference;
            }
            set
            {
                this._reference = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod
    {

        #region Private fields
        private string _algorithm;
        #endregion

        public SignedInfoTypeCanonicalizationMethod()
        {
            this._algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this._algorithm;
            }
            set
            {
                this._algorithm = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod
    {

        #region Private fields
        private string _algorithm;
        #endregion

        public SignedInfoTypeSignatureMethod()
        {
            this._algorithm = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this._algorithm;
            }
            set
            {
                this._algorithm = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType
    {

        #region Private fields
        private List<TransformType> _transforms;

        private ReferenceTypeDigestMethod _digestMethod;

        private byte[] _digestValue;

        private string _id;

        private string _uRI;

        private string _type;
        #endregion

        public ReferenceType()
        {
            this._digestMethod = new ReferenceTypeDigestMethod();
            this._transforms = new List<TransformType>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public List<TransformType> Transforms
        {
            get
            {
                return this._transforms;
            }
            set
            {
                this._transforms = value;
            }
        }

        public ReferenceTypeDigestMethod DigestMethod
        {
            get
            {
                return this._digestMethod;
            }
            set
            {
                this._digestMethod = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get
            {
                return this._digestValue;
            }
            set
            {
                this._digestValue = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
    {

        #region Private fields
        private List<string> _xPath;

        private TTransformURI _algorithm;
        #endregion

        public TransformType()
        {
            this._xPath = new List<string>();
        }

        [System.Xml.Serialization.XmlElementAttribute("XPath")]
        public List<string> XPath
        {
            get
            {
                return this._xPath;
            }
            set
            {
                this._xPath = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm
        {
            get
            {
                return this._algorithm;
            }
            set
            {
                this._algorithm = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod
    {

        #region Private fields
        private string _algorithm;
        #endregion

        public ReferenceTypeDigestMethod()
        {
            this._algorithm = "http://www.w3.org/2000/09/xmldsig#sha1";
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this._algorithm;
            }
            set
            {
                this._algorithm = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {

        #region Private fields
        private string _id;

        private byte[] _value;
        #endregion

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {

        #region Private fields
        private X509DataType _x509Data;

        private string _id;
        #endregion

        public KeyInfoType()
        {
            this._x509Data = new X509DataType();
        }

        public X509DataType X509Data
        {
            get
            {
                return this._x509Data;
            }
            set
            {
                this._x509Data = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {

        #region Private fields
        private byte[] _x509Certificate;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] X509Certificate
        {
            get
            {
                return this._x509Certificate;
            }
            set
            {
                this._x509Certificate = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TUnidadeTransp
    {

        #region Private fields
        private TtipoUnidTransp _tpUnidTransp;

        private string _idUnidTransp;

        private List<TUnidadeTranspLacUnidTransp> _lacUnidTransp;

        private List<TUnidCarga> _infUnidCarga;

        private string _qtdRat;
        #endregion

        public TUnidadeTransp()
        {
            this._infUnidCarga = new List<TUnidCarga>();
            this._lacUnidTransp = new List<TUnidadeTranspLacUnidTransp>();
        }

        public TtipoUnidTransp tpUnidTransp
        {
            get
            {
                return this._tpUnidTransp;
            }
            set
            {
                this._tpUnidTransp = value;
            }
        }

        public string idUnidTransp
        {
            get
            {
                return this._idUnidTransp;
            }
            set
            {
                this._idUnidTransp = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("lacUnidTransp")]
        public List<TUnidadeTranspLacUnidTransp> lacUnidTransp
        {
            get
            {
                return this._lacUnidTransp;
            }
            set
            {
                this._lacUnidTransp = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("infUnidCarga")]
        public List<TUnidCarga> infUnidCarga
        {
            get
            {
                return this._infUnidCarga;
            }
            set
            {
                this._infUnidCarga = value;
            }
        }

        public string qtdRat
        {
            get
            {
                return this._qtdRat;
            }
            set
            {
                this._qtdRat = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TtipoUnidTransp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TUnidadeTranspLacUnidTransp
    {

        #region Private fields
        private string _nLacre;
        #endregion

        public string nLacre
        {
            get
            {
                return this._nLacre;
            }
            set
            {
                this._nLacre = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TUnidCarga
    {

        #region Private fields
        private TtipoUnidCarga _tpUnidCarga;

        private string _idUnidCarga;

        private List<TUnidCargaLacUnidCarga> _lacUnidCarga;

        private string _qtdRat;
        #endregion

        public TUnidCarga()
        {
            this._lacUnidCarga = new List<TUnidCargaLacUnidCarga>();
        }

        public TtipoUnidCarga tpUnidCarga
        {
            get
            {
                return this._tpUnidCarga;
            }
            set
            {
                this._tpUnidCarga = value;
            }
        }

        public string idUnidCarga
        {
            get
            {
                return this._idUnidCarga;
            }
            set
            {
                this._idUnidCarga = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("lacUnidCarga")]
        public List<TUnidCargaLacUnidCarga> lacUnidCarga
        {
            get
            {
                return this._lacUnidCarga;
            }
            set
            {
                this._lacUnidCarga = value;
            }
        }

        public string qtdRat
        {
            get
            {
                return this._qtdRat;
            }
            set
            {
                this._qtdRat = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TtipoUnidCarga
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TUnidCargaLacUnidCarga
    {

        #region Private fields
        private string _nLacre;
        #endregion

        public string nLacre
        {
            get
            {
                return this._nLacre;
            }
            set
            {
                this._nLacre = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImp
    {

        #region Private fields
        private object _item;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TImpICMS00))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TImpICMS20))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS45", typeof(TImpICMS45))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS60", typeof(TImpICMS60))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TImpICMS90))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSOutraUF", typeof(TImpICMSOutraUF))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN", typeof(TImpICMSSN))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpICMS00
    {

        #region Private fields
        private TImpICMSCST _cST;

        private string _vBC;

        private string _pICMS;

        private string _vICMS;
        #endregion

        public TImpICMSCST CST
        {
            get
            {
                return this._cST;
            }
            set
            {
                this._cST = value;
            }
        }

        public string vBC
        {
            get
            {
                return this._vBC;
            }
            set
            {
                this._vBC = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this._pICMS;
            }
            set
            {
                this._pICMS = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this._vICMS;
            }
            set
            {
                this._vICMS = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpICMSCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00 = 00,
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20 = 20,
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpICMS20
    {

        #region Private fields
        private TImpICMSCST _cST;

        private string _pRedBC;

        private string _vBC;

        private string _pICMS;

        private string _vICMS;
        #endregion

        public TImpICMSCST CST
        {
            get
            {
                return this._cST;
            }
            set
            {
                this._cST = value;
            }
        }

        public string pRedBC
        {
            get
            {
                return this._pRedBC;
            }
            set
            {
                this._pRedBC = value;
            }
        }

        public string vBC
        {
            get
            {
                return this._vBC;
            }
            set
            {
                this._vBC = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this._pICMS;
            }
            set
            {
                this._pICMS = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this._vICMS;
            }
            set
            {
                this._vICMS = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpICMS45
    {

        #region Private fields
        private TImpICMSCST _cST;
        #endregion

        public TImpICMSCST CST
        {
            get
            {
                return this._cST;
            }
            set
            {
                this._cST = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpICMS60
    {

        #region Private fields
        private TImpICMSCST _cST;

        private string _vBCSTRet;

        private string _vICMSSTRet;

        private string _pICMSSTRet;

        private string _vCred;
        #endregion

        public TImpICMSCST CST
        {
            get
            {
                return this._cST;
            }
            set
            {
                this._cST = value;
            }
        }

        public string vBCSTRet
        {
            get
            {
                return this._vBCSTRet;
            }
            set
            {
                this._vBCSTRet = value;
            }
        }

        public string vICMSSTRet
        {
            get
            {
                return this._vICMSSTRet;
            }
            set
            {
                this._vICMSSTRet = value;
            }
        }

        public string pICMSSTRet
        {
            get
            {
                return this._pICMSSTRet;
            }
            set
            {
                this._pICMSSTRet = value;
            }
        }

        public string vCred
        {
            get
            {
                return this._vCred;
            }
            set
            {
                this._vCred = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpICMS90
    {

        #region Private fields
        private TImpICMSCST _cST;

        private string _pRedBC;

        private string _vBC;

        private string _pICMS;

        private string _vICMS;

        private string _vCred;
        #endregion

        public TImpICMSCST CST
        {
            get
            {
                return this._cST;
            }
            set
            {
                this._cST = value;
            }
        }

        public string pRedBC
        {
            get
            {
                return this._pRedBC;
            }
            set
            {
                this._pRedBC = value;
            }
        }

        public string vBC
        {
            get
            {
                return this._vBC;
            }
            set
            {
                this._vBC = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this._pICMS;
            }
            set
            {
                this._pICMS = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this._vICMS;
            }
            set
            {
                this._vICMS = value;
            }
        }

        public string vCred
        {
            get
            {
                return this._vCred;
            }
            set
            {
                this._vCred = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpICMSOutraUF
    {

        #region Private fields
        private TImpICMSCST _cST;

        private string _pRedBCOutraUF;

        private string _vBCOutraUF;

        private string _pICMSOutraUF;

        private string _vICMSOutraUF;
        #endregion

        public TImpICMSCST CST
        {
            get
            {
                return this._cST;
            }
            set
            {
                this._cST = value;
            }
        }

        public string pRedBCOutraUF
        {
            get
            {
                return this._pRedBCOutraUF;
            }
            set
            {
                this._pRedBCOutraUF = value;
            }
        }

        public string vBCOutraUF
        {
            get
            {
                return this._vBCOutraUF;
            }
            set
            {
                this._vBCOutraUF = value;
            }
        }

        public string pICMSOutraUF
        {
            get
            {
                return this._pICMSOutraUF;
            }
            set
            {
                this._pICMSOutraUF = value;
            }
        }

        public string vICMSOutraUF
        {
            get
            {
                return this._vICMSOutraUF;
            }
            set
            {
                this._vICMSOutraUF = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpICMSSN
    {

        #region Private fields
        private TImpICMSCST _cST;

        private TImpICMSSNIndSN _indSN;
        #endregion

        public TImpICMSCST CST
        {
            get
            {
                return this._cST;
            }
            set
            {
                this._cST = value;
            }
        }

        public TImpICMSSNIndSN indSN
        {
            get
            {
                return this._indSN;
            }
            set
            {
                this._indSN = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpICMSSNIndSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TEndeEmi
    {

        #region Private fields
        private string _xLgr;

        private string _nro;

        private string _xCpl;

        private string _xBairro;

        private string _cMun;

        private string _xMun;

        private string _cEP;

        private TUF_sem_EX _uf;

        private string _fone;
        #endregion

        public string xLgr
        {
            get
            {
                return this._xLgr;
            }
            set
            {
                this._xLgr = value;
            }
        }

        public string nro
        {
            get
            {
                return this._nro;
            }
            set
            {
                this._nro = value;
            }
        }

        public string xCpl
        {
            get
            {
                if (string.IsNullOrEmpty(this._xCpl))
                    return "";
                else
                    return this._xCpl;
            }
            set
            {
                this._xCpl = value;
            }
        }

        public string xBairro
        {
            get
            {
                return this._xBairro;
            }
            set
            {
                this._xBairro = value;
            }
        }

        public string cMun
        {
            get
            {
                return this._cMun;
            }
            set
            {
                this._cMun = value;
            }
        }

        public string xMun
        {
            get
            {
                return this._xMun;
            }
            set
            {
                this._xMun = value;
            }
        }

        public string CEP
        {
            get
            {
                return this._cEP;
            }
            set
            {
                this._cEP = value;
            }
        }

        public string ProxyCEP
        {
            get { return CEP.Replace(".", "").Replace("-", ""); }
            set { CEP = value.Replace(".", "").Replace("-", ""); }
        }

        public TUF_sem_EX UF
        {
            get
            {
                return this._uf;
            }
            set
            {
                this._uf = value;
            }
        }

        public string ProxyUF
        {
            get { return UF.ToString(); }
        }

        public string fone
        {
            get
            {
                return this._fone;
            }
            set
            {
                this._fone = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TUF_sem_EX
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TEndereco
    {

        #region Private fields
        private string _xLgr;

        private string _nro;

        private string _xCpl;

        private string _xBairro;

        private string _cMun;

        private string _xMun;

        private string _cEP;

        private TUf _uf;

        private int? _cPais;

        private string _xPais;
        #endregion

        public string xLgr
        {
            get
            {
                return this._xLgr;
            }
            set
            {
                this._xLgr = value;
            }
        }

        public string nro
        {
            get
            {
                return this._nro;
            }
            set
            {
                this._nro = value;
            }
        }

        public string xCpl
        {
            get
            {
                if (string.IsNullOrEmpty(this._xCpl))
                    return "";
                else
                    return this._xCpl;
            }
            set
            {
                this._xCpl = value;
            }
        }

        public string xBairro
        {
            get
            {
                return this._xBairro;
            }
            set
            {
                this._xBairro = value;
            }
        }

        public string cMun
        {
            get
            {
                return this._cMun;
            }
            set
            {
                this._cMun = value;
            }
        }

        public string xMun
        {
            get
            {
                return this._xMun;
            }
            set
            {
                this._xMun = value;
            }
        }

        public string CEP
        {
            get
            {
                return this._cEP;
            }
            set
            {
                this._cEP = value;
            }
        }

        public string ProxyCEP
        {
            get { return CEP.Replace(".", "").Replace("-", ""); }
            set { CEP = value.Replace(".", "").Replace("-", ""); }
        }

        public TUf UF
        {
            get
            {
                return this._uf;
            }
            set
            {
                this._uf = value;
            }
        }

        public string ProxyUF
        {
            get { return UF.ToString(); }
        }

        public int? cPais
        {
            get
            {
                return this._cPais;
            }
            set
            {
                this._cPais = value;
            }
        }

        public bool cPaisSpecified { get { return cPais.HasValue; } }

        public string xPais
        {
            get
            {
                return this._xPais;
            }
            set
            {
                this._xPais = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteIdeToma4
    {

        #region Private fields
        private TCTeInfCteIdeToma4Toma _toma;

        private string _item;

        private ItemChoiceType _itemElementName;

        private string _ie;

        private string _xNome;

        private string _xFant;

        private string _fone;

        private TEndereco _enderToma;

        private string _email;
        #endregion

        public TCTeInfCteIdeToma4()
        {
            this._enderToma = new TEndereco();
        }

        public TCTeInfCteIdeToma4Toma toma
        {
            get
            {
                return this._toma;
            }
            set
            {
                this._toma = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ")]
        [System.Xml.Serialization.XmlElementAttribute("CPF")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }

        public string IE
        {
            get
            {
                return this._ie;
            }
            set
            {
                this._ie = value;
            }
        }

        public string xNome
        {
            get
            {
                return this._xNome;
            }
            set
            {
                this._xNome = value;
            }
        }

        public string xFant
        {
            get
            {
                return this._xFant;
            }
            set
            {
                this._xFant = value;
            }
        }

        public string fone
        {
            get
            {
                return this._fone;
            }
            set
            {
                this._fone = value;
            }
        }

        public TEndereco enderToma
        {
            get
            {
                return this._enderToma;
            }
            set
            {
                this._enderToma = value;
            }
        }

        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeToma4Toma
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteCompl
    {

        #region Private fields
        private string _xCaracAd;

        private string _xCaracSer;

        private string _xEmi;

        private TCTeInfCteComplFluxo _fluxo;

        private TCTeInfCteComplEntrega _entrega;

        private string _origCalc;

        private string _destCalc;

        private string _xObs;

        private List<TCTeInfCteComplObsCont> _obsCont;

        private List<TCTeInfCteComplObsFisco> _obsFisco;
        #endregion

        public TCTeInfCteCompl()
        {
            this._obsFisco = new List<TCTeInfCteComplObsFisco>();
            this._obsCont = new List<TCTeInfCteComplObsCont>();
            this._entrega = new TCTeInfCteComplEntrega();
            this._fluxo = new TCTeInfCteComplFluxo();
        }

        public string xCaracAd
        {
            get
            {
                return this._xCaracAd;
            }
            set
            {
                this._xCaracAd = value;
            }
        }

        public string xCaracSer
        {
            get
            {
                return this._xCaracSer;
            }
            set
            {
                this._xCaracSer = value;
            }
        }

        public string xEmi
        {
            get
            {
                return this._xEmi;
            }
            set
            {
                this._xEmi = value;
            }
        }

        public TCTeInfCteComplFluxo fluxo
        {
            get
            {
                return this._fluxo;
            }
            set
            {
                this._fluxo = value;
            }
        }

        public TCTeInfCteComplEntrega Entrega
        {
            get
            {
                return this._entrega;
            }
            set
            {
                this._entrega = value;
            }
        }

        public string origCalc
        {
            get
            {
                return this._origCalc;
            }
            set
            {
                this._origCalc = value;
            }
        }

        public string destCalc
        {
            get
            {
                return this._destCalc;
            }
            set
            {
                this._destCalc = value;
            }
        }

        public string xObs
        {
            get
            {
                return this._xObs;
            }
            set
            {
                this._xObs = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ObsCont")]
        public List<TCTeInfCteComplObsCont> ObsCont
        {
            get
            {
                return this._obsCont;
            }
            set
            {
                this._obsCont = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ObsFisco")]
        public List<TCTeInfCteComplObsFisco> ObsFisco
        {
            get
            {
                return this._obsFisco;
            }
            set
            {
                this._obsFisco = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplFluxo
    {

        #region Private fields
        private string _xOrig;

        private List<TCTeInfCteComplFluxoPass> _pass;

        private string _xDest;

        private string _xRota;
        #endregion

        public TCTeInfCteComplFluxo()
        {
            this._pass = new List<TCTeInfCteComplFluxoPass>();
        }

        public string xOrig
        {
            get
            {
                return this._xOrig;
            }
            set
            {
                this._xOrig = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("pass")]
        public List<TCTeInfCteComplFluxoPass> pass
        {
            get
            {
                return this._pass;
            }
            set
            {
                this._pass = value;
            }
        }

        public string xDest
        {
            get
            {
                return this._xDest;
            }
            set
            {
                this._xDest = value;
            }
        }

        public string xRota
        {
            get
            {
                return this._xRota;
            }
            set
            {
                this._xRota = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplFluxoPass
    {

        #region Private fields
        private string _xPass;
        #endregion

        public string xPass
        {
            get
            {
                return this._xPass;
            }
            set
            {
                this._xPass = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntrega
    {

        #region Private fields
        private object _item;

        private object _item1;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("comData", typeof(TCTeInfCteComplEntregaComData))]
        [System.Xml.Serialization.XmlElementAttribute("noPeriodo", typeof(TCTeInfCteComplEntregaNoPeriodo))]
        [System.Xml.Serialization.XmlElementAttribute("semData", typeof(TCTeInfCteComplEntregaSemData))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("comHora", typeof(TCTeInfCteComplEntregaComHora))]
        [System.Xml.Serialization.XmlElementAttribute("noInter", typeof(TCTeInfCteComplEntregaNoInter))]
        [System.Xml.Serialization.XmlElementAttribute("semHora", typeof(TCTeInfCteComplEntregaSemHora))]
        public object Item1
        {
            get
            {
                return this._item1;
            }
            set
            {
                this._item1 = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaComData
    {

        #region Private fields
        private TCTeInfCteComplEntregaComDataTpPer _tpPer;

        private string _dProg;
        #endregion

        public TCTeInfCteComplEntregaComDataTpPer tpPer
        {
            get
            {
                return this._tpPer;
            }
            set
            {
                this._tpPer = value;
            }
        }

        public string dProg
        {
            get
            {
                return this._dProg;
            }
            set
            {
                this._dProg = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaComDataTpPer
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaNoPeriodo
    {

        #region Private fields
        private TCTeInfCteComplEntregaNoPeriodoTpPer _tpPer;

        private string _dIni;

        private string _dFim;
        #endregion

        public TCTeInfCteComplEntregaNoPeriodoTpPer tpPer
        {
            get
            {
                return this._tpPer;
            }
            set
            {
                this._tpPer = value;
            }
        }

        public string dIni
        {
            get
            {
                return this._dIni;
            }
            set
            {
                this._dIni = value;
            }
        }

        public string dFim
        {
            get
            {
                return this._dFim;
            }
            set
            {
                this._dFim = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaNoPeriodoTpPer
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaSemData
    {

        #region Private fields
        private TCTeInfCteComplEntregaSemDataTpPer _tpPer;
        #endregion

        public TCTeInfCteComplEntregaSemDataTpPer tpPer
        {
            get
            {
                return this._tpPer;
            }
            set
            {
                this._tpPer = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaSemDataTpPer
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaComHora
    {

        #region Private fields
        private TCTeInfCteComplEntregaComHoraTpHor _tpHor;

        private string _hProg;
        #endregion

        public TCTeInfCteComplEntregaComHoraTpHor tpHor
        {
            get
            {
                return this._tpHor;
            }
            set
            {
                this._tpHor = value;
            }
        }

        public string hProg
        {
            get
            {
                return this._hProg;
            }
            set
            {
                this._hProg = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaComHoraTpHor
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaNoInter
    {

        #region Private fields
        private TCTeInfCteComplEntregaNoInterTpHor _tpHor;

        private string _hIni;

        private string _hFim;
        #endregion

        public TCTeInfCteComplEntregaNoInterTpHor tpHor
        {
            get
            {
                return this._tpHor;
            }
            set
            {
                this._tpHor = value;
            }
        }

        public string hIni
        {
            get
            {
                return this._hIni;
            }
            set
            {
                this._hIni = value;
            }
        }

        public string hFim
        {
            get
            {
                return this._hFim;
            }
            set
            {
                this._hFim = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaNoInterTpHor
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaSemHora
    {

        #region Private fields
        private TCTeInfCteComplEntregaSemHoraTpHor _tpHor;
        #endregion

        public TCTeInfCteComplEntregaSemHoraTpHor tpHor
        {
            get
            {
                return this._tpHor;
            }
            set
            {
                this._tpHor = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaSemHoraTpHor
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplObsCont
    {

        #region Private fields
        private string _xTexto;

        private string _xCampo;
        #endregion

        public string xTexto
        {
            get
            {
                return this._xTexto;
            }
            set
            {
                this._xTexto = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this._xCampo;
            }
            set
            {
                this._xCampo = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplObsFisco
    {

        #region Private fields
        private string _xTexto;

        private string _xCampo;
        #endregion

        public string xTexto
        {
            get
            {
                return this._xTexto;
            }
            set
            {
                this._xTexto = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this._xCampo;
            }
            set
            {
                this._xCampo = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteEmit
    {

        #region Private fields
        private string _cNPJ;

        private string _ie;

        private string _iEST;

        private string _xNome;

        private string _xFant;

        private TEndeEmi _enderEmit;
        #endregion

        public TCTeInfCteEmit()
        {
            this._enderEmit = new TEndeEmi();
        }

        public string CNPJ
        {
            get
            {
                return this._cNPJ;
            }
            set
            {
                this._cNPJ = value;
            }
        }

        public string IE
        {
            get
            {
                return this._ie;
            }
            set
            {
                this._ie = value;
            }
        }

        public string IEST
        {
            get
            {
                return this._iEST;
            }
            set
            {
                this._iEST = value;
            }
        }

        public string xNome
        {
            get
            {
                return this._xNome;
            }
            set
            {
                this._xNome = value;
            }
        }

        public string xFant
        {
            get
            {
                return this._xFant;
            }
            set
            {
                this._xFant = value;
            }
        }

        public TEndeEmi enderEmit
        {
            get
            {
                return this._enderEmit;
            }
            set
            {
                this._enderEmit = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteRem
    {

        #region Private fields
        private string _item;

        private ItemChoiceType1 _itemElementName;

        private string _ie;

        private string _xNome;

        private string _xFant;

        private string _fone;

        private TEndereco _enderReme;

        private string _email;
        #endregion

        public TCTeInfCteRem()
        {
            this._enderReme = new TEndereco();
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ")]
        [System.Xml.Serialization.XmlElementAttribute("CPF")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }

        public string IE
        {
            get
            {
                return this._ie;
            }
            set
            {
                this._ie = value;
            }
        }

        public string xNome
        {
            get
            {
                return this._xNome;
            }
            set
            {
                this._xNome = value;
            }
        }

        public string xFant
        {
            get
            {
                return this._xFant;
            }
            set
            {
                this._xFant = value;
            }
        }

        public string fone
        {
            get
            {
                return this._fone;
            }
            set
            {
                this._fone = value;
            }
        }

        public TEndereco enderReme
        {
            get
            {
                return this._enderReme;
            }
            set
            {
                this._enderReme = value;
            }
        }

        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteExped
    {

        #region Private fields
        private string _item;

        private ItemChoiceType2 _itemElementName;

        private string _ie;

        private string _xNome;

        private string _fone;

        private TEndereco _enderExped;

        private string _email;

        private string _cpf;

        private string _cnpj;
        #endregion

        public TCTeInfCteExped()
        {
            this._enderExped = new TEndereco();
        }

        public string Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }

        public string IE
        {
            get
            {
                return this._ie;
            }
            set
            {
                this._ie = value;
            }
        }

        public string CPF
        {
            get
            {
                return this._cpf;
            }
            set
            {
                this._cpf = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this._cnpj;
            }
            set
            {
                this._cnpj = value;
            }
        }

        public string xNome
        {
            get
            {
                return this._xNome;
            }
            set
            {
                this._xNome = value;
            }
        }

        public string fone
        {
            get
            {
                return this._fone;
            }
            set
            {
                this._fone = value;
            }
        }

        public TEndereco enderExped
        {
            get
            {
                return this._enderExped;
            }
            set
            {
                this._enderExped = value;
            }
        }

        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteReceb
    {

        #region Private fields
        private string _cpf;

        private string _cnpj;

        private ItemChoiceType3 _itemElementName;

        private string _ie;

        private string _xNome;

        private string _fone;

        private TEndereco _enderReceb;

        private string _email;
        #endregion

        public TCTeInfCteReceb()
        {
            this._enderReceb = new TEndereco();
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }

        public string IE
        {
            get
            {
                return this._ie;
            }
            set
            {
                this._ie = value;
            }
        }

        public string xNome
        {
            get
            {
                return this._xNome;
            }
            set
            {
                this._xNome = value;
            }
        }

        public string CPF
        {
            get
            {
                return this._cpf;
            }
            set
            {
                this._cpf = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this._cnpj;
            }
            set
            {
                this._cnpj = value;
            }
        }

        public string fone
        {
            get
            {
                return this._fone;
            }
            set
            {
                this._fone = value;
            }
        }

        public TEndereco enderReceb
        {
            get
            {
                return this._enderReceb;
            }
            set
            {
                this._enderReceb = value;
            }
        }

        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType3
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteDest
    {

        #region Private fields

        private ItemChoiceType4 _itemElementName;

        private string _ie;

        private string _xNome;

        private string _cpf;

        private string _cnpj;

        private string _fone;

        private string _iSUF;

        private TEndereco _enderDest;

        private string _email;
        #endregion

        public TCTeInfCteDest()
        {
            this._enderDest = new TEndereco();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }

        public string IE
        {
            get
            {
                return this._ie;
            }
            set
            {
                this._ie = value;
            }
        }

        public string CPF
        {
            get
            {
                return this._cpf;
            }
            set
            {
                this._cpf = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this._cnpj;
            }
            set
            {
                this._cnpj = value;
            }
        }

        public string xNome
        {
            get
            {
                return this._xNome;
            }
            set
            {
                this._xNome = value;
            }
        }

        public string fone
        {
            get
            {
                return this._fone;
            }
            set
            {
                this._fone = value;
            }
        }

        public string ISUF
        {
            get
            {
                return string.IsNullOrEmpty(this._iSUF) ? "" : this._iSUF;
            }
            set
            {
                this._iSUF = value;
            }
        }

        public TEndereco enderDest
        {
            get
            {
                return this._enderDest;
            }
            set
            {
                this._enderDest = value;
            }
        }

        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType4
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteVPrest
    {

        #region Private fields
        private string _vTPrest;

        private string _vRec;

        private List<TCTeInfCteVPrestComp> _comp;
        #endregion

        public TCTeInfCteVPrest()
        {
            this._comp = new List<TCTeInfCteVPrestComp>();
        }

        public string vTPrest
        {
            get
            {
                return this._vTPrest;
            }
            set
            {
                this._vTPrest = value;
            }
        }

        public string vRec
        {
            get
            {
                return this._vRec;
            }
            set
            {
                this._vRec = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Comp")]
        public List<TCTeInfCteVPrestComp> Comp
        {
            get
            {
                return this._comp;
            }
            set
            {
                this._comp = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteVPrestComp
    {

        #region Private fields
        private string _xNome;

        private string _vComp;
        #endregion

        public string xNome
        {
            get
            {
                return this._xNome;
            }
            set
            {
                this._xNome = value;
            }
        }

        public string vComp
        {
            get
            {
                return this._vComp;
            }
            set
            {
                this._vComp = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteImp
    {

        #region Private fields
        private TImp _iCMS;

        private string _vTotTrib;

        private string _infAdFisco;

        private TCTeInfCteImpICMSUFFim _iCMSUFFim;
        #endregion

        public TCTeInfCteImp()
        {
            this._iCMSUFFim = new TCTeInfCteImpICMSUFFim();
            this._iCMS = new TImp();
        }

        public TImp ICMS
        {
            get
            {
                return this._iCMS;
            }
            set
            {
                this._iCMS = value;
            }
        }

        public string vTotTrib
        {
            get
            {
                return this._vTotTrib;
            }
            set
            {
                this._vTotTrib = value;
            }
        }

        public string infAdFisco
        {
            get
            {
                return this._infAdFisco;
            }
            set
            {
                this._infAdFisco = value;
            }
        }

        public TCTeInfCteImpICMSUFFim ICMSUFFim
        {
            get
            {
                return this._iCMSUFFim;
            }
            set
            {
                this._iCMSUFFim = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteImpICMSUFFim
    {

        #region Private fields
        private decimal _vBCUFFim;

        private decimal _pFCPUFFim;

        private decimal _pICMSUFFim;

        private decimal _pICMSInter;

        private decimal _pICMSInterPart;

        private decimal _vFCPUFFim;

        private decimal _vICMSUFFim;

        private decimal _vICMSUFIni;
        #endregion

        public decimal vBCUFFim
        {
            get
            {
                return this._vBCUFFim;
            }
            set
            {
                this._vBCUFFim = value;
            }
        }

        public decimal pFCPUFFim
        {
            get
            {
                return this._pFCPUFFim;
            }
            set
            {
                this._pFCPUFFim = value;
            }
        }

        public decimal pICMSUFFim
        {
            get
            {
                return this._pICMSUFFim;
            }
            set
            {
                this._pICMSUFFim = value;
            }
        }

        public decimal pICMSInter
        {
            get
            {
                return this._pICMSInter;
            }
            set
            {
                this._pICMSInter = value;
            }
        }

        public decimal pICMSInterPart
        {
            get
            {
                return this._pICMSInterPart;
            }
            set
            {
                this._pICMSInterPart = value;
            }
        }

        public decimal vFCPUFFim
        {
            get
            {
                return this._vFCPUFFim;
            }
            set
            {
                this._vFCPUFFim = value;
            }
        }

        public decimal vICMSUFFim
        {
            get
            {
                return this._vICMSUFFim;
            }
            set
            {
                this._vICMSUFFim = value;
            }
        }

        public decimal vICMSUFIni
        {
            get
            {
                return this._vICMSUFIni;
            }
            set
            {
                this._vICMSUFIni = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNorm
    {

        #region Private fields
        private TCTeInfCteInfCTeNormInfCarga _infCarga;

        private TCTeInfCteInfCTeNormInfDoc _infDoc;

        private List<TCTeInfCteInfCTeNormEmiDocAnt> _docAnt;

        private TCTeInfCteInfCTeNormInfModal _infModal;

        private List<TCTeInfCteInfCTeNormVeicNovos> _veicNovos;

        private TCTeInfCteInfCTeNormCobr _cobr;

        private TCTeInfCteInfCTeNormInfCteSub _infCteSub;

        private TCTeInfCteInfCTeNormInfGlobalizado _infGlobalizado;

        private List<TCTeInfCteInfCTeNormInfCTeMultimodal> _infServVinc;

        private List<TCTeOSInfCteInfCTeNormSeg> _seg;

        private List<infDocRef> _infDocRef;
        #endregion

        public TCTeInfCteInfCTeNorm()
        {
            this._infServVinc = new List<TCTeInfCteInfCTeNormInfCTeMultimodal>();
            this._infGlobalizado = new TCTeInfCteInfCTeNormInfGlobalizado();
            this._infCteSub = new TCTeInfCteInfCTeNormInfCteSub();
            this._cobr = new TCTeInfCteInfCTeNormCobr();
            this._veicNovos = new List<TCTeInfCteInfCTeNormVeicNovos>();
            this._infModal = new TCTeInfCteInfCTeNormInfModal();
            this._docAnt = new List<TCTeInfCteInfCTeNormEmiDocAnt>();
            this._infDoc = new TCTeInfCteInfCTeNormInfDoc();
            this._infCarga = new TCTeInfCteInfCTeNormInfCarga();
            this._infDocRef = new List<infDocRef>();
            this._seg = new List<TCTeOSInfCteInfCTeNormSeg>();
        }

        public TCTeInfCteInfCTeNormInfCarga infCarga
        {
            get
            {
                return this._infCarga;
            }
            set
            {
                this._infCarga = value;
            }
        }

        public TCTeInfCteInfCTeNormInfDoc infDoc
        {
            get
            {
                return this._infDoc;
            }
            set
            {
                this._infDoc = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("emiDocAnt", IsNullable = false)]
        public List<TCTeInfCteInfCTeNormEmiDocAnt> docAnt
        {
            get
            {
                return this._docAnt;
            }
            set
            {
                this._docAnt = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("infDocRef", IsNullable = false)]
        public List<infDocRef> infDocRef
        {
            get
            {
                return this._infDocRef;
            }
            set
            {
                this._infDocRef = value;
            }
        }

        public TCTeInfCteInfCTeNormInfModal infModal
        {
            get
            {
                return this._infModal;
            }
            set
            {
                this._infModal = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("veicNovos")]
        public List<TCTeInfCteInfCTeNormVeicNovos> veicNovos
        {
            get
            {
                return this._veicNovos;
            }
            set
            {
                this._veicNovos = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("seg")]
        public List<TCTeOSInfCteInfCTeNormSeg> seg
        {
            get
            {
                return this._seg;
            }
            set
            {
                this._seg = value;
            }
        }

        public TCTeInfCteInfCTeNormCobr cobr
        {
            get
            {
                return this._cobr;
            }
            set
            {
                this._cobr = value;
            }
        }

        public TCTeInfCteInfCTeNormInfCteSub infCteSub
        {
            get
            {
                return this._infCteSub;
            }
            set
            {
                this._infCteSub = value;
            }
        }

        public TCTeInfCteInfCTeNormInfGlobalizado infGlobalizado
        {
            get
            {
                return this._infGlobalizado;
            }
            set
            {
                this._infGlobalizado = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("infCTeMultimodal", IsNullable = false)]
        public List<TCTeInfCteInfCTeNormInfCTeMultimodal> infServVinc
        {
            get
            {
                return this._infServVinc;
            }
            set
            {
                this._infServVinc = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCarga
    {

        #region Private fields
        private decimal? _vCarga;

        private string _proPred;

        private string _xOutCat;

        private List<TCTeInfCteInfCTeNormInfCargaInfQ> _infQ;

        private decimal? _vCargaAverb;
        #endregion

        public TCTeInfCteInfCTeNormInfCarga()
        {
            this._infQ = new List<TCTeInfCteInfCTeNormInfCargaInfQ>();
        }

        public decimal? vCarga
        {
            get
            {
                return this._vCarga;
            }
            set
            {
                this._vCarga = value;
            }
        }

        public bool vCargaSpecified { get { return _vCarga.HasValue; } }

        public string proPred
        {
            get
            {
                return this._proPred;
            }
            set
            {
                this._proPred = value;
            }
        }

        public string xOutCat
        {
            get
            {
                return this._xOutCat;
            }
            set
            {
                this._xOutCat = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("infQ")]
        public List<TCTeInfCteInfCTeNormInfCargaInfQ> infQ
        {
            get
            {
                return this._infQ;
            }
            set
            {
                this._infQ = value;
            }
        }

        public decimal? vCargaAverb
        {
            get
            {
                return this._vCargaAverb;
            }
            set
            {
                this._vCargaAverb = value;
            }
        }

        public bool vCargaAverbSpecified { get { return vCargaAverb.HasValue; } }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCargaInfQ
    {

        #region Private fields
        private TCTeInfCteInfCTeNormInfCargaInfQCUnid _cUnid;

        private string _tpMed;

        private decimal _qCarga;
        #endregion

        public TCTeInfCteInfCTeNormInfCargaInfQCUnid cUnid
        {
            get
            {
                return this._cUnid;
            }
            set
            {
                this._cUnid = value;
            }
        }

        public string tpMed
        {
            get
            {
                return this._tpMed;
            }
            set
            {
                this._tpMed = value;
            }
        }

        public decimal qCarga
        {
            get
            {
                return this._qCarga;
            }
            set
            {
                this._qCarga = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteInfCTeNormInfCargaInfQCUnid
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfDoc
    {

        #region Private fields
        private List<object> _items;
        private string _nCont { get; set; }

        private string _dPrev { get; set; }
        #endregion

        public TCTeInfCteInfCTeNormInfDoc()
        {
            this._items = new List<object>();
        }

        public string nCont { get { return this._nCont; } set { this._nCont = value; } }

        public string dPrev { get { return this._dPrev; } set { this._dPrev = value; } }

        [System.Xml.Serialization.XmlElementAttribute("infNF", typeof(TCTeInfCteInfCTeNormInfDocInfNF))]
        [System.Xml.Serialization.XmlElementAttribute("infNFe", typeof(TCTeInfCteInfCTeNormInfDocInfNFe))]
        [System.Xml.Serialization.XmlElementAttribute("infOutros", typeof(TCTeInfCteInfCTeNormInfDocInfOutros))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfDocInfNF
    {

        #region Private fields
        private string _nRoma;

        private string _nPed;

        private TModNF _mod;

        private string _serie;

        private string _nDoc;

        private DateTime _dEmi;

        private string _vBC;

        private string _vICMS;

        private string _vBCST;

        private string _vST;

        private string _vProd;

        private string _vNF;

        private string _nCFOP;

        private string _nPeso;

        private string _pIN;

        private DateTime? _dPrev;

        private List<object> _items;
        #endregion

        public TCTeInfCteInfCTeNormInfDocInfNF()
        {
            this._items = new List<object>();
        }

        public string nRoma
        {
            get
            {
                return this._nRoma;
            }
            set
            {
                this._nRoma = value;
            }
        }

        public string nPed
        {
            get
            {
                return this._nPed;
            }
            set
            {
                this._nPed = value;
            }
        }

        public TModNF mod
        {
            get
            {
                return this._mod;
            }
            set
            {
                this._mod = value;
            }
        }

        public string serie
        {
            get
            {
                return this._serie;
            }
            set
            {
                this._serie = value;
            }
        }

        public string nDoc
        {
            get
            {
                return this._nDoc;
            }
            set
            {
                this._nDoc = value;
            }
        }

        public DateTime dEmi
        {
            get
            {
                return this._dEmi;
            }
            set
            {
                this._dEmi = value;
            }
        }

        public string vBC
        {
            get
            {
                return this._vBC;
            }
            set
            {
                this._vBC = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this._vICMS;
            }
            set
            {
                this._vICMS = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this._vBCST;
            }
            set
            {
                this._vBCST = value;
            }
        }

        public string vST
        {
            get
            {
                return this._vST;
            }
            set
            {
                this._vST = value;
            }
        }

        public string vProd
        {
            get
            {
                return this._vProd;
            }
            set
            {
                this._vProd = value;
            }
        }

        public string vNF
        {
            get
            {
                return this._vNF;
            }
            set
            {
                this._vNF = value;
            }
        }

        public string nCFOP
        {
            get
            {
                return this._nCFOP;
            }
            set
            {
                this._nCFOP = value;
            }
        }

        public string nPeso
        {
            get
            {
                return this._nPeso;
            }
            set
            {
                this._nPeso = value;
            }
        }

        public string PIN
        {
            get
            {
                return this._pIN;
            }
            set
            {
                this._pIN = value;
            }
        }

        public DateTime? dPrev
        {
            get
            {
                return this._dPrev;
            }
            set
            {
                this._dPrev = value;
            }
        }

        public string ProxyddPrev
        {
            get
            {
                if (dPrev != null)
                {
                    return dPrev.Value.ParaDataString();
                }
                return null;
            }
            set { dPrev = DateTime.Parse(value); }
        }

        public string ProxyddEmi
        {
            get
            {
                if (dEmi != null)
                {
                    return dEmi.ParaDataString();
                }
                return null;
            }
            set { dEmi = DateTime.Parse(value); }
        }

        [System.Xml.Serialization.XmlElementAttribute("infUnidCarga", typeof(TUnidCarga))]
        [System.Xml.Serialization.XmlElementAttribute("infUnidTransp", typeof(TUnidadeTransp))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfDocInfNFe
    {

        #region Private fields
        private string _chave;

        private string _pIN;

        private DateTime? _dPrev;

        private List<object> _items;
        #endregion

        public TCTeInfCteInfCTeNormInfDocInfNFe()
        {
            this._items = new List<object>();
        }

        public string chave
        {
            get
            {
                return this._chave;
            }
            set
            {
                this._chave = value;
            }
        }

        public string PIN
        {
            get
            {
                return this._pIN;
            }
            set
            {
                this._pIN = value;
            }
        }

        public DateTime? dPrev
        {
            get
            {
                return this._dPrev;
            }
            set
            {
                this._dPrev = value;
            }
        }

        public string ProxyddPrev
        {
            get
            {
                if (dPrev != null)
                {
                    return dPrev.Value.ParaDataString();
                }
                return null;
            }
            set { dPrev = DateTime.Parse(value); }
        }

        [System.Xml.Serialization.XmlElementAttribute("infUnidCarga", typeof(TUnidCarga))]
        [System.Xml.Serialization.XmlElementAttribute("infUnidTransp", typeof(TUnidadeTransp))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfDocInfOutros
    {

        #region Private fields
        private TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc _tpDoc;

        private string _descOutros;

        private string _nDoc;

        private DateTime? _dEmi;

        private decimal? _vDocFisc;

        private DateTime? _dPrev;

        private List<object> _items;
        #endregion

        public TCTeInfCteInfCTeNormInfDocInfOutros()
        {
            this._items = new List<object>();
        }

        public TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc tpDoc
        {
            get
            {
                return this._tpDoc;
            }
            set
            {
                this._tpDoc = value;
            }
        }

        public string descOutros
        {
            get
            {
                return this._descOutros;
            }
            set
            {
                this._descOutros = value;
            }
        }

        public string nDoc
        {
            get
            {
                return this._nDoc;
            }
            set
            {
                this._nDoc = value;
            }
        }

        public DateTime? dEmi
        {
            get
            {
                return this._dEmi;
            }
            set
            {
                this._dEmi = value;
            }
        }

        public string ProxyddEmi
        {
            get
            {
                if (dEmi != null)
                {
                    return dEmi.Value.ParaDataString();
                }
                return null;
            }
            set { dEmi = DateTime.Parse(value); }
        }

        public decimal? vDocFisc
        {
            get { return _vDocFisc.Arredondar(2); }
            set { _vDocFisc = value.Arredondar(2); }
        }

        public bool vDocFiscSpecified { get { return vDocFisc.HasValue; } }

        public DateTime? dPrev
        {
            get
            {
                return this._dPrev;
            }
            set
            {
                this._dPrev = value;
            }
        }

        public string ProxyddPrev
        {
            get
            {
                if (dPrev != null)
                {
                    return dPrev.Value.ParaDataString();
                }
                return null;
            }
            set { dPrev = DateTime.Parse(value); }
        }

        [System.Xml.Serialization.XmlElementAttribute("infUnidCarga", typeof(TUnidCarga))]
        [System.Xml.Serialization.XmlElementAttribute("infUnidTransp", typeof(TUnidadeTransp))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormEmiDocAnt
    {

        #region Private fields
        private string _item;

        private ItemChoiceType5 _itemElementName;

        private string _ie;

        private TUf _uf;

        private string _xNome;

        private List<TCTeInfCteInfCTeNormEmiDocAntIdDocAnt> _idDocAnt;
        #endregion

        public TCTeInfCteInfCTeNormEmiDocAnt()
        {
            this._idDocAnt = new List<TCTeInfCteInfCTeNormEmiDocAntIdDocAnt>();
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ")]
        [System.Xml.Serialization.XmlElementAttribute("CPF")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }

        public string IE
        {
            get
            {
                return this._ie;
            }
            set
            {
                this._ie = value;
            }
        }

        public TUf UF
        {
            get
            {
                return this._uf;
            }
            set
            {
                this._uf = value;
            }
        }

        public string xNome
        {
            get
            {
                return this._xNome;
            }
            set
            {
                this._xNome = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("idDocAnt")]
        public List<TCTeInfCteInfCTeNormEmiDocAntIdDocAnt> idDocAnt
        {
            get
            {
                return this._idDocAnt;
            }
            set
            {
                this._idDocAnt = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType5
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormEmiDocAntIdDocAnt
    {

        #region Private fields
        private List<object> _items;
        #endregion

        public TCTeInfCteInfCTeNormEmiDocAntIdDocAnt()
        {
            this._items = new List<object>();
        }

        [System.Xml.Serialization.XmlElementAttribute("idDocAntEle", typeof(TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntEle))]
        [System.Xml.Serialization.XmlElementAttribute("idDocAntPap", typeof(TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPap))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntEle
    {

        #region Private fields
        private string _chCTe;
        #endregion

        public string chCTe
        {
            get
            {
                return this._chCTe;
            }
            set
            {
                this._chCTe = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPap
    {

        #region Private fields
        private TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPapTpDoc _tpDoc;

        private string _serie;

        private string _subser;

        private string _nDoc;

        private string _dEmi;
        #endregion

        public TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPapTpDoc tpDoc
        {
            get
            {
                return this._tpDoc;
            }
            set
            {
                this._tpDoc = value;
            }
        }

        public string serie
        {
            get
            {
                return this._serie;
            }
            set
            {
                this._serie = value;
            }
        }

        public string subser
        {
            get
            {
                return this._subser;
            }
            set
            {
                this._subser = value;
            }
        }

        public string nDoc
        {
            get
            {
                return this._nDoc;
            }
            set
            {
                this._nDoc = value;
            }
        }

        public string dEmi
        {
            get
            {
                return this._dEmi;
            }
            set
            {
                this._dEmi = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPapTpDoc
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfModal
    {

        #region Private fields
        private ContainerModal _containerModal;

        private string _versaoModal;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("rodo", typeof(rodo))]
        [System.Xml.Serialization.XmlElementAttribute("rodoOS", typeof(rodoOS))]
        [System.Xml.Serialization.XmlElementAttribute("aereo", typeof(aereo))]
        [System.Xml.Serialization.XmlElementAttribute("aquav", typeof(aquav))]
        [System.Xml.Serialization.XmlElementAttribute("ferrov", typeof(ferrov))]
        [System.Xml.Serialization.XmlElementAttribute("duto", typeof(duto))]
        [System.Xml.Serialization.XmlElementAttribute("multimodal", typeof(multimodal))]
        public ContainerModal ContainerModal
        {
            get
            {
                return this._containerModal;
            }
            set
            {
                this._containerModal = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versaoModal
        {
            get
            {
                return this._versaoModal;
            }
            set
            {
                this._versaoModal = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public abstract class ContainerModal
    {

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormVeicNovos
    {

        #region Private fields
        private string _chassi;

        private string _cCor;

        private string _xCor;

        private string _cMod;

        private string _vUnit;

        private string _vFrete;
        #endregion

        public string chassi
        {
            get
            {
                return this._chassi;
            }
            set
            {
                this._chassi = value;
            }
        }

        public string cCor
        {
            get
            {
                return this._cCor;
            }
            set
            {
                this._cCor = value;
            }
        }

        public string xCor
        {
            get
            {
                return this._xCor;
            }
            set
            {
                this._xCor = value;
            }
        }

        public string cMod
        {
            get
            {
                return this._cMod;
            }
            set
            {
                this._cMod = value;
            }
        }

        public string vUnit
        {
            get
            {
                return this._vUnit;
            }
            set
            {
                this._vUnit = value;
            }
        }

        public string vFrete
        {
            get
            {
                return this._vFrete;
            }
            set
            {
                this._vFrete = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormCobr
    {

        #region Private fields
        private TCTeInfCteInfCTeNormCobrFat _fat;

        private List<TCTeInfCteInfCTeNormCobrDup> _dup;
        #endregion

        public TCTeInfCteInfCTeNormCobr()
        {
            this._dup = new List<TCTeInfCteInfCTeNormCobrDup>();
            this._fat = new TCTeInfCteInfCTeNormCobrFat();
        }

        public TCTeInfCteInfCTeNormCobrFat fat
        {
            get
            {
                return this._fat;
            }
            set
            {
                this._fat = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("dup")]
        public List<TCTeInfCteInfCTeNormCobrDup> dup
        {
            get
            {
                return this._dup;
            }
            set
            {
                this._dup = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormCobrFat
    {

        #region Private fields
        private string _nFat;

        private decimal? _vOrig;
        private decimal? _vDesc;
        private decimal? _vLiq;
        #endregion

        public string nFat
        {
            get
            {
                return this._nFat;
            }
            set
            {
                this._nFat = value;
            }
        }

        public decimal? vOrig
        {
            get { return _vOrig.Arredondar(2); }
            set { _vOrig = value.Arredondar(2); }
        }

        public decimal? vDesc
        {
            get { return _vDesc.Arredondar(2); }
            set { _vDesc = value.Arredondar(2); }
        }

        public decimal? vLiq
        {
            get { return _vLiq.Arredondar(2); }
            set { _vLiq = value.Arredondar(2); }
        }


        public bool vOrigSpecified { get { return vOrig.HasValue; } }
        public bool vDescSpecified { get { return vDesc.HasValue; } }
        public bool vLiqSpecified { get { return vLiq.HasValue; } }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormCobrDup
    {

        #region Private fields
        private string _nDup;

        private string _dVenc;

        private string _vDup;
        #endregion

        public string nDup
        {
            get
            {
                return this._nDup;
            }
            set
            {
                this._nDup = value;
            }
        }

        public string dVenc
        {
            get
            {
                return this._dVenc;
            }
            set
            {
                this._dVenc = value;
            }
        }

        public string vDup
        {
            get
            {
                return this._vDup;
            }
            set
            {
                this._vDup = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCteSub
    {

        #region Private fields
        private string _chCte;
        private string _refCteAnu;
        private object _item;

        private TCTeInfCteInfCTeNormInfCteSubIndAlteraToma _indAlteraToma;
        #endregion

        public string chCte
        {
            get
            {
                return this._chCte;
            }
            set
            {
                this._chCte = value;
            }
        }

        public string refCteAnu { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("tomaICMS", typeof(TCTeInfCteInfCTeNormInfCteSubTomaICMS))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        public TCTeInfCteInfCTeNormInfCteSubIndAlteraToma? indAlteraToma { get; set; }
        public bool indAlteraTomaSpecified { get { return indAlteraToma.HasValue; } }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCteSubTomaICMS
    {

        #region Private fields
        private object _item;

        private ItemChoiceType7 _itemElementName;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("refCte", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("refNF", typeof(TCTeInfCteInfCTeNormInfCteSubTomaICMSRefNF))]
        [System.Xml.Serialization.XmlElementAttribute("refNFe", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType7 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCteSubTomaICMSRefNF
    {

        #region Private fields
        private string _item;

        private ItemChoiceType6 _itemElementName;

        private TModDoc _mod;

        private int _serie;

        private int? _subserie;

        private int _nro;

        private string _valor;

        private DateTime _dEmi;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("CNPJ")]
        [System.Xml.Serialization.XmlElementAttribute("CPF")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }

        public TModDoc mod
        {
            get
            {
                return this._mod;
            }
            set
            {
                this._mod = value;
            }
        }

        public int serie
        {
            get
            {
                return this._serie;
            }
            set
            {
                this._serie = value;
            }
        }

        public int? subserie
        {
            get
            {
                return this._subserie;
            }
            set
            {
                this._subserie = value;
            }
        }

        public bool subserieSpecified { get { return subserie.HasValue; } }

        public int nro
        {
            get
            {
                return this._nro;
            }
            set
            {
                this._nro = value;
            }
        }

        public string valor
        {
            get
            {
                return this._valor;
            }
            set
            {
                this._valor = value;
            }
        }

        public DateTime dEmi
        {
            get
            {
                return this._dEmi;
            }
            set
            {
                this._dEmi = value;
            }
        }

        public string ProxydEmi
        {
            get { return dEmi.ParaDataString(); }
            set { dEmi = Convert.ToDateTime(value); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType6
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModDoc
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1B")]
        Item1B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2D")]
        Item2D,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2E")]
        Item2E,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8B")]
        Item8B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType7
    {

        /// <remarks/>
        refCte,

        /// <remarks/>
        refNF,

        /// <remarks/>
        refNFe,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteInfCTeNormInfCteSubIndAlteraToma
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfGlobalizado
    {

        #region Private fields
        private string _xObs;
        #endregion

        public string xObs
        {
            get
            {
                return this._xObs;
            }
            set
            {
                this._xObs = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCTeMultimodal
    {

        #region Private fields
        private string _chCTeMultimodal;
        #endregion

        public string chCTeMultimodal
        {
            get
            {
                return this._chCTeMultimodal;
            }
            set
            {
                this._chCTeMultimodal = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCteAnu
    {

        #region Private fields
        private string _chCte;

        private DateTime _dEmi;
        #endregion

        public string chCte
        {
            get
            {
                return this._chCte;
            }
            set
            {
                this._chCte = value;
            }
        }

        public DateTime dEmi
        {
            get
            {
                return this._dEmi;
            }
            set
            {
                this._dEmi = value;
            }
        }

        public string ProxydEmi
        {
            get { return dEmi.ParaDataString(); }
            set { dEmi = Convert.ToDateTime(value); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCteComp
    {

        #region Private fields
        private string _chave;

        private string _chCTe;
        #endregion

        public string chave
        {
            get
            {
                return this._chave;
            }
            set
            {
                this._chave = value;
            }
        }

        public string chCTe
        {
            get
            {
                return this._chCTe;
            }
            set
            {
                this._chCTe = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteAutXML
    {

        #region Private fields
        private string _item;

        private ItemChoiceType8 _itemElementName;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("CNPJ")]
        [System.Xml.Serialization.XmlElementAttribute("CPF")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType8 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType8
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }
}
