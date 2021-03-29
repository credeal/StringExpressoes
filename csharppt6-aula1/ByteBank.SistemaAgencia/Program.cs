using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("teste");

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

            Console.ReadLine();
        }
    }
}
