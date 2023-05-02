using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1.ConsoleApp
{
    public class TelaInicial
    {
        public string MostrarInicio()
        {
            Console.WriteLine("Qual opção quer: ");
            Console.WriteLine("1 - Garçons");
            Console.WriteLine("2 - Mesas");
            Console.WriteLine("3 - Produtos");
            Console.WriteLine("4 - Pedidos");
            Console.WriteLine();
            Console.WriteLine("S - Sair");
            string opcao = Console.ReadLine().ToUpper();
            return opcao;
        }
    }
}
