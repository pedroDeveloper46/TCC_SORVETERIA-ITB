using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{


    public class Cartao
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados()
            ;

        public string instrucao;

        private int numero;
        private string tipo;
        private int geo;
        private string carro;
        private DateTime utilizacao;


        public string Tipo { get => tipo; set => tipo = value; }
        public int Geo { get => geo; set => geo = value; }
        public int Numero { get => numero; set => numero = value; }
        public DateTime Utilizacao { get => utilizacao; set => utilizacao = value; }
        public string Carro { get => carro; set => carro = value; }

        public void incluir()

        {
            try
            {
                SqlParameter[] lista =
                {
                    new SqlParameter("@N_CARTAO", SqlDbType.Int) {Value = Numero},
                    new SqlParameter("@UTILIZACAO", SqlDbType.DateTime) {Value = Utilizacao},
                    new SqlParameter("@TIPO", SqlDbType.VarChar) {Value = Tipo},
                    new SqlParameter("@GEO", SqlDbType.Int) {Value = Geo},
                    new SqlParameter("@CARRO", SqlDbType.VarChar) {Value = Carro}
                };
                instrucao = "INSERT INTO CARTAO VALUES (GETDATE(), @N_CARTAO, @TIPO, @CARRO, @GEO)";
                c.ExecutarComandoParametro(instrucao, lista);

            }
            catch (Exception ex)
            {
                throw ex;
                throw;
            }
        }

        public DataSet listaGeo(string carro)
        {
            try
            {
                instrucao = "SELECT MAX(HORA_FINAL) FROM GEO where CARRO = '" + carro +"'";
                return c.RetornarDataSet(instrucao);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
