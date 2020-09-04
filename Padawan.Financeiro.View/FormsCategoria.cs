using LiteDB;
using Padawan.Financeiro.Negocio.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Padawan.Financeiro.View
{
    public partial class FormsCategoria : Form
    {
        private Categoria categoria;
        public FormsCategoria()
        {
            InitializeComponent();
            categoria = new Categoria();

            using (var db = new LiteDatabase("banco.db"))
            {
                var teste = db.GetCollection<Categoria>("Categoria");
                var colecao = teste.FindAll();

                colecao.ToList().ForEach(p =>
                {
                    list_Categoria.Text = p.Descricao;
                });
            }
        }

        private void btn_AdicionarCategoria_Click(object sender, EventArgs e)
        {
            categoria.Add(new CategoriaModel() { 

               Descricao = txt_Categoria.Text

            });

            using (var db = new LiteDatabase("banco.db"))
            {
                var teste = db.GetCollection<CategoriaModel>();
                var colecao = teste.FindAll();
                list_Categoria.Items.Clear();
                list_Categoria.Items.AddRange(colecao.Select(q => q.Descricao).ToArray());
                
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void list_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
