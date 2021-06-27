using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
    public class Contas
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

        private int _ID_Conta;
        private string _TipoNOME_Conta;
        private DateTime _DATA_VENCTO_Conta;
        private DateTime _DATA_PGTO_Conta;
        private decimal _VALOR_Conta;
        private byte _Status_Conta;
        private int _ID_Funcionario;
        private int _ID_FormaPagamento;

        public int ID_Conta
        {
            get
            {
                return _ID_Conta;
            }

            set
            {
                _ID_Conta = value;
            }
        }

        public string TipoNOME_Conta
        {
            get
            {
                return _TipoNOME_Conta;
            }

            set
            {
                _TipoNOME_Conta = value;
            }
        }

        public DateTime DATA_VENCTO_Conta
        {
            get
            {
                return _DATA_VENCTO_Conta;
            }

            set
            {
                _DATA_VENCTO_Conta = value;
            }
        }

        public DateTime DATA_PGTO_Conta
        {
            get
            {
                return _DATA_PGTO_Conta;
            }

            set
            {
                _DATA_PGTO_Conta = value;
            }
        }

        public decimal VALOR_Conta
        {
            get
            {
                return _VALOR_Conta;
            }

            set
            {
                _VALOR_Conta = value;
            }
        }

        public byte Status_Conta
        {
            get
            {
                return _Status_Conta;
            }

            set
            {
                _Status_Conta = value;
            }
        }

        public int ID_Funcionario { get => _ID_Funcionario; set => _ID_Funcionario = value; }
        public int ID_FormaPagamento { get => _ID_FormaPagamento; set => _ID_FormaPagamento = value; }

        public void AtualizarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Conta", SqlDbType.Int) { Value= _ID_Conta },
                    new SqlParameter("@TipoNOME_Conta",SqlDbType.VarChar) { Value= _TipoNOME_Conta },
                    new SqlParameter("@DATA_VENCTO_Conta", SqlDbType.DateTime) {Value=_DATA_VENCTO_Conta },
                    new SqlParameter("@DATA_PGTO_Conta", SqlDbType.DateTime) {Value=_DATA_PGTO_Conta },
                    new SqlParameter("@VALOR_Conta", SqlDbType.Decimal) {Value = _VALOR_Conta },
                   


                };

                instrucaoSql = "UPDATE Contas SET ID_Conta=@ID_Conta, TipoNOME_Conta=@TipoNOME_Conta,";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);





            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet ConsultarConta()
        {
            try
            {
                instrucaoSql = "Select * from Contas Order By TipoNOME_Conta";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception  ex)
            {

                throw ex;
            }
        }
        public void AtivarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Conta",SqlDbType.Int) { Value= _ID_Conta}


                };

                instrucaoSql = "UPDATE Contas SET Status_Conta=1 WHERE ID_Conta=@ID_Conta";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DesativarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Conta",SqlDbType.Int) { Value= _ID_Conta }


                };

                instrucaoSql = "UPDATE Contas SET Status_Conta=0 WHERE ID_Conta=@ID_Conta";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader Consultar()
        {
            try
            {
                instrucaoSql = "SELECT * FROM Contas WHERE ID_Conta" + _ID_Conta;
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
               // instrucaoSql = "SELECT ID_Conta, TipoNOME_Conta, DATA_VENCTO_Conta, DATA_PGTO_Conta, VALOR_Conta, Status_Conta	 FROM Contas ORDER BY TipoNOME_Conta";
                
                
                    instrucaoSql = "SELECT ID_Conta, TipoNOME_Conta, DATA_VENCTO_Conta, DATA_PGTO_Conta, VALOR_Conta, ID_FormaPagamento FROM Contas WHERE TipoNOME_Conta LIKE '%" + parteNome + "%'";
                
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Listar1()
        {
            try
            {
                instrucaoSql = "SELECT ID_Conta, TipoNOME_Conta, DATA_VENCTO_Conta, DATA_PGTO_Conta, VALOR_Conta, ID_FormaPagamento FROM Contas";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        public DataSet ListaDataVenc(DateTime data, DateTime data1)

        {
            try
            {
                // instrucaoSql = "SELECT ID_Conta, TipoNOME_Conta, DATA_VENCTO_Conta, DATA_PGTO_Conta, VALOR_Conta, Status_Conta	 FROM Contas ORDER BY TipoNOME_Conta";


                instrucaoSql = "SELECT ID_Conta, TipoNOME_Conta, DATA_VENCTO_Conta, DATA_PGTO_Conta, VALOR_Conta, Status_Conta FROM Contas WHERE  DATA_PGTO_Conta between '" + data + "' and  '" + data1 + "'";

                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListaDataPag(DateTime parteNome)

        {
            try
            {
                // instrucaoSql = "SELECT ID_Conta, TipoNOME_Conta, DATA_VENCTO_Conta, DATA_PGTO_Conta, VALOR_Conta, Status_Conta	 FROM Contas ORDER BY TipoNOME_Conta";


                instrucaoSql = "SELECT ID_Conta, TipoNOME_Conta, DATA_VENCTO_Conta, DATA_PGTO_Conta, VALOR_Conta, Status_Conta FROM Contas WHERE  DATA_PGTO_Conta LIKE '%" + parteNome + "%'";

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


                    new SqlParameter("@ID_Conta", SqlDbType.Int) { Value= _ID_Conta },
                    new SqlParameter("@TipoNOME_Conta",SqlDbType.VarChar) { Value= _TipoNOME_Conta },
                    new SqlParameter("@DATA_VENCTO_Conta", SqlDbType.DateTime) {Value=_DATA_VENCTO_Conta },
                    new SqlParameter("@DATA_PGTO_Conta", SqlDbType.DateTime) {Value=_DATA_PGTO_Conta },
                    new SqlParameter("@VALOR_Conta", SqlDbType.Decimal) {Value = _VALOR_Conta },
                    new SqlParameter("@ID_Funcionario", SqlDbType.Int) {Value = _ID_Funcionario},
                    new SqlParameter("@ID_FormaPagamento", SqlDbType.Int) {Value = _ID_FormaPagamento}



                };

                instrucaoSql = "INSERT INTO Contas " + "(TipoNOME_Conta, DATA_VENCTO_Conta,DATA_PGTO_Conta,VALOR_Conta, ID_Funcionario, ID_FormaPagamento)" + " Values(@TipoNOME_Conta, @Data_VENCTO_Conta, @Data_PGTO_Conta, @VALOR_Conta, @ID_Funcionario, @ID_FormaPagamento)" ;

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }































































    }




















}

