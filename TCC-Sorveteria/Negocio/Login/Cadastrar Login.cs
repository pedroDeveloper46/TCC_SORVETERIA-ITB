using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Login
{
    public partial class CadastrarLogin : Modelos.Cadastrar
    {
        private int iDLogin = 0;

        public int IDLogin { get => iDLogin; set => iDLogin = value; }

        public CadastrarLogin()
        {
            InitializeComponent();
            CarregarCombo();
        }























        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Login log = new BLL_SORVETERIA.Login();
            try
            {
                log.Usuario_Login = txtUsuario.Text;
                log.Senha_Login = txtSenha.Text;
                log.ID_Funcionario = Convert.ToInt32(comboBox1.SelectedValue);
                log.nivelAcesso = comboBox2.SelectedItem.ToString();

                if (txtSenha.Text.Trim().Length < 5)
                {
                    MessageBox.Show("SENHA MUITO CURTA");
                    txtSenha.Clear();
                    txtSenha.Focus();
                    log.Senha_Login = txtSenha.Text;
                    


                }
                else
                {
                    log.IncluirComParametro();
                    MessageBox.Show("LOGIN CADASTRADO");
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

        private void CarregarCombo()
        {
            BLL_SORVETERIA.Funcionario f = new BLL_SORVETERIA.Funcionario();
            comboBox1.DataSource = f.ConsultarFuncionario().Tables[0];
            comboBox1.DisplayMember = "Nome_Funcionario";
            comboBox1.ValueMember = "ID_Funcionario";
            comboBox1.SelectedIndex = -1;
        }
        private void chkExibirSenha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CadastrarLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.Text) > 0)
                {
                    BLL_SORVETERIA.Login l = new BLL_SORVETERIA.Login();
                    l.ID_Login = Convert.ToInt32(this.Text);
                    System.Data.SqlClient.SqlDataReader dr;
                    dr = l.Consultar();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtUsuario.Text = Convert.ToString(dr["Usuario_Login"]);
                        txtSenha.Text = Convert.ToString(dr["Senha_Login"]);
                       comboBox1.SelectedValue = Convert.ToString(dr["ID_Funcionario"]);
                        comboBox2.SelectedText = Convert.ToString(dr["nivelAcesso"]);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
               // throw;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Login log = new BLL_SORVETERIA.Login();
            try
            {
                log.ID_Login = IDLogin;
                log.Usuario_Login = txtUsuario.Text;
                log.Senha_Login = txtSenha.Text;
                log.nivelAcesso = comboBox2.SelectedItem.ToString();
              //  log.ID_Funcionario = Convert.ToInt32(comboBox1.SelectedValue);
                if (txtSenha.Text.Trim().Length < 5)
                {
                    MessageBox.Show("SENHA INVÁLIDA");
                    txtSenha.Clear();
                    txtSenha.Focus();
                    log.Senha_Login = txtSenha.Text;



                }
              
                

                else
                {
                    log.AtualizarParametro();
                    MessageBox.Show("LOGIN ALTERADO");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw ex;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
