using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TCC_Sorveteria.Telas_Iniciais
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void combo()
        {
            BLL_SORVETERIA.Cartao c = new BLL_SORVETERIA.Cartao();

            comboBox1.DataSource = c.listaGeo(txtCarro.Text).Tables[0];
            comboBox1.DisplayMember = "CARRO";
            comboBox1.ValueMember = "ID_GEO";
            comboBox1.SelectedIndex = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Cartao c = new BLL_SORVETERIA.Cartao();

            try
            {
                c.Numero = Convert.ToInt32(txtCart.Text);
                c.Tipo = txtTipo.Text;
                c.Carro = txtCarro.Text;
                c.Geo = comboBox1.SelectedIndex;

                MessageBox.Show("CADASTRO FEITO");

                c.incluir();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtCarro_Leave(object sender, EventArgs e)
        {
            combo();
        }
    }
}
