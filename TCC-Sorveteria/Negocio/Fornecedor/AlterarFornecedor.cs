using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Sorveteria.Negocio.Fornecedor
{
    public partial class AlterarFornecedor : Modelos.Cadastrar
    {
        public AlterarFornecedor()
        {
            InitializeComponent();
        }
        private Int32 _Codigo;

        private byte _Operação;

        public byte Operação
        {
            get
            {
                return _Operação;
            }

            set
            {
                _Operação = value;
            }
        }

        public int Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                _Codigo = value;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                BLL_SORVETERIA.Fornecedor forn = new BLL_SORVETERIA.Fornecedor();
                switch (Operação)
                {
                    case 0:
                        
                
                        break;

                    case 1:
                        forn.ID_Fornecedor = Convert.ToInt32(txtID.Text);
                      //  forn.Nome_Fornecedor = txtNome.Text;

                        forn.alterar();
                        break;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void AlterarFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
