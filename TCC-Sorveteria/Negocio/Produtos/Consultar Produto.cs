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
    public partial class ConsultarProdutos : Modelos.Consultar
    {
        public ConsultarProdutos()
        {
            InitializeComponent();
            CarregarCombo();
            CarregaCombo2();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Produtos.CadastrarProdutos pro = new CadastrarProdutos();
            pro.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (txtPesquisar.Text.Length > 0)
            {
                BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
                dataGridView2.DataSource = pro.Listar(txtPesquisar.Text.Trim().ToUpper()).Tables[0];
                
                dataGridView2.Columns[0].HeaderText = "Cód";
                dataGridView2.AutoResizeColumn(0);
                dataGridView2.Columns[1].HeaderText = "Produto";
                dataGridView2.AutoResizeColumn(1);
                dataGridView2.Columns[2].HeaderText = "Descricao";
                dataGridView2.AutoResizeColumn(2);
                dataGridView2.Columns[3].HeaderText = "Preço";
                dataGridView2.AutoResizeColumn(3);

            }
            else if (Convert.ToInt32(comboBox1.SelectedValue) > 0)
            {
               // comboBox2.SelectedIndex = -1;


                BLL_SORVETERIA.Produto p = new BLL_SORVETERIA.Produto();
                dataGridView2.DataSource = p.ListarForn(Convert.ToInt32(comboBox1.SelectedValue)).Tables[0];
            }
            else if (Convert.ToInt32(comboBox2.SelectedValue) > 0)
            {
                //comboBox1.SelectedIndex = -1;
                BLL_SORVETERIA.Produto p = new BLL_SORVETERIA.Produto();
                dataGridView2.DataSource = p.ListarCat(Convert.ToInt32(comboBox2.SelectedValue)).Tables[0];
            }
            else
            {
                BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
                dataGridView2.DataSource = pro.ListarAtivos().Tables[0];
                //  int q = 10;
               

            }
          
            

            

        }
        private void CarregarCombo()
        {
            BLL_SORVETERIA.Fornecedor f = new BLL_SORVETERIA.Fornecedor();
            comboBox1.DataSource = f.ConsultarFornecedor().Tables[0];
            comboBox1.DisplayMember = "NomeFantasia_Fornecedor";
            comboBox1.ValueMember = "ID_Fornecedor";
            comboBox1.SelectedIndex = -1;

        }
        private void CarregaCombo2()
        {
            BLL_SORVETERIA.Categoria c = new BLL_SORVETERIA.Categoria();
            comboBox2.DataSource = c.ConsultarCat().Tables[0];
            comboBox2.DisplayMember = "Nome_Categoria";
            comboBox2.ValueMember = "ID_Categoria";
            comboBox2.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
            dataGridView2.DataSource = pro.ListarAtivos().Tables[0];
            

        }

        private void rdbIna_CheckedChanged(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
            dataGridView2.DataSource = pro.ListarInativos().Tables[0];

        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView2, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);





            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Produtos.CadastrarProdutos pro = new CadastrarProdutos();
            pro.btnAlterar.Visible = true;
            
            pro.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            pro.Id_Produto = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());



            pro.Show();
        }

        private void desativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indice = 0;
            BLL_SORVETERIA.Produto p = new BLL_SORVETERIA.Produto();
            p.ID_Produto = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("DESEJA ATIVAR?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    if (indice >= 0)
                    {
                        var linha = dataGridView2.Rows[indice];
                        if (!linha.IsNewRow)
                            dataGridView2.Rows.Remove(linha);
                    }


                    p.AtivarParametro();
                    MessageBox.Show("PRODUTO ATIVADO");
                    dataGridView2.DataSource = p.ListarInativos().Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }

        private void ativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            var indice = 0;
            BLL_SORVETERIA.Produto p = new BLL_SORVETERIA.Produto();
            p.ID_Produto = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("DESEJA DESATIVAR " + "?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {


                    if (indice >= 0)
                    {
                        var linha = dataGridView2.Rows[indice];
                        if (!linha.IsNewRow)
                            dataGridView2.Rows.Remove(linha);
                    }

                    p.DesativarParametro();
                    MessageBox.Show("PRODUTO DESATIVADO");
                    dataGridView2.DataSource = p.ListarAtivos().Tables[0];

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void tet()
        {
            



        }
    }
}
