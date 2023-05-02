using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;

namespace Prova1.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string qtdcliente;
        public string livre;
        public Mesa(string qtdcliente, string livre)
        {
            this.qtdcliente = qtdcliente;
            this.livre = livre;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa garcomAtualizado = (Mesa)registroAtualizado;

            this.qtdcliente = garcomAtualizado.qtdcliente;
            this.livre = garcomAtualizado.livre;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(qtdcliente.Trim()))
                erros.Add("O campo \"Quantidade de Cliente\" é obrigatório");

            if (string.IsNullOrEmpty(livre.Trim()))
                erros.Add("O campo \"Livre\" é obrigatório");

            return erros;
        }
    }
}
