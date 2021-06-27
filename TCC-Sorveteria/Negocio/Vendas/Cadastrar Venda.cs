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
        public byte Status;
       // 710,320
        public Vendas()
        {
            InitializeComponent();
            //CarregarCombo();
            Carrega();
            ////comboCat();
            


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

            try
            {
                

                if (comboPro.ValueMember == String.Empty)
                {
                    return;
                }
                else {
                    p.ID_Produto = Convert.ToInt32(comboPro.SelectedValue);
                    p.RecuperarQuant();

                    lblQuan.Text = Convert.ToInt32(p.qtdeATUAL_Produto).ToString();
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Login log = new BLL_SORVETERIA.Login();
            //lblIdProd.Visible = true;
            //lblIdProd.Text = "0";
            lblQuan.Visible = false;
            label14.Visible = false;
            //System.Data.SqlClient.SqlDataReader dr;
            //dr = log.Log();
            //dr.Read();
            //if (dr.HasRows)
            //{
            //    label15.Text = dr["ID_Funcionario"].ToString();
            //}
           
            pegarUltimaVenda();
            //TCC_Sorveteria.Telas_Iniciais.TelaMenu tlm = new TCC_Sorveteria.Telas_Iniciais.TelaMenu();
           // Telas_Iniciais.TelaLogin t = new Telas_Iniciais.TelaLogin();
            TCC_Sorveteria.Negocio.Vendas.Vendas v = new TCC_Sorveteria.Negocio.Vendas.Vendas();
            Negocio.Vendas.Vendas vi = new Vendas();
           // comboFunc.SelectedText = "Jonathan";
            

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

        public void pegarUltimoID()
        {
            BLL_SORVETERIA.Funcionario f = new BLL_SORVETERIA.Funcionario();
            System.Data.SqlClient.SqlDataReader dr;
            dr = f.IdFunc();
            dr.Read();

            if (dr["ID_Funcionario"].ToString() == "")
            {
                label15.Text = "0";
            }
            else
            {
                label15.Text = dr["ID_Funcionario"].ToString();
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
            //comboBox3.Enabled = true;

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

            if (dataGridView2.RowCount >0 && Convert.ToInt32(txtQuant.Text) > 0  &&  Convert.ToDecimal(txtTotal.Text) > 0)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].DataGridView.Columns.Clear();
                }
                txtTotal.Text = "0";
                txtQuant.Text = "0";
                comboBox1.SelectedIndex = -1;
                txtValoraPagar.Clear();
                txtValorPago.Clear();
                txtTroco.Clear();


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
           // BLL_SORVETERIA.Venda ve = new BLL_SORVETERIA.Venda();
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

                if (Convert.ToDecimal(lblQuan.Text.ToString()) < numericQuant.Value)
                {
                    MessageBox.Show("NÃO TEM ESTA QUANTIDADE NO ESTOQUE", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTotal.Text = "0";
                }
                else
                {

                    v.IncluirComParametro();
                    MessageBox.Show("ITEM ADICIONADO NO CARRINHO ");
                    
                    v.AtualizarQtdeProdParametro();
                   
            

                    txtQuant.Text = Convert.ToString(Convert.ToInt32(txtQuant.Text) + Convert.ToInt32(numericQuant.Value));

                    //textBox3.Clear();
                    // txtTotal.Clear();
                    //comboPro.SelectedIndex = -1;
                    //comboBox3.SelectedIndex = -1;
                    //// comboPro.SelectedIndex = -1;
                    //lblIdProd.Text = "0";
                    //txtPreco_Produto.Clear();
                    //numericQuant.Value = 1;
                    //comboPro.SelectedIndex = -1;
                    //comboBox3.SelectedIndex = -1;

                    dataGridView2.DataSource = v.Listar(v.ID_venda).Tables[0];
                    dataGridView2.Columns[0].HeaderText = "Cod Item da Venda";
                    dataGridView2.AutoResizeColumn(0);
                    dataGridView2.Columns[1].HeaderText = " Cod Produto";
                    dataGridView2.AutoResizeColumn(1);
                    dataGridView2.Columns[2].HeaderText = "Produto";
                    dataGridView2.AutoResizeColumn(2);
                    dataGridView2.Columns[3].HeaderText = "Preço Produto";
                   dataGridView2.AutoResizeColumn(3);
                    dataGridView2.Columns[4].HeaderText = "Quantidade";
                    dataGridView2.AutoResizeColumn(4);




                }









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

       // public void CarregarCombo()
        //{
        //    BLL_SORVETERIA.Funcionario func = new BLL_SORVETERIA.Funcionario();
        //    comboFunc.DataSource = func.ConsultarFuncionario().Tables[0];
        //    comboFunc.DisplayMember = "Nome_Funcionario";
        //    comboFunc.ValueMember = "ID_Funcionario";
        //    comboFunc.SelectedIndex = -1;



        //}

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
            try
            {
                v.ID_Venda = idVenda;
                v.ID_Venda = Convert.ToInt32(lblCod.Text);
                //.SelectedIndex = -1;
                //comboBox3.SelectedIndex = -1;

                txtPreco_Produto.Clear();
                numericQuant.Value = 1;
                txtQuant.Text = "0";
                txtTotal.Text = "0";
                txtRestante.Text = "0";
                txtTroco.Text = "0";
                txtValoraPagar.Text = "0";
                txtValorPago.Text = "0";
                lblIdProd.Text = "0";
                comboBox1.SelectedIndex = -1;
                //comboPro.SelectedIndex = -1;

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].DataGridView.Columns.Clear();
                }


                

                v.CancelarVenda();
                MessageBox.Show("VENDA CANCELADA");
                //v.Data_Venda = dateTimePicker1.Value;
                //v.VALOR_TOTAL_Venda = Convert.ToDecimal(txtTotal.Text);
                //v.QTDE_ITEM_Venda = Convert.ToInt32(numericQuant.Value);
               

                // v.ID_Funcionario = 0;

                //double quant, total;
                //double valoruni;
                //valoruni = Convert.ToDouble(textBox2.Text.Replace("R$", "").Replace(",", "."));
                //quant = Convert.ToDouble(numericQuant.Value);
                //total = Convert.ToDouble(valoruni) * Convert.ToDouble(quant);
                //txtTotal.Text = "R$" + Convert.ToString(total);



               




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
        double menorValor = 0;
        double[] mv = new double[0];
        int[] idItem = new int[0];

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
                v.ID_Funcionario = Convert.ToInt32(label15.Text);

                //p.ID_Venda = Convert.ToInt32(lblCod.Text);
                //p.ID_FormaPagamento = Convert.ToInt32(comboBox1.SelectedValue);
                //p.ValorPago_PAGTO_VENDA = Convert.ToDecimal(txtTotal.Text);

               


                v.AtualizarComParametro();
               // p.IncluirComParametro();

                MessageBox.Show("VENDA FINALIZADA");
                txtValoraPagar.Text = txtTotal.Text;
                if (textBox1.Text.Equals("10%"))
                {
                    txtValoraPagar.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) * 0.90);
                }
                else if (textBox1.Text.Equals("15%"))
                {
                    txtValoraPagar.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) * 0.85);
                }
                else if (textBox1.Text.Equals("Compre 1 e ganhe outro") || textBox1.Text.Equals("Compre 2 e ganhe 1"))


                {

                    mv = new double[dataGridView2.RowCount];

                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {

                        mv[i] += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);

                    }

                    Array.Sort(mv);
                    menorValor = mv[1];

                   // MessageBox.Show("o Menor valor é " + menorValor);
                    txtValoraPagar.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(menorValor));

                }
               
                
                else
                {
                    txtValoraPagar.Text = txtTotal.Text;    
                    
                }
                //comboFunc.SelectedIndex = -1;

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
            BLL_SORVETERIA.Produto pr = new BLL_SORVETERIA.Produto();
            p.ID_ITENS_VENDA = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            p.ID_venda = Convert.ToInt32(lblCod.Text);
            DialogResult dialog = MessageBox.Show("DESEJA EXCLUIR " + "?", "", MessageBoxButtons.YesNo);
            pr.ID_Produto = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            int q = Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value.ToString());
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
                    pr.InserirParametroz(q);
                    p.ExcluirParametro();
                    

                    MessageBox.Show("ITEM REMOVIDO DA VENDA");
                    txtTotal.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(dataGridView2.CurrentRow.Cells[5].Value.ToString()));
                    txtQuant.Text = Convert.ToString(Convert.ToInt32(txtQuant.Text) - Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value.ToString()));
                    dataGridView2.DataSource = p.Listar(p.ID_venda).Tables[0];

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
                else if (valorpago < valorPagar)
                {
                    restante = valorPagar - valorpago;
                    txtRestante.Text = Convert.ToString(restante);
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
                //double a = Convert.ToDouble(txtValoraPagar.Text) - Convert.ToDouble(txtValorPago.Text);
                //txtTroco.Text = Convert.ToString(a).Replace("-","");
                if (Convert.ToDouble(txtRestante.Text) == 0)
                {
                    if (Convert.ToDouble(txtValorPago.Text) >= Convert.ToDouble(txtValoraPagar.Text))
                    {
                        txtTroco.Text = Convert.ToString(Convert.ToDouble(txtValorPago.Text) - Convert.ToDouble(txtValoraPagar.Text));
                        if (Convert.ToDouble(txtTroco.Text) > 0)
                        {
                            txtValorPago.Enabled = false;
                        }
                    }
                    else if (Convert.ToDouble(txtValorPago.Text) < Convert.ToDouble(txtValoraPagar.Text))
                    {
                        txtRestante.Text = Convert.ToString(Convert.ToDouble(txtValoraPagar.Text) - Convert.ToDouble(txtValorPago.Text));
                       // txtValorPago.Text = "0";
                    }
                }
                else
                {
                    if (Convert.ToDouble(txtValorPago.Text) >= Convert.ToDouble(txtRestante.Text))
                    {

                        txtTroco.Text = Convert.ToString(Convert.ToDouble(txtValorPago.Text) - (Convert.ToDouble(txtRestante.Text)));
                        //txtRestante.Text = "0";
                        //txtValorPago.Text = "0";
                        if (Convert.ToDouble(txtTroco.Text) > 0)
                        {
                            txtValorPago.Enabled = false;
                        }
                    }
                    else if (Convert.ToDouble(txtValorPago.Text) < Convert.ToDouble(txtRestante.Text))
                    {
                        txtRestante.Text = Convert.ToString(Convert.ToDouble(txtRestante.Text) - Convert.ToDouble(txtValorPago.Text));
                       // txtValorPago.Text = "0";
                    }

                }


            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.PAGTO_VENDA forma = new BLL_SORVETERIA.PAGTO_VENDA();
           
            {
                try
                {
                    forma.ID_Venda = Convert.ToInt32(lblCod.Text);
                    forma.ID_FormaPagamento = Convert.ToInt32(comboBox1.SelectedValue);
                    forma.ValorPago_PAGTO_VENDA = Convert.ToDecimal(txtValorPago.Text);
                   
                    int cli = 0;
                    if (Convert.ToInt32(comboBox1.SelectedIndex) < 0)
                    {
                        MessageBox.Show("É PRECISO ADICIONAR UMA FORMA DE PAGAMENTO");
                        return;
                    }
                    else
                    {
                        forma.IncluirComParametro();
                        MessageBox.Show("PAGAMENTO EFETUADO");
                        BLL_SORVETERIA.Cupom c = new BLL_SORVETERIA.Cupom();
                        if (Status == 1)
                        {
                            c.ID_Cupom = Convert.ToInt32(label18.Text);
                            c.CupomPara0();
                        }
                        System.Data.SqlClient.SqlDataReader dr;
                        dr = c.CodigoCupom(Convert.ToInt32(label18.Text));
                        dr.Read();
                        if (dr.HasRows)
                        {
                            cli = Convert.ToInt32(dr["ID_Cliente"]);
                        }

                        BLL_SORVETERIA.Cliente a = new BLL_SORVETERIA.Cliente();
                        a.ID_Cliente = Convert.ToInt32(cli);
                        a.ativarParametro();




                        if (Convert.ToDouble(txtRestante.Text) > 0)
                        {
                            txtValoraPagar.Text = txtRestante.Text;
                            txtValorPago.Text = "0";
                            return;
                        }
                        else
                        {
                            Close();
                        }
                    }




                    
                   

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }

                //Close();

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTotal_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

        private void dataGridView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView2, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void comboFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Login log = new BLL_SORVETERIA.Login();
            comboPro.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            txtPreco_Produto.Clear();
            numericQuant.Value = 1;
            txtQuant.Clear();
            txtTotal.Clear();
            txtRestante.Clear();
            txtTroco.Clear();
            txtValoraPagar.Clear();
            txtValorPago.Clear();
            comboBox1.SelectedIndex = -1;
            //comboPro.SelectedIndex = -1;

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].DataGridView.Columns.Clear();
            }


            pegarUltimaVenda();

            //comboProd(Convert.ToInt32(comboBox3.SelectedValue));
            //comboBox3.Enabled = false;
           // Close();
            TCC_Sorveteria.Negocio.Vendas.Vendas v = new Vendas();
            //pegarUltimoID();
           




        }

        private void comboPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            comboPro.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Cupom.Cupom c = new Cupom.Cupom();
            c.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                BLL_SORVETERIA.Cupom c = new BLL_SORVETERIA.Cupom();


                try
                {


                    System.Data.SqlClient.SqlDataReader dr;
                    dr = c.Listartipo(textBox2.Text);
                    dr.Read();

                    if (dr.HasRows)
                    {
                        textBox1.Text = dr["tipoDesconto_Cupom"].ToString();
                        label18.Text = dr["ID_Cupom"].ToString();
                        if (Convert.ToInt32(dr["Status_Cupom"]) == 1)
                        {
                            label21.Text = "ESTE CUPOM NÃO FOI USADO";
                            Status = 1;

                            
                        }
                        else if (Convert.ToInt32(dr["Status_Cupom"]) == 0)
                        {
                            label21.Text = "ESTE CUPOM JÁ FOI USADO";
                            textBox1.Clear();
                           
                        }


                       

                    }
                    else
                    {
                        MessageBox.Show("ESTE CUPOM NÃO EXISTE");
                    }

                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw ex;
                }
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
          
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
        
        
        //TCC_Sorveteria.Negocio.Vendas.Vendas v = new Vendas();

        private void button3_Click_1(object sender, EventArgs e)
        {
            //PRIMEIRA
           

            //

            //for (int i = 0; i < dataGridView2.RowCount; i++)
            //{
            //    for (int j = 0; j < dataGridView2.RowCount; j++)
            //    {
            //        if (!(i == 0))
            //        {
            //            if (dataGridView2.Rows[i].Cells[3] > dataGridView2.Rows[j].Cells[3])
            //            {

            //            }
            //        }
            //    }
            //}
        }
    }
}
