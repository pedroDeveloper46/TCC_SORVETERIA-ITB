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
    public partial class Gerar_Cupom : Form
    {
        BLL_SORVETERIA.Cupom c = new BLL_SORVETERIA.Cupom();
        int i = 0;
        BLL_SORVETERIA.Cliente cl = new BLL_SORVETERIA.Cliente();
        public Gerar_Cupom()
        {
            InitializeComponent();
            Combo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public Bitmap GerarQRCode(int width, int height, string text)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions() { Width = width, Height = height, Margin = 0 };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                var resultado = new Bitmap(bw.Write(text));
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            try
            {
               
                
                c.Numero_Cupom = textBox1.Text.ToString();
                c.TipoDesconto_Cupom = comboBox2.SelectedItem.ToString();
                c.ID_Cliente = Convert.ToInt32(comboBox1.SelectedValue);
                System.Data.SqlClient.SqlDataReader dr;
                dr = c.ListarNumeroCupom(textBox1.Text);
                dr.Read();
                
                if (dr.HasRows)
                {
                    
                        MessageBox.Show("JÁ EXISTE ESTE CUPOM");
                        textBox1.Clear();

                }
                else
                {

                    c.CadastrarCupom();
                    MessageBox.Show("CUPOM INSERIDO COM SUCESSO!!");
                    BLL_SORVETERIA.Cliente l = new BLL_SORVETERIA.Cliente();
                    l.ID_Cliente = Convert.ToInt32(comboBox1.SelectedValue);
                    l.DesativarParametro();
                    Close();
                
                }




                

               


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Combo()
        {
           
            comboBox1.DataSource = cl.Filtro().Tables[0];
            comboBox1.DisplayMember = "Nome_Cliente";
            comboBox1.ValueMember = "ID_Cliente";
            comboBox1.SelectedIndex = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
