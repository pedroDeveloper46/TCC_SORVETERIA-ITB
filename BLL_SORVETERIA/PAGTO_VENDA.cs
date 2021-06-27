using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace BLL_SORVETERIA
{
    public class PAGTO_VENDA
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();
        private string instrucaoSql;

        private int _ID_Venda;
        private int _ID_FormaPagamento;
        private decimal _ValorPago_PAGTO_VENDA;

        public int ID_Venda { get => _ID_Venda; set => _ID_Venda = value; }
        public int ID_FormaPagamento { get => _ID_FormaPagamento; set => _ID_FormaPagamento = value; }
        public decimal ValorPago_PAGTO_VENDA { get => _ValorPago_PAGTO_VENDA; set => _ValorPago_PAGTO_VENDA = value; }

        public void IncluirComParametro()
        {
            try 
            {
                SqlParameter[] listaComParametros = {


                    new SqlParameter("@ID_Venda", SqlDbType.Int) { Value= _ID_Venda },
                    new SqlParameter("@ID_FormaPagamento",SqlDbType.Int) { Value= _ID_FormaPagamento},

                    new SqlParameter("@ValorPago_PAGTO_VENDA",SqlDbType.Decimal) { Value= _ValorPago_PAGTO_VENDA},




                };

                instrucaoSql = "INSERT INTO PAGTO_VENDA" + " (ID_Venda, ID_FormaPagamento, ValorPago_PAGTO_VENDA)" +
                    " VALUES(@ID_Venda,@ID_FormaPagamento,@ValorPago_PAGTO_VENDA)";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}

