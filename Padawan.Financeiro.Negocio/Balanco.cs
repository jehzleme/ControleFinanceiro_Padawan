using Padawan.Financeiro.Negocio.Interfaces;
using Padawan.Financeiro.Negocio.Model;
using System;
using System.Collections.Generic;

namespace Padawan.Financeiro.Negocio
{
    public class Balanco : IBalanco
    {
        

        public double Saldo { get => CalcularSaldo();}
        public List<IOperacao> Operacoes { get; } = new List<IOperacao>();


        private double CalcularSaldo()
        {
            double result = 0;

            foreach (var item in Operacoes)
            {
                if (item is Debito)
                {
                    result -= item.Valor;
                }
                if (item is Credito)
                {
                    result += item.Valor;
                }
            }
            return result;
        }

        public void Add(IOperacao operacao)
        {
            Operacoes.Add(operacao);
            
        }
      

        public void Delete(IOperacao operacao)
        {
            Operacoes.Remove(operacao);
           
        }
    }
}
