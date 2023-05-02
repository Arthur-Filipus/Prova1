using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;

namespace Prova1.ConsoleApp.ModuloGarcom
{
    public class TelaGarcom : TelaBase
    {
        public TelaGarcom(RepositorioGarcom repositorioGarcom)
        {
            this.repositorioBase = repositorioGarcom;
            nomeEntidade = "Garcom";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} {3, -20}", "Id", "Nome", "CPF" ,"Telefone");

            Console.WriteLine("-------------------------------------------------------------------------");

            foreach (Garcom garcom in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", garcom.id, garcom.nome, garcom.cpf, garcom.telefone);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Qual o Nome do Garçom: ");
            string nome = Console.ReadLine();
            Console.Write("Qual o CPF do Garçom: ");
            string cpf = Console.ReadLine();
            Console.Write("Qual o Telefone do Garçom: ");
            string telefone = Console.ReadLine();

            Garcom garcom = new Garcom(nome, cpf, telefone);

            return garcom;
        }
    }
}
