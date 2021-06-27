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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Vendas.Vendas vend = new Vendas();
            vend.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
