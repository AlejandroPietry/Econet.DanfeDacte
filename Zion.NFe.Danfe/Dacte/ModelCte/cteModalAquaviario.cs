using System.Collections.Generic;

namespace Zion.NFe.Danfe.Dacte.ModelCte
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class aquav : ContainerModal
    {

        #region Private fields
        private string _vPrest;

        private string _vAFRMM;

        private string _xNavio;

        private List<aquavBalsa> _balsa;

        private string _nViag;

        private aquavDirec _direc;

        private string _irin;

        private List<aquavDetCont> _detCont;

        private aquavTpNav _tpNav;
        #endregion

        public aquav()
        {
            this._detCont = new List<aquavDetCont>();
            this._balsa = new List<aquavBalsa>();
        }

        public string vPrest
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

        public string vAFRMM
        {
            get
            {
                return this._vAFRMM;
            }
            set
            {
                this._vAFRMM = value;
            }
        }

        public string xNavio
        {
            get
            {
                return this._xNavio;
            }
            set
            {
                this._xNavio = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("balsa")]
        public List<aquavBalsa> balsa
        {
            get
            {
                return this._balsa;
            }
            set
            {
                this._balsa = value;
            }
        }

        public string nViag
        {
            get
            {
                return this._nViag;
            }
            set
            {
                this._nViag = value;
            }
        }

        public aquavDirec direc
        {
            get
            {
                return this._direc;
            }
            set
            {
                this._direc = value;
            }
        }

        public string irin
        {
            get
            {
                return this._irin;
            }
            set
            {
                this._irin = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("detCont")]
        public List<aquavDetCont> detCont
        {
            get
            {
                return this._detCont;
            }
            set
            {
                this._detCont = value;
            }
        }

        public aquavTpNav tpNav
        {
            get
            {
                return this._tpNav;
            }
            set
            {
                this._tpNav = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aquavBalsa
    {

        #region Private fields
        private string _xBalsa;
        #endregion

        public string xBalsa
        {
            get
            {
                return this._xBalsa;
            }
            set
            {
                this._xBalsa = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum aquavDirec
    {

        /// <remarks/>
        N,

        /// <remarks/>
        S,

        /// <remarks/>
        L,

        /// <remarks/>
        O,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aquavDetCont
    {

        #region Private fields
        private string _nCont;

        private List<aquavDetContLacre> _lacre;

        private aquavDetContInfDoc _infDoc;
        #endregion

        public aquavDetCont()
        {
            this._infDoc = new aquavDetContInfDoc();
            this._lacre = new List<aquavDetContLacre>();
        }

        public string nCont
        {
            get
            {
                return this._nCont;
            }
            set
            {
                this._nCont = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("lacre")]
        public List<aquavDetContLacre> lacre
        {
            get
            {
                return this._lacre;
            }
            set
            {
                this._lacre = value;
            }
        }

        public aquavDetContInfDoc infDoc
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aquavDetContLacre
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aquavDetContInfDoc
    {

        #region Private fields
        private List<object> _items;
        #endregion

        public aquavDetContInfDoc()
        {
            this._items = new List<object>();
        }

        [System.Xml.Serialization.XmlElementAttribute("infNF", typeof(aquavDetContInfDocInfNF))]
        [System.Xml.Serialization.XmlElementAttribute("infNFe", typeof(aquavDetContInfDocInfNFe))]
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
    public partial class aquavDetContInfDocInfNF
    {

        #region Private fields
        private string _serie;

        private string _nDoc;

        private string _unidRat;
        #endregion

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

        public string unidRat
        {
            get
            {
                return this._unidRat;
            }
            set
            {
                this._unidRat = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aquavDetContInfDocInfNFe
    {

        #region Private fields
        private string _chave;

        private string _unidRat;
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

        public string unidRat
        {
            get
            {
                return this._unidRat;
            }
            set
            {
                this._unidRat = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum aquavTpNav
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
}
