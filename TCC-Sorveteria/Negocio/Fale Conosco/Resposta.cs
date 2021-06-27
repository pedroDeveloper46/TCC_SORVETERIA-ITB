using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace TCC_Sorveteria.Negocio.Fale_Conosco
{
    public partial class Resposta : Form
    {
        public Resposta()
        {
            InitializeComponent();
            Combo();
            Combo1();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            BLL_SORVETERIA.Resposta r = new BLL_SORVETERIA.Resposta();
            try
            {
                r.ID_Funcionario = Convert.ToInt32(label6.Text);
                r.Data_Resposta_MSG = dateTimePicker1.Value;
                r.Mensagem_Resposta = textBox1.Text;
                r.ID_MSG = Convert.ToInt32(lblMensagem.Text);
                r.MensagemRecebida_Resposta = textBox2.Text;
                

                r.Inserir();
                
                MessageBox.Show("RESPOSTA SALVA NO SISTEMA");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("pedro46tr@gmail.com", "pedroelindo");
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("pedro46tr@gmail.com", "ENVIADOR");
            mail.From = new MailAddress("pedro46tr@gmail.com", "GLACIL SORVETERIA");
            mail.To.Add(new MailAddress(txtEmail.Text, "RECEBEDOR"));
            mail.Subject = "Contato";
            mail.Body = " Mensagem do site:<br/> Nome:  " + txtNome.Text + "<br/> Email : " + txtEmail.Text + " <br/> Mensagem : " + textBox1.Text;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
                MessageBox.Show("EMAIL ENVIADO COM SUCESSO!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }finally
            {
                mail = null;
            }
        }

        public void Combo()
        {
            //BLL_SORVETERIA.Fale_Conosco f = new BLL_SORVETERIA.Fale_Conosco();
            //comboBox2.DataSource = f.ListarEmail().Tables[0];
            //comboBox2.DisplayMember = "Email_Fale";
            //comboBox2.ValueMember = "ID_MSG_Fale";
            //comboBox2.SelectedIndex = -1;
        }
        public void Combo1()
        {
            BLL_SORVETERIA.Funcionario f = new BLL_SORVETERIA.Funcionario();
            //comboBox1.DataSource = f.ConsultarFuncionario().Tables[0];
            //comboBox1.DisplayMember = "Nome_Funcionario";
            //comboBox1.ValueMember = "ID_Funcionario";
            //comboBox1.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Resposta_Load(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Fale_Conosco f = new BLL_SORVETERIA.Fale_Conosco();
            BLL_SORVETERIA.Login log = new BLL_SORVETERIA.Login();
            TCC_Sorveteria.Telas_Iniciais.TelaMenu t = new Telas_Iniciais.TelaMenu();
            TCC_Sorveteria.Negocio.Vendas.Vendas v = new Vendas.Vendas();
            TCC_Sorveteria.Telas_Iniciais.TelaLogin vi = new Telas_Iniciais.TelaLogin();
            
            
            
           

            dataGridView_Fala.DataSource = f.Listar().Tables[0];
           // dataGridView_Fala.Columns[1].HeaderText = "Email";
            //dataGridView_Fala.Columns[2].HeaderText = "Nome";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void responderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox2.Text = dataGridView_Fala.CurrentRow.Cells[4].Value.ToString();
            lblMensagem.Text = dataGridView_Fala.CurrentRow.Cells[0].Value.ToString();
            txtEmail.Text = dataGridView_Fala.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dataGridView_Fala.CurrentRow.Cells[2].Value.ToString();
           //comboBox2.SelectedItem = dataGridView_Fala.CurrentRow.Cells[1].ToString();
        }

        private void dataGridView_Fala_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dataGridView_Fala, e.Location);
                this.contextMenuStrip1.Show(Cursor.Position);





            }
           
        }

        private void dataGridView_Fala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Fale_Conosco f = new BLL_SORVETERIA.Fale_Conosco();
            dataGridView_Fala.DataSource = f.Listar().Tables[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BLL_SORVETERIA.Resposta r = new BLL_SORVETERIA.Resposta();
            dataGridView_Fala.DataSource = r.Listar().Tables[0];
        }


    }
}
