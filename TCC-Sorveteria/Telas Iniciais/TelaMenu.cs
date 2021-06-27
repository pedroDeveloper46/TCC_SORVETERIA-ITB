using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Telas_Iniciais
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Funcionário.CadastrarFuncionário cadFunc = new Negocio.Funcionário.CadastrarFuncionário();
            //TCC_Sorveteria.Negocio.Funcionário.CadastrarFuncionário cadastrarFuncionário = new Negocio.Funcionário.CadastrarFuncionário();
            
            cadFunc.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Relogio(Object o, EventArgs e) 
        {
            this.posição1.Text = System.DateTime.Now.ToString();
        }

        private void Form_KeyDown(Object o, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {

        }


        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Cargo.ConsultarCargo concargo = new Negocio.Cargo.ConsultarCargo();
            concargo.Show();
        }

        


        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Fornecedor.ConsultarFornecedor conFor = new Negocio.Fornecedor.ConsultarFornecedor();
            conFor.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Funcionário.ConsultarFuncionário conFunc = new Negocio.Funcionário.ConsultarFuncionário();
            conFunc.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Login.ConsultarLogin conLog = new Negocio.Login.ConsultarLogin();
            conLog.Show();
        }

        

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Produtos.ConsultarProdutos conProd = new Negocio.Produtos.ConsultarProdutos();
            conProd.Show();
        }

    

      

       

        private void cargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Negocio.Cargo.CadastrarCargo cadCargo = new Negocio.Cargo.CadastrarCargo();
            cadCargo.Show();
        }

       

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Negocio.Fornecedor.CadastrarFornecedor cadFor = new Negocio.Fornecedor.CadastrarFornecedor();
            cadFor.Show();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Negocio.Produtos.CadastrarProdutos cadPro = new Negocio.Produtos.CadastrarProdutos();
            cadPro.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Negocio.Vendas.ConsultarVendas conPed = new Negocio.Vendas.ConsultarVendas();
            conPed.Show();
        }

        private void vendasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Negocio.Vendas.Vendas cadVen = new Negocio.Vendas.Vendas();
            cadVen.label15.Text = label1.Text;
            cadVen.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void entradaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Produtos.Entrada_Produto entrada = new Negocio.Produtos.Entrada_Produto();
            entrada.ShowDialog();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Contas_a_Pagar.Contas_Pagar contas = new Negocio.Contas_a_Pagar.Contas_Pagar();
            contas.ShowDialog();
        }

        private void loginToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Negocio.Login.CadastrarLogin log = new Negocio.Login.CadastrarLogin();
            log.ShowDialog();
        }

        private void contasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Negocio.Contas_a_Pagar.Consulta_Conta con = new Negocio.Contas_a_Pagar.Consulta_Conta();
            con.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Categoria.CadCategoria c = new Negocio.Categoria.CadCategoria();
            c.ShowDialog();
        }

        private void gerarQRCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Cupom.Gerar_Cupom g = new Negocio.Cupom.Gerar_Cupom();
            g.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void responderClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Fale_Conosco f = new BLL_SORVETERIA.Fale_Conosco();
            TCC_Sorveteria.Negocio.Fale_Conosco.Resposta r = new Negocio.Fale_Conosco.Resposta();
            r.label6.Text = label2.Text;
            r.Show();
            //Negocio.Fale_Conosco.Resposta rr = new Negocio.Fale_Conosco.Resposta();
            //rr.dataGridView_Fala.DataSource = f.Listar().Tables[0];

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.Cliente.Cadastro_Cliente C = new Negocio.Cliente.Cadastro_Cliente();
            C.Show();

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Negocio.Cliente.Consulta_Cliente c = new Negocio.Cliente.Consulta_Cliente();
            c.Show();
        }

        private void usuarioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Cliente.Consulta_Usuario_do_Cliente c = new Negocio.Cliente.Consulta_Usuario_do_Cliente();
            c.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usuárioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCC_Sorveteria.Negocio.Cliente.Usuario_Cliente u = new Negocio.Cliente.Usuario_Cliente();
            u.Text = "Cadastrar Usuário do Cliente";
            u.Show();
        }

        private void consultarCupomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Resposta r = new BLL_SORVETERIA.Resposta();
            TCC_Sorveteria.Negocio.Cupom.Cupom c = new Negocio.Cupom.Cupom();
            c.Show();
            BLL_SORVETERIA.Cupom cp = new BLL_SORVETERIA.Cupom();
            c.dataGridView1.DataSource = cp.List().Tables[0];
        }
    }
}
