namespace Zion.NFe.Danfe.Dacte.ModelCte
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class duto : ContainerModal
    {

        #region Private fields
        private string _vTar;

        private string _dIni;

        private string _dFim;
        #endregion

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
}
