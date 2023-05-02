using Prova1.ConsoleApp.ModuloGarcom;
using Prova1.ConsoleApp.ModuloMesa;
using Prova1.ConsoleApp.ModuloProduto;
using Prova1.ConsoleApp.ModuloConta;
using System.Collections;

namespace Prova1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());

            TelaInicial telaInicial = new TelaInicial();
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            TelaConta telaConta = new TelaConta(repositorioConta, repositorioGarcom, telaGarcom, repositorioMesa, 
                                                telaMesa, repositorioProduto, telaProduto);

            while (true)
            {
                Console.Clear();
                string opcao = telaInicial.MostrarInicio();
                Console.WriteLine();

                if (opcao == "1")
                {
                    string subopcao = telaGarcom.ApresentarMenu();
                    if (subopcao == "1")
                    {
                        telaGarcom.InserirNovoRegistro();
                    }
                    else if (subopcao == "2")
                    {
                        telaGarcom.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subopcao == "3")
                    {
                        telaGarcom.EditarRegistro();
                    }
                    else if (subopcao == "4")
                    {
                        telaGarcom.ExcluirRegistro();
                    }
                    else if (subopcao == "S")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digitou errado");
                        Console.ReadLine();
                    }
                }
                else if (opcao == "2")
                {
                    string subopcao = telaMesa.ApresentarMenu();
                    
                    if (subopcao == "1")
                    {
                        telaMesa.InserirNovoRegistro();
                    }
                    else if (subopcao == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subopcao == "3")
                    {
                        telaMesa.EditarRegistro();
                    }
                    else if (subopcao == "4")
                    {
                        telaMesa.ExcluirRegistro();
                    }
                    else if (subopcao == "S")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digitou errado");
                        Console.ReadLine();
                    }
                }
                else if (opcao == "3")
                {
                    string subopcao = telaProduto.ApresentarMenu();
                    if (subopcao == "1")
                    {
                        telaProduto.InserirNovoRegistro();
                    }
                    else if (subopcao == "2")
                    {
                        telaProduto.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subopcao == "3")
                    {
                        telaProduto.EditarRegistro();
                    }
                    else if (subopcao == "4")
                    {
                        telaProduto.ExcluirRegistro();
                    }
                    else if (subopcao == "S")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digitou errado");
                        Console.ReadLine();
                    }
                }
                else if (opcao == "4")
                {
                    string subopcao = telaConta.ApresentarMenu();
                    if (subopcao == "1")
                    {
                        telaConta.InserirNovoRegistro();
                    }
                    else if (subopcao == "2")
                    {
                        telaConta.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subopcao == "3")
                    {
                        telaConta.EditarRegistro();
                    }
                    else if (subopcao == "4")
                    {
                        telaConta.ExcluirRegistro();
                    }
                    else if (subopcao == "S")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digitou errado");
                        Console.ReadLine();
                    }
                }
                else if (opcao == "S")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digitou errado");
                    Console.ReadLine();
                }
            }
        }
    }
}