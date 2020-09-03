using Padawan.Financeiro.Negocio;
using Padawan.Financeiro.Negocio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padawan.Financeiro.View
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var balanco = new Balanco();

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
           
            if (cmb_Tipo.Text == "Credito")
            {
                balanco.Add(new Credito(double.Parse(txt_valor.Text)));
            }

            txt_ListaBalanco.Text = Convert.ToString(balanco.Saldo);
        }


    }
}
