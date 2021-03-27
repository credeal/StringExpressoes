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
            // pagina?argumentos
            // 012345678

            string url = "pagina?argumentos";
            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);



            Console.ReadLine();
        }
    }


}
