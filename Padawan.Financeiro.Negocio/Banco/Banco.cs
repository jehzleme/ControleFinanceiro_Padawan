using LiteDB;
using Padawan.Financeiro.Negocio.Interfaces;
using Padawan.Financeiro.Negocio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Padawan.Financeiro.Negocio.Banco
{
    public class Banco<T>
    {
        public List<T> Listar()
        {
            using (var db = new LiteDatabase("banco.db"))
            {
              return db.GetCollection<T>().FindAll().ToList();

            }

        }
    }
}
