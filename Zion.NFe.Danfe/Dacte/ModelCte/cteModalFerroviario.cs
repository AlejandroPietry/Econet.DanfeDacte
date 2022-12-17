using System.Collections.Generic;

namespace Zion.NFe.Danfe.Dacte.ModelCte
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class ferrov : ContainerModal
    {

        #region Private fields
        private ferrovTpTraf _tpTraf;

        private ferrovTrafMut _trafMut;

        private string _fluxo;
        #endregion

        public ferrov()
        {
            this._trafMut = new ferrovTrafMut();
        }

        public ferrovTpTraf tpTraf
        {
            get
            {
                return this._tpTraf;
            }
            set
            {
                this._tpTraf = value;
            }
        }

        public ferrovTrafMut trafMut
        {
            get
            {
                return this._trafMut;
            }
            set
            {
                this._trafMut = value;
            }
        }

        public string fluxo
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum ferrovTpTraf
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class ferrovTrafMut
    {

        #region Private fields
        private ferrovTrafMutRespFat _respFat;

        private ferrovTrafMutFerrEmi _ferrEmi;

        private string _vFrete;

        private string _chCTeFerroOrigem;

        private List<ferrovTrafMutFerroEnv> _ferroEnv;
        #endregion

        public ferrovTrafMut()
        {
            this._ferroEnv = new List<ferrovTrafMutFerroEnv>();
        }

        public ferrovTrafMutRespFat respFat
        {
            get
            {
                return this._respFat;
            }
            set
            {
                this._respFat = value;
            }
        }

        public ferrovTrafMutFerrEmi ferrEmi
        {
            get
            {
                return this._ferrEmi;
            }
            set
            {
                this._ferrEmi = value;
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

        public string chCTeFerroOrigem
        {
            get
            {
                return this._chCTeFerroOrigem;
            }
            set
            {
                this._chCTeFerroOrigem = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ferroEnv")]
        public List<ferrovTrafMutFerroEnv> ferroEnv
        {
            get
            {
                return this._ferroEnv;
            }
            set
            {
                this._ferroEnv = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum ferrovTrafMutRespFat
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
    public enum ferrovTrafMutFerrEmi
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class ferrovTrafMutFerroEnv
    {

        #region Private fields
        private string _cNPJ;

        private string _cInt;

        private string _ie;

        private string _xNome;

        private TEnderFer _enderFerro;
        #endregion

        public ferrovTrafMutFerroEnv()
        {
            this._enderFerro = new TEnderFer();
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

        public string cInt
        {
            get
            {
                return this._cInt;
            }
            set
            {
                this._cInt = value;
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

        public TEnderFer enderFerro
        {
            get
            {
                return this._enderFerro;
            }
            set
            {
                this._enderFerro = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TEnderFer
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
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
}
