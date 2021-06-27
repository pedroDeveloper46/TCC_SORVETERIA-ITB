using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Fornecedor
{
    public partial class CadastrarFornecedor : Modelos.Cadastrar
    {
        public CadastrarFornecedor()
        {
            InitializeComponent();
        }


        BLL_SORVETERIA.Fornecedor forn = new BLL_SORVETERIA.Fornecedor();
        BLL_SORVETERIA.Cep cep = new BLL_SORVETERIA.Cep();

      

        private byte _TipoUso;

        private int _Id_Fornecedor;


        public byte TipoUso
        {
            get
            {
                return _TipoUso;
            }

            set
            {
                _TipoUso = value;
            }
        }

        public int Id_Fornecedor
        {
            get
            {
                return _Id_Fornecedor;
            }

            set
            {
                _Id_Fornecedor = value;
            }
        }
        private void BuscarDadosCep(Object o, EventArgs e)
        {
            
            try
            {
                if (txtCEP.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DIGITE O CEP");
                    return;
                }
                cep.NumeroCep = txtCEP.Text;
                cep.RecuperarDadosCep();


                if (cep.NomeRua == "NAO EXISTE ESTE CEP")
                {
                    MessageBox.Show("CEP INCORRETO");
                    return;
                }

                txtBairro.Text = cep.Bairro;
                txtLogradouro.Text = cep.NomeRua;
                txtCidade.Text = cep.Cidade;
                txtUF.Text = cep.Uf;



            }
            catch (Exception ex)
            {
                MessageBox.Show("DIGITE UM CEP");
                //throw;
            }
        }

        //private void CadastrarFornecedor_Load(object sender, EventArgs e)
        //{


        //    try
        //    {

        //        if (Convert.ToInt32(this.Text) > 0)
        //        {
        //            BLL_SORVETERIA.Fornecedor forne = new BLL_SORVETERIA.Fornecedor();
        //            forne.ID_Fornecedor = Convert.ToInt32(this.Text);
        //            System.Data.SqlClient.SqlDataReader ddrr;
        //            ddrr = forne.Consultar();
        //            ddrr.Read();
        //            if (ddrr.HasRows)
        //            {
        //                txtNome.Text = Convert.ToString(ddrr["Nome_Fornecedor"]);
        //                txtCNPJ.Text = Convert.ToString(ddrr["CNPJ_CPF_Fornecedor"]);
        //                txtCelular.Text = Convert.ToString(ddrr["Celular_Fornecedor"]);
        //                txtTelefone.Text = Convert.ToString(ddrr["Telefone_Fornecedor"]);
        //                txtWeb.Text = Convert.ToString(ddrr["WebSite_Fornecedor"]);
                       
        //                txtEmail.Text = Convert.ToString(ddrr["Email_Fornecedor"]);
        //                txtCEP.Text = Convert.ToString(ddrr["CEP_Fornecedor"]);
        //                txtComplemento.Text = Convert.ToString(ddrr["Complemento_Fornecedor"]);
        //                txtBairro.Text = Convert.ToString(ddrr["Bairro_Fornecedor"]);
        //                txtUF.Text = Convert.ToString(ddrr["UF_Fornecedor"]);
        //                txtCidade.Text = Convert.ToString(ddrr["Cidade_Fornecedor"]);
        //                txtNúmero.Text = Convert.ToString(ddrr["Numero_Fornecedor"]);
        //                txtLogradouro.Text = Convert.ToString(ddrr["Logradouro_Fornecedor"]);

                      

        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        //throw;
        //    }

        //}


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Fornecedor forn = new BLL_SORVETERIA.Fornecedor();
            try
            {
                forn.RazaoSocial_Fornecedor = txtRazao.Text;
                forn.NomeFantasia_Fornecedor = txtNome.Text;
                forn.CNPJ_CPF_Fornecedor = txtCNPJ.Text;
                forn.Telefone_Fornecedor = txtTelefone.Text;
                forn.Email_Fornecedor = txtEmail.Text;
                forn.WebSite_Fornecedor = txtWeb.Text;
                forn.Celular_Fornecedor = txtCelular.Text;
                forn.Logradouro_Fornecedor = txtLogradouro.Text;
                forn.Numero_Fornecedor = Convert.ToInt32(txtNúmero.Text);
                forn.CEP_Fornecedor = txtCEP.Text;
                forn.Bairro_Fornecedor = txtBairro.Text;
                forn.Cidade_Fornecedor = txtCidade.Text;
                forn.Complemento_Fornecedor = txtComplemento.Text;
                forn.UF_Fornecedor = txtUF.Text;

             

                
                if (txtNome.Text.Equals(""))
                {
                    MessageBox.Show("DIGITE UM NOME");
                    txtNome.Focus();
                }
            
                  
                else
                {
                    forn.IncluirComParametro();
                    MessageBox.Show("CADASTRO CONCLUÍDO");
                    Close();
                }



              

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(this.Text) > 0)
                {
                  
                    BLL_SORVETERIA.Fornecedor forne = new BLL_SORVETERIA.Fornecedor();
                    forne.ID_Fornecedor = Convert.ToInt32(this.Text);
                    System.Data.SqlClient.SqlDataReader ddrr;
                    ddrr = forne.Consultar();
                    ddrr.Read();
                    if (ddrr.HasRows)
                    {
                        txtRazao.Text = Convert.ToString(ddrr["RazaoSocial_Fornecedor"]);
                        txtNome.Text = Convert.ToString(ddrr["NomeFantasia_Fornecedor"]);
                        txtCNPJ.Text = Convert.ToString(ddrr["CNPJ_CPF_Fornecedor"]);
                        txtCelular.Text = Convert.ToString(ddrr["Celular_Fornecedor"]);
                        txtTelefone.Text = Convert.ToString(ddrr["Telefone_Fornecedor"]);
                        txtWeb.Text = Convert.ToString(ddrr["WebSite_Fornecedor"]);

                        txtEmail.Text = Convert.ToString(ddrr["Email_Fornecedor"]);
                        txtCEP.Text = Convert.ToString(ddrr["CEP_Fornecedor"]);
                        txtComplemento.Text = Convert.ToString(ddrr["Complemento_Fornecedor"]);
                        txtBairro.Text = Convert.ToString(ddrr["Bairro_Fornecedor"]);
                        txtUF.Text = Convert.ToString(ddrr["UF_Fornecedor"]);
                        txtCidade.Text = Convert.ToString(ddrr["Cidade_Fornecedor"]);
                        txtNúmero.Text = Convert.ToString(ddrr["Numero_Fornecedor"]);
                        txtLogradouro.Text = Convert.ToString(ddrr["Logradouro_Fornecedor"]);

                        


                    }

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                ////throw;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //private void btnLimpar_Click(object sender, EventArgs e)
        //{
        //    BLL_SORVETERIA.Fornecedor forn = new BLL_SORVETERIA.Fornecedor();
        //    txtNome.Clear();
        //    txtEmail.Clear();
        //    txtCNPJ.Clear();
        //    txtCelular.Clear();
        //    txtWeb.Clear();
        //    txtTelefone.Clear();


        //}

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void btnNome_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAlterar_Click(object o, EventArgs e)
        {
            Negocio.Fornecedor.ConsultarFornecedor c = new ConsultarFornecedor();
            BLL_SORVETERIA.Fornecedor forn = new BLL_SORVETERIA.Fornecedor();
            try
            {
               
                forn.ID_Fornecedor = Id_Fornecedor;
                forn.NomeFantasia_Fornecedor = txtNome.Text;
                forn.RazaoSocial_Fornecedor = txtRazao.Text;
                forn.CNPJ_CPF_Fornecedor = txtCNPJ.Text;
                forn.Telefone_Fornecedor = txtTelefone.Text;
                forn.Email_Fornecedor = txtEmail.Text;
                forn.WebSite_Fornecedor = txtWeb.Text;
                forn.Celular_Fornecedor = txtCelular.Text;
                forn.Logradouro_Fornecedor = txtLogradouro.Text;
                forn.Numero_Fornecedor = Convert.ToInt32(txtNúmero.Text);
                forn.CEP_Fornecedor = txtCEP.Text;
                forn.Bairro_Fornecedor = txtBairro.Text;
                forn.Cidade_Fornecedor = txtCidade.Text;
                forn.Complemento_Fornecedor = txtComplemento.Text;
                forn.UF_Fornecedor = txtUF.Text;

                if (txtNome.Text.Equals(""))
                {
                    MessageBox.Show("DIGITE UM NOME");
                    txtNome.Focus();
                }
                else
                {
                    forn.AtualizarParametro();
                    MessageBox.Show("FORNECEDOR ALTERADO");


                    Close();

                   // c.dataGridView_Forne.DataSource = forn.ListarAtivos().Tables[0];
                }


                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.Text.Equals(""))
            {
                MessageBox.Show("DIGITE UM CNPJ");
                txtCNPJ.Focus();
            }
            else
            {
                if (!BLL_SORVETERIA.FuncoesGerais.IsCnpj(txtCNPJ.Text))
                {
                    MessageBox.Show("CNPJ INVÁLIDO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCNPJ.Clear();
                    txtCNPJ.Focus();
                }
            }
           
        }

        private void txtRazao_LocationChanged(object sender, EventArgs e)
        {

        }

        private void txtRazao_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            //if (txtNome.Text.Equals(""))
            //{
            //    MessageBox.Show("DIGITE UM NOME");
            //    txtNome.Focus();
            //}
        }

        private void txtRazao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

