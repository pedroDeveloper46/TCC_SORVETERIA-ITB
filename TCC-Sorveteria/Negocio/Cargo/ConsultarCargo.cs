using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Cargo
{
    public partial class ConsultarCargo : Modelos.Consultar
    {
        public ConsultarCargo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Cargo.CadastrarCargo car = new CadastrarCargo();
            car.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
