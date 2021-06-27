using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Funcionário
{
    public partial class CadastrarFuncionário : Modelos.Cadastrar
    {
        public int idFunc = 0;
        public CadastrarFuncionário()
        {
            InitializeComponent();
            carregaCombo();
            //EsconderButton();
            
            
            
        }

        BLL_SORVETERIA.Cep cep = new BLL_SORVETERIA.Cep();
        BLL_SORVETERIA.Funcionario func = new BLL_SORVETERIA.Funcionario();
        string sexo;
        
        

       




        private byte _TipoUso;
        private int _Id_Funcionario;

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

        public int Id_Funcionario
        {
            get
            {
                return _Id_Funcionario;
            }

            set
            {
                _Id_Funcionario = value;
            }
        }

        

        private void BuscarDadosCep(Object o, EventArgs e)
        {
            try
            {
                if (txtCEP.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Digite o cep");
                    return;
                }
                cep.NumeroCep = txtCEP.Text;
                cep.RecuperarDadosCep();


                if (cep.NomeRua == "NAO EXISTE ESTE CEP")
                {
                    MessageBox.Show("Cep incorreto");
                    return;
                }

                txtBairro.Text = cep.Bairro;
                txtLogradouro.Text = cep.NomeRua;
                txtCidade.Text = cep.Cidade;
                txtUF.Text = cep.Uf;



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

        

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarteiraTrabalho_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //if (BLL_SORVETERIA.FuncoesGerais.ValidarEmailRegEx(txtEmail.Text))
            //{
                
            //}
            //else
            //{
            //    MessageBox.Show("Email Inválido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void butnSalvar_Click(object sender, EventArgs e)
        {
            



            BLL_SORVETERIA.Funcionario func = new BLL_SORVETERIA.Funcionario();
            
            try
            {
                func.Nome_Funcionario = txtNome.Text;
                func.RG_Funcionario = txtRG.Text;
                func.Logradouro_Funcionario = txtLogradouro.Text;
                func.Numero_Funcionario = Convert.ToInt32(txtNúmero.Text);
                func.Celular_Funcionario = txtCelular.Text;
                func.Telefone_Funcionario = txtTel.Text;
                func.UF_Funcionario = txtUF.Text;
                func.Cidade_Funcionario = txtCidade.Text;
                func.Bairro_Funcionario = txtBairro.Text;
                func.Email_Funcionario = txtEmail.Text;
                func.CEP_Funcionario = txtCEP.Text;
                func.Complemento_Funcionario = txtComplemento.Text;
                func.CPF_Funcionario = txtCPF.Text;
                func.DataNasc_Funcionario = Convert.ToDateTime(maskedTextBox1.Text);
                func.ID_Cargo = Convert.ToInt32(comboBox1.SelectedValue);


                if (rbMasculino.Checked)
                {
                    func.Sexo_Funcionario = Convert.ToChar("M");
                }
                if (rbFeminino.Checked)
                {
                    func.Sexo_Funcionario = Convert.ToChar("F");
                }

                func.IncluirComParametro();
                MessageBox.Show("CADASTRO CONCLUÍDO");



                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;

            }

        }

        private void CadastrarFuncionário_Load(object sender, EventArgs e)
        {
            //TCC_Sorveteria.Negocio.Funcionário.CadastrarFuncionário c = new CadastrarFuncionário();

         
                try
                {

                    if (Convert.ToInt32(this.Text) > 0)
                    {
                        BLL_SORVETERIA.Funcionario fnc = new BLL_SORVETERIA.Funcionario();
                        fnc.ID_Funcionario = Convert.ToInt32(this.Text);
                        System.Data.SqlClient.SqlDataReader ddrr;
                        ddrr = fnc.Consultar();

                        ddrr.Read();
                        if (ddrr.HasRows)
                        {
                            txtNome.Text = Convert.ToString(ddrr["Nome_FUncionario"]);
                            txtRG.Text = Convert.ToString(ddrr["Rg_Funcionario"]);
                            txtCPF.Text = Convert.ToString(ddrr["CPF_Funcionario"]);
                            txtTel.Text = Convert.ToString(ddrr["Telefone_Funcionario"]);
                            maskedTextBox1.Text = Convert.ToString(ddrr["DataNasc_Funcionario"]);
                            txtCelular.Text = Convert.ToString(ddrr["Celular_Funcionario"]);
                            txtEmail.Text = Convert.ToString(ddrr["Email_Funcionario"]);
                            txtCEP.Text = Convert.ToString(ddrr["CEP_Funcionario"]);
                            txtComplemento.Text = Convert.ToString(ddrr["Complemento_Funcionario"]);
                            txtBairro.Text = Convert.ToString(ddrr["Bairro_Funcionario"]);
                            txtUF.Text = Convert.ToString(ddrr["UF_Funcionario"]);
                            txtCidade.Text = Convert.ToString(ddrr["Cidade_Funcionario"]);
                            txtNúmero.Text = Convert.ToString(ddrr["Numero_Funcionario"]);
                            txtLogradouro.Text = Convert.ToString(ddrr["Logradouro_Funcionario"]);
                            comboBox1.SelectedValue = Convert.ToString(ddrr["ID_Cargo"]);
                            //rbFeminino.Checked = Convert.ToBoolean(Convert.ToString(ddrr["Sexo_Funcionario"]));
                            //rbMasculino.Checked = Convert.ToBoolean(Convert.ToString(ddrr["Sexo_Funcionario"]));

                            //rbMasculino.Enabled = false;
                            //rbFeminino.Enabled = false;

                            //
                            if (sexo == "MASCULINO")
                            {
                                rbMasculino.Checked = true;
                            }
                            else
                            {
                                rbFeminino.Checked = true;
                            }











                            // rbFeminino.Checked = Convert.ToBoolean(Convert.ToChar(ddrr["Sexo_Funcionario"]));







                        }

                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    ////throw;
                }
            }

          

        









        //private void btnLimpar_Click(object sender, EventArgs e)
        //{
        //    BLL_SORVETERIA.Funcionario func = new BLL_SORVETERIA.Funcionario();
        //    txtNome.Clear();
        //    txtNúmero.Clear();
        //    txtLogradouro.Clear();
        //    txtCPF.Clear();
        //    txtEmail.Clear();
        //    txtRG.Clear();
        //    txtBairro.Clear();
        //    txtTelefone.Clear();
        //    txtUF.Clear();
        //    txtComplemento.Clear();
        //    txtCidade.Clear();
        //    txtCEP.Clear();
        //    txtTelefone.Clear();




        //}

        private void butnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblComplemento_Click(object sender, EventArgs e)
        {

        }
        public void carregaCombo()
        {
            BLL_SORVETERIA.Cargo cargo = new BLL_SORVETERIA.Cargo();

            comboBox1.DataSource = cargo.ConsultarCargo().Tables[0];
            comboBox1.DisplayMember = "Nome_Cargo";
            comboBox1.ValueMember = "ID_Cargo";
            comboBox1.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Funcionario func = new BLL_SORVETERIA.Funcionario();
            try
            {
                func.ID_Funcionario = idFunc; 
                func.Nome_Funcionario = txtNome.Text;
                func.RG_Funcionario = txtRG.Text;
                func.Logradouro_Funcionario = txtLogradouro.Text;
                func.Numero_Funcionario = Convert.ToInt32(txtNúmero.Text);
                func.Celular_Funcionario = txtCelular.Text;
                func.Telefone_Funcionario = txtTel.Text;
                func.UF_Funcionario = txtUF.Text;
                func.Cidade_Funcionario = txtCidade.Text;
                func.Bairro_Funcionario = txtBairro.Text;
                func.Email_Funcionario = txtEmail.Text;
                func.CEP_Funcionario = txtCEP.Text;
                func.Complemento_Funcionario = txtComplemento.Text;
                func.DataNasc_Funcionario = Convert.ToDateTime(maskedTextBox1.Text);

               
                func.ID_Cargo = Convert.ToInt32(comboBox1.SelectedValue);



                if (rbMasculino.Checked)
                {
                    func.Sexo_Funcionario = Convert.ToChar("M");
                }
                if (rbFeminino.Checked)
                {
                    func.Sexo_Funcionario = Convert.ToChar("F");

                }

                button1.TabIndex = 14;

                func.AtualizarParametro();
                MessageBox.Show("ALTERAÇÃO CONCLUÍDA");



                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (BLL_SORVETERIA.FuncoesGerais.ValidarEmailRegEx(txtEmail.Text))
            {

            }

            else
            {
                //MessageBox.Show("EMAIL INVÁLIDO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtEmail.Clear();
                //txtEmail.Focus();
            }


        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (BLL_SORVETERIA.FuncoesGerais.IsCpf(txtCPF.Text))
            {
                
            }
            else
            {
                MessageBox.Show("CPF INVÁLIDO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Clear();
               // txtCPF.Focus();
            }
           


        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (BLL_SORVETERIA.FuncoesGerais.IsDataValida(maskedTextBox1.TextAlign.ToString()))
            {

            }

            else
            {
                //MessageBox.Show("DATA INVÁLIDA", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtEmail.Clear();
                //txtEmail.Focus();
            }
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
