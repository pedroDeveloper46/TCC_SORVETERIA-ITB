using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BLL_SORVETERIA
{
     public class Pedido_Compra
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

        private int _ID_ITENS_VENDA;

        private int _ID_venda;
        private int _ID_Produto;


     
        
        private int _QTDADE_Itens;






        public int ID_venda { get => _ID_venda; set => _ID_venda = value; }
        public int ID_Produto { get => _ID_Produto; set => _ID_Produto = value; }
        public int QTDADE_Itens { get => _QTDADE_Itens; set => _QTDADE_Itens = value; }
        public int ID_ITENS_VENDA { get => _ID_ITENS_VENDA; set => _ID_ITENS_VENDA = value; }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    

                    new SqlParameter("@ID_VENDA", SqlDbType.Int) { Value= _ID_venda },
                    new SqlParameter("@ID_Produto",SqlDbType.Int) { Value= _ID_Produto },
                  
                    new SqlParameter("@QTDADE_Itens",SqlDbType.Int) { Value= _QTDADE_Itens},
                                     



                };

                instrucaoSql = "INSERT INTO ITENS_VENDA" + " (ID_VENDA, ID_PRODUTO, QTDADE_Itens)" +
                    " VALUES(@ID_VENDA,@ID_Produto,@QTDADE_Itens)";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //public void Atualizar()
        //{
        //    try
        //    {
        //        SqlParameter[] listaParametro = {
        //            new SqlParameter("@ID_Produto", SqlDbType.Int) {Value = _ID_Produto},

        //            new SqlParameter("@QT")


                    
        //        };
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
        public void AtualizarQtdeProdParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Venda", SqlDbType.Int) { Value= _ID_venda },
                      new SqlParameter("@ID_Produto", SqlDbType.Int) { Value= _ID_Produto }




                };

                instrucaoSql = " update Produto   set qtdeATUAL_Produto = qtdeATUAL_Produto - (select sum(ITENS_VENDA.QTDADE_Itens) from venda inner join ITENS_VENDA"
                                 + " on venda.ID_Venda = ITENS_VENDA.ID_Venda inner join Produto on Produto.ID_Produto = ITENS_VENDA.ID_Produto" +
                            "  where venda.ID_Venda = @ID_Venda and Produto.ID_Produto = @ID_Produto) where ID_Produto = @ID_Produto";





                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public void ExcluirParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_ITENS_VENDA",SqlDbType.Int) { Value= _ID_ITENS_VENDA }

                };

                instrucaoSql = "DELETE FROM ITENS_VENDA WHERE ID_ITENS_VENDA=@ID_ITENS_VENDA";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader SubValor(int ID_venda)
        {
            try
            {
                instrucaoSql = "select sum(SUBTOTAL_VENDA) from ITENS_VENDA where ID_Venda =" + _ID_venda;
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Listar(int idVenda)
        {
            try
            {
                instrucaoSql = "SELECT ITENS_VENDA.ID_ITENS_VENDA, ITENS_VENDA.ID_PRODUTO, PRODUTO.Nome_Produto, Produto.Preco_Produto, ITENS_VENDA.QTDADE_Itens, (ITENS_VENDA.QTDADE_Itens * Produto.Preco_Produto) SUBTOTAL FROM " +
                               "Produto INNER JOIN ITENS_VENDA ON PRODUTO.ID_PRODUTO = ITENS_VENDA.ID_Produto " +
                               "INNER JOIN VENDA ON VENDA.ID_Venda = ITENS_VENDA.ID_Venda WHERE VENDA.ID_VENDA = " + idVenda;

                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




























    }



}
