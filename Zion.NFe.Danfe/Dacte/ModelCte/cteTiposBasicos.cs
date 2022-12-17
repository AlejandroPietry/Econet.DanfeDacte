using System.Collections.Generic;
using Zion.NFe.Danfe.Tools.Extensions;

namespace Zion.NFe.Danfe.Dacte.ModelCte
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class TProtCTeOS : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._infProt == value))
                {
                    return;
                }
                if (((this._infProt == null)
                            || (_infProt.Equals(value) != true)))
                {
                    this._infProt = value;
                    this.OnPropertyChanged("infProt");
                }
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
                if ((this._signature == value))
                {
                    return;
                }
                if (((this._signature == null)
                            || (_signature.Equals(value) != true)))
                {
                    this._signature = value;
                    this.OnPropertyChanged("Signature");
                }
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
                if ((this._versao == value))
                {
                    return;
                }
                if (((this._versao == null)
                            || (_versao.Equals(value) != true)))
                {
                    this._versao = value;
                    this.OnPropertyChanged("versao");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TProtCTeOSInfProt : System.ComponentModel.INotifyPropertyChanged
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
                if ((_tpAmb.Equals(value) != true))
                {
                    this._tpAmb = value;
                    this.OnPropertyChanged("tpAmb");
                }
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
                if ((this._verAplic == value))
                {
                    return;
                }
                if (((this._verAplic == null)
                            || (_verAplic.Equals(value) != true)))
                {
                    this._verAplic = value;
                    this.OnPropertyChanged("verAplic");
                }
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
                if ((this._chCTe == value))
                {
                    return;
                }
                if (((this._chCTe == null)
                            || (_chCTe.Equals(value) != true)))
                {
                    this._chCTe = value;
                    this.OnPropertyChanged("chCTe");
                }
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
                if ((this._dhRecbto == value))
                {
                    return;
                }
                if (((this._dhRecbto == null)
                            || (_dhRecbto.Equals(value) != true)))
                {
                    this._dhRecbto = value;
                    this.OnPropertyChanged("dhRecbto");
                }
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
                if ((this._nProt == value))
                {
                    return;
                }
                if (((this._nProt == null)
                            || (_nProt.Equals(value) != true)))
                {
                    this._nProt = value;
                    this.OnPropertyChanged("nProt");
                }
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
                if ((this._digVal == value))
                {
                    return;
                }
                if (((this._digVal == null)
                            || (_digVal.Equals(value) != true)))
                {
                    this._digVal = value;
                    this.OnPropertyChanged("digVal");
                }
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
                if ((this._cStat == value))
                {
                    return;
                }
                if (((this._cStat == null)
                            || (_cStat.Equals(value) != true)))
                {
                    this._cStat = value;
                    this.OnPropertyChanged("cStat");
                }
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
                if ((this._xMotivo == value))
                {
                    return;
                }
                if (((this._xMotivo == null)
                            || (_xMotivo.Equals(value) != true)))
                {
                    this._xMotivo = value;
                    this.OnPropertyChanged("xMotivo");
                }
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
                if ((this._id == value))
                {
                    return;
                }
                if (((this._id == null)
                            || (_id.Equals(value) != true)))
                {
                    this._id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class TRetCTeOS : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private TAmb _tpAmb;

        private TCodUfIBGE _cUF;

        private string _verAplic;

        private string _cStat;

        private string _xMotivo;

        private TProtCTeOS _protCTe;

        private string _versao;
        #endregion

        public TRetCTeOS()
        {
            this._protCTe = new TProtCTeOS();
        }

        public TAmb tpAmb
        {
            get
            {
                return this._tpAmb;
            }
            set
            {
                if ((_tpAmb.Equals(value) != true))
                {
                    this._tpAmb = value;
                    this.OnPropertyChanged("tpAmb");
                }
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this._cUF;
            }
            set
            {
                if ((_cUF.Equals(value) != true))
                {
                    this._cUF = value;
                    this.OnPropertyChanged("cUF");
                }
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
                if ((this._verAplic == value))
                {
                    return;
                }
                if (((this._verAplic == null)
                            || (_verAplic.Equals(value) != true)))
                {
                    this._verAplic = value;
                    this.OnPropertyChanged("verAplic");
                }
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
                if ((this._cStat == value))
                {
                    return;
                }
                if (((this._cStat == null)
                            || (_cStat.Equals(value) != true)))
                {
                    this._cStat = value;
                    this.OnPropertyChanged("cStat");
                }
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
                if ((this._xMotivo == value))
                {
                    return;
                }
                if (((this._xMotivo == null)
                            || (_xMotivo.Equals(value) != true)))
                {
                    this._xMotivo = value;
                    this.OnPropertyChanged("xMotivo");
                }
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
                if ((this._protCTe == value))
                {
                    return;
                }
                if (((this._protCTe == null)
                            || (_protCTe.Equals(value) != true)))
                {
                    this._protCTe = value;
                    this.OnPropertyChanged("protCTe");
                }
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
                if ((this._versao == value))
                {
                    return;
                }
                if (((this._versao == null)
                            || (_versao.Equals(value) != true)))
                {
                    this._versao = value;
                    this.OnPropertyChanged("versao");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class TCTeOS : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._infCte == value))
                {
                    return;
                }
                if (((this._infCte == null)
                            || (_infCte.Equals(value) != true)))
                {
                    this._infCte = value;
                    this.OnPropertyChanged("infCte");
                }
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
                if ((this._signature == value))
                {
                    return;
                }
                if (((this._signature == null)
                            || (_signature.Equals(value) != true)))
                {
                    this._signature = value;
                    this.OnPropertyChanged("Signature");
                }
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
                if ((this._versao == value))
                {
                    return;
                }
                if (((this._versao == null)
                            || (_versao.Equals(value) != true)))
                {
                    this._versao = value;
                    this.OnPropertyChanged("versao");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCte : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._ide == value))
                {
                    return;
                }
                if (((this._ide == null)
                            || (_ide.Equals(value) != true)))
                {
                    this._ide = value;
                    this.OnPropertyChanged("ide");
                }
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
                if ((this._compl == value))
                {
                    return;
                }
                if (((this._compl == null)
                            || (_compl.Equals(value) != true)))
                {
                    this._compl = value;
                    this.OnPropertyChanged("compl");
                }
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
                if ((this._emit == value))
                {
                    return;
                }
                if (((this._emit == null)
                            || (_emit.Equals(value) != true)))
                {
                    this._emit = value;
                    this.OnPropertyChanged("emit");
                }
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
                if ((this._toma == value))
                {
                    return;
                }
                if (((this._toma == null)
                            || (_toma.Equals(value) != true)))
                {
                    this._toma = value;
                    this.OnPropertyChanged("toma");
                }
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
                if ((this._vPrest == value))
                {
                    return;
                }
                if (((this._vPrest == null)
                            || (_vPrest.Equals(value) != true)))
                {
                    this._vPrest = value;
                    this.OnPropertyChanged("vPrest");
                }
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
                if ((this._imp == value))
                {
                    return;
                }
                if (((this._imp == null)
                            || (_imp.Equals(value) != true)))
                {
                    this._imp = value;
                    this.OnPropertyChanged("imp");
                }
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
                if ((this._item == value))
                {
                    return;
                }
                if (((this._item == null)
                            || (_item.Equals(value) != true)))
                {
                    this._item = value;
                    this.OnPropertyChanged("Item");
                }
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
                if ((this._autXML == value))
                {
                    return;
                }
                if (((this._autXML == null)
                            || (_autXML.Equals(value) != true)))
                {
                    this._autXML = value;
                    this.OnPropertyChanged("autXML");
                }
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
                if ((this._versao == value))
                {
                    return;
                }
                if (((this._versao == null)
                            || (_versao.Equals(value) != true)))
                {
                    this._versao = value;
                    this.OnPropertyChanged("versao");
                }
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
                if ((this._id == value))
                {
                    return;
                }
                if (((this._id == null)
                            || (_id.Equals(value) != true)))
                {
                    this._id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteIde : System.ComponentModel.INotifyPropertyChanged
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
                if ((_cUF.Equals(value) != true))
                {
                    this._cUF = value;
                    this.OnPropertyChanged("cUF");
                }
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
                if ((this._cCT == value))
                {
                    return;
                }
                if (((this._cCT == null)
                            || (_cCT.Equals(value) != true)))
                {
                    this._cCT = value;
                    this.OnPropertyChanged("cCT");
                }
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
                if ((this._cFOP == value))
                {
                    return;
                }
                if (((this._cFOP == null)
                            || (_cFOP.Equals(value) != true)))
                {
                    this._cFOP = value;
                    this.OnPropertyChanged("CFOP");
                }
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
                if ((this._natOp == value))
                {
                    return;
                }
                if (((this._natOp == null)
                            || (_natOp.Equals(value) != true)))
                {
                    this._natOp = value;
                    this.OnPropertyChanged("natOp");
                }
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
                if ((_mod.Equals(value) != true))
                {
                    this._mod = value;
                    this.OnPropertyChanged("mod");
                }
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
                if ((this._serie == value))
                {
                    return;
                }
                if (((this._serie == null)
                            || (_serie.Equals(value) != true)))
                {
                    this._serie = value;
                    this.OnPropertyChanged("serie");
                }
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
                if ((this._nCT == value))
                {
                    return;
                }
                if (((this._nCT == null)
                            || (_nCT.Equals(value) != true)))
                {
                    this._nCT = value;
                    this.OnPropertyChanged("nCT");
                }
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
                if ((this._dhEmi == value))
                {
                    return;
                }
                if (((this._dhEmi == null)
                            || (_dhEmi.Equals(value) != true)))
                {
                    this._dhEmi = value;
                    this.OnPropertyChanged("dhEmi");
                }
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
                if ((_tpImp.Equals(value) != true))
                {
                    this._tpImp = value;
                    this.OnPropertyChanged("tpImp");
                }
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
                if ((_tpEmis.Equals(value) != true))
                {
                    this._tpEmis = value;
                    this.OnPropertyChanged("tpEmis");
                }
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
                if ((this._cDV == value))
                {
                    return;
                }
                if (((this._cDV == null)
                            || (_cDV.Equals(value) != true)))
                {
                    this._cDV = value;
                    this.OnPropertyChanged("cDV");
                }
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
                if ((_tpAmb.Equals(value) != true))
                {
                    this._tpAmb = value;
                    this.OnPropertyChanged("tpAmb");
                }
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
                if ((_tpCTe.Equals(value) != true))
                {
                    this._tpCTe = value;
                    this.OnPropertyChanged("tpCTe");
                }
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
                if ((_procEmi.Equals(value) != true))
                {
                    this._procEmi = value;
                    this.OnPropertyChanged("procEmi");
                }
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
                if ((this._verProc == value))
                {
                    return;
                }
                if (((this._verProc == null)
                            || (_verProc.Equals(value) != true)))
                {
                    this._verProc = value;
                    this.OnPropertyChanged("verProc");
                }
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
                if ((this._cMunEnv == value))
                {
                    return;
                }
                if (((this._cMunEnv == null)
                            || (_cMunEnv.Equals(value) != true)))
                {
                    this._cMunEnv = value;
                    this.OnPropertyChanged("cMunEnv");
                }
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
                if ((this._xMunEnv == value))
                {
                    return;
                }
                if (((this._xMunEnv == null)
                            || (_xMunEnv.Equals(value) != true)))
                {
                    this._xMunEnv = value;
                    this.OnPropertyChanged("xMunEnv");
                }
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
                if ((_uFEnv.Equals(value) != true))
                {
                    this._uFEnv = value;
                    this.OnPropertyChanged("UFEnv");
                }
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
                if ((_modal.Equals(value) != true))
                {
                    this._modal = value;
                    this.OnPropertyChanged("modal");
                }
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
                if ((_tpServ.Equals(value) != true))
                {
                    this._tpServ = value;
                    this.OnPropertyChanged("tpServ");
                }
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
                if ((_indIEToma.Equals(value) != true))
                {
                    this._indIEToma = value;
                    this.OnPropertyChanged("indIEToma");
                }
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
                if ((this._cMunIni == value))
                {
                    return;
                }
                if (((this._cMunIni == null)
                            || (_cMunIni.Equals(value) != true)))
                {
                    this._cMunIni = value;
                    this.OnPropertyChanged("cMunIni");
                }
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
                if ((this._xMunIni == value))
                {
                    return;
                }
                if (((this._xMunIni == null)
                            || (_xMunIni.Equals(value) != true)))
                {
                    this._xMunIni = value;
                    this.OnPropertyChanged("xMunIni");
                }
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
                if ((_uFIni.Equals(value) != true))
                {
                    this._uFIni = value;
                    this.OnPropertyChanged("UFIni");
                }
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
                if ((this._cMunFim == value))
                {
                    return;
                }
                if (((this._cMunFim == null)
                            || (_cMunFim.Equals(value) != true)))
                {
                    this._cMunFim = value;
                    this.OnPropertyChanged("cMunFim");
                }
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
                if ((this._xMunFim == value))
                {
                    return;
                }
                if (((this._xMunFim == null)
                            || (_xMunFim.Equals(value) != true)))
                {
                    this._xMunFim = value;
                    this.OnPropertyChanged("xMunFim");
                }
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
                if ((_uFFim.Equals(value) != true))
                {
                    this._uFFim = value;
                    this.OnPropertyChanged("UFFim");
                }
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
                if ((this._infPercurso == value))
                {
                    return;
                }
                if (((this._infPercurso == null)
                            || (_infPercurso.Equals(value) != true)))
                {
                    this._infPercurso = value;
                    this.OnPropertyChanged("infPercurso");
                }
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
                if ((this._dhCont == value))
                {
                    return;
                }
                if (((this._dhCont == null)
                            || (_dhCont.Equals(value) != true)))
                {
                    this._dhCont = value;
                    this.OnPropertyChanged("dhCont");
                }
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
                if ((this._xJust == value))
                {
                    return;
                }
                if (((this._xJust == null)
                            || (_xJust.Equals(value) != true)))
                {
                    this._xJust = value;
                    this.OnPropertyChanged("xJust");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModCTOS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteIdeInfPercurso : System.ComponentModel.INotifyPropertyChanged
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
                if ((_uFPer.Equals(value) != true))
                {
                    this._uFPer = value;
                    this.OnPropertyChanged("UFPer");
                }
            }
        }
        public string ProxyUFPer { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteCompl : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._xCaracAd == value))
                {
                    return;
                }
                if (((this._xCaracAd == null)
                            || (_xCaracAd.Equals(value) != true)))
                {
                    this._xCaracAd = value;
                    this.OnPropertyChanged("xCaracAd");
                }
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
                if ((this._xCaracSer == value))
                {
                    return;
                }
                if (((this._xCaracSer == null)
                            || (_xCaracSer.Equals(value) != true)))
                {
                    this._xCaracSer = value;
                    this.OnPropertyChanged("xCaracSer");
                }
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
                if ((this._xEmi == value))
                {
                    return;
                }
                if (((this._xEmi == null)
                            || (_xEmi.Equals(value) != true)))
                {
                    this._xEmi = value;
                    this.OnPropertyChanged("xEmi");
                }
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
                if ((this._xObs == value))
                {
                    return;
                }
                if (((this._xObs == null)
                            || (_xObs.Equals(value) != true)))
                {
                    this._xObs = value;
                    this.OnPropertyChanged("xObs");
                }
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
                if ((this._obsCont == value))
                {
                    return;
                }
                if (((this._obsCont == null)
                            || (_obsCont.Equals(value) != true)))
                {
                    this._obsCont = value;
                    this.OnPropertyChanged("ObsCont");
                }
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
                if ((this._obsFisco == value))
                {
                    return;
                }
                if (((this._obsFisco == null)
                            || (_obsFisco.Equals(value) != true)))
                {
                    this._obsFisco = value;
                    this.OnPropertyChanged("ObsFisco");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteComplObsCont : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._xTexto == value))
                {
                    return;
                }
                if (((this._xTexto == null)
                            || (_xTexto.Equals(value) != true)))
                {
                    this._xTexto = value;
                    this.OnPropertyChanged("xTexto");
                }
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
                if ((this._xCampo == value))
                {
                    return;
                }
                if (((this._xCampo == null)
                            || (_xCampo.Equals(value) != true)))
                {
                    this._xCampo = value;
                    this.OnPropertyChanged("xCampo");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteComplObsFisco : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._xTexto == value))
                {
                    return;
                }
                if (((this._xTexto == null)
                            || (_xTexto.Equals(value) != true)))
                {
                    this._xTexto = value;
                    this.OnPropertyChanged("xTexto");
                }
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
                if ((this._xCampo == value))
                {
                    return;
                }
                if (((this._xCampo == null)
                            || (_xCampo.Equals(value) != true)))
                {
                    this._xCampo = value;
                    this.OnPropertyChanged("xCampo");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteEmit : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._cNPJ == value))
                {
                    return;
                }
                if (((this._cNPJ == null)
                            || (_cNPJ.Equals(value) != true)))
                {
                    this._cNPJ = value;
                    this.OnPropertyChanged("CNPJ");
                }
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
                if ((this._ie == value))
                {
                    return;
                }
                if (((this._ie == null)
                            || (_ie.Equals(value) != true)))
                {
                    this._ie = value;
                    this.OnPropertyChanged("IE");
                }
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
                if ((this._iEST == value))
                {
                    return;
                }
                if (((this._iEST == null)
                            || (_iEST.Equals(value) != true)))
                {
                    this._iEST = value;
                    this.OnPropertyChanged("IEST");
                }
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
                if ((this._xNome == value))
                {
                    return;
                }
                if (((this._xNome == null)
                            || (_xNome.Equals(value) != true)))
                {
                    this._xNome = value;
                    this.OnPropertyChanged("xNome");
                }
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
                if ((this._xFant == value))
                {
                    return;
                }
                if (((this._xFant == null)
                            || (_xFant.Equals(value) != true)))
                {
                    this._xFant = value;
                    this.OnPropertyChanged("xFant");
                }
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
                if ((this._enderEmit == value))
                {
                    return;
                }
                if (((this._enderEmit == null)
                            || (_enderEmit.Equals(value) != true)))
                {
                    this._enderEmit = value;
                    this.OnPropertyChanged("enderEmit");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteToma : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private string _item;

        private ItemChoiceType9 _itemElementName;

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
                if ((this._item == value))
                {
                    return;
                }
                if (((this._item == null)
                            || (_item.Equals(value) != true)))
                {
                    this._item = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType9 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                if ((_itemElementName.Equals(value) != true))
                {
                    this._itemElementName = value;
                    this.OnPropertyChanged("ItemElementName");
                }
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
                if ((this._ie == value))
                {
                    return;
                }
                if (((this._ie == null)
                            || (_ie.Equals(value) != true)))
                {
                    this._ie = value;
                    this.OnPropertyChanged("IE");
                }
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
                if ((this._xNome == value))
                {
                    return;
                }
                if (((this._xNome == null)
                            || (_xNome.Equals(value) != true)))
                {
                    this._xNome = value;
                    this.OnPropertyChanged("xNome");
                }
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
                if ((this._xFant == value))
                {
                    return;
                }
                if (((this._xFant == null)
                            || (_xFant.Equals(value) != true)))
                {
                    this._xFant = value;
                    this.OnPropertyChanged("xFant");
                }
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
                if ((this._fone == value))
                {
                    return;
                }
                if (((this._fone == null)
                            || (_fone.Equals(value) != true)))
                {
                    this._fone = value;
                    this.OnPropertyChanged("fone");
                }
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
                if ((this._enderToma == value))
                {
                    return;
                }
                if (((this._enderToma == null)
                            || (_enderToma.Equals(value) != true)))
                {
                    this._enderToma = value;
                    this.OnPropertyChanged("enderToma");
                }
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
                if ((this._email == value))
                {
                    return;
                }
                if (((this._email == null)
                            || (_email.Equals(value) != true)))
                {
                    this._email = value;
                    this.OnPropertyChanged("email");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType9
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
    public partial class TCTeOSInfCteVPrest : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._vTPrest == value))
                {
                    return;
                }
                if (((this._vTPrest == null)
                            || (_vTPrest.Equals(value) != true)))
                {
                    this._vTPrest = value;
                    this.OnPropertyChanged("vTPrest");
                }
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
                if ((this._vRec == value))
                {
                    return;
                }
                if (((this._vRec == null)
                            || (_vRec.Equals(value) != true)))
                {
                    this._vRec = value;
                    this.OnPropertyChanged("vRec");
                }
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
                if ((this._comp == value))
                {
                    return;
                }
                if (((this._comp == null)
                            || (_comp.Equals(value) != true)))
                {
                    this._comp = value;
                    this.OnPropertyChanged("Comp");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteVPrestComp : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._xNome == value))
                {
                    return;
                }
                if (((this._xNome == null)
                            || (_xNome.Equals(value) != true)))
                {
                    this._xNome = value;
                    this.OnPropertyChanged("xNome");
                }
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
                if ((this._vComp == value))
                {
                    return;
                }
                if (((this._vComp == null)
                            || (_vComp.Equals(value) != true)))
                {
                    this._vComp = value;
                    this.OnPropertyChanged("vComp");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteImp : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._iCMS == value))
                {
                    return;
                }
                if (((this._iCMS == null)
                            || (_iCMS.Equals(value) != true)))
                {
                    this._iCMS = value;
                    this.OnPropertyChanged("ICMS");
                }
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
                if ((this._vTotTrib == value))
                {
                    return;
                }
                if (((this._vTotTrib == null)
                            || (_vTotTrib.Equals(value) != true)))
                {
                    this._vTotTrib = value;
                    this.OnPropertyChanged("vTotTrib");
                }
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
                if ((this._infAdFisco == value))
                {
                    return;
                }
                if (((this._infAdFisco == null)
                            || (_infAdFisco.Equals(value) != true)))
                {
                    this._infAdFisco = value;
                    this.OnPropertyChanged("infAdFisco");
                }
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
                if ((this._iCMSUFFim == value))
                {
                    return;
                }
                if (((this._iCMSUFFim == null)
                            || (_iCMSUFFim.Equals(value) != true)))
                {
                    this._iCMSUFFim = value;
                    this.OnPropertyChanged("ICMSUFFim");
                }
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
                if ((this._infTribFed == value))
                {
                    return;
                }
                if (((this._infTribFed == null)
                            || (_infTribFed.Equals(value) != true)))
                {
                    this._infTribFed = value;
                    this.OnPropertyChanged("infTribFed");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOS : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._item == value))
                {
                    return;
                }
                if (((this._item == null)
                            || (_item.Equals(value) != true)))
                {
                    this._item = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMS00 : System.ComponentModel.INotifyPropertyChanged
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
                if ((_cST.Equals(value) != true))
                {
                    this._cST = value;
                    this.OnPropertyChanged("CST");
                }
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
                if ((this._vBC == value))
                {
                    return;
                }
                if (((this._vBC == null)
                            || (_vBC.Equals(value) != true)))
                {
                    this._vBC = value;
                    this.OnPropertyChanged("vBC");
                }
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
                if ((this._pICMS == value))
                {
                    return;
                }
                if (((this._pICMS == null)
                            || (_pICMS.Equals(value) != true)))
                {
                    this._pICMS = value;
                    this.OnPropertyChanged("pICMS");
                }
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
                if ((this._vICMS == value))
                {
                    return;
                }
                if (((this._vICMS == null)
                            || (_vICMS.Equals(value) != true)))
                {
                    this._vICMS = value;
                    this.OnPropertyChanged("vICMS");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMS00CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMS45 : System.ComponentModel.INotifyPropertyChanged
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
                if ((_cST.Equals(value) != true))
                {
                    this._cST = value;
                    this.OnPropertyChanged("CST");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMS90 : System.ComponentModel.INotifyPropertyChanged
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
                if ((_cST.Equals(value) != true))
                {
                    this._cST = value;
                    this.OnPropertyChanged("CST");
                }
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
                if ((this._pRedBC == value))
                {
                    return;
                }
                if (((this._pRedBC == null)
                            || (_pRedBC.Equals(value) != true)))
                {
                    this._pRedBC = value;
                    this.OnPropertyChanged("pRedBC");
                }
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
                if ((this._vBC == value))
                {
                    return;
                }
                if (((this._vBC == null)
                            || (_vBC.Equals(value) != true)))
                {
                    this._vBC = value;
                    this.OnPropertyChanged("vBC");
                }
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
                if ((this._pICMS == value))
                {
                    return;
                }
                if (((this._pICMS == null)
                            || (_pICMS.Equals(value) != true)))
                {
                    this._pICMS = value;
                    this.OnPropertyChanged("pICMS");
                }
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
                if ((this._vICMS == value))
                {
                    return;
                }
                if (((this._vICMS == null)
                            || (_vICMS.Equals(value) != true)))
                {
                    this._vICMS = value;
                    this.OnPropertyChanged("vICMS");
                }
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
                if ((this._vCred == value))
                {
                    return;
                }
                if (((this._vCred == null)
                            || (_vCred.Equals(value) != true)))
                {
                    this._vCred = value;
                    this.OnPropertyChanged("vCred");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMS90CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMSOutraUF : System.ComponentModel.INotifyPropertyChanged
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
                if ((_cST.Equals(value) != true))
                {
                    this._cST = value;
                    this.OnPropertyChanged("CST");
                }
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
                if ((this._pRedBCOutraUF == value))
                {
                    return;
                }
                if (((this._pRedBCOutraUF == null)
                            || (_pRedBCOutraUF.Equals(value) != true)))
                {
                    this._pRedBCOutraUF = value;
                    this.OnPropertyChanged("pRedBCOutraUF");
                }
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
                if ((this._vBCOutraUF == value))
                {
                    return;
                }
                if (((this._vBCOutraUF == null)
                            || (_vBCOutraUF.Equals(value) != true)))
                {
                    this._vBCOutraUF = value;
                    this.OnPropertyChanged("vBCOutraUF");
                }
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
                if ((this._pICMSOutraUF == value))
                {
                    return;
                }
                if (((this._pICMSOutraUF == null)
                            || (_pICMSOutraUF.Equals(value) != true)))
                {
                    this._pICMSOutraUF = value;
                    this.OnPropertyChanged("pICMSOutraUF");
                }
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
                if ((this._vICMSOutraUF == value))
                {
                    return;
                }
                if (((this._vICMSOutraUF == null)
                            || (_vICMSOutraUF.Equals(value) != true)))
                {
                    this._vICMSOutraUF = value;
                    this.OnPropertyChanged("vICMSOutraUF");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMSOutraUFCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpOSICMSSN : System.ComponentModel.INotifyPropertyChanged
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
                if ((_cST.Equals(value) != true))
                {
                    this._cST = value;
                    this.OnPropertyChanged("CST");
                }
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
                if ((_indSN.Equals(value) != true))
                {
                    this._indSN = value;
                    this.OnPropertyChanged("indSN");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMSSNCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpOSICMSSNIndSN
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
    public partial class TCTeOSInfCteImpICMSUFFim : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._vBCUFFim == value))
                {
                    return;
                }
                if (((this._vBCUFFim == null)
                            || (_vBCUFFim.Equals(value) != true)))
                {
                    this._vBCUFFim = value;
                    this.OnPropertyChanged("vBCUFFim");
                }
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
                if ((this._pFCPUFFim == value))
                {
                    return;
                }
                if (((this._pFCPUFFim == null)
                            || (_pFCPUFFim.Equals(value) != true)))
                {
                    this._pFCPUFFim = value;
                    this.OnPropertyChanged("pFCPUFFim");
                }
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
                if ((this._pICMSUFFim == value))
                {
                    return;
                }
                if (((this._pICMSUFFim == null)
                            || (_pICMSUFFim.Equals(value) != true)))
                {
                    this._pICMSUFFim = value;
                    this.OnPropertyChanged("pICMSUFFim");
                }
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
                if ((this._pICMSInter == value))
                {
                    return;
                }
                if (((this._pICMSInter == null)
                            || (_pICMSInter.Equals(value) != true)))
                {
                    this._pICMSInter = value;
                    this.OnPropertyChanged("pICMSInter");
                }
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
                if ((this._pICMSInterPart == value))
                {
                    return;
                }
                if (((this._pICMSInterPart == null)
                            || (_pICMSInterPart.Equals(value) != true)))
                {
                    this._pICMSInterPart = value;
                    this.OnPropertyChanged("pICMSInterPart");
                }
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
                if ((this._vFCPUFFim == value))
                {
                    return;
                }
                if (((this._vFCPUFFim == null)
                            || (_vFCPUFFim.Equals(value) != true)))
                {
                    this._vFCPUFFim = value;
                    this.OnPropertyChanged("vFCPUFFim");
                }
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
                if ((this._vICMSUFFim == value))
                {
                    return;
                }
                if (((this._vICMSUFFim == null)
                            || (_vICMSUFFim.Equals(value) != true)))
                {
                    this._vICMSUFFim = value;
                    this.OnPropertyChanged("vICMSUFFim");
                }
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
                if ((this._vICMSUFIni == value))
                {
                    return;
                }
                if (((this._vICMSUFIni == null)
                            || (_vICMSUFIni.Equals(value) != true)))
                {
                    this._vICMSUFIni = value;
                    this.OnPropertyChanged("vICMSUFIni");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteImpInfTribFed : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private decimal? _vPis;
        private decimal? _vCofins;
        private decimal? _vIr;
        private decimal? _vInss;
        private decimal? _vCsll;
        #endregion

        public decimal? vPIS
        {
            get { return _vPis.Arredondar(2); }
            set { _vPis = value.Arredondar(2); }
        }

        public decimal? vCOFINS
        {
            get { return _vCofins.Arredondar(2); }
            set { _vCofins = value.Arredondar(2); }
        }

        public decimal? vIR
        {
            get { return _vIr.Arredondar(2); }
            set { _vIr = value.Arredondar(2); }
        }

        public decimal? vINSS
        {
            get { return _vInss.Arredondar(2); }
            set { _vInss = value.Arredondar(2); }
        }

        public decimal? vCSLL
        {
            get { return _vCsll.Arredondar(2); }
            set { _vCsll = value.Arredondar(2); }
        }


        public bool vPISSpecified { get { return vPIS.HasValue; } }
        public bool vCOFINSSpecified { get { return vCOFINS.HasValue; } }
        public bool vIRSpecified { get { return vIR.HasValue; } }
        public bool vINSSSpecified { get { return vINSS.HasValue; } }
        public bool vCSLLSpecified { get { return vCSLL.HasValue; } }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNorm : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._infServico == value))
                {
                    return;
                }
                if (((this._infServico == null)
                            || (_infServico.Equals(value) != true)))
                {
                    this._infServico = value;
                    this.OnPropertyChanged("infServico");
                }
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
                if ((this._infDocRef == value))
                {
                    return;
                }
                if (((this._infDocRef == null)
                            || (_infDocRef.Equals(value) != true)))
                {
                    this._infDocRef = value;
                    this.OnPropertyChanged("infDocRef");
                }
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
                if ((this._seg == value))
                {
                    return;
                }
                if (((this._seg == null)
                            || (_seg.Equals(value) != true)))
                {
                    this._seg = value;
                    this.OnPropertyChanged("seg");
                }
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
                if ((this._infModal == value))
                {
                    return;
                }
                if (((this._infModal == null)
                            || (_infModal.Equals(value) != true)))
                {
                    this._infModal = value;
                    this.OnPropertyChanged("infModal");
                }
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
                if ((this._infCteSub == value))
                {
                    return;
                }
                if (((this._infCteSub == null)
                            || (_infCteSub.Equals(value) != true)))
                {
                    this._infCteSub = value;
                    this.OnPropertyChanged("infCteSub");
                }
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
                if ((this._refCTeCanc == value))
                {
                    return;
                }
                if (((this._refCTeCanc == null)
                            || (_refCTeCanc.Equals(value) != true)))
                {
                    this._refCTeCanc = value;
                    this.OnPropertyChanged("refCTeCanc");
                }
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
                if ((this._cobr == value))
                {
                    return;
                }
                if (((this._cobr == null)
                            || (_cobr.Equals(value) != true)))
                {
                    this._cobr = value;
                    this.OnPropertyChanged("cobr");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfServico : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._xDescServ == value))
                {
                    return;
                }
                if (((this._xDescServ == null)
                            || (_xDescServ.Equals(value) != true)))
                {
                    this._xDescServ = value;
                    this.OnPropertyChanged("xDescServ");
                }
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
                if ((this._infQ == value))
                {
                    return;
                }
                if (((this._infQ == null)
                            || (_infQ.Equals(value) != true)))
                {
                    this._infQ = value;
                    this.OnPropertyChanged("infQ");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfServicoInfQ : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._qCarga == value))
                {
                    return;
                }
                if (((this._qCarga == null)
                            || (_qCarga.Equals(value) != true)))
                {
                    this._qCarga = value;
                    this.OnPropertyChanged("qCarga");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfDocRef : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private string _nDoc;

        private string _serie;

        private string _subserie;

        private string _dEmi;

        private decimal? _vDoc;
        #endregion

        public string nDoc
        {
            get
            {
                return this._nDoc;
            }
            set
            {
                if ((this._nDoc == value))
                {
                    return;
                }
                if (((this._nDoc == null)
                            || (_nDoc.Equals(value) != true)))
                {
                    this._nDoc = value;
                    this.OnPropertyChanged("nDoc");
                }
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
                if ((this._serie == value))
                {
                    return;
                }
                if (((this._serie == null)
                            || (_serie.Equals(value) != true)))
                {
                    this._serie = value;
                    this.OnPropertyChanged("serie");
                }
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
                if ((this._subserie == value))
                {
                    return;
                }
                if (((this._subserie == null)
                            || (_subserie.Equals(value) != true)))
                {
                    this._subserie = value;
                    this.OnPropertyChanged("subserie");
                }
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
                if ((this._dEmi == value))
                {
                    return;
                }
                if (((this._dEmi == null)
                            || (_dEmi.Equals(value) != true)))
                {
                    this._dEmi = value;
                    this.OnPropertyChanged("dEmi");
                }
            }
        }

        public decimal? vDoc
        {
            get { return _vDoc.Arredondar(2); }
            set { _vDoc = value.Arredondar(2); }
        }

        public bool vDocSpecified
        {
            get { return vDoc.HasValue; }
        }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormSeg : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private TCTeOSInfCteInfCTeNormSegRespSeg _respSeg;
        private decimal? _vCarga;
        private string _xSeg;

        private string _nApol;
        private string _nAver;
        #endregion

        public TCTeOSInfCteInfCTeNormSegRespSeg respSeg
        {
            get
            {
                return this._respSeg;
            }
            set
            {
                if ((_respSeg.Equals(value) != true))
                {
                    this._respSeg = value;
                    this.OnPropertyChanged("respSeg");
                }
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
                if ((this._xSeg == value))
                {
                    return;
                }
                if (((this._xSeg == null)
                            || (_xSeg.Equals(value) != true)))
                {
                    this._xSeg = value;
                    this.OnPropertyChanged("xSeg");
                }
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
                if ((this._nApol == value))
                {
                    return;
                }
                if (((this._nApol == null)
                            || (_nApol.Equals(value) != true)))
                {
                    this._nApol = value;
                    this.OnPropertyChanged("nApol");
                }
            }
        }

        public string nAver { get { return this._nAver; } set { _nAver = value; } }

        public decimal? vCarga
        {
            get { return _vCarga.Arredondar(2); }
            set { _vCarga = value.Arredondar(2); }
        }

        public bool vCargaSpecified { get { return vCarga.HasValue; } }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeOSInfCteInfCTeNormSegRespSeg
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

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfModal : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._any == value))
                {
                    return;
                }
                if (((this._any == null)
                            || (_any.Equals(value) != true)))
                {
                    this._any = value;
                    this.OnPropertyChanged("Any");
                }
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
                if ((this._versaoModal == value))
                {
                    return;
                }
                if (((this._versaoModal == null)
                            || (_versaoModal.Equals(value) != true)))
                {
                    this._versaoModal = value;
                    this.OnPropertyChanged("versaoModal");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfCteSub : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._chCte == value))
                {
                    return;
                }
                if (((this._chCte == null)
                            || (_chCte.Equals(value) != true)))
                {
                    this._chCte = value;
                    this.OnPropertyChanged("chCte");
                }
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
                if ((this._item == value))
                {
                    return;
                }
                if (((this._item == null)
                            || (_item.Equals(value) != true)))
                {
                    this._item = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfCteSubTomaICMS : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private object _item;

        private ItemChoiceType11 _itemElementName;
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
                if ((this._item == value))
                {
                    return;
                }
                if (((this._item == null)
                            || (_item.Equals(value) != true)))
                {
                    this._item = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType11 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                if ((_itemElementName.Equals(value) != true))
                {
                    this._itemElementName = value;
                    this.OnPropertyChanged("ItemElementName");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormInfCteSubTomaICMSRefNF : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private string _item;

        private ItemChoiceType10 _itemElementName;

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
                if ((this._item == value))
                {
                    return;
                }
                if (((this._item == null)
                            || (_item.Equals(value) != true)))
                {
                    this._item = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType10 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                if ((_itemElementName.Equals(value) != true))
                {
                    this._itemElementName = value;
                    this.OnPropertyChanged("ItemElementName");
                }
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
                if ((_mod.Equals(value) != true))
                {
                    this._mod = value;
                    this.OnPropertyChanged("mod");
                }
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
                if ((this._serie == value))
                {
                    return;
                }
                if (((this._serie == null)
                            || (_serie.Equals(value) != true)))
                {
                    this._serie = value;
                    this.OnPropertyChanged("serie");
                }
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
                if ((this._subserie == value))
                {
                    return;
                }
                if (((this._subserie == null)
                            || (_subserie.Equals(value) != true)))
                {
                    this._subserie = value;
                    this.OnPropertyChanged("subserie");
                }
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
                if ((this._nro == value))
                {
                    return;
                }
                if (((this._nro == null)
                            || (_nro.Equals(value) != true)))
                {
                    this._nro = value;
                    this.OnPropertyChanged("nro");
                }
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
                if ((this._valor == value))
                {
                    return;
                }
                if (((this._valor == null)
                            || (_valor.Equals(value) != true)))
                {
                    this._valor = value;
                    this.OnPropertyChanged("valor");
                }
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
                if ((this._dEmi == value))
                {
                    return;
                }
                if (((this._dEmi == null)
                            || (_dEmi.Equals(value) != true)))
                {
                    this._dEmi = value;
                    this.OnPropertyChanged("dEmi");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType10
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType11
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormCobr : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._fat == value))
                {
                    return;
                }
                if (((this._fat == null)
                            || (_fat.Equals(value) != true)))
                {
                    this._fat = value;
                    this.OnPropertyChanged("fat");
                }
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
                if ((this._dup == value))
                {
                    return;
                }
                if (((this._dup == null)
                            || (_dup.Equals(value) != true)))
                {
                    this._dup = value;
                    this.OnPropertyChanged("dup");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormCobrFat : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._nFat == value))
                {
                    return;
                }
                if (((this._nFat == null)
                            || (_nFat.Equals(value) != true)))
                {
                    this._nFat = value;
                    this.OnPropertyChanged("nFat");
                }
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
                if ((this._vOrig == value))
                {
                    return;
                }
                if (((this._vOrig == null)
                            || (_vOrig.Equals(value) != true)))
                {
                    this._vOrig = value;
                    this.OnPropertyChanged("vOrig");
                }
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
                if ((this._vDesc == value))
                {
                    return;
                }
                if (((this._vDesc == null)
                            || (_vDesc.Equals(value) != true)))
                {
                    this._vDesc = value;
                    this.OnPropertyChanged("vDesc");
                }
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
                if ((this._vLiq == value))
                {
                    return;
                }
                if (((this._vLiq == null)
                            || (_vLiq.Equals(value) != true)))
                {
                    this._vLiq = value;
                    this.OnPropertyChanged("vLiq");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCTeNormCobrDup : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._nDup == value))
                {
                    return;
                }
                if (((this._nDup == null)
                            || (_nDup.Equals(value) != true)))
                {
                    this._nDup = value;
                    this.OnPropertyChanged("nDup");
                }
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
                if ((this._dVenc == value))
                {
                    return;
                }
                if (((this._dVenc == null)
                            || (_dVenc.Equals(value) != true)))
                {
                    this._dVenc = value;
                    this.OnPropertyChanged("dVenc");
                }
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
                if ((this._vDup == value))
                {
                    return;
                }
                if (((this._vDup == null)
                            || (_vDup.Equals(value) != true)))
                {
                    this._vDup = value;
                    this.OnPropertyChanged("vDup");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCteAnu : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._chCte == value))
                {
                    return;
                }
                if (((this._chCte == null)
                            || (_chCte.Equals(value) != true)))
                {
                    this._chCte = value;
                    this.OnPropertyChanged("chCte");
                }
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
                if ((this._dEmi == value))
                {
                    return;
                }
                if (((this._dEmi == null)
                            || (_dEmi.Equals(value) != true)))
                {
                    this._dEmi = value;
                    this.OnPropertyChanged("dEmi");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteInfCteComp : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._chCTe == value))
                {
                    return;
                }
                if (((this._chCTe == null)
                            || (_chCTe.Equals(value) != true)))
                {
                    this._chCTe = value;
                    this.OnPropertyChanged("chCTe");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeOSInfCteAutXML : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private string _item;

        private ItemChoiceType12 _itemElementName;
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
                if ((this._item == value))
                {
                    return;
                }
                if (((this._item == null)
                            || (_item.Equals(value) != true)))
                {
                    this._item = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType12 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                if ((_itemElementName.Equals(value) != true))
                {
                    this._itemElementName = value;
                    this.OnPropertyChanged("ItemElementName");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType12
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class TEnviCTe : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private string _idLote;

        private List<TCTe> _cTe;

        private string _versao;
        #endregion

        public TEnviCTe()
        {
            this._cTe = new List<TCTe>();
        }

        public string idLote
        {
            get
            {
                return this._idLote;
            }
            set
            {
                if ((this._idLote == value))
                {
                    return;
                }
                if (((this._idLote == null)
                            || (_idLote.Equals(value) != true)))
                {
                    this._idLote = value;
                    this.OnPropertyChanged("idLote");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CTe")]
        public List<TCTe> CTe
        {
            get
            {
                return this._cTe;
            }
            set
            {
                if ((this._cTe == value))
                {
                    return;
                }
                if (((this._cTe == null)
                            || (_cTe.Equals(value) != true)))
                {
                    this._cTe = value;
                    this.OnPropertyChanged("CTe");
                }
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
                if ((this._versao == value))
                {
                    return;
                }
                if (((this._versao == null)
                            || (_versao.Equals(value) != true)))
                {
                    this._versao = value;
                    this.OnPropertyChanged("versao");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class TRetEnviCTe : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private TAmb _tpAmb;

        private TCodUfIBGE _cUF;

        private string _verAplic;

        private string _cStat;

        private string _xMotivo;

        private TRetEnviCTeInfRec _infRec;

        private string _versao;
        #endregion

        public TRetEnviCTe()
        {
            this._infRec = new TRetEnviCTeInfRec();
        }

        public TAmb tpAmb
        {
            get
            {
                return this._tpAmb;
            }
            set
            {
                if ((_tpAmb.Equals(value) != true))
                {
                    this._tpAmb = value;
                    this.OnPropertyChanged("tpAmb");
                }
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this._cUF;
            }
            set
            {
                if ((_cUF.Equals(value) != true))
                {
                    this._cUF = value;
                    this.OnPropertyChanged("cUF");
                }
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
                if ((this._verAplic == value))
                {
                    return;
                }
                if (((this._verAplic == null)
                            || (_verAplic.Equals(value) != true)))
                {
                    this._verAplic = value;
                    this.OnPropertyChanged("verAplic");
                }
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
                if ((this._cStat == value))
                {
                    return;
                }
                if (((this._cStat == null)
                            || (_cStat.Equals(value) != true)))
                {
                    this._cStat = value;
                    this.OnPropertyChanged("cStat");
                }
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
                if ((this._xMotivo == value))
                {
                    return;
                }
                if (((this._xMotivo == null)
                            || (_xMotivo.Equals(value) != true)))
                {
                    this._xMotivo = value;
                    this.OnPropertyChanged("xMotivo");
                }
            }
        }

        public TRetEnviCTeInfRec infRec
        {
            get
            {
                return this._infRec;
            }
            set
            {
                if ((this._infRec == value))
                {
                    return;
                }
                if (((this._infRec == null)
                            || (_infRec.Equals(value) != true)))
                {
                    this._infRec = value;
                    this.OnPropertyChanged("infRec");
                }
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
                if ((this._versao == value))
                {
                    return;
                }
                if (((this._versao == null)
                            || (_versao.Equals(value) != true)))
                {
                    this._versao = value;
                    this.OnPropertyChanged("versao");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TRetEnviCTeInfRec : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private string _nRec;

        private string _dhRecbto;

        private string _tMed;
        #endregion

        public string nRec
        {
            get
            {
                return this._nRec;
            }
            set
            {
                if ((this._nRec == value))
                {
                    return;
                }
                if (((this._nRec == null)
                            || (_nRec.Equals(value) != true)))
                {
                    this._nRec = value;
                    this.OnPropertyChanged("nRec");
                }
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
                if ((this._dhRecbto == value))
                {
                    return;
                }
                if (((this._dhRecbto == null)
                            || (_dhRecbto.Equals(value) != true)))
                {
                    this._dhRecbto = value;
                    this.OnPropertyChanged("dhRecbto");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string tMed
        {
            get
            {
                return this._tMed;
            }
            set
            {
                if ((this._tMed == value))
                {
                    return;
                }
                if (((this._tMed == null)
                            || (_tMed.Equals(value) != true)))
                {
                    this._tMed = value;
                    this.OnPropertyChanged("tMed");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class TEndernac : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._xLgr == value))
                {
                    return;
                }
                if (((this._xLgr == null)
                            || (_xLgr.Equals(value) != true)))
                {
                    this._xLgr = value;
                    this.OnPropertyChanged("xLgr");
                }
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
                if ((this._nro == value))
                {
                    return;
                }
                if (((this._nro == null)
                            || (_nro.Equals(value) != true)))
                {
                    this._nro = value;
                    this.OnPropertyChanged("nro");
                }
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
                if ((this._xCpl == value))
                {
                    return;
                }
                if (((this._xCpl == null)
                            || (_xCpl.Equals(value) != true)))
                {
                    this._xCpl = value;
                    this.OnPropertyChanged("xCpl");
                }
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
                if ((this._xBairro == value))
                {
                    return;
                }
                if (((this._xBairro == null)
                            || (_xBairro.Equals(value) != true)))
                {
                    this._xBairro = value;
                    this.OnPropertyChanged("xBairro");
                }
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
                if ((this._cMun == value))
                {
                    return;
                }
                if (((this._cMun == null)
                            || (_cMun.Equals(value) != true)))
                {
                    this._cMun = value;
                    this.OnPropertyChanged("cMun");
                }
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
                if ((this._xMun == value))
                {
                    return;
                }
                if (((this._xMun == null)
                            || (_xMun.Equals(value) != true)))
                {
                    this._xMun = value;
                    this.OnPropertyChanged("xMun");
                }
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
                if ((this._cEP == value))
                {
                    return;
                }
                if (((this._cEP == null)
                            || (_cEP.Equals(value) != true)))
                {
                    this._cEP = value;
                    this.OnPropertyChanged("CEP");
                }
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
                if ((_uf.Equals(value) != true))
                {
                    this._uf = value;
                    this.OnPropertyChanged("UF");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class TEndOrg : System.ComponentModel.INotifyPropertyChanged
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
                if ((this._xLgr == value))
                {
                    return;
                }
                if (((this._xLgr == null)
                            || (_xLgr.Equals(value) != true)))
                {
                    this._xLgr = value;
                    this.OnPropertyChanged("xLgr");
                }
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
                if ((this._nro == value))
                {
                    return;
                }
                if (((this._nro == null)
                            || (_nro.Equals(value) != true)))
                {
                    this._nro = value;
                    this.OnPropertyChanged("nro");
                }
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
                if ((this._xCpl == value))
                {
                    return;
                }
                if (((this._xCpl == null)
                            || (_xCpl.Equals(value) != true)))
                {
                    this._xCpl = value;
                    this.OnPropertyChanged("xCpl");
                }
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
                if ((this._xBairro == value))
                {
                    return;
                }
                if (((this._xBairro == null)
                            || (_xBairro.Equals(value) != true)))
                {
                    this._xBairro = value;
                    this.OnPropertyChanged("xBairro");
                }
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
                if ((this._cMun == value))
                {
                    return;
                }
                if (((this._cMun == null)
                            || (_cMun.Equals(value) != true)))
                {
                    this._cMun = value;
                    this.OnPropertyChanged("cMun");
                }
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
                if ((this._xMun == value))
                {
                    return;
                }
                if (((this._xMun == null)
                            || (_xMun.Equals(value) != true)))
                {
                    this._xMun = value;
                    this.OnPropertyChanged("xMun");
                }
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
                if ((this._cEP == value))
                {
                    return;
                }
                if (((this._cEP == null)
                            || (_cEP.Equals(value) != true)))
                {
                    this._cEP = value;
                    this.OnPropertyChanged("CEP");
                }
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
                if ((_uf.Equals(value) != true))
                {
                    this._uf = value;
                    this.OnPropertyChanged("UF");
                }
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
                if ((this._cPais == value))
                {
                    return;
                }
                if (((this._cPais == null)
                            || (_cPais.Equals(value) != true)))
                {
                    this._cPais = value;
                    this.OnPropertyChanged("cPais");
                }
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
                if ((this._xPais == value))
                {
                    return;
                }
                if (((this._xPais == null)
                            || (_xPais.Equals(value) != true)))
                {
                    this._xPais = value;
                    this.OnPropertyChanged("xPais");
                }
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
                if ((this._fone == value))
                {
                    return;
                }
                if (((this._fone == null)
                            || (_fone.Equals(value) != true)))
                {
                    this._fone = value;
                    this.OnPropertyChanged("fone");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class TLocal : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private string _cMun;

        private string _xMun;

        private TUf _uf;
        #endregion

        public string cMun
        {
            get
            {
                return this._cMun;
            }
            set
            {
                if ((this._cMun == value))
                {
                    return;
                }
                if (((this._cMun == null)
                            || (_cMun.Equals(value) != true)))
                {
                    this._cMun = value;
                    this.OnPropertyChanged("cMun");
                }
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
                if ((this._xMun == value))
                {
                    return;
                }
                if (((this._xMun == null)
                            || (_xMun.Equals(value) != true)))
                {
                    this._xMun = value;
                    this.OnPropertyChanged("xMun");
                }
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
                if ((_uf.Equals(value) != true))
                {
                    this._uf = value;
                    this.OnPropertyChanged("UF");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class TEndReEnt : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        private string _item;

        private ItemChoiceType13 _itemElementName;

        private string _xNome;

        private string _xLgr;

        private string _nro;

        private string _xCpl;

        private string _xBairro;

        private string _cMun;

        private string _xMun;

        private TUf _uf;
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
                if ((this._item == value))
                {
                    return;
                }
                if (((this._item == null)
                            || (_item.Equals(value) != true)))
                {
                    this._item = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType13 ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                if ((_itemElementName.Equals(value) != true))
                {
                    this._itemElementName = value;
                    this.OnPropertyChanged("ItemElementName");
                }
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
                if ((this._xNome == value))
                {
                    return;
                }
                if (((this._xNome == null)
                            || (_xNome.Equals(value) != true)))
                {
                    this._xNome = value;
                    this.OnPropertyChanged("xNome");
                }
            }
        }

        public string xLgr
        {
            get
            {
                return this._xLgr;
            }
            set
            {
                if ((this._xLgr == value))
                {
                    return;
                }
                if (((this._xLgr == null)
                            || (_xLgr.Equals(value) != true)))
                {
                    this._xLgr = value;
                    this.OnPropertyChanged("xLgr");
                }
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
                if ((this._nro == value))
                {
                    return;
                }
                if (((this._nro == null)
                            || (_nro.Equals(value) != true)))
                {
                    this._nro = value;
                    this.OnPropertyChanged("nro");
                }
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
                if ((this._xCpl == value))
                {
                    return;
                }
                if (((this._xCpl == null)
                            || (_xCpl.Equals(value) != true)))
                {
                    this._xCpl = value;
                    this.OnPropertyChanged("xCpl");
                }
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
                if ((this._xBairro == value))
                {
                    return;
                }
                if (((this._xBairro == null)
                            || (_xBairro.Equals(value) != true)))
                {
                    this._xBairro = value;
                    this.OnPropertyChanged("xBairro");
                }
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
                if ((this._cMun == value))
                {
                    return;
                }
                if (((this._cMun == null)
                            || (_cMun.Equals(value) != true)))
                {
                    this._cMun = value;
                    this.OnPropertyChanged("cMun");
                }
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
                if ((this._xMun == value))
                {
                    return;
                }
                if (((this._xMun == null)
                            || (_xMun.Equals(value) != true)))
                {
                    this._xMun = value;
                    this.OnPropertyChanged("xMun");
                }
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
                if ((_uf.Equals(value) != true))
                {
                    this._uf = value;
                    this.OnPropertyChanged("UF");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType13
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }
}
