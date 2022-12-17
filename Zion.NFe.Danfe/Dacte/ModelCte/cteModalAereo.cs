using System.Collections.Generic;

namespace Zion.NFe.Danfe.Dacte.ModelCte
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class aereo : ContainerModal
    {

        #region Private fields
        private string _nMinu;

        private string _nOCA;

        private string _dPrevAereo;

        private aereoNatCarga _natCarga;

        private aereoTarifa _tarifa;

        private List<aereoPeri> _peri;
        #endregion

        public aereo()
        {
            this._peri = new List<aereoPeri>();
            this._tarifa = new aereoTarifa();
            this._natCarga = new aereoNatCarga();
        }

        public string nMinu
        {
            get
            {
                return this._nMinu;
            }
            set
            {
                this._nMinu = value;
            }
        }

        public string nOCA
        {
            get
            {
                return this._nOCA;
            }
            set
            {
                this._nOCA = value;
            }
        }

        public string dPrevAereo
        {
            get
            {
                return this._dPrevAereo;
            }
            set
            {
                this._dPrevAereo = value;
            }
        }

        public aereoNatCarga natCarga
        {
            get
            {
                return this._natCarga;
            }
            set
            {
                this._natCarga = value;
            }
        }

        public aereoTarifa tarifa
        {
            get
            {
                return this._tarifa;
            }
            set
            {
                this._tarifa = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("peri")]
        public List<aereoPeri> peri
        {
            get
            {
                return this._peri;
            }
            set
            {
                this._peri = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aereoNatCarga
    {

        #region Private fields
        private string _xDime;

        private List<aereoNatCargaCInfManu> _cInfManu;
        #endregion

        public aereoNatCarga()
        {
            this._cInfManu = new List<aereoNatCargaCInfManu>();
        }

        public string xDime
        {
            get
            {
                return this._xDime;
            }
            set
            {
                this._xDime = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("cInfManu")]
        public List<aereoNatCargaCInfManu> cInfManu
        {
            get
            {
                return this._cInfManu;
            }
            set
            {
                this._cInfManu = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum aereoNatCargaCInfManu
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

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aereoTarifa
    {

        #region Private fields
        private string _cl;

        private string _cTar;

        private string _vTar;
        #endregion

        public string CL
        {
            get
            {
                return this._cl;
            }
            set
            {
                this._cl = value;
            }
        }

        public string cTar
        {
            get
            {
                return this._cTar;
            }
            set
            {
                this._cTar = value;
            }
        }

        public string vTar
        {
            get
            {
                return this._vTar;
            }
            set
            {
                this._vTar = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aereoPeri
    {

        #region Private fields
        private string _nONU;

        private string _qTotEmb;

        private aereoPeriInfTotAP _infTotAP;
        #endregion

        public aereoPeri()
        {
            this._infTotAP = new aereoPeriInfTotAP();
        }

        public string nONU
        {
            get
            {
                return this._nONU;
            }
            set
            {
                this._nONU = value;
            }
        }

        public string qTotEmb
        {
            get
            {
                return this._qTotEmb;
            }
            set
            {
                this._qTotEmb = value;
            }
        }

        public aereoPeriInfTotAP infTotAP
        {
            get
            {
                return this._infTotAP;
            }
            set
            {
                this._infTotAP = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aereoPeriInfTotAP
    {

        #region Private fields
        private string _qTotProd;

        private aereoPeriInfTotAPUniAP _uniAP;
        #endregion

        public string qTotProd
        {
            get
            {
                return this._qTotProd;
            }
            set
            {
                this._qTotProd = value;
            }
        }

        public aereoPeriInfTotAPUniAP uniAP
        {
            get
            {
                return this._uniAP;
            }
            set
            {
                this._uniAP = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum aereoPeriInfTotAPUniAP
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
    }
}
