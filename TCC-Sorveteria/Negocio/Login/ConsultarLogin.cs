using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Login
{
    public partial class ConsultarLogin : Modelos.Consultar
    {
        public ConsultarLogin()
        {
            InitializeComponent();
        }
        BLL_SORVETERIA.Login log = new BLL_SORVETERIA.Login();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Login.CadastrarLogin log = new CadastrarLogin();
            log.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkInativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = log.Listar(txtPesquisar.Text.Trim().ToUpper()).Tables[0];

            dataGridView2.Columns[0].HeaderText = "Cód";
            dataGridView2.AutoResizeColumn(0);
            dataGridView2.Columns[1].HeaderText = "Usuário";
            dataGridView2.AutoResizeColumn(1);
            dataGridView2.Columns[2].HeaderText = "Senha";
            dataGridView2.AutoResizeColumn(2);

        }

        private void dataGridView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView2, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);





            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Login.CadastrarLogin cad = new CadastrarLogin();

           // btnCadastrar//.Visible = false;

            cad.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            cad.IDLogin = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());

            cad.ShowDialog();
        }

        private void ativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indice = 0;
            BLL_SORVETERIA.Login func = new BLL_SORVETERIA.Login();
            func.ID_Login = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("DESEJA DESATIVAR " + "?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {


                    if (indice >= 0)
                    {
                        var linha = dataGridView2.Rows[indice];
                        if (!linha.IsNewRow)
                           dataGridView2.Rows.Remove(linha);
                    }

                    func.DesativarParametro();
                    MessageBox.Show("LOGIN DESATIVADO");

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void desativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indice = 0;
            BLL_SORVETERIA.Login func = new BLL_SORVETERIA.Login();
            func.ID_Login = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("DESEJA DESATIVAR " + "?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {


                    if (indice >= 0)
                    {
                        var linha = dataGridView2.Rows[indice];
                        if (!linha.IsNewRow)
                            dataGridView2.Rows.Remove(linha);
                    }

                    func.AtivarParametro();
                    MessageBox.Show("LOGIN ATIVADO");

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
