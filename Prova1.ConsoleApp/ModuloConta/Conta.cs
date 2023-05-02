using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.ModuloMesa;
using Prova1.ConsoleApp.ModuloProduto;
using Prova1.ConsoleApp.Compartilhado;
using System.Collections;

namespace Prova1.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public DateTime data;
        public int custototal;
        public Garcom garcom;
        public Mesa mesa;
        public Produto produto;
        public Conta(DateTime data, int custototal, Garcom garcom, Mesa mesa, Produto produto)
        {
            this.data = data;
            this.custototal = custototal;
            this.garcom = garcom;
            this.mesa = mesa;
            this.produto = produto;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta contaAtualizado = (Conta)registroAtualizado;

            this.data = contaAtualizado.data;
            this.custototal = contaAtualizado.custototal;
            this.garcom = contaAtualizado.garcom;
            this.mesa = contaAtualizado.mesa;
            this.produto = contaAtualizado.produto;
        }
        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (data < DateTime.Now.Date)
                erros.Add("O campo \"data\" deve ser maior que a data atual");

            if (garcom == null)
                erros.Add("O campo \"Garçom\" é obrigatório");

            if (mesa == null)
                erros.Add("O campo \"MESA\" é obrigatório");

            if (produto == null)
                erros.Add("O campo \"PRODUTO\" é obrigatório");

            return erros;
        }
    }
}
