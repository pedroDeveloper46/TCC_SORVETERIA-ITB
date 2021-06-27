using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
    public class Login
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

        private int _ID_Login;
        private string _Usuario_Login;
        private string _Senha_Login;
        private byte _Status_Login;
        private int _ID_Funcionario;
        private string _nivelAcesso;

        public int ID_Login
        {
            get
            {
                return _ID_Login;
            }

            set
            {
                _ID_Login = value;
            }
        }

        public string Usuario_Login
        {
            get
            {
                return _Usuario_Login;
            }

            set
            {
                _Usuario_Login = value;
            }
        }

        public string Senha_Login
        {
            get
            {
                return _Senha_Login;
            }

            set
            {
                _Senha_Login = value;
            }
        }

        public byte Status_Login
        {
            get
            {
                return _Status_Login;
            }

            set
            {
                _Status_Login = value;
            }
        }

        public int ID_Funcionario { get => _ID_Funcionario; set => _ID_Funcionario = value; }
        public string nivelAcesso { get => _nivelAcesso; set => _nivelAcesso = value; }

        public void AtualizarParametro()
        {

            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Login", SqlDbType.Int) { Value= _ID_Login },
                    new SqlParameter("@Usuario_Login",SqlDbType.VarChar) { Value=_Usuario_Login },
                    new SqlParameter("@Senha_Login",SqlDbType.VarChar) { Value=_Senha_Login},
                   new SqlParameter("@nivelAcesso",SqlDbType.VarChar) { Value= _nivelAcesso },
                  //  new SqlParameter("@ID_Funcionario", SqlDbType.Int) {Value = _ID_Funcionario},



                };
                instrucaoSql = "UPDATE Login SET  Usuario_Login=@Usuario_Login, Senha_Login=@Senha_Login, nivelAcesso=@nivelAcesso where ID_Login=@ID_Login";

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
                    new SqlParameter("@ID_Login",SqlDbType.Int) { Value= ID_Login},
                    new SqlParameter ("@Status_Login", SqlDbType.Bit) {Value = _Status_Login}


                };

                instrucaoSql = "UPDATE Login SET Status_Login=1 WHERE ID_Login=@ID_Login";

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
                    new SqlParameter("@ID_Login",SqlDbType.Int) { Value= ID_Login },
                    new SqlParameter ("@Status_Login", SqlDbType.Bit) {Value = _Status_Login}



                };

                instrucaoSql = "UPDATE Login SET Status_Login=0 WHERE ID_Login=@ID_Login";

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
                instrucaoSql = "SELECT * FROM Login WHERE ID_Login =" + ID_Login;
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
                //instrucaoSql = "SELECT ID_Login, Usuario_Login, Senha_Login FROM Login ORDER BY Usuario_Login";
                //if (parteNome.Length != 0)
                
                    instrucaoSql = "SELECT ID_Login, Usuario_Login, Senha_Login, ID_Funcionario, nivelAcesso, Status_Login FROM Login WHERE Usuario_Login LIKE '%" + parteNome + "%'";
                
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
                instrucaoSql = "SELECT ID_Login, Usuario_Login, Senha_Login, ID_Funcionario, nivelAcesso, Status_Login FROM Login WHERE Status_Login=1";
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
                instrucaoSql = "SELECT ID_Login, Usuario_Login, Senha_Login, ID_Funcionario, nivelAcesso, Status_Login FROM Login WHERE Status_Login=0";
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
                    new SqlParameter("@ID_Login", SqlDbType.Int) { Value= _ID_Login },
                    new SqlParameter("@Usuario_Login",SqlDbType.VarChar) { Value=_Usuario_Login },
                    new SqlParameter("@Senha_Login",SqlDbType.VarChar) { Value= _Senha_Login},
                    new SqlParameter("@Status_Login",SqlDbType.Bit) { Value= _Status_Login },
                    new SqlParameter("@ID_Funcionario", SqlDbType.Int) {Value = _ID_Funcionario},
                    new SqlParameter("@nivelAcesso", SqlDbType.VarChar){Value = _nivelAcesso}

                };

                instrucaoSql = "INSERT INTO Login  "+ "(Usuario_Login, Senha_Login, ID_Funcionario, nivelAcesso )   VALUES " + " (@Usuario_Login, @Senha_Login, @ID_Funcionario, @nivelAcesso )";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public SqlDataReader Logar()
        {
            try
            {
                instrucaoSql = "SELECT ID_Login, Usuario_Login, Senha_Login, nivelAcesso, ID_Funcionario FROM Login WHERE Usuario_Login='" + Usuario_Login + "'   AND  Senha_Login='" + Senha_Login + "' and Status_Login = 1";

                SqlDataReader dr;

                dr = c.RetornarDataReader(instrucaoSql);
               
                return dr;
               

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader Log()
        {
            try
            {
                instrucaoSql = "Select Max(ID_Funcionario) from Login";
                SqlDataReader dr;

                dr = c.RetornarDataReader(instrucaoSql);
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }







    }



}         
