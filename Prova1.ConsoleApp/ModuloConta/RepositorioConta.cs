﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;

namespace Prova1.ConsoleApp.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList listaConta)
        {
            this.listaRegistros = listaConta;
        }
        public override Conta SelecionarPorId(int id)
        {
            return (Conta)base.SelecionarPorId(id);
        }
    }
}
