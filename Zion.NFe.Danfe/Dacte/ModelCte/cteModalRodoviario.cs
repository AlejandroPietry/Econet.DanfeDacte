using System.Collections.Generic;

namespace Zion.NFe.Danfe.Dacte.ModelCte
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class rodo : ContainerModal
    {

        #region Private fields
        private string _rNTRC;

        private List<rodoOcc> _occ;
        #endregion

        public rodo()
        {
            this._occ = new List<rodoOcc>();
        }

        public string RNTRC
        {
            get
            {
                return this._rNTRC;
            }
            set
            {
                this._rNTRC = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("occ")]
        public List<rodoOcc> occ
        {
            get
            {
                return this._occ;
            }
            set
            {
                this._occ = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class rodoOcc
    {

        #region Private fields
        private string _serie;

        private string _nOcc;

        private string _dEmi;

        private rodoOccEmiOcc _emiOcc;
        #endregion

        public rodoOcc()
        {
            this._emiOcc = new rodoOccEmiOcc();
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

        public string nOcc
        {
            get
            {
                return this._nOcc;
            }
            set
            {
                this._nOcc = value;
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

        public rodoOccEmiOcc emiOcc
        {
            get
            {
                return this._emiOcc;
            }
            set
            {
                this._emiOcc = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class rodoOccEmiOcc
    {

        #region Private fields
        private string _cNPJ;

        private string _cInt;

        private string _ie;

        private TUf _uf;

        private string _fone;
        #endregion

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
}
