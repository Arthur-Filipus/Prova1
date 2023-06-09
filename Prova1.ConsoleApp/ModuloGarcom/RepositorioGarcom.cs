﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1.ConsoleApp.Compartilhado;

namespace Prova1.ConsoleApp.ModuloGarcom
{
    public class RepositorioGarcom : RepositorioBase
    {
        public RepositorioGarcom(ArrayList listaGarcom)
        {
            this.listaRegistros = listaGarcom;
        }
        public override Garcom SelecionarPorId(int id)
        {
            return (Garcom)base.SelecionarPorId(id);
        }
    }
}
