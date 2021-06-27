using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;


namespace TCC_Sorveteria.Negocio.Fornecedor
{
    public partial class ConsultarFornecedor : Form
    {
        public ConsultarFornecedor()
        {
            InitializeComponent();
        }

        BLL_SORVETERIA.Fornecedor FORNE = new BLL_SORVETERIA.Fornecedor();
        BLL_SORVETERIA.FuncoesGerais FUG = new BLL_SORVETERIA.FuncoesGerais();
        


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Fornecedor.CadastrarFornecedor cadF = new TCC_Sorveteria.Negocio.Fornecedor.CadastrarFornecedor();
            cadF.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


       private void CarregarGrid()
        {

            //if (chkAtivo.Checked && chkInativo.Checked)
            //{
            //    TipoStatus = (byte)BLL_SORVETERIA.FuncoesGerais.TipoStatus.Todos;
            //}
            //else if (chkAtivo.Checked && !chkInativo.Checked)
            //{
            //    TipoStatus = (byte)BLL_SORVETERIA.FuncoesGerais.TipoStatus.Ativo;
            //}
            //else
            //{
            //    TipoStatus = (byte)BLL_SORVETERIA.FuncoesGerais.TipoStatus.Inativo;
            //}


            //dataGridView_Forne.DataSource = FORNE.Listar(txtPesquisar.Text.Trim().ToUpper()).Tables[0];

            //dataGridView_Forne.Columns[0].HeaderText = "Cód";
            //dataGridView_Forne.AutoResizeColumn(0);
            //dataGridView_Forne.Columns[1].HeaderText = "Nome";
            //dataGridView_Forne.AutoResizeColumn(1);
            //dataGridView_Forne.Columns[2].HeaderText = "CPF/CNPJ";
            //dataGridView_Forne.AutoResizeColumn(2);

            //if (o == btnFiltrar)
            //{
            //    txtPesquisa.Clear();
            //}

            txtPesquisar.Focus();

        }



        private byte _TipoStatus;

        public byte TipoStatus
        {
            get
            {
                return _TipoStatus;
            }

            set
            {
                _TipoStatus = value;
            }
        }

      
        private void Fixar(Object o, EventArgs e)
        {

        }

