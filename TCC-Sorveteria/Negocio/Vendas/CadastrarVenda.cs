using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Vendas
{
    public partial class Vendas : Modelos.Cadastrar
    {
        public int idVenda = 0;
        public Vendas()
        {
            InitializeComponent();
            CarregarCombo();
            Carrega();


            //comboProd(1);
        }
    
        BLL_SORVETERIA.Produto p = new BLL_SORVETERIA.Produto();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void BuscarDadosPro(Object o, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtNomeP.Text.Trim().Length == 0)
        //        {
        //            MessageBox.Show("DIGITE UM PRODUTO");
        //            return;
        //        }
        //        p.Nome_Produto = txtNomeP.Text;
        //        p.RecuperarDadosPro();
        //        textBox2.Text = "R$" + Convert.ToString(p.Preco_Produto);




        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        //throw;
        //    }
        //}

        private void BuscarDadosProId(object o, EventArgs e)
        {
            try
            {
               
                   
                p.ID_Produto = Convert.ToInt32(comboPro.SelectedValue);
               // lblIdProd.Text = Convert.ToString(Convert.ToInt32(comboPro.SelectedValue));
                p.RecuperarDadosProId();


                txtPreco_Produto.Text = "R$" +  Convert.ToDecimal(Convert.ToString(p.Preco_Produto));

                lblIdProd.Text = Convert.ToString(Convert.ToInt32(comboPro.SelectedValue));





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            pegarUltimaVenda();
            //this.MinimumSize = new Size(this.Width, this.Height);
            //this.MaximumSize = new Size(this.Width, this.Height);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void pegarUltimaVenda()
        {
            BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
            System.Data.SqlClient.SqlDataReader dr;
            dr = v.IdVenda();
            dr.Read();
            
                  if (dr["ID_Venda"].ToString() == "")
                  {
                    lblCod.Text = "0";
                  }
                  else
                  {
                    lblCod.Text = dr["ID_Venda"].ToString();
                  }
            
        }
        private void label5_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
            try
            {
                v.Data_Venda = dateTimePicker1.Value;
                v.VALOR_TOTAL_Venda = Convert.ToDecimal(txtTotal.Text);
                v.QTDE_ITEM_Venda = Convert.ToInt32(numericQuant.Value);
               // v.ID_Funcionario = 0;

                //double quant, total;
                //double valoruni;
                //valoruni = Convert.ToDouble(textBox2.Text.Replace("R$", "").Replace(",", "."));
                //quant = Convert.ToDouble(numericQuant.Value);
                //total = Convert.ToDouble(valoruni) * Convert.ToDouble(quant);
                //txtTotal.Text = "R$" + Convert.ToString(total);



                v.IncluirComParametro();
                MessageBox.Show("VENDA INCLUÍDA");

                pegarUltimaVenda();
                comboCat();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
      


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtPreco_Produto.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }
        string valor;
        private void textBox2_Leave(object sender, EventArgs e)
        {

            valor = txtPreco_Produto.Text.Replace("R$", "");
            txtPreco_Produto.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtPreco_Produto.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtPreco_Produto.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtPreco_Produto.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtPreco_Produto.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtPreco_Produto.Text.StartsWith("0,"))
                {
                    txtPreco_Produto.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtPreco_Produto.Text.Contains("00,"))
                {
                    txtPreco_Produto.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtPreco_Produto.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtPreco_Produto.Text;
            txtPreco_Produto.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtPreco_Produto.Select(txtPreco_Produto.Text.Length, 0);
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Pedido_Compra v = new BLL_SORVETERIA.Pedido_Compra();
            try
            {
                v.ID_Produto = Convert.ToInt32(lblIdProd.Text);
                v.ID_venda = Convert.ToInt32(lblCod.Text);
                v.QTDADE_Itens = Convert.ToInt32(numericQuant.Value);


                decimal total;
                int quant;
                decimal valoruni;
                quant = Convert.ToInt32(numericQuant.Value);
                valoruni = Convert.ToDecimal(txtPreco_Produto.Text.Replace("R$", ""));
                total = Convert.ToDecimal(quant * valoruni);
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + total);

               
                
                

                
                v.IncluirComParametro();
                MessageBox.Show("ITEM ADICIONADO NO CARRINHO ");
                txtQuant.Text = Convert.ToString(Convert.ToInt32(txtQuant.Text) + Convert.ToInt32(numericQuant.Value));

              //  textBox3.Clear();
        //        txtTotal.Clear();

                comboBox3.SelectedIndex = -1;
               // comboPro.SelectedIndex = -1;
                lblIdProd.Text = "0";
               txtPreco_Produto.Clear();
                numericQuant.Value = 1;
                comboPro.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;

                dataGridView1.DataSource = v.Listar(v.ID_venda).Tables[0];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }






            


        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);





            }
        }

        public void CarregarCombo()
        {
            BLL_SORVETERIA.Funcionario func = new BLL_SORVETERIA.Funcionario();
            comboFunc.DataSource = func.ConsultarFuncionario().Tables[0];
            comboFunc.DisplayMember = "Nome_Funcionario";
            comboFunc.ValueMember = "ID_Funcionario";
            comboFunc.SelectedIndex = -1;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
            try
            {
                v.ID_Venda = idVenda;
                v.ID_Venda = Convert.ToInt32(lblCod.Text);
                v.CancelarVenda();
                MessageBox.Show("VENDA CANCELADA");
                comboBox1.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboFunc.SelectedIndex = -1;
                comboPro.SelectedIndex = -1;
                txtPreco_Produto.Clear();
                numericQuant.Value = 1;
                txtQuant.Clear();
                txtTotal.Clear();
                lblCod.Text = "0";


            }
            catch (Exception ex)
            {

                // throw;
                MessageBox.Show(ex.Message);
            }

        }

        private void Picolé_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BLL_SORVETERIA.Produto pro = new BLL_SORVETERIA.Produto();
            //System.Data.SqlClient.SqlDataReader dr;

        }


        public void comboProd(int idCat)
        {
            BLL_SORVETERIA.Produto p = new BLL_SORVETERIA.Produto();
            comboPro.DataSource = p.ConsultarProduto(idCat).Tables[0];
            comboPro.DisplayMember = "Nome_Produto";
            comboPro.ValueMember = "ID_Produto";
            comboPro.SelectedIndex = -1;

        }
        public void comboCat()

        {
            BLL_SORVETERIA.Categoria c = new BLL_SORVETERIA.Categoria();
            comboBox3.DataSource = c.ConsultarCategorias().Tables[0];
            comboBox3.DisplayMember = "Nome_Categoria";
            comboBox3.ValueMember = "ID_Categoria";
            comboBox3.SelectedIndex = -1;




        }

       
        



     
      

        private void label(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNomeP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //private void NomeP(Object o, EventArgs e)
        //{
        //    txtNomeP.Text = comboPro.Text;
        //    lblIdProd.Text = Convert.ToString(comboPro.SelectedValue);
        //}

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.ValueMember == String.Empty)
            {
                return;
            }
          
            comboProd(Convert.ToInt32(comboBox3.SelectedValue));
            

             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Pedido_Compra p = new BLL_SORVETERIA.Pedido_Compra();

            p.ID_venda = Convert.ToInt32(lblCod.Text);
            p.SubValor(p.ID_venda);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
            BLL_SORVETERIA.PAGTO_VENDA p = new BLL_SORVETERIA.PAGTO_VENDA();
            try
            {
                v.ID_Venda = Convert.ToInt32(lblCod.Text);
                v.Data_Venda = dateTimePicker1.Value;
                v.QTDE_ITEM_Venda = Convert.ToInt32(txtQuant.Text);
                v.VALOR_TOTAL_Venda = Convert.ToDecimal(txtTotal.Text);
                v.ID_Funcionario = Convert.ToInt32(comboFunc.SelectedValue);
                //p.ID_Venda = Convert.ToInt32(lblCod.Text);
                //p.ID_FormaPagamento = Convert.ToInt32(comboBox1.SelectedValue);
                //p.ValorPago_PAGTO_VENDA = Convert.ToDecimal(txtTotal.Text);

                txtValoraPagar.Text = txtTotal.Text;


                v.AtualizarComParametro();
              //  p.IncluirComParametro();

                MessageBox.Show("VENDA FINALIZADA");
                comboFunc.SelectedIndex = -1;
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw;
            }
        }
      
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indice = 0;
         
            BLL_SORVETERIA.Pedido_Compra p = new BLL_SORVETERIA.Pedido_Compra();
            p.ID_ITENS_VENDA = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            p.ID_venda = Convert.ToInt32(lblCod.Text);
            DialogResult dialog = MessageBox.Show("DESEJA EXCLUIR " + "?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {


                    if (indice >= 0)
                    {
                        var linha = dataGridView1.Rows[indice];
                        if (!linha.IsNewRow)
                            dataGridView1.Rows.Remove(linha);
                    }

                    p.ExcluirParametro();
                    MessageBox.Show("ITEM REMOVIDO DA VENDA");
                    txtTotal.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value.ToString()));
                    txtQuant.Text = Convert.ToString(Convert.ToInt32(txtQuant.Text) - Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString()));
                    dataGridView1.DataSource = p.Listar(p.ID_venda).Tables[0];

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

      
       private void chkDinheiro_True(object sender, EventArgs e)

        {

            //txtValoraPagar.Text = txtTotal.Text;
            //valorPagar = Convert.ToDecimal(txtValoraPagar.Text);
            
            
            //if (txtValorPago.Text.Equals(""))

            //{
            //    txtValorPago.Text = Convert.ToString(Convert.ToDecimal(txtValorPago));
            //    valorpago = Convert.ToDecimal(txtValorPago.Text);
            //}

            //if (valorpago >= valorPagar)
            //{
            //    troco = Convert.ToDecimal(valorpago - valorPagar);
            //    txtTroco.Text = Convert.ToString(troco);
            //}
            //else if (valorpago < valorPagar)
            //{
            //   // restante = Convert.ToDecimal(valorPagar - valorpago);
            //    txtRestante.Text = Convert.ToString(restante);
            //}



            //txtTroco.Text = Convert.ToDecimal(txtValoraPagar.Text - Convert.ToDecimal(txtValorPago.Text));
            //txtTroco.Text = Convert.ToDecimal(troco).ToString();









        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void a(object sender, EventArgs e)
        {
           
        }

        public void Carrega()
        {
            BLL_SORVETERIA.FormaPGTO f = new BLL_SORVETERIA.FormaPGTO();
            comboBox1.DataSource = f.Consultar().Tables[0];
            comboBox1.DisplayMember = "Nome_FormaPagamento";
            comboBox1.ValueMember = "ID_FormaPagamento";
            comboBox1.SelectedIndex = -1;
        }
        decimal valorPagar;
        decimal troco;
        decimal valorpago = 0;
        decimal restante;
        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            if (!txtValorPago.Text.Equals(""))

            {
                if (valorpago >= valorPagar)
                {
                    troco = valorpago - valorPagar;
                    txtTroco.Text = Convert.ToString(troco);
                }
                //else if (valorpago < valorPagar)
                //{
                //    restante = Convert.ToDecimal(valorPagar - valorpago);
                //    txtRestante.Text = Convert.ToString(restante);
                //}
            }
        }

        private void txtValorPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double a = Convert.ToDouble(txtValoraPagar.Text) - Convert.ToDouble(txtValorPago.Text);
                txtTroco.Text = Convert.ToString(a).Replace("-","");

            }
                
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.PAGTO_VENDA forma = new BLL_SORVETERIA.PAGTO_VENDA();
            try
            {
                forma.ID_Venda = Convert.ToInt32(lblCod.Text);
                forma.ID_FormaPagamento = Convert.ToInt32(comboBox1.SelectedValue);
                forma.ValorPago_PAGTO_VENDA = Convert.ToDecimal(txtValorPago.Text);
                if (Convert.ToInt32(comboBox1.SelectedValue) != 1)
                {
                    txtTroco.Visible = false;
                }


                forma.IncluirComParametro();
                MessageBox.Show("PAGAMENTO EFETUADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
