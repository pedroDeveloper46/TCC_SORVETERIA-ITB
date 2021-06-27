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
    public partial class Consulta_Usuario_do_Cliente : Form
    {
        public Consulta_Usuario_do_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Usu_Cliente u = new BLL_SORVETERIA.Usu_Cliente();
            if (textBox1.Text.Length > 0)
            {
                dataGridView1.DataSource = u.Usu(textBox1.Text).Tables[0];
                dataGridView1.Columns[3].HeaderText = "Cliente";
            }
            else
            {
               
                dataGridView1.DataSource = u.Listar().Tables[0];
                dataGridView1.Columns[3].HeaderText = "Cliente";
            }
          

        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);





            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Cliente.Usuario_Cliente u = new Usuario_Cliente();
            u.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            u.ID_usu = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            u.button3.Visible = false;
            u.Show();

        }
    }
}
