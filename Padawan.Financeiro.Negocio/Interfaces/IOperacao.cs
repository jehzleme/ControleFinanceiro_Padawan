using Padawan.Financeiro.Negocio.Model;
using System;

namespace Padawan.Financeiro.Negocio.Interfaces
{
    public interface IOperacao
    {
        double Valor { get; set; }
        DateTime Data { get; set; }
        Categoria Categoria { get; set; }
    }
}