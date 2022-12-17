namespace Zion.NFe.Danfe.Dacte.ModelCte
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class rodoOS : ContainerModal
    {

        #region Private fields
        private string _item;

        private Item1ChoiceType _itemElementName;

        private rodoOSVeic _veic;
        #endregion

        public rodoOS()
        {
            this._veic = new rodoOSVeic();
        }

        [System.Xml.Serialization.XmlElementAttribute("NroRegEstadual")]
        [System.Xml.Serialization.XmlElementAttribute("TAF")]
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
        public Item1ChoiceType ItemElementName
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

        public rodoOSVeic veic
        {
            get
            {
                return this._veic;
            }
            set
            {
                this._veic = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class rodoOSVeic
    {

        #region Private fields
        private string _placa;

        private string _rENAVAM;

        private rodoOSVeicProp _prop;

        private TUf _uf;
        #endregion

        public rodoOSVeic()
        {
            this._prop = new rodoOSVeicProp();
        }

        public string placa
        {
            get
            {
                return this._placa;
            }
            set
            {
                this._placa = value;
            }
        }

        public string RENAVAM
        {
            get
            {
                return this._rENAVAM;
            }
            set
            {
                this._rENAVAM = value;
            }
        }

        public rodoOSVeicProp prop
        {
            get
            {
                return this._prop;
            }
            set
            {
                this._prop = value;
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class rodoOSVeicProp
    {

        #region Private fields
        private string _item;

        private ItemChoiceType1 _itemElementName;

        private string _item1;

        private Item1ChoiceType _item1ElementName;

        private string _xNome;

        private string _ie;

        private TUf _uf;

        private rodoOSVeicPropTpProp _tpProp;
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

        [System.Xml.Serialization.XmlElementAttribute("NroRegEstadual")]
        [System.Xml.Serialization.XmlElementAttribute("TAF")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public string Item1
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName
        {
            get
            {
                return this._item1ElementName;
            }
            set
            {
                this._item1ElementName = value;
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

        public rodoOSVeicPropTpProp tpProp
        {
            get
            {
                return this._tpProp;
            }
            set
            {
                this._tpProp = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum Item1ChoiceType
    {

        /// <remarks/>
        NroRegEstadual,

        /// <remarks/>
        TAF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum rodoOSVeicPropTpProp
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
    }
}
