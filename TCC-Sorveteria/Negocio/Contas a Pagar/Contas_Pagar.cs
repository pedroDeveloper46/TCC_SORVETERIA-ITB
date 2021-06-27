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
    public partial class Contas_Pagar : Form
    {
        public Contas_Pagar()
        {
            InitializeComponent();
            CarregarCombo();
            //CarregarCombo2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Contas con = new BLL_SORVETERIA.Contas();
            try
            {
                con.DATA_VENCTO_Conta = Convert.ToDateTime(mkd_venc.Text);
                con.DATA_PGTO_Conta = Convert.ToDateTime(mkd_Paga.Text);
                con.VALOR_Conta = Convert.ToDecimal(textBox1.Text);
                con.ID_Funcionario = Convert.ToInt32(comboBox_Func.SelectedValue);
                con.TipoNOME_Conta = txtTipoConta.Text;


                con.IncluirComParametro();
                MessageBox.Show("CONTA EFETUADA");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        public void CarregarCombo()
        {
            BLL_SORVETERIA.Funcionario func = new BLL_SORVETERIA.Funcionario();
            comboBox_Func.DataSource = func.ConsultarFuncionario().Tables[0];
            comboBox_Func.DisplayMember = "Nome_Funcionario";
            comboBox_Func.ValueMember = "ID_Funcionario";
            comboBox_Func.SelectedIndex = -1;
        }

        private void comboBox_Conta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //public void CarregarCombo2()
        //{
        //    BLL_SORVETERIA.Contas con = new BLL_SORVETERIA.Contas();
        //    combo_Conta.DataSource = con.ConsultarConta().Tables[0];
        //    combo_Conta.DisplayMember = "TipoNOME_Conta";
        //    combo_Conta.ValueMember = "ID_Conta";
        //    combo_Conta.SelectedIndex = -1;
        //}
    }   
}
