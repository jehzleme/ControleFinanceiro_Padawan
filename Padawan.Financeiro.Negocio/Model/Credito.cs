using Padawan.Financeiro.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.Financeiro.Negocio.Model
{
    public class Credito : IOperacao
    {
        public Credito(double valor)
        {
            Valor = valor;
        }

        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public Categoria Categoria { get; set; }
    }
}
