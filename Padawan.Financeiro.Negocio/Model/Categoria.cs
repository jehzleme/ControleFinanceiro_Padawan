using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.Financeiro.Negocio.Model
{
    public class Categoria
    {
        private string text;

        public Categoria()
        {
        }

        public Categoria(string text)
        {
            this.text = text;
        }

        public string Descricao { get; set; }

        public void Add(CategoriaModel operacao)
        {
            using (var db = new LiteDatabase("banco.db"))
            {
                var teste = db.GetCollection<CategoriaModel>();
                teste.Insert(operacao);
            }
        }

        
    }

    public class CategoriaModel
    {
        public string Descricao { get; set; }

    }



}