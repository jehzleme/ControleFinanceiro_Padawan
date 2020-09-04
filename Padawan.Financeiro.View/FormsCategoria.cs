using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Padawan.Financeiro.View
{
    public partial class FormsCategoria : Form
    {
        private readonly Padawan.Financeiro.Negocio.Model.Categoria categoria;
        public FormsCategoria()
        {
            InitializeComponent();
            categoria = new Padawan.Financeiro.Negocio.Model.Categoria();

            //foreach (var item in categoria.Listar())
            //{
            //    list_Categoria.Items.Add(item);
            //}
        }

        private void btn_AdicionarCategoria_Click(object sender, EventArgs e)
        {
            categoria.Add(txt_Categoria.Text);
            list_Categoria.Items.Add(txt_Categoria.Text);
            txt_Categoria.Text = "";
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            list_Categoria.Items.Remove(txt_Categoria.Text);
            categoria.Remove(txt_Categoria.Text);
            txt_Categoria.Text = "";
        }
    }
}
