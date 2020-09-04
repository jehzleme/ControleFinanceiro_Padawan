using LiteDB;
using Padawan.Financeiro.Negocio.Interfaces;
using Padawan.Financeiro.Negocio.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.Financeiro.Negocio
{
    public class Balanco : IBalanco
    {

       public  double Saldo { get => CalcularSaldo();}
       public  List<IOperacao> Operacoes { get; } = new List<IOperacao>();

        

        public double CalcularSaldo()
        {
            double result = 0;

            using (var db = new LiteDatabase("banco.db"))
            {
                var teste = db.GetCollection<IOperacao>();
                var colecao = teste.FindAll();
                
                colecao.ToList().ForEach(p => 
                {
                    if (p is Debito)
                    {
                        result -= p.Valor;
                    }
                    if (p is Credito)
                    {
                        result += p.Valor;
                    }
                });
            }
            return result;
        }

        public void Add(IOperacao operacao)
        {
            using (var db = new LiteDatabase("banco.db"))
            {
                var teste = db.GetCollection<IOperacao>("Operacao");
                teste.Insert(operacao);
            }
        }

        public  void Delete(IOperacao operacao)
        {

            using (var db = new LiteDatabase("banco.db"))
            {
                var teste = db.GetCollection<IOperacao>("Operacao");
                // teste.Delete()
            }

        }
    }
}
