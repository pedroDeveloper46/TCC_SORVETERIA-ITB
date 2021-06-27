using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
   public class Venda
    {

        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

        private int _ID_Venda;
        private DateTime _Data_Venda;
        private decimal _VALOR_TOTAL_Venda;
        private int _QTDE_ITEM_Venda;
        private int _ID_Funcionario;
        private byte _Status_Venda;

      //  private decimal _PrecoProduto_Venda;
        private int _ID_Produto;

        public DateTime Data_Venda { get => _Data_Venda; set => _Data_Venda = value; }
        public decimal VALOR_TOTAL_Venda { get => _VALOR_TOTAL_Venda; set => _VALOR_TOTAL_Venda = value; }
        public int QTDE_ITEM_Venda { get => _QTDE_ITEM_Venda; set => _QTDE_ITEM_Venda = value; }
        public int ID_Venda { get => _ID_Venda; set => _ID_Venda = value; }
        public int ID_Funcionario { get => _ID_Funcionario; set => _ID_Funcionario = value; }
        public byte Status_Venda { get => _Status_Venda; set => _Status_Venda = value; }

        public SqlDataReader Consultar()
        {
            try
            {
                instrucaoSql = "SELECT * FROM VENDA WHERE ID_Venda" + ID_Venda;
                return c.RetornarDataReader(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader IdVenda()
        {
            try
            {
                instrucaoSql = "select Max(ID_Venda) as ID_Venda from Venda";
                return c.RetornarDataReader(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Listar(string parteNome)
        {
            try
            {
                  instrucaoSql = "SELECT ID_Venda, Data_Venda, VALOR_TOTAL_Venda, QTDE_ITEM_Venda   FROM VENDA WHERE Data_Venda LIKE " + parteNome + " ORDER BY Data_Venda";
                
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Venda", SqlDbType.Int) { Value= ID_Venda },
                    new SqlParameter("@Data_Venda",SqlDbType.DateTime) { Value= Data_Venda },
                    new SqlParameter("@VALOR_TOTAL_Venda", SqlDbType.Decimal) {Value = VALOR_TOTAL_Venda },
                    new SqlParameter("@QTDE_ITEM_Venda", SqlDbType.Int) { Value = QTDE_ITEM_Venda },
                   // new SqlParameter("@ID_Funcionario", SqlDbType.Int) { Value= ID_Funcionario },


                };

                instrucaoSql = "INSERT INTO VENDA" + " ( Data_Venda, VALOR_TOTAL_Venda, QTDE_ITEM_Venda)" + " Values (getdate(), @VALOR_TOTAL_Venda, @QTDE_ITEM_Venda)";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public DataSet BuscarPorMes(int data)
        {
            try
            {
                instrucaoSql = "select * from VENDA where DATEPART(MM, DATA_Venda) = '" + data + "'";

                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet listarData(DateTime data, DateTime data1)
        {
            try
            {
                instrucaoSql = "select * from VENDA where DATA_Venda between '" + data + "' and '" + data1 + "'";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarData(DateTime data)
        {
                       
            try
            {
                instrucaoSql = "select *  from VENDA where CAST(DATA_Venda as date) = '"+ data + "'";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AtualizarComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Venda", SqlDbType.Int) { Value= _ID_Venda },
                    new SqlParameter("@Data_Venda",SqlDbType.DateTime) { Value= _Data_Venda },
                    new SqlParameter("@VALOR_TOTAL_Venda", SqlDbType.Decimal) {Value = _VALOR_TOTAL_Venda },
                    new SqlParameter("@QTDE_ITEM_Venda", SqlDbType.Int) { Value = _QTDE_ITEM_Venda },
                    new SqlParameter("@ID_Funcionario", SqlDbType.Int) { Value= _ID_Funcionario },


                };

                instrucaoSql = "UPDATE VENDA set  Data_Venda=@Data_Venda, VALOR_TOTAL_Venda=@VALOR_TOTAL_Venda, QTDE_ITEM_Venda=@QTDE_ITEM_Venda, ID_Funcionario=@ID_Funcionario where ID_Venda=@ID_Venda";

                
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

       
       

        public void CancelarVenda()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Venda", SqlDbType.Int) { Value= _ID_Venda },
                    new SqlParameter("@Status_Venda", SqlDbType.Bit) {Value = _Status_Venda} };

                instrucaoSql = "UPDATE VENDA set Status_Venda = 0 where ID_Venda=@ID_Venda";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IncluirItensVenda()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Venda", SqlDbType.Int) { Value= ID_Venda },
                    new SqlParameter("@ID_Produto",SqlDbType.Int) { Value= _ID_Produto },
                   // new SqlParameter("@VALOR_TOTAL_Venda", SqlDbType.Decimal) {Value = _VALOR_TOTAL_Venda },
                    new SqlParameter("@QTDE_ITEM_Venda", SqlDbType.Int) { Value = QTDE_ITEM_Venda }


                };

                instrucaoSql = "INSERT INTO VENDA" + " (ID_Venda, ID_Produto, QTDE_ITEM_Venda)" + " Values (@ID_Venda, @ID_Produto, @QTDE_ITEM_Venda)";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



















    }
}
