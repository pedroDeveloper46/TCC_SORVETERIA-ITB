using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
    public class Cep
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

        private string _NumeroCep;
        private string _NomeRua;

        public string NumeroCep
        {
            get
            {
                return _NumeroCep;
            }

            set
            {
                _NumeroCep = value;
            }
        }

        public string NomeRua
        {
            get
            {
                return _NomeRua;
            }

            set
            {
                _NomeRua = value;
            }
        }

        public string Uf
        {
            get
            {
                return _Uf;
            }

            set
            {
                _Uf = value;
            }
        }

        public string Cidade
        {
            get
            {
                return _Cidade;
            }

            set
            {
                _Cidade = value;
            }
            
        }

        public string Bairro
        {
            get
            {
                return _Bairro;
            }

            set
            {
                _Bairro = value;
            }
        }

        private string _Uf;
        private string _Cidade;
        private string _Bairro;



        public SqlDataReader Consultar()
        {
            try
            {
                instrucaoSql = "SELECT * FROM CEP  WHERE CEP= " + _NumeroCep;
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void RecuperarDadosCep()
        {
            try
            {
                instrucaoSql = "SELECT * FROM CEP  WHERE CEP= " + _NumeroCep.Replace("-", "").Trim();
                SqlDataReader ddr;
                ddr=c.RetornarDataReader(instrucaoSql);
                ddr.Read();
                if (ddr.HasRows)
                {
                    _Bairro = Convert.ToString(ddr["Bairro"]);
                    _Cidade = Convert.ToString(ddr["Cidade"]);
                    _Uf = Convert.ToString(ddr["Uf"]);
                    _NomeRua = Convert.ToString(ddr["Descricao"]); 
                }
                else
                {
                    _Bairro = "";
                    _Cidade = "";
                    _Uf = "";
                    _NomeRua = "NAO EXISTE ESTE CEP";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
