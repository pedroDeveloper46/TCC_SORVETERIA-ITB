using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL_SORVETERIA
{
   public class Usu_Cliente 
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();
        private string InstrucaoSql;

        private int _ID_Usu;
        private string _Email_Usu;
        private string _Senha_Usu;
        private int _ID_USU_Cliente;

        public int ID_Usu { get => _ID_Usu; set => _ID_Usu = value; }
        public string Email_Usu { get => _Email_Usu; set => _Email_Usu = value; }
        public string Senha_Usu { get => _Senha_Usu; set => _Senha_Usu = value; }
        public int ID_USU_Cliente { get => _ID_USU_Cliente; set => _ID_USU_Cliente = value; }

        public DataSet Listar()
        {
            try
            {
                InstrucaoSql = "select * from Usu_Cliente";
                return c.RetornarDataSet(InstrucaoSql);
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
                InstrucaoSql = "select * from Usu_Cliente where ID_Usu=" + _ID_Usu;
                return c.RetornarDataReader(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Usu(string nome)
        {
            try
            {
                InstrucaoSql = "select * from Usu_Cliente where Email_Usu like '%" + nome + "%'";
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
                SqlParameter[] lista = {
                    new SqlParameter("ID_Usu", SqlDbType.Int) {Value = _ID_Usu},
                    new SqlParameter("@Email_Usu", SqlDbType.VarChar) {Value = _Email_Usu},
                    new SqlParameter("@Senha_Usu", SqlDbType.VarChar) {Value = _Senha_Usu},
                    new SqlParameter("ID_USU_Cliente", SqlDbType.Int) {Value = _ID_USU_Cliente}
                };
                InstrucaoSql = "update Usu_Cliente set Email_Usu=@Email_Usu, Senha_Usu=@Senha_Usu, ID_USU_Cliente=@ID_USU_Cliente where ID_Usu=@ID_Usu ";
                c.ExecutarComandoParametro(InstrucaoSql, lista);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Cad()
        {
            try
            {
                SqlParameter[] lista = {
                    new SqlParameter("ID_Usu", SqlDbType.Int) {Value = _ID_Usu},
                    new SqlParameter("@Email_Usu", SqlDbType.VarChar) {Value = _Email_Usu},
                    new SqlParameter("@Senha_Usu", SqlDbType.VarChar) {Value = _Senha_Usu},
                    new SqlParameter("ID_USU_Cliente", SqlDbType.Int) {Value = _ID_USU_Cliente}
                };
                InstrucaoSql = "insert into Usu_Cliente(Email_Cliente, Senha_Cliente, ID_USU_Cliente) values (@Email_Cliente, @Senha_Cliente, @ID_Usu_Cliente) ";
                c.ExecutarComandoParametro(InstrucaoSql, lista);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
