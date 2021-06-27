using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Funcionário
{
    public partial class ConsultarFuncionário : Modelos.Consultar
    {
        public ConsultarFuncionário()
        {

            InitializeComponent();
            CarregaCombo();
            //string Sexo;
            //txtNome.Text linha.Cells[0].Value.ToString();
            ////CadastrarFuncionário cadastrar = new CadastrarFuncionário();









        }

        BLL_SORVETERIA.Funcionario func = new BLL_SORVETERIA.Funcionario();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Negocio.Funcionário.CadastrarFuncionário cadastrarFuncionário = new CadastrarFuncionário();
            cadastrarFuncionário.ShowDialog();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text.Length > 0)
            {
                
                dataGridView_Func.DataSource = func.ListarPorCPF(txtCPF.Text.Trim().ToUpper()).Tables[0];
                dataGridView_Func.Columns[0].HeaderText = "Cód";
                dataGridView_Func.AutoResizeColumn(0);
                dataGridView_Func.Columns[1].HeaderText = "Nome";
                dataGridView_Func.AutoResizeColumn(1);
                dataGridView_Func.Columns[2].HeaderText = "Celular";
                dataGridView_Func.AutoResizeColumn(2);

                
                txtCPF.Focus();

            }
             else if (txtNome.Text.Length > 0)
            {
               
               // txtCPF.Clear();
                dataGridView_Func.DataSource = func.ListarPorNome(txtNome.Text.Trim().ToUpper()).Tables[0];
                dataGridView_Func.Columns[0].HeaderText = "Cód";
                dataGridView_Func.AutoResizeColumn(0);
                dataGridView_Func.Columns[1].HeaderText = "Nome";
                dataGridView_Func.AutoResizeColumn(1);
                dataGridView_Func.Columns[2].HeaderText = "Celular";
                dataGridView_Func.AutoResizeColumn(2);

                txtNome.Focus();
            }
            else if (Convert.ToInt32(comboBox1.SelectedValue) > 0)
            {
                BLL_SORVETERIA.Funcionario f = new BLL_SORVETERIA.Funcionario();
                dataGridView_Func.DataSource = f.ListarCargo(Convert.ToInt32(comboBox1.SelectedValue)).Tables[0];
            }
            else
            {
                dataGridView_Func.DataSource = func.ListarPorNome(txtNome.Text.Trim().ToUpper()).Tables[0];
                dataGridView_Func.Columns[0].HeaderText = "Cód";
                dataGridView_Func.AutoResizeColumn(0);
                dataGridView_Func.Columns[1].HeaderText = "Nome";
                dataGridView_Func.AutoResizeColumn(1);
                dataGridView_Func.Columns[2].HeaderText = "Celular";
                dataGridView_Func.AutoResizeColumn(2);

            }

           
            //dataGridView_Func.DataSource = func.ListarPorNome(txtCPF.Text.Trim().ToUpper()).Tables[0];




            ////dataGridView_Func.Columns[0].HeaderText = "Cód";
            ////dataGridView_Func.AutoResizeColumn(0);
            ////dataGridView_Func.Columns[1].HeaderText = "Nome";
            ////dataGridView_Func.AutoResizeColumn(1);
            ////dataGridView_Func.Columns[2].HeaderText = "Celular";
            ////dataGridView_Func.AutoResizeColumn(2);

            //txtNome.Focus();

        }
        private void CarregaCombo()
        {
            BLL_SORVETERIA.Cargo c = new BLL_SORVETERIA.Cargo();
            comboBox1.DataSource = c.ConsultarCargo().Tables[0];
            comboBox1.DisplayMember = "Nome_Cargo";
            comboBox1.ValueMember = "ID_Cargo";
            comboBox1.SelectedIndex = -1;
        }


        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView_Func, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);

                



            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

            

        }
      


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
      }

        private void ativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          
        }



        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdbAtivo.Checked)
        //    {
        //        dataGridView_Func.DataSource = func.ListarAtivos().Tables[0];


        //    }
        //}

        //private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdbInativo.Checked)
        //    {
        //        dataGridView_Func.DataSource = func.ListarInativos().Tables[0];
        //    }
        //}

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            //Convert.ToString(dataGridView_Func.DataSource = func.ConsultarNome().Tables[0]);
            //dataGridView_Func.DataSource = func.ListarPorCPF(txtNome.Text.Trim().ToUpper()).Tables[0];
        }

        private void dataGridView_Func_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Negocio.Funcionário.CadastrarFuncionário cad = new CadastrarFuncionário();
          
            cad.Text = dataGridView_Func.CurrentRow.Cells[0].Value.ToString();
            cad.idFunc = Convert.ToInt32(dataGridView_Func.CurrentRow.Cells[0].Value.ToString());

            cad.ShowDialog();
        }

        private void desativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indice = 0;
            BLL_SORVETERIA.Funcionario func = new BLL_SORVETERIA.Funcionario();
            func.ID_Funcionario = Convert.ToInt32(dataGridView_Func.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("DESEJA DESATIVAR " + "?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {


                    if (indice >= 0)
                    {
                        var linha = dataGridView_Func.Rows[indice];
                        if (!linha.IsNewRow)
                            dataGridView_Func.Rows.Remove(linha);
                    }

                    func.DesativarParametro();
                    MessageBox.Show("FUNCIONARIO DESATIVADO");
                    dataGridView_Func.DataSource = func.ListarAtivos().Tables[0];

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ativarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var indice = 0;
            BLL_SORVETERIA.Funcionario fun = new BLL_SORVETERIA.Funcionario();
            fun.ID_Funcionario = Convert.ToInt32(dataGridView_Func.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("DESEJA ATIVAR?", "", MessageBoxButtons.YesNo);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    if (indice >= 0)
                    {
                        var linha = dataGridView_Func.Rows[indice];
                        if (!linha.IsNewRow)
                            dataGridView_Func.Rows.Remove(linha);
                    }


                    fun.Ativar();
                    MessageBox.Show("FUNCIONARIO ATIVADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
           
                dataGridView_Func.DataSource = func.ListarAtivos().Tables[0];


            
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            // (rdbInativo.Checked)
            
                dataGridView_Func.DataSource = func.ListarInativos().Tables[0];


            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

    
}
