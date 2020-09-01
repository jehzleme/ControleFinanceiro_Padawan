using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.Financeiro.Negocio.Model
{
    public class Credito
    {

        public Credito(double v)
        {
            Valor = v;
        }

        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public Categoria Categoria { get; set; }
    }
}
