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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        public int idFunc = 0;
        public String nomeFunc = "";
        public int id = 0;

        private void Relogio(Object o, EventArgs e)
        {
            this.posição1.Text = System.DateTime.Now.ToString();
        }

        private void Form_KeyDown(Object o, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                //aqui depois irá um metodo para verificar a digitação de usuario/senha
                BLL_SORVETERIA.Login log = new BLL_SORVETERIA.Login();
                log.Usuario_Login = txtUsuario.Text;
                log.Senha_Login = txtSenha.Text;

               
               TCC_Sorveteria.Negocio.Vendas.Vendas v = new TCC_Sorveteria.Negocio.Vendas.Vendas();
                TCC_Sorveteria.Telas_Iniciais.TelaMenu tlm = new TCC_Sorveteria.Telas_Iniciais.TelaMenu();
                TCC_Sorveteria.Negocio.Fale_Conosco.Resposta r = new Negocio.Fale_Conosco.Resposta();

                System.Data.SqlClient.SqlDataReader dr;
                dr = log.Logar();
                dr.Read();
                


                if (dr.HasRows)
                {

                    MessageBox.Show("SEJA BEM VINDO");

                    if (dr["nivelAcesso"].ToString().Equals("ADM"))
                    {
                        tlm.Text = tlm.Text + "LOGADO COMO " + txtUsuario.Text.ToUpper() + " (ADMINISTRADOR)";
                        //MessageBox.Show(dr["ID_Funcionario"].ToString());
                        // v.label15.Text = dr["ID_Funcionario"].ToString();
                       tlm.label2.Text = dr["ID_Funcionario"].ToString();
                        r.label6.Text =  dr["ID_Funcionario"].ToString();

                        tlm.label1.Text = dr["ID_Funcionario"].ToString();
                        
                       

                        // v.Text = tlm.Text + "LOGADO COMO " + txtUsuario.Text.ToUpper() + " (ADMINISTRADOR)";
                        tlm.Show();
                      //  v.Show();
                       










                    } else if (dr["nivelAcesso"].ToString().Equals("CAIXA"))
                    {
                        v.Text = v.Text + "LOGADO COMO " + txtUsuario.Text.ToUpper() + " (CAIXA)";
                        v.label15.Text = dr["ID_Funcionario"].ToString();
                        v.Show();
                        //v.comboFunc.SelectedText = txtUsuario.Text;

                    }







                    Hide();

                }
                else
                {
                    MessageBox.Show("USUARIO/SENHA INCORRETOS OU VOCÊ NÃO TEM PERMISSÃO");
                    txtSenha.Clear();
                    txtUsuario.Focus();
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;

                
            }

        


        }

       

        private void chkExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkExibirSenha.Checked)
            {
                this.txtSenha.PasswordChar = '\0';
            }
            else
            {
                this.txtSenha.PasswordChar = '*';
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Login.CadastrarLogin log = new Negocio.Login.CadastrarLogin();
            log.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
