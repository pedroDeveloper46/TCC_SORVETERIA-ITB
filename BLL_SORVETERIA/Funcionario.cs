using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
    public class Funcionario
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

       

        private int _ID_Funcionario;
        
        private string _Nome_Funcionario;
        private string _CPF_Funcionario;
        private string _RG_Funcionario;
        private DateTime  _DataNasc_Funcionario;
        private string _Telefone_Funcionario;
        private char _Sexo_Funcionario;
        private string _Email_Funcionario;
        private string _Logradouro_Funcionario;
        private int _Numero_Funcionario;
        private string _Complemento_Funcionario;
        private string _Bairro_Funcionario;
        private string _Cidade_Funcionario;
        private string _UF_Funcionario;
        private string _CEP_Funcionario;
       
        private int _Status_Funcionario;
        private string _Celular_Funcionario;
        private int _ID_Cargo;
     
        public int ID_Funcionario
        {
            get
            {
                return _ID_Funcionario;
            }

            set
            {
                _ID_Funcionario = value;
            }
        }

        

        public string Nome_Funcionario
        {
            get
            {
                return _Nome_Funcionario;
            }

            set
            {
                _Nome_Funcionario = value;
            }
        }

        public string CPF_Funcionario
        {
            get
            {
                return _CPF_Funcionario;
            }

            set
            {
                _CPF_Funcionario = value;
            }
        }

        public string RG_Funcionario
        {
            get
            {
                return _RG_Funcionario;
            }

            set
            {
                _RG_Funcionario = value;
            }
        }

        public DateTime DataNasc_Funcionario
        {
            get
            {
                return _DataNasc_Funcionario;
            }

            set
            {
                _DataNasc_Funcionario = value;
            }
        }

        public string Telefone_Funcionario
        {
            get
            {
                return _Telefone_Funcionario;
            }

            set
            {
                _Telefone_Funcionario = value;
            }
        }

        public char Sexo_Funcionario
        {
            get
            {
                return _Sexo_Funcionario;
            }

            set
            {
                _Sexo_Funcionario = value;
            }
        }

        public string Email_Funcionario
        {
            get
            {
                return _Email_Funcionario;
            }

            set
            {
                _Email_Funcionario = value;
            }
        }

        public string Logradouro_Funcionario
        {
            get
            {
                return _Logradouro_Funcionario;
            }

            set
            {
                _Logradouro_Funcionario = value;
            }
        }

        public int Numero_Funcionario
        {
            get
            {
                return _Numero_Funcionario;
            }

            set
            {
                _Numero_Funcionario = value;
            }
        }

        public string Complemento_Funcionario
        {
            get
            {
                return _Complemento_Funcionario;
            }

            set
            {
                _Complemento_Funcionario = value;
            }
        }

        public string Bairro_Funcionario
        {
            get
            {
                return _Bairro_Funcionario;
            }

            set
            {
                _Bairro_Funcionario = value;
            }
        }

        public string Cidade_Funcionario
        {
            get
            {
                return _Cidade_Funcionario;
            }

            set
            {
                _Cidade_Funcionario = value;
            }
        }

       
        public string CEP_Funcionario
        {
            get
            {
                return _CEP_Funcionario;
            }

            set
            {
                _CEP_Funcionario = value;
            }
        }

        
        public int Status_Funcionario
        {
            get
            {
                return _Status_Funcionario;
            }

            set
            {
                _Status_Funcionario = value;
            }
        }

        public string Celular_Funcionario { get => _Celular_Funcionario; set => _Celular_Funcionario = value; }
        public string UF_Funcionario { get => _UF_Funcionario; set => _UF_Funcionario = value; }
        public int ID_Cargo { get => _ID_Cargo; set => _ID_Cargo = value; }
        

        public void AtualizarParametro()
        {
          
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Funcionario", SqlDbType.Int) { Value= _ID_Funcionario },
                    
                    new SqlParameter("@Nome_Funcionario", SqlDbType.VarChar) { Value= _Nome_Funcionario},
                     new SqlParameter("@Celular_Funcionario", SqlDbType.VarChar) { Value= _Celular_Funcionario},
                    //new SqlParameter("@CPF_Funcionario", SqlDbType.VarChar) { Value= _CPF_Funcionario},
                    new SqlParameter("@RG_Funcionario", SqlDbType.VarChar) { Value=_RG_Funcionario},
                    new SqlParameter("@DataNasc_Funcionario", SqlDbType.Date) { Value= _DataNasc_Funcionario},
                    new SqlParameter("@Telefone_Funcionario", SqlDbType.VarChar) { Value= _Telefone_Funcionario},
                    new SqlParameter("@Sexo_Funcionario", SqlDbType.Char) { Value= _Sexo_Funcionario},
                    new SqlParameter("@Email_Funcionario", SqlDbType.VarChar) { Value= _Email_Funcionario},
                    new SqlParameter("@Logradouro_Funcionario", SqlDbType.VarChar) { Value= _Logradouro_Funcionario},
                    new SqlParameter("@Numero_Funcionario", SqlDbType.Int) { Value= _Numero_Funcionario},
                    new SqlParameter("@Complemento_Funcionario", SqlDbType.VarChar) { Value= _Complemento_Funcionario},
                    new SqlParameter("@Bairro_Funcionario", SqlDbType.VarChar) { Value= _Bairro_Funcionario},
                    new SqlParameter("@Cidade_Funcionario", SqlDbType.VarChar) { Value= _Cidade_Funcionario},
                    new SqlParameter("@UF_Funcionario", SqlDbType.VarChar) { Value= UF_Funcionario},
                    new SqlParameter("@CEP_Funcionario", SqlDbType.VarChar) { Value= _CEP_Funcionario},
                    new SqlParameter("@ID_Cargo", SqlDbType.Int) {Value = _ID_Cargo},
                    
                    //new SqlParameter("@Status_Funcionario", SqlDbType.Int) { Value=_Status_Funcionario},
                };

                instrucaoSql = "UPDATE Funcionario SET  Nome_Funcionario=@Nome_Funcionario,  RG_Funcionario=@RG_Funcionario, DataNasc_Funcionario=@DataNasc_Funcionario, Telefone_Funcionario=@Telefone_Funcionario, Celular_Funcionario=@Celular_Funcionario,  Sexo_Funcionario=@Sexo_Funcionario, Email_Funcionario=@Email_Funcionario, Logradouro_Funcionario=@Logradouro_Funcionario, Numero_Funcionario=@Numero_Funcionario, Complemento_Funcionario=@Complemento_Funcionario, Bairro_Funcionario=@Bairro_Funcionario, Cidade_Funcionario=@Cidade_Funcionario, UF_Funcionario=@UF_Funcionario, CEP_Funcionario=@CEP_Funcionario, ID_Cargo=@ID_Cargo where ID_Funcionario=@ID_Funcionario";


                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


        }

        public void ExcluirParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Funcionario",SqlDbType.Int) { Value=_ID_Funcionario }

                };

                instrucaoSql = "DELETE Funcionario WHERE ID_Funcionario=@ID_Funcionario";

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
                    new SqlParameter("@ID_Funcionario",SqlDbType.Int) { Value=_ID_Funcionario},
                    new SqlParameter("@Status_Funcionario", SqlDbType.Bit) {Value = _Status_Funcionario}

                    
            };

                instrucaoSql = "UPDATE Funcionario SET Status_Funcionario = 1 where ID_Funcionario= " + _ID_Funcionario;

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
                    new SqlParameter("@ID_Funcionario",SqlDbType.Int) { Value=_ID_Funcionario},
                       new SqlParameter("@Status_Funcionario", SqlDbType.Bit) {Value = _Status_Funcionario}




                };

                instrucaoSql = "UPDATE Funcionario SET Status_Funcionario=0 WHERE ID_Funcionario= " + _ID_Funcionario;

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
                instrucaoSql = "SELECT * FROM Funcionario WHERE ID_Funcionario=" +_ID_Funcionario;
                return c.RetornarDataReader(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Ativar()
        {
            try
            {
                instrucaoSql = "UPDATE Funcionario SET Status_Funcionario = 1 where ID_Funcionario= " + _ID_Funcionario;
                c.ExecutarComando(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Desativar()
        {
            try
            {
                instrucaoSql = "UPDATE Funcionario SET Status_Funcionario = 0 where ID_Funcionario= " + _ID_Funcionario;
                c.ExecutarComando(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet ListarPorCPF(string parteNome)
        {
            try
            {
               // instrucaoSql = "SELECT ID_Funcionario, Nome_Funcionario, Celular_Funcionario, Sexo_Funcionario, CPF_Funcionario, CEP_Funcionario, Bairro_Funcionario, Cidade_Funcionario, UF_Funcionario, DataNasc_Funcionario, RG_Funcionario, Logradouro_Funcionario, Telefone_Funcionario, Complemento_Funcionario, Numero_Funcionario, Email_Funcionario, Status_Funcionario, ID_Cargo FROM Funcionario ORDER BY Nome_Funcionario";
                //if (parteNome.Length != 0)
                
                    instrucaoSql = "SELECT ID_Funcionario, Nome_Funcionario, Celular_Funcionario, Sexo_Funcionario, CPF_Funcionario, CEP_Funcionario, Bairro_Funcionario, Cidade_Funcionario, UF_Funcionario, DataNasc_Funcionario, RG_Funcionario, Logradouro_Funcionario, Telefone_Funcionario, Complemento_Funcionario, Numero_Funcionario, Email_Funcionario, Status_Funcionario, ID_Cargo FROM Funcionario where CPF_Funcionario like '%" + parteNome + "%'";
                    
                
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader IdFunc()
        {
            try
            {
                instrucaoSql = "select Max(ID_Funcionario) as ID_Funcionario from Funcionario";
                return c.RetornarDataReader(instrucaoSql);

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
                instrucaoSql = "Select Min(ID_Funcionario) from Funcionario";
                SqlDataReader dr;

                dr = c.RetornarDataReader(instrucaoSql);
                return dr;
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


                instrucaoSql = "SELECT ID_Funcionario, Nome_Funcionario, CPF_Funcionario, RG_Funcionario, DataNasc_Funcionario, Celular_Funcionario, Telefone_Funcionario, Email_Funcionario, Sexo_Funcionario, CEP_Funcionario, Bairro_Funcionario, Cidade_Funcionario, UF_Funcionario, Logradouro_Funcionario, Complemento_Funcionario, Numero_Funcionario, ID_Cargo, Status_Funcionario FROM Funcionario";


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
                
                
                instrucaoSql = "SELECT ID_Funcionario, Nome_Funcionario, CPF_Funcionario, RG_Funcionario, DataNasc_Funcionario, Celular_Funcionario, Telefone_Funcionario, Email_Funcionario, Sexo_Funcionario, CEP_Funcionario, Bairro_Funcionario, Cidade_Funcionario, UF_Funcionario, Logradouro_Funcionario, Complemento_Funcionario, Numero_Funcionario, ID_Cargo, Status_Funcionario  FROM Funcionario where Nome_Funcionario like '%" + parteNome + "%'";

                
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarCargo(int ID_Cargo)
        {
            try
            {


                instrucaoSql = "SELECT ID_Funcionario, Nome_Funcionario, CPF_Funcionario, RG_Funcionario, DataNasc_Funcionario, Celular_Funcionario, Telefone_Funcionario, Email_Funcionario, Sexo_Funcionario, CEP_Funcionario, Bairro_Funcionario, Cidade_Funcionario, UF_Funcionario, Logradouro_Funcionario, Complemento_Funcionario, Numero_Funcionario, ID_Cargo, Status_Funcionario FROM Funcionario where ID_Cargo =" + ID_Cargo;


                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public DataSet ConsultarNome()
        {
            try
            {
                 instrucaoSql = "SELECT * FROM FUNCIONARIO WHERE Nome_Funcionario like '%Nome_Funcionario%'";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet ConsultarFuncionario()
        {
            try
            {
                instrucaoSql = "SELECT * FROM Funcionario ORDER BY Nome_Funcionario";
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
                instrucaoSql = "SELECT ID_Funcionario, Nome_Funcionario, CPF_Funcionario, RG_Funcionario, DataNasc_Funcionario, Celular_Funcionario, Telefone_Funcionario, Email_Funcionario, Sexo_Funcionario, CEP_Funcionario, Bairro_Funcionario, Cidade_Funcionario, UF_Funcionario, Logradouro_Funcionario, Complemento_Funcionario, Numero_Funcionario, ID_Cargo, Status_Funcionario FROM Funcionario where Status_Funcionario = 1";
               
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
                instrucaoSql = "SELECT ID_Funcionario, Nome_Funcionario, CPF_Funcionario, RG_Funcionario, DataNasc_Funcionario, Celular_Funcionario, Telefone_Funcionario, Email_Funcionario, Sexo_Funcionario, CEP_Funcionario, Bairro_Funcionario, Cidade_Funcionario, UF_Funcionario, Logradouro_Funcionario, Complemento_Funcionario, Numero_Funcionario, ID_Cargo, Status_Funcionario FROM Funcionario where Status_Funcionario = 0";

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


                     new SqlParameter("@ID_Funcionario", SqlDbType.Int) { Value= _ID_Funcionario },
                  
                    new SqlParameter("@Nome_Funcionario", SqlDbType.VarChar) { Value= _Nome_Funcionario},
                    new SqlParameter("@CPF_Funcionario", SqlDbType.VarChar) { Value= _CPF_Funcionario},
                    new SqlParameter("@RG_Funcionario", SqlDbType.VarChar) { Value=_RG_Funcionario},
                    new SqlParameter("@DataNasc_Funcionario", SqlDbType.DateTime) { Value= _DataNasc_Funcionario},
                    new SqlParameter("@Telefone_Funcionario", SqlDbType.VarChar) { Value= _Telefone_Funcionario},
                    new SqlParameter("@Sexo_Funcionario", SqlDbType.Char) { Value= _Sexo_Funcionario},
                    new SqlParameter("@Email_Funcionario", SqlDbType.VarChar) { Value= _Email_Funcionario},
                    new SqlParameter("@Logradouro_Funcionario", SqlDbType.VarChar) { Value= _Logradouro_Funcionario},
                    new SqlParameter("@Numero_Funcionario", SqlDbType.Int) { Value= _Numero_Funcionario},
                    new SqlParameter("@Complemento_Funcionario", SqlDbType.VarChar) { Value= _Complemento_Funcionario},
                    new SqlParameter("@Bairro_Funcionario", SqlDbType.VarChar) { Value= _Bairro_Funcionario},
                    new SqlParameter("@Cidade_Funcionario", SqlDbType.VarChar) { Value= _Cidade_Funcionario},
                    new SqlParameter("@UF_Funcionario", SqlDbType.VarChar) { Value= UF_Funcionario},
                    new SqlParameter("@CEP_Funcionario", SqlDbType.VarChar) { Value= _CEP_Funcionario},
                   
                    new SqlParameter("@Status_Funcionario", SqlDbType.Int) { Value=_Status_Funcionario},
                    new SqlParameter("@Celular_Funcionario", SqlDbType.VarChar) { Value= _Celular_Funcionario},
                    new SqlParameter ("ID_Cargo", SqlDbType.Int) {Value = _ID_Cargo}


                };



                instrucaoSql = "INSERT INTO Funcionario" + "(Nome_Funcionario, CPF_Funcionario, RG_Funcionario, DataNasc_Funcionario, Telefone_Funcionario, Sexo_Funcionario, Email_Funcionario, Logradouro_Funcionario, Numero_Funcionario, Complemento_Funcionario, Bairro_Funcionario, Cidade_Funcionario, UF_Funcionario, CEP_Funcionario, Celular_Funcionario, ID_Cargo)" +
                    "Values (@Nome_Funcionario,@CPF_Funcionario,@RG_Funcionario, @DataNasc_Funcionario, @Telefone_Funcionario, @Sexo_Funcionario, @Email_Funcionario, @Logradouro_Funcionario, @Numero_Funcionario, @Complemento_Funcionario, @Bairro_Funcionario, @Cidade_Funcionario, @UF_Funcionario, @CEP_Funcionario, @Celular_Funcionario, @ID_Cargo)";
;

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public void Atualizar()
        {



            instrucaoSql = "UPDATE Funcionario SET  Nome_Funcionario='" + _Nome_Funcionario + "',  " +
                "RG_Funcionario='" + _RG_Funcionario + "', " +
                "DataNasc_Funcionario= '" + _DataNasc_Funcionario + "', " +
                "Telefone_Funcionario='" + _Telefone_Funcionario + "', " +
                "Celular_Funcionario= '" + _Celular_Funcionario + "', " +
                "Sexo_Funcionario='" + _Sexo_Funcionario + "', " +
                "Email_Funcionario='" + _Email_Funcionario + "', " +
                "Logradouro_Funcionario='" + _Logradouro_Funcionario + "', " +
                "Numero_Funcionario= '" + _Numero_Funcionario + "', " +
                "Complemento_Funcionario='" + _Complemento_Funcionario + "', " +
                "Bairro_Funcionario= '" + _Bairro_Funcionario + "', " +
                "Cidade_Funcionario='" + _Cidade_Funcionario + "', " +
                "UF_Funcionario='" + _UF_Funcionario + "', " +
                "CEP_Funcionario='" + _CEP_Funcionario + "', " +
                "Status_Funcionario= '" + _Status_Funcionario + "', " +
                "ID_Cargo = '" + _ID_Cargo + "', " +

                "where ID_Funcionario='" + _ID_Funcionario + "' ";
            c.ExecutarComando(instrucaoSql);


        }






    }
}
