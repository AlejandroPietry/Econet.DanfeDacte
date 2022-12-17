using System.Xml.Serialization;

namespace Zion.NFe.Danfe.Enumeracoes
{
    public enum forPag
    {
        [XmlEnum("0")]
        Pago,
        [XmlEnum("1")]
        Apagar,
        [XmlEnum("2")]
        Outros
    }

    public enum lota
    {
        [XmlEnum("0")]
        Nao = 0,
        [XmlEnum("1")]
        Sim = 1
    }

}
