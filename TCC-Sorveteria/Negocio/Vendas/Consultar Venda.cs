using System;
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
    public partial class ConsultarVendas : Modelos.Consultar
    {
        public ConsultarVendas()
        {
            InitializeComponent();
        }

        private string sql;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Vendas.Vendas vend = new Vendas();
            vend.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex) == 0)
            {
                BLL_SORVETERIA.Venda c = new BLL_SORVETERIA.Venda();
                dataGridView1.DataSource = c.ListarData(dateTimePicker1.Value).Tables[0];
            }
            else 
            {

                BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex + 1).Tables[0];

                //if ((comboBox1.SelectedIndex) == 0)
                //{
                //}
                //else if ((comboBox1.SelectedIndex) == 1)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 1).Tables[0];
                //}
                //else if ((comboBox1.SelectedIndex) == 2)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 2).Tables[0] ;
                //}
                //else if ((comboBox1.SelectedIndex)== 3)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 3).Tables[0];
                //}
                //else if ((comboBox1.SelectedIndex) == 4)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 4).Tables[0];
                //}
                //else if ((comboBox1.SelectedIndex) == 5)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 5).Tables[0];
                //}
                //else if ((comboBox1.SelectedIndex) == 6)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 6).Tables[0];
                //}
                //else if ((comboBox1.SelectedIndex) == 7)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 7).Tables[0];
                //}
                //else if ((comboBox1.SelectedIndex) == 8)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 8).Tables[0];
                //}
                //else if ((comboBox1.SelectedIndex) == 9)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 9).Tables[0];
                //}
                //else if ((comboBox1.SelectedIndex) == 10)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 10).Tables[0];
                //}
                //else if ((comboBox1.SelectedIndex) == 11)
                //{
                //    BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                //    dataGridView1.DataSource = v.BuscarPorMes(comboBox1.SelectedIndex = 11).Tables[0];
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BLL_SORVETERIA.Venda v = new BLL_SORVETERIA.Venda();
                dataGridView1.DataSource = v.listarData(dateTimePicker1.Value, dateTimePicker2.Value).Tables[0];
            }
        }
    }
}
