using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
    public class Fornecedor
    {
        //public = é possivel encontrar
        //private = não é possivel encontrar

        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

        private int _ID_Fornecedor;
        private string _NomeFantasia_Fornecedor;
        private string _RazaoSocial_Fornecedor;
        private string _CNPJ_CPF_Fornecedor ;
        private string _Telefone_Fornecedor;
        private string _Email_Fornecedor;
        private string _WebSite_Fornecedor;
        private byte _Status_Fornecedor;
        private string _Celular_Fornecedor;
        private string _Logradouro_Fornecedor;
        private int _Numero_Fornecedor;
        private string _Complemento_Fornecedor;
        private string _Bairro_Fornecedor;
        private string _Cidade_Fornecedor;
        private string _UF_Fornecedor;
        private string _CEP_Fornecedor;


        public int ID_Fornecedor
        {
            get
            {
                return _ID_Fornecedor;
            }

            set
            {
                _ID_Fornecedor = value;
            }
        }

        public string NomeFantasia_Fornecedor
        {
            get
            {
                return _NomeFantasia_Fornecedor;
            }

            set
            {
                _NomeFantasia_Fornecedor = value;
            }
        }

        public string CNPJ_CPF_Fornecedor
        {
            get
            {
                return _CNPJ_CPF_Fornecedor;
            }

            set
            {
                _CNPJ_CPF_Fornecedor = value;
            }
        }

        public string Telefone_Fornecedor
        {
            get
            {
                return _Telefone_Fornecedor;
            }

            set
            {
                _Telefone_Fornecedor = value;
            }
        }

        public string Email_Fornecedor
        {
            get
            {
                return _Email_Fornecedor;
            }

            set
            {
                _Email_Fornecedor = value;
            }
        }

        public string WebSite_Fornecedor
        {
            get
            {
                return _WebSite_Fornecedor;
            }

            set
            {
                _WebSite_Fornecedor = value;
            }
        }

        public byte Status_Fornecedor
        {
            get
            {
                return _Status_Fornecedor;
            }

            set
            {
                _Status_Fornecedor = value;
            }
        }

        public string Celular_Fornecedor { get => _Celular_Fornecedor; set => _Celular_Fornecedor = value; }
        public string Logradouro_Fornecedor { get => _Logradouro_Fornecedor; set => _Logradouro_Fornecedor = value; }
        public int Numero_Fornecedor { get => _Numero_Fornecedor; set => _Numero_Fornecedor = value; }
        public string Complemento_Fornecedor { get => _Complemento_Fornecedor; set => _Complemento_Fornecedor = value; }
        public string Bairro_Fornecedor { get => _Bairro_Fornecedor; set => _Bairro_Fornecedor = value; }
        public string Cidade_Fornecedor { get => _Cidade_Fornecedor; set => _Cidade_Fornecedor = value; }
        public string UF_Fornecedor { get => _UF_Fornecedor; set => _UF_Fornecedor = value; }
        public string CEP_Fornecedor { get => _CEP_Fornecedor; set => _CEP_Fornecedor = value; }
        public string RazaoSocial_Fornecedor { get => _RazaoSocial_Fornecedor; set => _RazaoSocial_Fornecedor = value; }







        //metodos
        public void AtualizarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Fornecedor", SqlDbType.Int) { Value= _ID_Fornecedor },
                    new SqlParameter("@RazaoSocial_Fornecedor",SqlDbType.VarChar) { Value= _RazaoSocial_Fornecedor },
                      new SqlParameter("@NomeFantasia_Fornecedor",SqlDbType.VarChar) { Value= _NomeFantasia_Fornecedor },
                    new SqlParameter("@CNPJ_CPF_Fornecedor",SqlDbType.VarChar) { Value= _CNPJ_CPF_Fornecedor },
                    new SqlParameter("@Telefone_Fornecedor",SqlDbType.VarChar) { Value=_Telefone_Fornecedor },
                    new SqlParameter("@Email_Fornecedor",SqlDbType.VarChar) { Value=_Email_Fornecedor },
                    new SqlParameter("@WebSite_Fornecedor", SqlDbType.VarChar) {Value=_WebSite_Fornecedor },
                    //new SqlParameter("@Status_Fornecedor", SqlDbType.Bit) {Value=_Status_Fornecedor },
                     new SqlParameter("@Logradouro_Fornecedor", SqlDbType.VarChar) { Value= _Logradouro_Fornecedor},
                    new SqlParameter("@Numero_Fornecedor", SqlDbType.Int) { Value= _Numero_Fornecedor},
                    new SqlParameter("@Complemento_Fornecedor", SqlDbType.VarChar) { Value= _Complemento_Fornecedor},
                    new SqlParameter("@Bairro_Fornecedor", SqlDbType.VarChar) { Value= _Bairro_Fornecedor},
                    new SqlParameter("@Cidade_Fornecedor", SqlDbType.VarChar) { Value= _Cidade_Fornecedor},
                    new SqlParameter("@UF_Fornecedor", SqlDbType.VarChar) { Value= UF_Fornecedor},
                    new SqlParameter("@CEP_Fornecedor", SqlDbType.VarChar) { Value= _CEP_Fornecedor}

                };

                instrucaoSql = "UPDATE Fornecedor SET NomeFantasia_Fornecedor=@NomeFantasia_Fornecedor, RazaoSocial_Fornecedor=@RazaoSocial_Fornecedor,  CNPJ_CPF_Fornecedor=@CNPJ_CPF_Fornecedor, Telefone_Fornecedor=@Telefone_Fornecedor, Email_Fornecedor=@Email_Fornecedor, WebSite_Fornecedor=@WebSite_Fornecedor, Logradouro_Fornecedor=@Logradouro_Fornecedor, CEP_Fornecedor=@CEP_Fornecedor, Cidade_Fornecedor=@Cidade_Fornecedor, Bairro_Fornecedor=@Bairro_Fornecedor, Complemento_Fornecedor=@Complemento_Fornecedor, UF_Fornecedor=@UF_Fornecedor where ID_Fornecedor=@ID_Fornecedor";

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
                    new SqlParameter("@ID_Fornecedor",SqlDbType.Int) { Value= _ID_Fornecedor }

                };

                instrucaoSql = "DELETE FROM Fornecedor WHERE ID_Fornecedor=@ID_Fornecedor";

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
                    new SqlParameter("@ID_Fornecedor",SqlDbType.Int) { Value=_ID_Fornecedor},
                    new SqlParameter("@Status_Fornecedor", SqlDbType.Bit) {Value = _Status_Fornecedor}


            };

                instrucaoSql = "UPDATE Fornecedor SET Status_Fornecedor = 1 where ID_Fornecedor= " + _ID_Fornecedor;

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
                    new SqlParameter("@ID_Fornecedor",SqlDbType.Int) { Value= _ID_Fornecedor },
                    new SqlParameter("@Status_Fornecedor", SqlDbType.Bit) {Value = _Status_Fornecedor}




                };

                instrucaoSql = "UPDATE Fornecedor SET Status_Fornecedor=0 WHERE ID_Fornecedor= " + _ID_Fornecedor; ;

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
                instrucaoSql = "SELECT * FROM  Fornecedor  WHERE ID_Fornecedor=" + _ID_Fornecedor;
                return c.RetornarDataReader(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DataSet ConsultarFornecedor()
        {
            try
            {
                instrucaoSql = "SELECT * FROM Fornecedor ORDER BY NomeFantasia_Fornecedor";
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public DataSet ListarCNPJ(string parteNome)
        {
            try
            {
                //ID_Fornecedor, Nome_Fornecedor, CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Celular_Fornecedor, Email_Fornecedor, WebSite_Fornecedor, Logradouro_Fornecedor, CEP_Fornecedor, Bairro_Fornecedor, UF_Fornecedor, Cidade_Fornecedor, Numero_Fornecedor, Status_Fornecedor

                //instrucaoSql = "SELECT ID_Fornecedor, NomeFantasia_Fornecedor, RazaoSocial_Fornecedor,  CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Celular_Fornecedor, Email_Fornecedor,  WebSite_Fornecedor, Logradouro_Fornecedor, CEP_Fornecedor, Bairro_Fornecedor, UF_Fornecedor, Cidade_Fornecedor, Numero_Fornecedor, Status_Fornecedor FROM Fornecedor ORDER BY NomeFantasia_Fornecedor";
              //  if (parteNome.Length != 0)
                
                    instrucaoSql = "SELECT ID_Fornecedor, NomeFantasia_Fornecedor, RazaoSocial_Fornecedor, CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Celular_Fornecedor, Email_Fornecedor,  WebSite_Fornecedor, CEP_Fornecedor, Logradouro_Fornecedor, Bairro_Fornecedor, UF_Fornecedor, Cidade_Fornecedor, Numero_Fornecedor, Status_Fornecedor FROM Fornecedor WHERE CNPJ_CPF_Fornecedor like '%" + parteNome +"%'";
                
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

       
                throw ex;
            }
        }

        public DataSet ListarPorNome(string parteNome)
        {
            try
            {
                //ID_Fornecedor, Nome_Fornecedor, CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Celular_Fornecedor, Email_Fornecedor, WebSite_Fornecedor, Logradouro_Fornecedor, CEP_Fornecedor, Bairro_Fornecedor, UF_Fornecedor, Cidade_Fornecedor, Numero_Fornecedor, Status_Fornecedor

                instrucaoSql = "SELECT ID_Fornecedor, RazaoSocial_Fornecedor, NomeFantasia_Fornecedor,  CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Celular_Fornecedor, Email_Fornecedor,  WebSite_Fornecedor, CEP_Fornecedor, Logradouro_Fornecedor , Bairro_Fornecedor, UF_Fornecedor, Cidade_Fornecedor, Numero_Fornecedor, Status_Fornecedor FROM Fornecedor WHERE Nomefantasia_Fornecedor like '%" + parteNome + "%'";
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
                instrucaoSql = "SELECT ID_Fornecedor, NomeFantasia_Fornecedor, RazaoSocial_Fornecedor, CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Celular_Fornecedor, Email_Fornecedor,  WebSite_Fornecedor, CEP_Fornecedor, Logradouro_Fornecedor , Bairro_Fornecedor, UF_Fornecedor, Cidade_Fornecedor, Numero_Fornecedor, Status_Fornecedor from Fornecedor where Status_Fornecedor = 1";
            
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
                instrucaoSql = "SELECT ID_Fornecedor, NomeFantasia_Fornecedor, RazaoSocial_Fornecedor, CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Celular_Fornecedor, Email_Fornecedor,  WebSite_Fornecedor, CEP_Fornecedor,  Logradouro_Fornecedor, Bairro_Fornecedor, UF_Fornecedor, Cidade_Fornecedor, Numero_Fornecedor, Status_Fornecedor from Fornecedor where Status_Fornecedor = 0";

                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

               throw ex;
            }
        }

        //public void IncluirComParametro() { }
        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {

                    new SqlParameter("@ID_Fornecedor", SqlDbType.Int) { Value= _ID_Fornecedor },
                    new SqlParameter("@NomeFantasia_Fornecedor",SqlDbType.VarChar) { Value= _NomeFantasia_Fornecedor },
                     new SqlParameter("@RazaoSocial_Fornecedor",SqlDbType.VarChar) { Value= _RazaoSocial_Fornecedor },
                    new SqlParameter("@CNPJ_CPF_Fornecedor",SqlDbType.VarChar) { Value= _CNPJ_CPF_Fornecedor },
                    new SqlParameter("@Telefone_Fornecedor",SqlDbType.VarChar) { Value=_Telefone_Fornecedor },
                    new SqlParameter("@Email_Fornecedor",SqlDbType.VarChar) { Value=_Email_Fornecedor },
                    new SqlParameter("@WebSite_Fornecedor", SqlDbType.VarChar) { Value = _WebSite_Fornecedor },
                    new SqlParameter("@Celular_Fornecedor", SqlDbType.VarChar) { Value = _Celular_Fornecedor },
                     new SqlParameter("@Logradouro_Fornecedor", SqlDbType.VarChar) { Value= _Logradouro_Fornecedor},
                    new SqlParameter("@Numero_Fornecedor", SqlDbType.Int) { Value= _Numero_Fornecedor},
                    new SqlParameter("@Complemento_Fornecedor", SqlDbType.VarChar) { Value= _Complemento_Fornecedor},
                    new SqlParameter("@Bairro_Fornecedor", SqlDbType.VarChar) { Value= _Bairro_Fornecedor},
                    new SqlParameter("@Cidade_Fornecedor", SqlDbType.VarChar) { Value= _Cidade_Fornecedor},
                    new SqlParameter("@UF_Fornecedor", SqlDbType.VarChar) { Value= UF_Fornecedor},
                    new SqlParameter("@CEP_Fornecedor", SqlDbType.VarChar) { Value= _CEP_Fornecedor}




                };

                instrucaoSql = "INSERT INTO Fornecedor "+
                    "(NomeFantasia_Fornecedor, RazaoSocial_Fornecedor, CNPJ_CPF_Fornecedor, Telefone_Fornecedor, Celular_Fornecedor, Email_Fornecedor, WebSite_Fornecedor, Logradouro_Fornecedor, Numero_Fornecedor,Complemento_Fornecedor, Bairro_Fornecedor , Cidade_Fornecedor , UF_Fornecedor, CEP_Fornecedor) VALUES " +
                    "(@NomeFantasia_Fornecedor, @RazaoSocial_Fornecedor, @CNPJ_CPF_Fornecedor, @Telefone_Fornecedor, @Celular_Fornecedor, @Email_Fornecedor, @WebSite_Fornecedor, @Logradouro_Fornecedor,@Numero_Fornecedor, @Complemento_Fornecedor,@Bairro_Fornecedor, @Cidade_Fornecedor, @UF_Fornecedor, @CEP_Fornecedor  )";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void alterar()
        {
            try
            {
                DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();
                instrucaoSql = "update Fornecedor set  Nome_Fornecedor = '" + _NomeFantasia_Fornecedor + "' where ID_Fornecedor ='"+_ID_Fornecedor+"';";
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public void Alterar()
        {
            instrucaoSql = "UPDATE Fornecedor SET  NomeFantasia_Fornecedor='" + _NomeFantasia_Fornecedor + "',  " +
                "CNPJ_CPF_Fornecedor='" + _CNPJ_CPF_Fornecedor + "', " +
                "Celular_Fornecedor= '" + _Celular_Fornecedor + "', " +
                "Telefone_Fornecedor='" + _Telefone_Fornecedor + "', " +
                "WebSite_Fornecedor= '" + _WebSite_Fornecedor + "', " +
                "Email_Fornecedor='" + _Email_Fornecedor + "', " +
                "Logradouro_Fornecedor='" + _Logradouro_Fornecedor + "', " +

                "Numero_Fornecedor= '" + _Numero_Fornecedor + "', " +
                "Complemento_Fornecedor='" + _Complemento_Fornecedor + "', " +
                "Bairro_Fornecedor= '" + _Bairro_Fornecedor + "', " +
                "Cidade_Fornecedor='" + _Cidade_Fornecedor + "', " +
                "UF_Fornecedor='" + _UF_Fornecedor + "', " +

                "CEP_Fornecedor='" + _CEP_Fornecedor + "', " +
                "Status_Fornecedor= '" + _Status_Fornecedor + "', " +


                "where ID_Fornecedor='" + _ID_Fornecedor + "' ";
            c.ExecutarComando(instrucaoSql);
        }

































    }
}
