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
    public partial class CadastrarProdutos : Modelos.Cadastrar
    {
        public CadastrarProdutos()
        {
            InitializeComponent();

            CarregarCombo();
            CarrgarCombo2();
            
           
        }

        private int _Id_Produto;

        public int Id_Produto { get => _Id_Produto; set => _Id_Produto = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
                pro.ID_Produto = Convert.ToInt32(this.Text);
                System.Data.SqlClient.SqlDataReader ddr;
                ddr = pro.Consultar();
                ddr.Read();
                if (ddr.HasRows)
                {
                    txtNome.Text = Convert.ToString(ddr["Nome_Produto"]);
                    txtDescricao.Text = Convert.ToString(ddr["Descricao_Produto"]);
                    mkdPreco.Text = Convert.ToString(Convert.ToDecimal(ddr["Preco_Produto"]));
                    txtQ.Text = Convert.ToString(ddr["qtdeATUAL_Produto"]);
                    comboBox1.SelectedText = Convert.ToString(ddr["ID_Fornecedor"]);
                    comboBox_Produto.SelectedText = Convert.ToString(ddr["ID_Cat"]);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                ////throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
            try
            {
                
                pro.Nome_Produto = txtNome.Text;
                pro.Descricao_Produto = txtDescricao.Text;
                pro.qtdeATUAL_Produto = Convert.ToInt32(txtQ.Text);

                pro.Preco_Produto = Convert.ToDecimal(mkdPreco.Text.Replace("R", "").Replace("$", "").Replace(".", ""));


                pro.ID_Cat = Convert.ToInt32(comboBox1.SelectedValue);
                pro.ID_Fornecedor = Convert.ToInt32(comboBox_Produto.SelectedValue);

                pro.IncluirComParametro();
                MessageBox.Show("PRODUTO CADASTRADO");

                Close();

                
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void CarregarCombo()
        {
            BLL_SORVETERIA.Fornecedor forn = new BLL_SORVETERIA.Fornecedor();
            comboBox_Produto.DataSource = forn.ConsultarFornecedor().Tables[0];
            comboBox_Produto.DisplayMember = "NomeFantasia_Fornecedor";
            comboBox_Produto.ValueMember = "ID_Fornecedor";
            comboBox_Produto.SelectedIndex = -1;
        }

        public void CarrgarCombo2()
        {
            BLL_SORVETERIA.Categoria pro = new BLL_SORVETERIA.Categoria();
            comboBox1.DataSource = pro.ConsultarCat().Tables[0];
            comboBox1.DisplayMember = "Nome_Categoria";
            comboBox1.ValueMember = "ID_Categoria";
            comboBox1.SelectedIndex = -1;
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
            txtNome.Clear();
            //txtAtual.Clear();
            txtDescricao.Clear();
            //mkdPreco.Clear();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
            try
            {
                pro.ID_Produto = Id_Produto;
                pro.Nome_Produto = txtNome.Text;
                pro.Descricao_Produto = txtDescricao.Text;
                pro.Preco_Produto = Convert.ToDecimal(mkdPreco.Text.Replace("R", "").Replace("$", "").Replace(".", ""));
                pro.qtdeATUAL_Produto = Convert.ToInt32(txtQ.Text);
                //pro.ID_Fornecedor = Convert.ToInt32(comboBox_Produto.SelectedValue);
                //pro.ID_Cat = Convert.ToInt32(comboBox1.SelectedValue);

                pro.AtualizarParametro();
                MessageBox.Show("PRODUTO ALTERADO");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
