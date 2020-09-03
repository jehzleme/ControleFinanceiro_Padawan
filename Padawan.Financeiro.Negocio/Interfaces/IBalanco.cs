using Padawan.Financeiro.Negocio.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.Financeiro.Negocio.Interfaces
{
    public interface IBalanco
    {
        void Add(IOperacao operacao);
        void Delete(IOperacao operacao);
        List<IOperacao> Operacoes { get;}
        double Saldo { get; }
    }
}
