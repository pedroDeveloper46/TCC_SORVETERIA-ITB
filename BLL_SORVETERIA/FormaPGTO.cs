using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL_SORVETERIA
{
   public  class FormaPGTO
    {
        private string instrucaoSql;
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        private int _ID_FormaPagamento;
        private string _Nome_FormaPagamento;

        public int ID_FormaPagamento { get => _ID_FormaPagamento; set => _ID_FormaPagamento = value; }
        public string Nome_FormaPagamento { get => _Nome_FormaPagamento; set => _Nome_FormaPagamento = value; }

        public DataSet Consultar()
        {
            try
            {
                instrucaoSql = "SELECT * FROM FormaPGTO ORDER BY Nome_FormaPagamento";
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public void IncluirComParametro()
        //{
        //    try
        //    {
        //        SqlParameter[] listaComParametros = {


        //            new SqlParameter("@ID_VENDA", SqlDbType.Int) { Value= _ID_venda },
        //            new SqlParameter("@ID_Produto",SqlDbType.Int) { Value= _ID_Produto },

        //            new SqlParameter("@QTDADE_Itens",SqlDbType.Int) { Value= _QTDADE_Itens},




        //        };

        //        instrucaoSql = "INSERT INTO ITENS_VENDA" + " (ID_VENDA, ID_PRODUTO, QTDADE_Itens)" +
        //            " VALUES(@ID_VENDA,@ID_Produto,@QTDADE_Itens)";

        //        c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        }

    }

