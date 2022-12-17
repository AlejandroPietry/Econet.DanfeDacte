using System;
using Zion.NFe.Danfe.Tools;

namespace ECONET.EcoNFe2.Negocio.Dacte
{
    public static class FormatadorDacte
    {

        public static string LogradouroCompleto(string logradouro, string numero, string complemento)
        {
            return string.Concat(logradouro, !String.IsNullOrEmpty(numero) ? ", " : null, numero, !String.IsNullOrEmpty(complemento) ? ", " : null, complemento);
        }

        public static string Cep(string cep, int tamanho)
        {
            return cep != null ? Formatador.FormatarCEP(cep).PadLeft(tamanho, ' ') : string.Empty.PadLeft(tamanho, ' ');
        }
    }
}
