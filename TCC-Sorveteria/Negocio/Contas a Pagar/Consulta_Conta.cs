using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Contas_a_Pagar
{
    public partial class Consulta_Conta : Form
    {
        public Consulta_Conta()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text.Length > 0)
            {
                BLL_SORVETERIA.Contas contas = new BLL_SORVETERIA.Contas();
                dataGridView1.DataSource = contas.Listar(txtPesquisa.Text.Trim().ToUpper()).Tables[0]; 

                dataGridView1.Columns[0].HeaderText = "Cód";
                dataGridView1.AutoResizeColumn(0);
                dataGridView1.Columns[1].HeaderText = "Tipo";
                dataGridView1.AutoResizeColumn(1);
                dataGridView1.Columns[2].HeaderText = "Data de Vencimento";
                dataGridView1.AutoResizeColumn(2);
                dataGridView1.Columns[3].HeaderText = "Data de Pagamento";
                dataGridView1.AutoResizeColumn(3);
                dataGridView1.Columns[4].HeaderText = "Valor";
                dataGridView1.AutoResizeColumn(4);
                dataGridView1.Columns[5].HeaderText = "Pagamento";
                dataGridView1.AutoResizeColumn(5);


            }
            //else if (maskVenc.Text.Length > 0)
            //{
            //    BLL_SORVETERIA.Contas c = new BLL_SORVETERIA.Contas();
            //    dataGridView1.DataSource = c.ListaDataVenc(Convert.ToDateTime(maskVenc.TextAlign)).Tables[0];
            //    dataGridView1.Columns[0].HeaderText = "Cód";
            //    dataGridView1.AutoResizeColumn(0);
            //    dataGridView1.Columns[1].HeaderText = "Tipo";
            //    dataGridView1.AutoResizeColumn(1);
            //    dataGridView1.Columns[2].HeaderText = "Data de Vencimento";
            //    dataGridView1.AutoResizeColumn(2);
            //    dataGridView1.Columns[3].HeaderText = "Data de Pagamento";
            //    dataGridView1.AutoResizeColumn(3);
            //    dataGridView1.Columns[4].HeaderText = "Valor";
            //    dataGridView1.AutoResizeColumn(4);
            //    dataGridView1.Columns[5].HeaderText = "Pagamento";
            //    dataGridView1.AutoResizeColumn(5);
            //}
            //else if (maskedPag.Text.Length > 0)
            //{
            //    BLL_SORVETERIA.Contas c = new BLL_SORVETERIA.Contas();
            //    dataGridView1.DataSource = c.ListaDataPag(Convert.ToDateTime(maskedPag.TextAlign)).Tables[0];

            //    dataGridView1.Columns[0].HeaderText = "Cód";
            //    dataGridView1.AutoResizeColumn(0);
            //    dataGridView1.Columns[1].HeaderText = "Tipo";
            //    dataGridView1.AutoResizeColumn(1);
            //    dataGridView1.Columns[2].HeaderText = "Data de Vencimento";
            //    dataGridView1.AutoResizeColumn(2);
            //    dataGridView1.Columns[3].HeaderText = "Data de Pagamento";
            //    dataGridView1.AutoResizeColumn(3);
            //    dataGridView1.Columns[4].HeaderText = "Valor";
            //    dataGridView1.AutoResizeColumn(4);
            //    dataGridView1.Columns[5].HeaderText = "Pagamento";
            //    dataGridView1.AutoResizeColumn(5);

            //}
            else
            {
                BLL_SORVETERIA.Contas contas = new BLL_SORVETERIA.Contas();
                dataGridView1.DataSource = contas.Listar(txtPesquisa.Text.Trim().ToUpper().ToUpper()).Tables[0];

                dataGridView1.Columns[0].HeaderText = "Cód";
                dataGridView1.AutoResizeColumn(0);
                dataGridView1.Columns[1].HeaderText = "Tipo";
                dataGridView1.AutoResizeColumn(1);
                dataGridView1.Columns[2].HeaderText = "Data de Vencimento";
                dataGridView1.AutoResizeColumn(2);
                dataGridView1.Columns[3].HeaderText = "Data de Pagamento";
                dataGridView1.AutoResizeColumn(3);
                dataGridView1.Columns[4].HeaderText = "Valor";
                dataGridView1.AutoResizeColumn(4);
                dataGridView1.Columns[5].HeaderText = "Pagamento";
                dataGridView1.AutoResizeColumn(5);

            }







        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
