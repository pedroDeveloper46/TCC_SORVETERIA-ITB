using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Produtos
{
    public partial class Entrada_Produto : Form
    {
        public Entrada_Produto()
        {
            InitializeComponent();
            CarregarCombo();
        }

        private void Salvar(object sender, EventArgs e)
        {
            //BLL_SORVETERIA.Produto p = new BLL_SORVETERIA.Produto();
            //try
            //{
            //    //p.ID_Produto = Convert.ToInt32(combo_Produto.SelectedValue);
            //    p.Data_Produto = Convert.ToDateTime(mkdDATA.Text);
            //    p.QuantidadeEntrada = Convert.ToInt32(txtQuant.Text);

            //    p.Entrada();
            //    MessageBox.Show("ENTRADA DE PRODUTO EFETUADA");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //throw ;
            //}
        }

        public void CarregarCombo()
        {
            BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
            combo_Produto.DataSource = pro.ConsultarProduto().Tables[0];
            combo_Produto.DisplayMember = "Nome_Produto";
            combo_Produto.ValueMember = "ID_Produto";
            combo_Produto.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Produto p = new BLL_SORVETERIA.Produto();
            try
            {
                p.ID_Produto = Convert.ToInt32(combo_Produto.SelectedValue);
                p.QuantidadeEntrada = Convert.ToInt32(txtQuant.Text);
                p.Data_Produto = Convert.ToDateTime(mkdDATA.Text);
                

                p.InserirParametro();
                p.IncluirEntrada();
                MessageBox.Show("ENTRADA DE PRODUTO EFETUADA");
                dataGridView1.DataSource = p.ListarEntrada().Tables[0];

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                    // throw ex;
            }
        }

        private void Entrada_Produto_Load(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Produto p = new BLL_SORVETERIA.Produto();
            mkdDATA.Text = Convert.ToString( DateTime.Now);

            dataGridView1.DataSource = p.ListarEntrada().Tables[0];

            



        }
    }
}
