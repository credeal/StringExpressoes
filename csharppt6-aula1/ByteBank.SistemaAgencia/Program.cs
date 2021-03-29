using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Utils;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {   


            string urlParametros = "http://www.bytebank.com/cambio?MoedaOrigem=real&MoedaDestino=dolar";
            ExtrairValorArgumentosURL extrator = new ExtrairValorArgumentosURL(urlParametros);

            string valorOrigem = extrator.GetValor("MoedaOrigem");
            Console.WriteLine($"Valor da moeda Destino: {valorOrigem}");

            string valorDestino = extrator.GetValor("MoedaDestino");
            Console.WriteLine($"Valor da moeda Destino: {valorDestino}");

            //string testeRemocao = "primeiraParte&parteParaRemover";
            //int indicee = testeRemocao.IndexOf("&");
            //string removido = testeRemocao.Remove(indicee);
            //Console.WriteLine(removido);

            Console.ReadLine();
        }

        public static void Testes()
        {
            string urlTeste = "htpp://google.com/?q=http://www.bytebank.com";
            int indiceTeste = urlTeste.IndexOf("http://www.bytebank.com");


            Console.WriteLine(urlTeste.StartsWith("http://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("http://www.bytebank.com"));
            Console.WriteLine($"Contem: {urlTeste.Contains("bytebank")}");
            Console.WriteLine(indiceTeste >= 0 ? "Correto" : "Errado");

            // pagina?argumentos
            // 012345678

            //Pegando o Dolar           

            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumentoDolar = "moedaDestino";
            string nomeArgumentoReal = "moedaOrigem";


            int indiceDolar = palavra.IndexOf(nomeArgumentoDolar);
            int indiceReal = palavra.IndexOf(nomeArgumentoReal);

            Console.WriteLine($"Indice inicial: {indiceDolar}");
            Console.WriteLine($"Tamanho da string nome argumento: {nomeArgumentoDolar.Length}");
            Console.WriteLine($"Nome Argumento: {palavra.Substring(indiceDolar)}");
            Console.WriteLine($"{palavra.Substring(indiceDolar + nomeArgumentoDolar.Length + 1)}");

            Console.WriteLine("");

            Console.WriteLine($"Indice inicial: {indiceReal}");
            Console.WriteLine($"Tamanho da string nome argumento: {nomeArgumentoReal.Length}");
            Console.WriteLine($"Nome Argumento: {palavra.Substring(indiceReal)}");
            Console.WriteLine($"{palavra.Substring(indiceReal + nomeArgumentoReal.Length + 1)}");
        }

        public static void ExpressãoRegular()
        {
            //Olá meu nome é David e você pode entrar em contato comigo
            //através  do número 8832-3231

            //Meu nome é David, me ligue 4333-2231
        }
    }
}
