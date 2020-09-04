using System.Collections.Generic;

namespace Padawan.Financeiro.Negocio.Model
{
    public class Categoria
    {
        public void Add(string descricao)
        {
            if (!(descricao.Length <= 4))
            {
                BalancoStatic.Lista.Add(descricao);
            }
        }
        public void Remove(string descricao)
        {
            BalancoStatic.Lista.Remove(descricao);
        }


       
    }



}