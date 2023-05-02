using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;

namespace Prova1.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string nome;
        public int preco;
        public Produto(string nome, int preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto produtoAtualizado = (Produto)registroAtualizado;

            this.nome = produtoAtualizado.nome;
            this.preco = produtoAtualizado.preco;
        }
        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"NOME\" é obrigatório");

            if (preco == null)
                erros.Add("O campo \"Preço\" é obrigatório");

            return erros;
        }
    }
}
