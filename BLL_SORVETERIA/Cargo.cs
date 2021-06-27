using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace BLL_SORVETERIA
{
    public class Cargo
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

        private int _ID_Cargo;
        private string _Nome_Cargo;
        

        public int ID_Cargo
        {
            get
            {
                return _ID_Cargo;
            }

            set
            {
                _ID_Cargo = value;
            }
        }

        public string Nome_Cargo
        {
            get
            {
                return _Nome_Cargo;
            }

            set
            {
                _Nome_Cargo = value;
            }
        }

        

        public void AtualizarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Cargo", SqlDbType.Int) { Value= _ID_Cargo },
                    new SqlParameter("@Nome_Cargo",SqlDbType.VarChar) { Value= _Nome_Cargo },
                   

                };

                instrucaoSql = "UPDATE Cargo SET ID_Cargo=@ID_Cargo, Nome_Cargo=@Nome_Cargo,";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);





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
                    new SqlParameter("@ID_Cargo",SqlDbType.Int) { Value= _ID_Cargo}


                };

                instrucaoSql = "UPDATE Cargo SET Status_Cargo=1 WHERE ID_Cargo=@ID_Cargo";

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
                    new SqlParameter("@ID_Cargo",SqlDbType.Int) { Value= _ID_Cargo }


                };

                instrucaoSql = "UPDATE Cargo SET Status_Cargo=0 WHERE ID_Cargo=@ID_Cargo";

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
                instrucaoSql = "SELECT * FROM Cargo WHERE ID_Cargo" + _ID_Cargo;
                return c.RetornarDataReader(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ConsultarCargo()
        {
            try
            {
                instrucaoSql = "SELECT * FROM Cargo ORDER BY Nome_Cargo";
                return c.RetornarDataSet(instrucaoSql);

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
                instrucaoSql = "SELECT ID_Cargo, Nome_Cargo FROM Cargo ORDER BY Nome_Cargo";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = "SELECT ID_Cargo, Nome_Cargo FROM Cargo WHERE Nome_Cargo LIKE " + parteNome + " ORDER BY Nome_Cargo";
                }
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarAtivos()
        {
            try
            {
                instrucaoSql = "SELECT ID_Cargo, Nome_Cargo FROM Cargo WHERE Status_Cargo=1";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarInativos()
        {
            try
            {
                instrucaoSql = "SELECT ID_Cargo, Nome_Cargo FROM Cargo WHERE Status_Cargo=0";
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


                    new SqlParameter("@ID_Cargo", SqlDbType.Int) { Value= _ID_Cargo },
                    new SqlParameter("@Nome_Cargo",SqlDbType.VarChar) { Value= _Nome_Cargo },
                    



                };

                instrucaoSql = "INSERT INTO Cargo " + "(Nome_Cargo)" + "Values(@Nome_Cargo)";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


    }





}



    


        



        
       


    

