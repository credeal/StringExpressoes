using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Utils
{
    public class ExtrairValorArgumentosURL
    {
        public string URL { get; }
        private readonly string _argumentos;

        public ExtrairValorArgumentosURL(string p_url)
        {
            if (String.IsNullOrEmpty(p_url))
                throw new ArgumentException("O argumento URL não pode ser null ou vazio. ", nameof(p_url));


            int indiceInterrogacao = p_url.IndexOf('?');
            _argumentos = p_url.ToUpper().Substring(indiceInterrogacao + 1);

            URL = p_url;
        }

        //moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro.ToUpper() + "=";
            int indiceTermo = _argumentos.ToUpper().IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEcomercial = resultado.IndexOf('&');

            if(indiceEcomercial >= 0)
                return resultado.Remove(indiceEcomercial);

            return resultado;
        }

    }
}
