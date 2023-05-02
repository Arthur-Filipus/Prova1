using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;

namespace Prova1.ConsoleApp.ModuloProduto
{
    public class RepositorioProduto : RepositorioBase
    {
        public RepositorioProduto(ArrayList listaProduto)
        {
            this.listaRegistros = listaProduto;
        }
        public override Produto SelecionarPorId(int id)
        {
            return (Produto)base.SelecionarPorId(id);
        }
    }
}
