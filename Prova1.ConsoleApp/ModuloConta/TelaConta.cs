using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;
using Prova1.ConsoleApp.ModuloGarcom;
using Prova1.ConsoleApp.ModuloMesa;
using Prova1.ConsoleApp.ModuloProduto;
using System.Collections;

namespace Prova1.ConsoleApp.ModuloConta
{
    public class TelaConta : TelaBase
    {
        private RepositorioConta repositorioConta;

        private RepositorioGarcom repositorioGarcom;
        private TelaGarcom telaGarcom;

        private RepositorioMesa repositorioMesa;
        private TelaMesa telaMesa;

        private RepositorioProduto repositorioProduto;
        private TelaProduto telaProduto;

        public TelaConta(RepositorioConta repositorioConta, RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom,
        RepositorioMesa repositorioMesa, TelaMesa telaMesa, RepositorioProduto repositorioProduto, TelaProduto telaProduto)
        {
            this.repositorioBase = repositorioConta;
            nomeEntidade = "Conta";
            sufixo = "s";
        }
        public override void InserirNovoRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}{sufixo}", "Inserindo um novo registro...");

            bool temGarcom = repositorioGarcom.TemRegistros();

            if (temGarcom == false)
            {
                MostrarMensagem("Cadastre ao menos um Garçom para cadastrar requisições de saída", ConsoleColor.DarkYellow);
                return;
            }

            bool temMesa = repositorioMesa.TemRegistros();

            if (temMesa == false)
            {
                MostrarMensagem("Cadastre ao menos uma Mesa para cadastrar requisições de saída", ConsoleColor.DarkYellow);
                return;
            }


            bool temProduto = repositorioProduto.TemRegistros();

            if (temProduto == false)
            {
                MostrarMensagem("Cadastre ao menos um Produto para cadastrar requisições de saída", ConsoleColor.DarkYellow);
                return;
            }

            Conta registro = (Conta)ObterRegistro();

            if (TemErrosDeValidacao(registro))
            {
                return;
            }

            repositorioBase.Inserir(registro);

            MostrarMensagem("Registro inserido com sucesso!", ConsoleColor.Green);
        }
        public override void EditarRegistro()
        {
            bool temGarcom= repositorioGarcom.TemRegistros();

            if (temGarcom == false)
            {
                MostrarMensagem("Cadastre ao menos um Garçom para cadastrar requisições de saída", ConsoleColor.DarkYellow);
                return;
            }

            bool temMesa = repositorioMesa.TemRegistros();

            if (temMesa == false)
            {
                MostrarMensagem("Cadastre ao menos uma Mesa para cadastrar requisições de saída", ConsoleColor.DarkYellow);
                return;
            }

            bool temProduto = repositorioProduto.TemRegistros();

            if (temProduto == false)
            {
                MostrarMensagem("Cadastre ao menos um Produto para cadastrar requisições de saída", ConsoleColor.DarkYellow);
                return;
            }

            VisualizarRegistros(false);

            Console.WriteLine();

            Conta requisicaoSaida = (Conta)EncontrarRegistro("Digite o id do registro: ");

            Conta requisicaoSaidaAtualizado = (Conta)ObterRegistro();

            if (TemErrosDeValidacao(requisicaoSaidaAtualizado))
            {
                return;
            }

            repositorioBase.Editar(requisicaoSaida, requisicaoSaidaAtualizado);

            MostrarMensagem("Registro editado com sucesso!", ConsoleColor.Green);
        }
        public override void ExcluirRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}{sufixo}", "Excluindo um registro já cadastrado...");

            VisualizarRegistros(false);

            Console.WriteLine();

            Conta requisicaoSaida = (Conta)EncontrarRegistro("Digite o id do registro: ");

            repositorioBase.Excluir(requisicaoSaida);

            MostrarMensagem("Registro excluído com sucesso!", ConsoleColor.Green);
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            const string FORMATO_TABELA = "{0, -10} | {1, -10} | {2, -20} | {3, -20} | {4, -20} | {5, -20}";

            Console.WriteLine(FORMATO_TABELA, "Id", "Data", "Produto", "Garçom", "Mesa", "Preço");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Conta conta in registros)
            {
                Console.WriteLine(FORMATO_TABELA,
                    conta.id,
                    conta.data.ToShortDateString(),
                    conta.produto.nome,
                    conta.garcom.nome,
                    conta.mesa.id,
                    conta.produto.preco);
            }
        }
        protected override EntidadeBase ObterRegistro()
        {
            Garcom garcom = ObterGarcom();

            Mesa mesa = ObterMesa();

            Produto produto = ObterProduto();

            Console.Write("Digite a quantidade de Produtos: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            return new Conta(data, quantidade, garcom, mesa, produto);
        }
        private Garcom ObterGarcom()
        {
            telaGarcom.VisualizarRegistros(false);

            Garcom garcom = (Garcom)telaGarcom.EncontrarRegistro("Digite o id do Garçom: ");

            Console.WriteLine();

            return garcom;
        }
        private Mesa ObterMesa()
        {
            telaMesa.VisualizarRegistros(false);

            Mesa mesa = (Mesa)telaMesa.EncontrarRegistro("Digite o id da Mesa: ");

            Console.WriteLine();

            return mesa;
        }
        private Produto ObterProduto()
        {
            telaProduto.VisualizarRegistros(false);

            Produto produto = (Produto)telaProduto.EncontrarRegistro("Digite o id do Produto: ");

            Console.WriteLine();

            return produto;
        }
    }
}
