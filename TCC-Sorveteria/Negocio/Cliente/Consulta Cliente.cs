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
    public partial class Consulta_Cliente : Form
    {
        public Consulta_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Cliente c = new BLL_SORVETERIA.Cliente();
            if (textBox1.Text.Length <= 0)
            {
                dataGridView1.DataSource = c.Listar().Tables[0];
                dataGridView1.Columns[2].HeaderText = "Celular_Cliente";
            }
            else
            {
                dataGridView1.DataSource = c.ListarNome(textBox1.Text).Tables[0];
            }

            
          
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Cliente.Cadastro_Cliente c = new Cadastro_Cliente();
            c.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            c.ID_Cli = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            c.Show();
            c.btnCad.Visible = false;
            c.button3.Visible = true;
            groupBox1.Text = "Atualizar Cliente";
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);





            }
        }

        private void desativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indice = 0;
            BLL_SORVETERIA.Cliente func = new BLL_SORVETERIA.Cliente();
            func.ID_Cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("DESEJA DESATIVAR " + "?", "", MessageBoxButtons.YesNo);
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

                    func.DesativarParametro();
                    MessageBox.Show("CLIENTE DESATIVADO");
                    dataGridView1.DataSource = func.ListarAtivos().Tables[0];

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
            BLL_SORVETERIA.Cliente func = new BLL_SORVETERIA.Cliente();
            func.ID_Cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("DESEJA ATIVAR " + "?", "", MessageBoxButtons.YesNo);
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

                    func.ativarParametro();
                    MessageBox.Show("CLIENTE ATIVADO");
                    dataGridView1.DataSource = func.ListarInAtivos().Tables[0];

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rdbAti_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ativo().Tables[0];

        } 

        public static DataSet Ativo()
        {
            string instruçao;
            DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();
            try
            {
                instruçao = "select * from Cliente where Status_Cliente = 1";
                return c.RetornarDataSet(instruçao);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static DataSet InAtivo()
        {
            string instruçao;
            DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();
            try
            {
                instruçao = "select * from Cliente where Status_Cliente = 0";
                return c.RetornarDataSet(instruçao);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void rdbIna_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = InAtivo().Tables[0];
        }
    }
}
