namespace Zion.NFe.Danfe.Dacte.ModelCte
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class multimodal : ContainerModal
    {

        #region Private fields
        private string _cOTM;

        private multimodalIndNegociavel _indNegociavel;

        private multimodalSeg _seg;
        #endregion

        public multimodal()
        {
            this._seg = new multimodalSeg();
        }

        public string COTM
        {
            get
            {
                return this._cOTM;
            }
            set
            {
                this._cOTM = value;
            }
        }

        public multimodalIndNegociavel indNegociavel
        {
            get
            {
                return this._indNegociavel;
            }
            set
            {
                this._indNegociavel = value;
            }
        }

        public multimodalSeg seg
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

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum multimodalIndNegociavel
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class multimodalSeg
    {

        #region Private fields
        private multimodalSegInfSeg _infSeg;

        private string _nApol;

        private string _nAver;
        #endregion

        public multimodalSeg()
        {
            this._infSeg = new multimodalSegInfSeg();
        }

        public multimodalSegInfSeg infSeg
        {
            get
            {
                return this._infSeg;
            }
            set
            {
                this._infSeg = value;
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

        public string nAver
        {
            get
            {
                return this._nAver;
            }
            set
            {
                this._nAver = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class multimodalSegInfSeg
    {

        #region Private fields
        private string _xSeg;

        private string _cNPJ;
        #endregion

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
    }
}
