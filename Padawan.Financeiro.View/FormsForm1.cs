using Padawan.Financeiro.Negocio;
using Padawan.Financeiro.Negocio.Model;
using System;
using System.Windows.Forms;

namespace Padawan.Financeiro.View
{

    public  partial class FormsForm1 : Form
    {
        private Balanco balanco;
        private Categoria categoria;

        public FormsForm1()
        {

            //como pego a lista ja instaciada na outra tela 
            InitializeComponent();
            balanco = new Balanco();
            txt_ListaBalanco.Text =Convert.ToString(balanco.CalcularSaldo());
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
         
           // como faço isso por tipo e nao passando a string que ela ali dentro pra eu nao fazer if toda vez que eu adicionar algo
            if (cmb_Tipo.Text == "Credito")
            {
                balanco.Add(new Credito(double.Parse(txt_valor.Text)));
            }
            if (cmb_Tipo.Text == "Debito")
            {
                balanco.Add(new Debito(double.Parse(txt_valor.Text)));
            }

            txt_ListaBalanco.Text = Convert.ToString(balanco.Saldo);
        }


    }
}
