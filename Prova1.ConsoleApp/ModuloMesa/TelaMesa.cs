using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;

namespace Prova1.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            this.repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Quantidade de Clientes", "Livre");

            Console.WriteLine("--------------------------------------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", mesa.id, mesa.qtdcliente, mesa.livre);
            }
        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Qual o Numero da Mesa: ");
            string numeromesa = Console.ReadLine();
            Console.Write("Qual a Quantidade de Clientes na Mesa: ");
            string qtdcliente = Console.ReadLine();
            Console.Write("Mesa esta Livre: ");
            string livre = Console.ReadLine();

            Mesa mesa = new Mesa(qtdcliente, livre);

            return mesa;
        }
    }
}