        private void AbrirFormulario(Object o, EventArgs e)
        {
            try
            {
                AlterarFornecedor fcn = new AlterarFornecedor();
                //  depois vÊ       //fcn.TipoUso = (byte)BLL_SORVETERIA.FuncoesGerais.TipoUso.Inclusao;

                fcn.Operação = Convert.ToByte( BLL_SORVETERIA.FuncoesGerais. Operacao.Inclusao);
                // fcn.status.Visible = false;
                if (o == btnCadastrar)
                {
                                      
                    //fcu.chkAtivo.Checked = false;
                    //fcu.txtSenha.Visible = false;
                    //fcu.txtPergunta.Visible = false;
                    //fcu.txtResposta.Visible = false;
                    //fcu.lblPergunta.Visible = false;
                    //fcu.lblResposta.Visible = false;
                    //fcu.lblSenha.Visible = false;
                    //fcu.lblPin.Visible = false;
                    //fcu.lblPin.Text = Negocio.FuncoesGerais.GerarPin();

                }

             //   if (o == this.btnAlterar || o == this.btnConsultar)
                {
                    fcn.Codigo = Convert.ToInt32(this.dataGridView_Forne.CurrentRow.Cells[0].Value);
                    fcn.Operação = Convert.ToByte(BLL_SORVETERIA.FuncoesGerais .Operacao.Alteracao);
                    if (o == btnConsultar)
                    {
                        
                   //     fcn.groupBox1.Enabled = false;
                    //    fcn.btn.Visible = false;
                        fcn.Codigo = (byte)BLL_SORVETERIA.FuncoesGerais.TipoUso.Consulta;
                    }
                }
                var b = (Button)o;
                //fcn.label1.Text = label1.Text.PadRight(1) + " > " + b.Text;
                fcn.ShowDialog();

                CarregarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }


        private void ImprimirGrid(Object o, EventArgs e)
        {
            //https://pplware.sapo.pt/tutoriais/tutorial-c-imprimir-conteudo-da-datagridview/
            //https://pplware.sapo.pt/tutoriais/tutorial-c-imprimir-conteudo-da-datagridview/2/
           // printDGV.Print_DataGridView(dataGridView1);
        }





























        private void ConsultarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkInativo_CheckedChanged(object sender, EventArgs e)
        {

        }

       // private void btnAtivar_Click(object sender, EventArgs e)
        //{
        //    BLL_SORVETERIA.Fornecedor fornecedor = new BLL_SORVETERIA.Fornecedor();

        //    fornecedor.ID_Fornecedor = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);

        //    fornecedor.AtivarParametro();

        //   // MessageBox.Show("Você tem certeza?");

        //    CarregarGrid();
        //}

       // private void btnDesativar_Click(object sender, EventArgs e)
       //{
            //BLL_SORVETERIA.Fornecedor fornecedor = new BLL_SORVETERIA.Fornecedor();

            //fornecedor.ID_Fornecedor = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);

            //fornecedor.DesativarParametro();

            //if (chkAtivo.Checked)
            //{
            //    chkAtivo.Checked = false ;
            //}

            //fornecedor.ExcluirParametro();

          //  MessageBox.Show("Você tem certeza?");

            //CarregarGrid();
        //}



        private void Relogio(Object o, EventArgs e)
        {
            this.posicao1.Text = System.DateTime.Now.ToString();
        }

        private void Form_KeyDown(Object o, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

       private void CarregarGrid(object sender, EventArgs e)
        {
            //if (chkAtivo.Checked && chkInativo.Checked)
            //{
            //    TipoStatus = (byte)BLL_SORVETERIA.FuncoesGerais.TipoStatus.Todos;
            //}
            //else if (chkAtivo.Checked && !chkInativo.Checked)
            //{
            //    TipoStatus = (byte)BLL_SORVETERIA.FuncoesGerais.TipoStatus.Ativo;
            //}
            //else
            //{
            //    TipoStatus = (byte)BLL_SORVETERIA.FuncoesGerais.TipoStatus.Inativo;
            //}

            if (txtPesquisar.Text.Length > 0)
            {
                dataGridView_Forne.DataSource = FORNE.ListarPorNome(txtPesquisar.Text.Trim().ToUpper()).Tables[0];
            }
            else if (txtCNPJ.Text.Length > 0)
            {
                dataGridView_Forne.DataSource = FORNE.ListarCNPJ(txtCNPJ.Text.Trim().ToUpper()).Tables[0];
            }
            else
            {
                dataGridView_Forne.DataSource = FORNE.ListarAtivos().Tables[0];
            }
            

            //dataGridView_Forne.Columns[0].HeaderText = "Cód";
            //dataGridView_Forne.AutoResizeColumn(0);
            //dataGridView_Forne.Columns[1].HeaderText = "Nome";
            //dataGridView_Forne.AutoResizeColumn(1);
            //dataGridView_Forne.Columns[2].HeaderText = "CPF/CNPJ";
            //dataGridView_Forne.AutoResizeColumn(2);

            //if (o == btnFiltrar)
            //{
            //    txtPesquisa.Clear();
            //}

            txtPesquisar.Focus();
        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView_Forne, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);





            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Negocio.Fornecedor.CadastrarFornecedor forne = new CadastrarFornecedor();
            forne.btnAlterar.Visible = true;
            forne.Text = dataGridView_Forne.CurrentRow.Cells[0].Value.ToString();
            forne.Id_Fornecedor = Convert.ToInt32(dataGridView_Forne.CurrentRow.Cells[0].Value.ToString());



            forne.Show();



        }

        private void desativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indice = 0;
            BLL_SORVETERIA.Fornecedor f = new BLL_SORVETERIA.Fornecedor();
            f.ID_Fornecedor = Convert.ToInt32(dataGridView_Forne.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("DESEJA DESATIVAR " + "?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {


                    if (indice >= 0)
                    {
                        var linha = dataGridView_Forne.Rows[indice];
                        if (!linha.IsNewRow)
                            dataGridView_Forne.Rows.Remove(linha);
                    }

                    f.DesativarParametro();
                    MessageBox.Show("FORNECEDOR DESATIVADO");
                    dataGridView_Forne.DataSource = f.ListarAtivos().Tables[0];

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indice = 0;
            BLL_SORVETERIA.Fornecedor f = new BLL_SORVETERIA.Fornecedor();
            f.ID_Fornecedor = Convert.ToInt32(dataGridView_Forne.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("DESEJA ATIVAR " + "?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {


                    if (indice >= 0)
                    {
                        var linha = dataGridView_Forne.Rows[indice];
                        if (!linha.IsNewRow)
                            dataGridView_Forne.Rows.Remove(linha);
                    }

                    f.AtivarParametro();
                    MessageBox.Show("FORNECEDOR ATIVADO");
                    dataGridView_Forne.DataSource = f.ListarInativos().Tables[0];



                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Fornecedor f = new BLL_SORVETERIA.Fornecedor();
            dataGridView_Forne.DataSource = f.ListarAtivos().Tables[0];
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Fornecedor f = new BLL_SORVETERIA.Fornecedor();
            dataGridView_Forne.DataSource = f.ListarInativos().Tables[0];
        }
    }
    }
