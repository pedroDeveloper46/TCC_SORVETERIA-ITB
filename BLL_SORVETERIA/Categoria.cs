using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
    public class Categoria
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

        private int _ID_Categoria;
        private string _Nome_Categoria;

       

        

        public int ID_Categoria
        {
            get
            {
                return _ID_Categoria;
            }

            set
            {
                _ID_Categoria = value;
            }
        }

        public string Nome_Categoria
        {
            get
            {
                return _Nome_Categoria;
            }

            set
            {
                _Nome_Categoria = value;
            }
        }

        public void AtualizarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Categoria", SqlDbType.Int) { Value= _ID_Categoria },
                    new SqlParameter("@Nome_Categoria",SqlDbType.VarChar) { Value= _Nome_Categoria },
                    



                };

                instrucaoSql = "UPDATE Categoria SET ID_Categoria=@ID_Categoria, Nome_Categoria=@Nome_Categoria,";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);





            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ConsultarCategoria()
        {
            try
            {
                instrucaoSql = "SELECT * FROM Categoria  where ID_Categoria = " +ID_Categoria  + " ORDER BY NOME_CATEGORIA";
                return c.RetornarDataSet(instrucaoSql);
            }


            catch (Exception ex)
            {

                throw ex;
            }



        }

        public DataSet ConsultarCategorias()
        {
            try
            {
                instrucaoSql = "select distinct Categoria.* from Categoria inner join Produto on Categoria.ID_Categoria = Produto.ID_Cat ORDER BY Categoria.NOME_CATEGORIA";
                return c.RetornarDataSet(instrucaoSql);
            }


            catch (Exception ex)
            {

                throw ex;
            }



        }

        public DataSet ConsultarCat()
        {
            try
            {
                instrucaoSql = "SELECT * FROM Categoria ORDER BY Nome_Categoria";
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }





        public void AtivarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Categoria",SqlDbType.Int) { Value= _ID_Categoria}


                };

                instrucaoSql = "UPDATE Categoria SET Status_Categoria=1 WHERE ID_Categoria=@ID_Categoria";

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
                    new SqlParameter("@ID_Categoria",SqlDbType.Int) { Value= _ID_Categoria }


                };

                instrucaoSql = "UPDATE Categoria SET Status_Categpria=0 WHERE ID_Categoria=@ID_Categoria";

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
                instrucaoSql = "SELECT * FROM Categoria WHERE ID_Categoria" + _ID_Categoria;
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
                instrucaoSql = "SELECT ID_Categoria, Nome_Categoria FROM Categoria ORDER BY Nome_Categoria";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = "SELECT ID_Categoria, Nome_Categoria FROM Categoria WHERE Nome_Categoria LIKE " + parteNome + " ORDER BY Nome_Categoria";
                }
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
                    new SqlParameter("@ID_Categoria", SqlDbType.Int) { Value= _ID_Categoria },
                    new SqlParameter("@Nome_Categoria",SqlDbType.VarChar) { Value= _Nome_Categoria },


                };

                instrucaoSql = "INSERT INTO Categoria " + "(Nome_Categoria)" + "Values (@Nome_Categoria)";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
















    }

}
