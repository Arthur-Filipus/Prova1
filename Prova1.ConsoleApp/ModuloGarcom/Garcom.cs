using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;

namespace Prova1.ConsoleApp
{
    public class Garcom : EntidadeBase
    {
        public string nome;
        public string cpf;
        public string telefone;

        public Garcom(string nome, string cpf, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom garcomAtualizado = (Garcom)registroAtualizado;

            this.nome = garcomAtualizado.nome;
            this.cpf = garcomAtualizado.cpf;
            this.telefone = garcomAtualizado.telefone;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"NOME\" é obrigatório");

            if (string.IsNullOrEmpty(cpf.Trim()))
                erros.Add("O campo \"CPF\" é obrigatório");

            if (string.IsNullOrEmpty(telefone.Trim()))
                erros.Add("O campo \"TELEFONE\" é obrigatório");

            return erros;
        }
    }
}
