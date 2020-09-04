using Padawan.Financeiro.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.Financeiro.Negocio.Model
{
    public static class BalancoStatic
    {
        public static List<IOperacao> Operacoes { get; } = new List<IOperacao>();
        public static List<string> Lista { get; set; } = new List<string>();
    }
}
