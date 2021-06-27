using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Cliente
{
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        public int ID_Cli = 0;

        private void btnCad_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Cliente c = new BLL_SORVETERIA.Cliente();
            BLL_SORVETERIA.Cupom cupom = new BLL_SORVETERIA.Cupom();
            int id = 0;
            

            try
            {
                c.Nome_Cliente = textBox1.Text;
                c.Telefone_Cliente = maskedTextBox1.Text;
                c.Email_Cliente = textBox2.Text;
                c.Inserir();
                //string numero = string.Empty;
                //Random random = new Random();
                //numero = random.Next().ToString();
                //cupom.Numero_Cupom = c.Nome_Cliente.Substring(0, 3) + numero;
                //System.Data.SqlClient.SqlDataReader dr;
                //dr = c.Codigo();
                //dr.Read();
                //if (dr.HasRows)
                //{
                //    id = Convert.ToInt32(Convert.ToString(dr["ID_Cliente"]));
                    
                   
                //}
                //cupom.ID_Cliente = id;
                //cupom.TipoDesconto_Cupom = "15%";
                //cupom.CadastrarCupom();
                
               



                MessageBox.Show("CLIENTE CADASTRADO");
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw;
            }
           
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.Text) > 0)
                {
                    BLL_SORVETERIA.Cliente c = new BLL_SORVETERIA.Cliente();
                    c.ID_Cliente = Convert.ToInt32(this.Text);
                    System.Data.SqlClient.SqlDataReader dr;
                    dr = c.Consultar();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        textBox1.Text = Convert.ToString(dr["Nome_Cliente"]);
                        maskedTextBox1.Text = Convert.ToString(dr["Telefone_Cliente"]);
                        textBox2.Text = Convert.ToString(dr["Email_Cliente"]);
                    }
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                //throw ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Negocio.Cliente.Consulta_Cliente f = new Consulta_Cliente();
            BLL_SORVETERIA.Cliente c = new BLL_SORVETERIA.Cliente();
            try
            {
                c.ID_Cliente = ID_Cli;
                c.Nome_Cliente = textBox1.Text;
                c.Telefone_Cliente = maskedTextBox1.Text;
                c.Email_Cliente = textBox2.Text;
                c.Atualizar();
                MessageBox.Show("CLIENTE ATUALIZADO");
               
                Close();
                //f.dataGridView1.DataSource = c.Listar().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

            //System.Data.SqlClient.SqlDataReader dr;
            //dr = c.Email(txtNome.Text);
            //dr.Read();

            //if (dr.HasRows)
            //{
            //    txtEmail.Text = Convert.ToString(dr["Email"]);
            //}
            //else
            //{
            //    txtEmail.Text = "erroor";
            //}
            //try
            //{
            //    BLL_SORVETERIA.Cliente c = new BLL_SORVETERIA.Cliente();
            //    c.Email_Cliente = txtNome.Text;

            //    c.BuscarNome();

            //    txtEmail.Text = c.Nome_Cliente;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //throw;
            //}
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
