using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Categoria
{
    public partial class CadCategoria : Form
    {
        public CadCategoria()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butnSalvar_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Categoria c = new BLL_SORVETERIA.Categoria();
            try
            {
                c.Nome_Categoria = txtNome.Text;

                c.IncluirComParametro();
                MessageBox.Show("CATEGORIA CADASTRADA");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void butnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
