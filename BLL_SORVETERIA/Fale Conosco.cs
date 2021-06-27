using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
    public class Fale_Conosco

    {
        public string InstrucaoSql;
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        private int _ID_MSG_Fale;
        private string _Email_Fale;
        private string _Nome_Fale;
        private string _Telefone_Fale;
        private string _Mensagem_Fale;
        private DateTime _Data_MSG_Fale;
        private string _Status_MSG_Fale;

        public int ID_MSG_Fale { get => _ID_MSG_Fale; set => _ID_MSG_Fale = value; }
        public string Email_Fale { get => _Email_Fale; set => _Email_Fale = value; }
        public string Nome_Fale { get => _Nome_Fale; set => _Nome_Fale = value; }
        public string Telefone_Fale { get => _Telefone_Fale; set => _Telefone_Fale = value; }
        public string Mensagem_Fale { get => _Mensagem_Fale; set => _Mensagem_Fale = value; }
        public DateTime Data_MSG_Fale { get => _Data_MSG_Fale; set => _Data_MSG_Fale = value; }
        public string Status_MSG_Fale { get => _Status_MSG_Fale; set => _Status_MSG_Fale = value; }


        public DataSet ListarEmail()
        {
            try
            {
                InstrucaoSql = "Select * from Fale_Conosco order by Email_Fale";
                return c.RetornarDataSet(InstrucaoSql);

                
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public DataSet Listar()
        {
            try
            {
                InstrucaoSql = "select * from Fale_Conosco";
                return c.RetornarDataSet(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

     


    }

}
