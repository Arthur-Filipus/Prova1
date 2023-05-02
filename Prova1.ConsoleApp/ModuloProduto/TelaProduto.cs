using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;

namespace Prova1.ConsoleApp.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Preço");

            Console.WriteLine("-------------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", produto.id, produto.nome, produto.preco);
            }
        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Qual o Nome do Produto: ");
            string nome = Console.ReadLine();
            Console.Write("Qual o Preço do Produto: ");
            int preco = Convert.ToInt32(Console.ReadLine());

            Produto produto = new Produto(nome, preco);

            return produto;
        }
    }
}
