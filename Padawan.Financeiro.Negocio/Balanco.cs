using Padawan.Financeiro.Negocio.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.Financeiro.Negocio
{
    public class Balanco
    {
        public object Saldo { get; set; }

        public void Add(Credito credito)
        {
            throw new NotImplementedException();
        }

        public void Add(Debito debito)
        {
            throw new NotImplementedException();
        }
    }
}
