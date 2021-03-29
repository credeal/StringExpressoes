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
            _argumentos = URL.Substring(indiceInterrogacao + 1);

            URL = p_url;
        }

        public string GetValor(string nomeParametro)
        {
            return "";
        }

    }
}
