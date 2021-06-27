using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
    public class Cliente
    {
        public string InstrucaoSql;
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        private int _ID_Cliente;
        private string _Nome_Cliente;
        private string _Telefone_Cliente;
        private byte _Status_Cliente;
        private string _Email_Cliente;

        public int ID_Cliente { get => _ID_Cliente; set => _ID_Cliente = value; }
        public string Nome_Cliente { get => _Nome_Cliente; set => _Nome_Cliente = value; }
        public string Telefone_Cliente { get => _Telefone_Cliente; set => _Telefone_Cliente = value; }
        public byte Status_Cliente { get => _Status_Cliente; set => _Status_Cliente = value; }
        public string Email_Cliente { get => _Email_Cliente; set => _Email_Cliente = value; }

        public DataSet Listar()
        {
            try
            {
                InstrucaoSql = "Select * from Cliente order by Nome_Cliente";
                return c.RetornarDataSet(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Listar1()
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Filtro()
        {
            try
            {
                InstrucaoSql = "select * from Cliente  where Status_Cliente = 1 ORDER BY Nome_Cliente";
                return c.RetornarDataSet(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Atualizar()
        {
            try
            {
                SqlParameter[] lista =
                {
                    new SqlParameter("@Nome_Cliente", SqlDbType.VarChar) {Value = _Nome_Cliente},
                    new SqlParameter("@Telefone_Cliente", SqlDbType.VarChar) {Value = _Telefone_Cliente},
                     new SqlParameter("@Email_Cliente", SqlDbType.VarChar) {Value = _Email_Cliente},
                    new SqlParameter("@ID_Cliente", SqlDbType.VarChar) {Value = _ID_Cliente}
                    //new SqlParameter("Status_Cliente", SqlDbType.VarChar) {Value = _Nome_Cliente}
                };
                InstrucaoSql = "Update Cliente Set Nome_Cliente=@Nome_Cliente, Telefone_Cliente=@Telefone_Cliente, Email_Cliente=@Email_Cliente where ID_Cliente=@ID_Cliente" +
                    " ";
                c.ExecutarComandoParametro(InstrucaoSql, lista);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarNome(string Nome)
        {
            try
            {
                InstrucaoSql = "select * from Cliente where Nome_Cliente  like '%" + Nome + "%'";
                return c.RetornarDataSet(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Inserir()
        {
            try
            {
                SqlParameter[] lista =
                 {
                    new SqlParameter("@Nome_Cliente", SqlDbType.VarChar) {Value = _Nome_Cliente},
                    new SqlParameter("@Telefone_Cliente", SqlDbType.VarChar) {Value = _Telefone_Cliente},
                    new SqlParameter("@Email_Cliente", SqlDbType.VarChar) {Value = _Email_Cliente}
                };
                InstrucaoSql = "insert into Cliente(Nome_Cliente, Telefone_Cliente, Email_Cliente)" + "values(@Nome_Cliente, @Telefone_Cliente, @Email_Cliente)";
                c.ExecutarComandoParametro(InstrucaoSql, lista);
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
                InstrucaoSql = "SELECT * FROM Cliente WHERE ID_Cliente=" + _ID_Cliente;
                return c.RetornarDataReader(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }  



        public SqlDataReader Codigo()
        {
            try
            {
                InstrucaoSql = "Select Max(ID_Cliente) as ID_Cliente from Cliente";
                SqlDataReader dr;
                dr = c.RetornarDataReader(InstrucaoSql);

                return dr;
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
                    //new SqlParameter("@ID_CLiente",SqlDbType.Int) { Value= _ID_Cliente},
                       new SqlParameter("@Status_Cliente", SqlDbType.Bit) {Value = _Status_Cliente}




                };

                InstrucaoSql = "UPDATE Cliente SET Status_Cliente=0 WHERE ID_CLiente= " + _ID_Cliente;

                c.ExecutarComandoParametro(InstrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ativarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    //new SqlParameter("@ID_CLiente",SqlDbType.Int) { Value= _ID_Cliente},
                       new SqlParameter("@Status_Cliente", SqlDbType.Bit) {Value = _Status_Cliente}




                };

                InstrucaoSql = "UPDATE Cliente SET Status_Cliente=1 WHERE ID_CLiente= " + _ID_Cliente;

                c.ExecutarComandoParametro(InstrucaoSql, listaComParametros);


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
                InstrucaoSql = "select * from CLiente where Status_Cliente = 1";
                return c.RetornarDataSet(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet ListarInAtivos()
        {
            try
            {
                InstrucaoSql = "select * from CLiente where Status_Cliente = 0";
                return c.RetornarDataSet(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        public void BuscarNome()
        {
            try
            {
                InstrucaoSql = "select * from Cliente where Email_Cliente = " + _Email_Cliente;
                SqlDataReader dr;
                dr = c.RetornarDataReader(InstrucaoSql);
                dr.Read();
                if (dr.HasRows)
                {
                    _Nome_Cliente = Convert.ToString(dr["Nome_Cliente"]);
                }
                else
                {
                    _Nome_Cliente = "  ";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
