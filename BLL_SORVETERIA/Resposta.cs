using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
    public class Resposta

    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();
        public string InstrucaoSql;

        private int _ID_Funcionario;
        private DateTime _Data_Resposta_MSG;
        private int _ID_MSG;
        private string _Mensagem_Resposta;
        private string _MensagemRecebida_Resposta;

        public int ID_Funcionario { get => _ID_Funcionario; set => _ID_Funcionario = value; }
        public DateTime Data_Resposta_MSG { get => _Data_Resposta_MSG; set => _Data_Resposta_MSG = value; }
        public int ID_MSG { get => _ID_MSG; set => _ID_MSG = value; }
        public string Mensagem_Resposta { get => _Mensagem_Resposta; set => _Mensagem_Resposta = value; }
        public string MensagemRecebida_Resposta { get => _MensagemRecebida_Resposta; set => _MensagemRecebida_Resposta = value; }

        public void Inserir()
        {
            try
            {
                SqlParameter[] lista =
                {
                   new SqlParameter("@ID_Funcionario", SqlDbType.Int) { Value= _ID_Funcionario },
                   new SqlParameter("@Data_Resposta_MSG", SqlDbType.DateTime) { Value= _Data_Resposta_MSG },
                   new SqlParameter("@Mensagem_Resposta", SqlDbType.VarChar) { Value= _Mensagem_Resposta },
                   new SqlParameter("@ID_MSG", SqlDbType.Int) { Value= _ID_MSG },
                    new SqlParameter("@MensagemRecebida_Resposta", SqlDbType.VarChar) { Value= _MensagemRecebida_Resposta},
                };
                InstrucaoSql = "Insert into Resposta(ID_Funcionario, Data_Resposta_MSG, Mensagem_Resposta, ID_MSG, MensagemRecebida_Resposta)" +
                    "values (@ID_Funcionario, @Data_Resposta_MSG, @Mensagem_Resposta, @ID_MSG, @MensagemRecebida_Resposta)";
                c.ExecutarComandoParametro(InstrucaoSql, lista);
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
                InstrucaoSql = "select * from Resposta";
                return c.RetornarDataSet(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
