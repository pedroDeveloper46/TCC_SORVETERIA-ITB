using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
   public class Cupom
    {
        private string instrucaoSql;
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        private int _ID_Cupom;
        private string _Numero_Cupom;
        private int _ID_Cliente;
        private string _tipoDesconto_Cupom;



        public int ID_Cupom { get => _ID_Cupom; set => _ID_Cupom = value; }
        public string Numero_Cupom { get => _Numero_Cupom; set => _Numero_Cupom = value; }
        public int ID_Cliente { get => _ID_Cliente; set => _ID_Cliente = value; }
        public string TipoDesconto_Cupom { get => _tipoDesconto_Cupom; set => _tipoDesconto_Cupom = value; }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {


                    new SqlParameter("@ID_Cupom", SqlDbType.Int) { Value= _ID_Cupom },
                    new SqlParameter("@Numero_Cupom",SqlDbType.VarChar) { Value= _Numero_Cupom },
                    



                };

                instrucaoSql = "INSERT INTO Cupom" + "(Numero_Cupom) Values  (@Numero_Cupom)";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public DataSet Listarcupom(string cupom)
        {
            try
            {
                instrucaoSql = "select * from Cupom where Numero_Cupom like '%" + cupom + "%'";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet List()
        {
            try
            {
                instrucaoSql = "select * from Cupom";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet List1()
        {
            try
            {
                instrucaoSql = "select * from Cupom where Status_Cupom = 1";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet List2()
        {
            try
            {
                instrucaoSql = "select * from Cupom where Status_Cupom = 0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public SqlDataReader ListarNumero()
        {
            try
            {
               instrucaoSql = "select * from Cupom where Status_Cupom = 1"; 
               return c.RetornarDataReader(instrucaoSql);
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader ListarNumeroCupom(string cupom)
        {
            try
            {
                instrucaoSql = "select * from Cupom where Numero_Cupom = '" + cupom + "'";
                return c.RetornarDataReader(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public SqlDataReader Numero()
        {
            try
            {
                instrucaoSql = "select count(ID_Cupom) * from Cupom";
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public SqlDataReader ListarNumero(string nCupom)
        {
            try
            {
                instrucaoSql = "select * from Cupom";
                return c.RetornarDataReader(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader Listartipo(string numero)
        {
            try
            {
                
                instrucaoSql = "select * from Cupom where Numero_Cupom = '" + numero + "'";
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CadastrarCupom()
        
        

        {
            try
            {
                SqlParameter[] lista = {
                    new SqlParameter("@Numero_Cupom", SqlDbType.VarChar) { Value = _Numero_Cupom },
                    new SqlParameter("@ID_Cliente", SqlDbType.Int) { Value = _ID_Cliente },
                    new SqlParameter("@tipoDesconto_Cupom", SqlDbType.VarChar) { Value = _tipoDesconto_Cupom}

                   

                };
                instrucaoSql = "insert into Cupom(Numero_Cupom, ID_Cliente, tipoDesconto_Cupom) values (@Numero_Cupom, @ID_Cliente, @tipoDesconto_Cupom)";
                
c.ExecutarComandoParametro(instrucaoSql, lista);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 

        public void CupomPara0()
        {
            try
            {
                SqlParameter[] lista =
                {
                    new SqlParameter("@ID_Cupom", SqlDbType.Int) {Value = _ID_Cupom}
                };

                instrucaoSql = "update Cupom set Status_Cupom = 0 where ID_Cupom=@ID_Cupom";
                c.ExecutarComandoParametro(instrucaoSql, lista);
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Random(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }  

        public SqlDataReader CodigoCupom(int cod)
        {
            try
            {
                instrucaoSql = "select * from Cupom where ID_Cupom =" + cod;
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       // public String Sorteia()
        //////{
        //////    String[] s = new string[3];
        //////    s[0] = "Compre 1 e ganhe outro";
        //////    s[1] = "Compre 2 e ganhe outro";
        //////    s[2] = "15%";
        //////    s[3] = "10%";
            

            

          
        //////}
    }
}
