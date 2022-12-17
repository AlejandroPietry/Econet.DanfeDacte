using System.Collections.Generic;

namespace Zion.NFe.Danfe.Dacte.isolado
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class cteOSProc
    {

        #region Private fields
        private TCTeOS _cTeOS;

        private TProtCTeOS _protCTe;

        private string _versao;

        private string _ipTransmissor;
        #endregion

        public cteOSProc()
        {
            this._protCTe = new TProtCTeOS();
            this._cTeOS = new TCTeOS();
        }

        public TCTeOS CTeOS
        {
            get
            {
                return this._cTeOS;
            }
            set
            {
                this._cTeOS = value;
            }
        }

        public TProtCTeOS protCTe
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOS
    {

        #region Private fields
        private TCTeOSInfCte _infCte;

        private SignatureType _signature;

        private string _versao;
        #endregion

        public TCTeOS()
        {
            this._signature = new SignatureType();
            this._infCte = new TCTeOSInfCte();
        }

        public TCTeOSInfCte infCte
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCte
    {

        #region Private fields
        private TCTeOSInfCteIde _ide;

        private TCTeOSInfCteCompl _compl;

        private TCTeOSInfCteEmit _emit;

        private TCTeOSInfCteToma _toma;

        private TCTeOSInfCteVPrest _vPrest;

        private TCTeOSInfCteImp _imp;

        private object _item;

        private List<TCTeOSInfCteAutXML> _autXML;

        private string _versao;

        private string _id;
        #endregion

        public TCTeOSInfCte()
        {
            this._autXML = new List<TCTeOSInfCteAutXML>();
            this._imp = new TCTeOSInfCteImp();
            this._vPrest = new TCTeOSInfCteVPrest();
            this._toma = new TCTeOSInfCteToma();
            this._emit = new TCTeOSInfCteEmit();
            this._compl = new TCTeOSInfCteCompl();
            this._ide = new TCTeOSInfCteIde();
        }

        public TCTeOSInfCteIde ide
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

        public TCTeOSInfCteCompl compl
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

        public TCTeOSInfCteEmit emit
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

        public TCTeOSInfCteToma toma
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

        public TCTeOSInfCteVPrest vPrest
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

        public TCTeOSInfCteImp imp
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

        [System.Xml.Serialization.XmlElementAttribute("infCTeNorm", typeof(TCTeOSInfCteInfCTeNorm))]
        [System.Xml.Serialization.XmlElementAttribute("infCteAnu", typeof(TCTeOSInfCteInfCteAnu))]
        [System.Xml.Serialization.XmlElementAttribute("infCteComp", typeof(TCTeOSInfCteInfCteComp))]
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
        public List<TCTeOSInfCteAutXML> autXML
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteIde
    {

        #region Private fields
        private TCodUfIBGE _cUF;

        private string _cCT;

        private string _cFOP;

        private string _natOp;

        private TModCTOS _mod;

        private string _serie;

        private string _nCT;

        private string _dhEmi;

        private TCTeOSInfCteIdeTpImp _tpImp;

        private TCTeOSInfCteIdeTpEmis _tpEmis;

        private string _cDV;

        private TAmb _tpAmb;

        private TFinCTe _tpCTe;

        private TProcEmi _procEmi;

        private string _verProc;

        private string _cMunEnv;

        private string _xMunEnv;

        private TUf _uFEnv;

        private TModTranspOS _modal;

        private TCTeOSInfCteIdeTpServ _tpServ;

        private TCTeOSInfCteIdeIndIEToma _indIEToma;

        private string _cMunIni;

        private string _xMunIni;

        private TUf _uFIni;

        private string _cMunFim;

        private string _xMunFim;

        private TUf _uFFim;

        private List<TCTeOSInfCteIdeInfPercurso> _infPercurso;

        private string _dhCont;

        private string _xJust;
        #endregion

        public TCTeOSInfCteIde()
        {
            this._infPercurso = new List<TCTeOSInfCteIdeInfPercurso>();
        }

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

        public TModCTOS mod
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

        public TCTeOSInfCteIdeTpImp tpImp
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

        public TCTeOSInfCteIdeTpEmis tpEmis
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

        public TModTranspOS modal
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

        public TCTeOSInfCteIdeTpServ tpServ
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

        public TCTeOSInfCteIdeIndIEToma indIEToma
        {
            get
            {
                return this._indIEToma;
            }
            set
            {
                this._indIEToma = value;
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

        [System.Xml.Serialization.XmlElementAttribute("infPercurso")]
        public List<TCTeOSInfCteIdeInfPercurso> infPercurso
        {
            get
            {
                return this._infPercurso;
            }
            set
            {
                this._infPercurso = value;
            }
        }

        public string dhCont
        {
            get
            {
                return this._dhCont;
            }
            set
            {
                this._dhCont = value;
            }
        }

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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModCTOS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeOSInfCteIdeTpImp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeOSInfCteIdeTpEmis
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TFinCTe
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TUf
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

        /// <remarks/>
        EX,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModTranspOS
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeOSInfCteIdeTpServ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeOSInfCteIdeIndIEToma
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteIdeInfPercurso
    {

        #region Private fields
        private TUf _uFPer;
        #endregion

        public TUf UFPer
        {
            get
            {
                return this._uFPer;
            }
            set
            {
                this._uFPer = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TProtCTeOS
    {

        #region Private fields
        private TProtCTeOSInfProt _infProt;

        private SignatureType _signature;

        private string _versao;
        #endregion

        public TProtCTeOS()
        {
            this._signature = new SignatureType();
            this._infProt = new TProtCTeOSInfProt();
        }

        public TProtCTeOSInfProt infProt
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TProtCTeOSInfProt
    {

        #region Private fields
        private TAmb _tpAmb;

        private string _verAplic;

        private string _chCTe;

        private string _dhRecbto;

        private string _nProt;

        private byte[] _digVal;

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

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] digVal
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOS
    {

        #region Private fields
        private object _item;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TImpOSICMS00))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS45", typeof(TImpOSICMS45))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TImpOSICMS90))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSOutraUF", typeof(TImpOSICMSOutraUF))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN", typeof(TImpOSICMSSN))]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMS00
    {

        #region Private fields
        private TImpOSICMS00CST _cST;

        private string _vBC;

        private string _pICMS;

        private string _vICMS;
        #endregion

        public TImpOSICMS00CST CST
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMS00CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMS45
    {

        #region Private fields
        private TImpOSICMS45CST _cST;
        #endregion

        public TImpOSICMS45CST CST
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMS45CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMS90
    {

        #region Private fields
        private TImpOSICMS90CST _cST;

        private string _pRedBC;

        private string _vBC;

        private string _pICMS;

        private string _vICMS;

        private string _vCred;
        #endregion

        public TImpOSICMS90CST CST
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMS90CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMSOutraUF
    {

        #region Private fields
        private TImpOSICMSOutraUFCST _cST;

        private string _pRedBCOutraUF;

        private string _vBCOutraUF;

        private string _pICMSOutraUF;

        private string _vICMSOutraUF;
        #endregion

        public TImpOSICMSOutraUFCST CST
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMSOutraUFCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMSSN
    {

        #region Private fields
        private TImpOSICMSSNCST _cST;

        private TImpOSICMSSNIndSN _indSN;
        #endregion

        public TImpOSICMSSNCST CST
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

        public TImpOSICMSSNIndSN indSN
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMSSNCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMSSNIndSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

        private string _cPais;

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

        public string cPais
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteCompl
    {

        #region Private fields
        private string _xCaracAd;

        private string _xCaracSer;

        private string _xEmi;

        private string _xObs;

        private List<TCTeOSInfCteComplObsCont> _obsCont;

        private List<TCTeOSInfCteComplObsFisco> _obsFisco;
        #endregion

        public TCTeOSInfCteCompl()
        {
            this._obsFisco = new List<TCTeOSInfCteComplObsFisco>();
            this._obsCont = new List<TCTeOSInfCteComplObsCont>();
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
        public List<TCTeOSInfCteComplObsCont> ObsCont
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
        public List<TCTeOSInfCteComplObsFisco> ObsFisco
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteComplObsCont
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteComplObsFisco
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteEmit
    {

        #region Private fields
        private string _cNPJ;

        private string _ie;

        private string _iEST;

        private string _xNome;

        private string _xFant;

        private TEndeEmi _enderEmit;
        #endregion

        public TCTeOSInfCteEmit()
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteToma
    {

        #region Private fields
        private string _item;

        private ItemChoiceType _itemElementName;

        private string _ie;

        private string _xNome;

        private string _xFant;

        private string _fone;

        private TEndereco _enderToma;

        private string _email;
        #endregion

        public TCTeOSInfCteToma()
        {
            this._enderToma = new TEndereco();
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteVPrest
    {

        #region Private fields
        private string _vTPrest;

        private string _vRec;

        private List<TCTeOSInfCteVPrestComp> _comp;
        #endregion

        public TCTeOSInfCteVPrest()
        {
            this._comp = new List<TCTeOSInfCteVPrestComp>();
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
        public List<TCTeOSInfCteVPrestComp> Comp
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteVPrestComp
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteImp
    {

        #region Private fields
        private TImpOS _iCMS;

        private string _vTotTrib;

        private string _infAdFisco;

        private TCTeOSInfCteImpICMSUFFim _iCMSUFFim;

        private TCTeOSInfCteImpInfTribFed _infTribFed;
        #endregion

        public TCTeOSInfCteImp()
        {
            this._infTribFed = new TCTeOSInfCteImpInfTribFed();
            this._iCMSUFFim = new TCTeOSInfCteImpICMSUFFim();
            this._iCMS = new TImpOS();
        }

        public TImpOS ICMS
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

        public TCTeOSInfCteImpICMSUFFim ICMSUFFim
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

        public TCTeOSInfCteImpInfTribFed infTribFed
        {
            get
            {
                return this._infTribFed;
            }
            set
            {
                this._infTribFed = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteImpICMSUFFim
    {

        #region Private fields
        private string _vBCUFFim;

        private string _pFCPUFFim;

        private string _pICMSUFFim;

        private string _pICMSInter;

        private string _pICMSInterPart;

        private string _vFCPUFFim;

        private string _vICMSUFFim;

        private string _vICMSUFIni;
        #endregion

        public string vBCUFFim
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

        public string pFCPUFFim
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

        public string pICMSUFFim
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

        public string pICMSInter
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

        public string pICMSInterPart
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

        public string vFCPUFFim
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

        public string vICMSUFFim
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

        public string vICMSUFIni
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteImpInfTribFed
    {

        #region Private fields
        private string _vPIS;

        private string _vCOFINS;

        private string _vIR;

        private string _vINSS;

        private string _vCSLL;
        #endregion

        public string vPIS
        {
            get
            {
                return this._vPIS;
            }
            set
            {
                this._vPIS = value;
            }
        }

        public string vCOFINS
        {
            get
            {
                return this._vCOFINS;
            }
            set
            {
                this._vCOFINS = value;
            }
        }

        public string vIR
        {
            get
            {
                return this._vIR;
            }
            set
            {
                this._vIR = value;
            }
        }

        public string vINSS
        {
            get
            {
                return this._vINSS;
            }
            set
            {
                this._vINSS = value;
            }
        }

        public string vCSLL
        {
            get
            {
                return this._vCSLL;
            }
            set
            {
                this._vCSLL = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNorm
    {

        #region Private fields
        private TCTeOSInfCteInfCTeNormInfServico _infServico;

        private List<TCTeOSInfCteInfCTeNormInfDocRef> _infDocRef;

        private List<TCTeOSInfCteInfCTeNormSeg> _seg;

        private TCTeOSInfCteInfCTeNormInfModal _infModal;

        private TCTeOSInfCteInfCTeNormInfCteSub _infCteSub;

        private string _refCTeCanc;

        private TCTeOSInfCteInfCTeNormCobr _cobr;
        #endregion

        public TCTeOSInfCteInfCTeNorm()
        {
            this._cobr = new TCTeOSInfCteInfCTeNormCobr();
            this._infCteSub = new TCTeOSInfCteInfCTeNormInfCteSub();
            this._infModal = new TCTeOSInfCteInfCTeNormInfModal();
            this._seg = new List<TCTeOSInfCteInfCTeNormSeg>();
            this._infDocRef = new List<TCTeOSInfCteInfCTeNormInfDocRef>();
            this._infServico = new TCTeOSInfCteInfCTeNormInfServico();
        }

        public TCTeOSInfCteInfCTeNormInfServico infServico
        {
            get
            {
                return this._infServico;
            }
            set
            {
                this._infServico = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("infDocRef")]
        public List<TCTeOSInfCteInfCTeNormInfDocRef> infDocRef
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

        public TCTeOSInfCteInfCTeNormInfModal infModal
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

        public TCTeOSInfCteInfCTeNormInfCteSub infCteSub
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

        public string refCTeCanc
        {
            get
            {
                return this._refCTeCanc;
            }
            set
            {
                this._refCTeCanc = value;
            }
        }

        public TCTeOSInfCteInfCTeNormCobr cobr
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfServico
    {

        #region Private fields
        private string _xDescServ;

        private TCTeOSInfCteInfCTeNormInfServicoInfQ _infQ;
        #endregion

        public TCTeOSInfCteInfCTeNormInfServico()
        {
            this._infQ = new TCTeOSInfCteInfCTeNormInfServicoInfQ();
        }

        public string xDescServ
        {
            get
            {
                return this._xDescServ;
            }
            set
            {
                this._xDescServ = value;
            }
        }

        public TCTeOSInfCteInfCTeNormInfServicoInfQ infQ
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfServicoInfQ
    {

        #region Private fields
        private string _qCarga;
        #endregion

        public string qCarga
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfDocRef
    {

        #region Private fields
        private string _nDoc;

        private string _serie;

        private string _subserie;

        private string _dEmi;

        private string _vDoc;
        #endregion

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

        public string subserie
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

        public string vDoc
        {
            get
            {
                return this._vDoc;
            }
            set
            {
                this._vDoc = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormSeg
    {

        #region Private fields
        private TCTeOSInfCteInfCTeNormSegRespSeg _respSeg;

        private string _xSeg;

        private string _nApol;
        #endregion

        public TCTeOSInfCteInfCTeNormSegRespSeg respSeg
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

        public string xSeg
        {
            get
            {
                return this._xSeg;
            }
            set
            {
                this._xSeg = value;
            }
        }

        public string nApol
        {
            get
            {
                return this._nApol;
            }
            set
            {
                this._nApol = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeOSInfCteInfCTeNormSegRespSeg
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfModal
    {

        #region Private fields
        private System.Xml.XmlElement _any;

        private string _versaoModal;
        #endregion

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfCteSub
    {

        #region Private fields
        private string _chCte;

        private object _item;
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

        [System.Xml.Serialization.XmlElementAttribute("refCteAnu", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("tomaICMS", typeof(TCTeOSInfCteInfCTeNormInfCteSubTomaICMS))]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfCteSubTomaICMS
    {

        #region Private fields
        private object _item;

        private ItemChoiceType2 _itemElementName;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute("refCte", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("refNF", typeof(TCTeOSInfCteInfCTeNormInfCteSubTomaICMSRefNF))]
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfCteSubTomaICMSRefNF
    {

        #region Private fields
        private string _item;

        private ItemChoiceType1 _itemElementName;

        private TModDoc _mod;

        private string _serie;

        private string _subserie;

        private string _nro;

        private string _valor;

        private string _dEmi;
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

        public string subserie
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {

        /// <remarks/>
        refCte,

        /// <remarks/>
        refNF,

        /// <remarks/>
        refNFe,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormCobr
    {

        #region Private fields
        private TCTeOSInfCteInfCTeNormCobrFat _fat;

        private List<TCTeOSInfCteInfCTeNormCobrDup> _dup;
        #endregion

        public TCTeOSInfCteInfCTeNormCobr()
        {
            this._dup = new List<TCTeOSInfCteInfCTeNormCobrDup>();
            this._fat = new TCTeOSInfCteInfCTeNormCobrFat();
        }

        public TCTeOSInfCteInfCTeNormCobrFat fat
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
        public List<TCTeOSInfCteInfCTeNormCobrDup> dup
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormCobrFat
    {

        #region Private fields
        private string _nFat;

        private string _vOrig;

        private string _vDesc;

        private string _vLiq;
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

        public string vOrig
        {
            get
            {
                return this._vOrig;
            }
            set
            {
                this._vOrig = value;
            }
        }

        public string vDesc
        {
            get
            {
                return this._vDesc;
            }
            set
            {
                this._vDesc = value;
            }
        }

        public string vLiq
        {
            get
            {
                return this._vLiq;
            }
            set
            {
                this._vLiq = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormCobrDup
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCteAnu
    {

        #region Private fields
        private string _chCte;

        private string _dEmi;
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCteComp
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteAutXML
    {

        #region Private fields
        private string _item;

        private ItemChoiceType3 _itemElementName;
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2634.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType3
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }
}
