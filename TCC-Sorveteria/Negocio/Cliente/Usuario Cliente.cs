using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TCC_Sorveteria.Negocio.Cliente
{
    public partial class Usuario_Cliente : Form
    {
        public Usuario_Cliente()
        {
            InitializeComponent();
            ComboCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public int ID_usu = 0;

        private void Usuario_Cliente_Load(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Usu_Cliente u = new BLL_SORVETERIA.Usu_Cliente();
            try
            {
                u.ID_Usu = Convert.ToInt32(this.Text);
                System.Data.SqlClient.SqlDataReader dr;
                dr = u.Consultar();
                dr.Read();
                if (dr.HasRows)
                {
                    txtEmail.Text = Convert.ToString(dr["Email_Usu"]);
                    txtSenha.Text = Convert.ToString(dr["Senha_Usu"]);
                    comboBox1.SelectedValue = Convert.ToString(dr["ID_USU_Cliente"]);
                }
            }
            catch (Exception ex)
            {

               // throw ex;
                //MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Usu_Cliente c = new BLL_SORVETERIA.Usu_Cliente();
            try
            {
                c.ID_Usu = ID_usu;
                c.Email_Usu = txtEmail.Text;
                c.Senha_Usu = txtSenha.Text;
                c.ID_USU_Cliente = Convert.ToInt32(comboBox1.SelectedValue);

                c.Atualizar();
                MessageBox.Show("USUÁRIO DO CLIENTE ATUALIZADO");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw ex;
            }
        }

        public void ComboCliente()
        {
            BLL_SORVETERIA.Cliente c = new BLL_SORVETERIA.Cliente();
            comboBox1.DataSource = c.Filtro().Tables[0];
            comboBox1.DisplayMember = "Nome_Cliente";
            comboBox1.ValueMember = "ID_Cliente";
            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Usu_Cliente c = new BLL_SORVETERIA.Usu_Cliente();
            try
            {
               
                c.Email_Usu = txtEmail.Text;
                c.Senha_Usu = txtSenha.Text;
                c.ID_USU_Cliente = Convert.ToInt32(comboBox1.SelectedValue);

                c.Cad();
                MessageBox.Show("USUÁRIO DO CLIENTE CADASTRADO");
                Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw ex;
            }
        }
    }
}
