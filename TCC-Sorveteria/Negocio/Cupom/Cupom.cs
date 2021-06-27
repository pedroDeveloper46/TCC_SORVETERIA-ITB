using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Cupom
{
    public partial class Cupom : Form
    {
        public Cupom()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cupom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Cupom c = new BLL_SORVETERIA.Cupom();
            if (textBox1.Text.Length > 0)
            {
                dataGridView1.DataSource = c.Listarcupom(textBox1.Text).Tables[0];
            }
            else 
            {
                dataGridView1.DataSource = c.List().Tables[0];
            }
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Cupom c = new BLL_SORVETERIA.Cupom();
            dataGridView1.DataSource = c.List1().Tables[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Cupom c = new BLL_SORVETERIA.Cupom();
            dataGridView1.DataSource = c.List2().Tables[0];
        }
    }
}
