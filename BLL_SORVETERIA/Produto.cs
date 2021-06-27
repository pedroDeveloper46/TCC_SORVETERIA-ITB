using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SORVETERIA
{
   public  class Produto
    {
        DAO_SORVETERIA.ClasseParaManipularBancoDeDados c = new DAO_SORVETERIA.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;



        private int _ID_Produto;
        private string _Nome_Produto;
        private decimal _Preco_Produto;
        private string _Descricao_Produto;
        private int _qtdeATUAL_Produto;
        private DateTime _Data_Produto;
        //private int _qtdeMAX_Produto;
        //private int _qtdeMIN_Produto;
        private byte _Status_Produto;
        private string _Nome_Categoria;
        //private DateTime _Data;
        private int _QuantidadeEntrada;
        
                 

       

        public string Nome_Produto
        {
            get
            {
                return _Nome_Produto;
            }

            set
            {
                _Nome_Produto = value;
            }
        }

        public decimal Preco_Produto
        {
            get
            {
                return _Preco_Produto;
            }

            set
            {
                _Preco_Produto = value;
            }
        }

        public string Descricao_Produto
        {
            get
            {
                return _Descricao_Produto;
            }

            set
            {
                _Descricao_Produto = value;
            }
        }

        public int qtdeATUAL_Produto
        {
            get
            {
                return _qtdeATUAL_Produto;
            }

            set
            {
                _qtdeATUAL_Produto = value;
            }
        }

        //public int qtdeMAX_Produto
        //{
        //    get
        //    {
        //        return _qtdeMAX_Produto;
        //    }

        //    set
        //    {
        //        _qtdeMAX_Produto = value;
        //    }
        //}

        public byte Status_Produto
        {
            get
            {
                return _Status_Produto;
            }

            set
            {
                _Status_Produto = value;
            }
        }

        public int ID_Produto
        {
            get
            {
                return _ID_Produto;
            }

            set
            {
                _ID_Produto = value;
            }
        }

         private int _ID_Cat;
        private int _ID_Fornecedor;
        //private int _ID_Categoria;

        //public int QtdeMIN_Produto
        //{
        //    get
        //    {
        //        return _qtdeMIN_Produto;
        //    }

        //    set
        //    {
        //        _qtdeMIN_Produto = value;
        //    }
        //}

       
        public string Nome_Categoria { get => _Nome_Categoria; set => _Nome_Categoria = value; }
       // public int ID_Categoria { get => _ID_Categoria; set => _ID_Categoria = value; }
        public int ID_Cat { get => _ID_Cat; set => _ID_Cat = value; }
        public int ID_Fornecedor { get => _ID_Fornecedor; set => _ID_Fornecedor = value; }
        public DateTime Data_Produto { get => _Data_Produto; set => _Data_Produto = value; }
        public int QuantidadeEntrada { get => _QuantidadeEntrada; set => _QuantidadeEntrada = value; }


        //public DateTime Data { get => _Data; set => _Data = value; }
        //public int QuantidadeEntrada { get => _QuantidadeEntrada; set => _QuantidadeEntrada = value; }

        public void AtualizarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Produto", SqlDbType.Int) { Value= _ID_Produto },
                    new SqlParameter("@Nome_Produto",SqlDbType.VarChar) { Value= _Nome_Produto },
                    new SqlParameter("@Preco_Produto",SqlDbType.Decimal) { Value= _Preco_Produto },
                    new SqlParameter("@Descricao_Produto",SqlDbType.VarChar) { Value= _Descricao_Produto},
                    new SqlParameter("@qtdeATUAL_Produto",SqlDbType.Int) { Value= _qtdeATUAL_Produto },
                    //new SqlParameter("@qtdeMAX_Produto",SqlDbType.Int) { Value= _qtdeMAX_Produto },
                    //new SqlParameter("@qtdeMIN_Produto", SqlDbType.Int) {Value=_qtdeMIN_Produto },
                    new SqlParameter("@Status_Produto",SqlDbType.Bit) {Value= _Status_Produto },
                     new SqlParameter("@ID_Cat", SqlDbType.Int) {Value = _ID_Cat },
                    new SqlParameter("@ID_Fornecedor", SqlDbType.Int) {Value = _ID_Fornecedor}




                };

                instrucaoSql = "UPDATE Produto SET Nome_Produto=@Nome_Produto, Preco_Produto=@Preco_Produto, Descricao_Produto=@Descricao_Produto, qtdeATUAL_Produto=@qtdeATUAL_Produto, ID_Cat=@ID_Cat, ID_Fornecedor=@ID_Fornecedor where ID_Produto=@ID_Produto ";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);




            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InserirParametro()
        {
            try
            {
                SqlParameter[] listaParametro =
                 {
                    new SqlParameter("@ID_Produto", SqlDbType.Int){Value = _ID_Produto},
                    //new SqlParameter("@Data", SqlDbType.SmallDateTime) {Value = _Data_Produto},
                    new SqlParameter ("@QTDADE_PRODUTO", SqlDbType.Int) {Value = _QuantidadeEntrada}



                 };

                instrucaoSql = "update Produto set qtdeATUAL_Produto = qtdeATUAL_Produto + @QTDADE_PRODUTO where ID_Produto = @ID_Produto";


                c.ExecutarComandoParametro(instrucaoSql, listaParametro);





            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InserirParametroz(int qtde)
        {
            try
            {
                SqlParameter[] listaParametro =
                 {
                    new SqlParameter("@ID_Produto", SqlDbType.Int){Value = _ID_Produto}



                 };

                instrucaoSql = "update Produto set qtdeATUAL_Produto = qtdeATUAL_Produto + "+ qtde +" where ID_Produto = @ID_Produto";


                c.ExecutarComandoParametro(instrucaoSql, listaParametro);





            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IncluirEntrada()
        {
            try
            {
                SqlParameter[] listaParametro =
                 {
                    new SqlParameter("@ID_Produto", SqlDbType.Int){Value = _ID_Produto},
                    new SqlParameter("@Data", SqlDbType.SmallDateTime) {Value = _Data_Produto},
                    new SqlParameter ("@QTDADE_PRODUTO", SqlDbType.Int) {Value = _QuantidadeEntrada}



                 };

                instrucaoSql = "INSERT INTO ENTRADA_PRODUTO(ID_Produto, Data, QTDADE_PRODUTO) VALUES (@ID_Produto, @Data, @QTDADE_Produto)";


                c.ExecutarComandoParametro(instrucaoSql, listaParametro);





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
                    new SqlParameter("@ID_Produto",SqlDbType.Int) { Value= _ID_Produto }

                };

                instrucaoSql = "DELETE Produto WHERE ID_Produto=@ID_Produto";

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
                    new SqlParameter("@ID_Produto",SqlDbType.Int) { Value= _ID_Produto},
                    new SqlParameter("@Status_Produto", SqlDbType.Bit) {Value = _Status_Produto}
                    

                };

                instrucaoSql = "UPDATE Produto SET Status_Produto=1 WHERE ID_Produto =" + _ID_Produto;

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

     //   public DataSet ConsultarCategoria()
       // {
         ////////   try
            //{
            //    instrucaoSql = "Select * from "
            //}
            //catch (Exception ex)
            //{

            //    throw ex];
            //}
       // }
        public void DesativarParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@ID_Produto",SqlDbType.Int) { Value= _ID_Produto },
                    new SqlParameter("@Status_Produto", SqlDbType.Bit) { Value = _Status_Produto}


                };

                instrucaoSql = "UPDATE Produto SET Status_Produto=0 WHERE ID_Produto=" + _ID_Produto;

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
                instrucaoSql = "SELECT * FROM Produto WHERE ID_Produto=" + _ID_Produto;
                return c.RetornarDataReader(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet ListarForn(int ID_Fornecedor)
        {

            try
            {

                instrucaoSql = "SELECT ID_Produto, Nome_Produto, Descricao_Produto, Preco_Produto, qtdeATUAL_Produto, ID_Fornecedor,  ID_Cat, Status_Produto FROM Produto where ID_Fornecedor = " + ID_Fornecedor ;

                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarCat(int ID_Cat)
        {

            try
            {

                instrucaoSql = "SELECT ID_Produto, Nome_Produto, Descricao_Produto, Preco_Produto, qtdeATUAL_Produto, ID_Fornecedor,  ID_Cat, Status_Produto FROM Produto where ID_Cat = " + ID_Cat;

                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarProdVenda()
        {

            try
            {

                instrucaoSql = "SELECT ID_Produto, Nome_Produto FROM Produto where ID_Cat = " + _ID_Cat;

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

                instrucaoSql = "SELECT ID_Produto, Nome_Produto, Descricao_Produto, Preco_Produto, qtdeATUAL_Produto, ID_Fornecedor, ID_Cat, Status_Produto FROM Produto where Nome_Produto like '%" + parteNome + "%'";
                
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarEntrada()
        {
            try
            {
                instrucaoSql = "SELECT  ID_ENTRADA_PROD, ID_Produto, Data, QTDADE_PRODUTO from ENTRADA_PRODUTO";
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
                instrucaoSql = "SELECT ID_Produto, Nome_Produto, Descricao_Produto, Preco_Produto, qtdeATUAL_Produto, ID_Fornecedor, ID_Cat, Status_Produto FROM Produto WHERE Status_Produto=1";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ConsultarProduto(int idCat)
        {
            try
            {
                instrucaoSql = "SELECT * FROM Produto WHERE ID_Cat = " + idCat + " and Status_Produto = 1 ORDER BY Nome_Produto";
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public DataSet ConsultarProduto()
        {
            try
            {
                instrucaoSql = "SELECT * FROM Produto ORDER BY Nome_Produto";
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
                instrucaoSql = "SELECT ID_Produto, Nome_Produto, Descricao_Produto, Preco_Produto, qtdeATUAL_Produto , ID_Fornecedor, ID_Cat, Status_Produto FROM Produto WHERE Status_Produto = 0";
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

                    new SqlParameter("@ID_Produto", SqlDbType.Int) { Value= _ID_Produto },
                    new SqlParameter("@Nome_Produto",SqlDbType.VarChar) { Value= _Nome_Produto },
                    new SqlParameter("@Preco_Produto",SqlDbType.Decimal) { Value= _Preco_Produto },
                    new SqlParameter("@Descricao_Produto",SqlDbType.VarChar) { Value= _Descricao_Produto},
                    new SqlParameter("@qtdeATUAL_Produto",SqlDbType.Int) { Value= _qtdeATUAL_Produto },
                    //new SqlParameter("@qtdeMAX_Produto",SqlDbType.Int) { Value= _qtdeMAX_Produto },
                    //new SqlParameter("@qtdeMIN_Produto", SqlDbType.Int) {Value=_qtdeMIN_Produto },
                  //  new SqlParameter("@Status_Produto",SqlDbType.Bit) {Value= _Status_Produto },
                    new SqlParameter("@ID_Cat", SqlDbType.Int) {Value = _ID_Cat },
                    new SqlParameter("@ID_Fornecedor", SqlDbType.Int) {Value = _ID_Fornecedor},
                    //new SqlParameter("Data_Produto", SqlDbType.DateTime) {Value = _Data_Produto}
                   
                    



                };

                instrucaoSql = "INSERT INTO Produto ( Nome_Produto, Preco_Produto, Descricao_Produto, qtdeATUAL_Produto, ID_Cat, ID_Fornecedor ) VALUES(@Nome_Produto, @Preco_Produto, @Descricao_Produto, @qtdeATUAL_Produto, @ID_Cat, @ID_Fornecedor)";

                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public SqlDataReader ConsultarPreco()
        {
            try
            {
                instrucaoSql = "SELECT * FROM Produto  WHERE Nome_Produto= '" + _Nome_Produto +"'";
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void RecuperarDadosPro()
        {
            try
            {
                instrucaoSql = "SELECT * FROM Produto WHERE Nome_Produto= '" + _Nome_Produto+ "'";
                SqlDataReader ddr;
                ddr = c.RetornarDataReader(instrucaoSql);
                ddr.Read();
                if (ddr.HasRows)
                {
                    _Preco_Produto = Convert.ToDecimal(Convert.ToString(ddr[6]));
                    
                }
                else
                {
                    _Preco_Produto = Convert.ToDecimal("NÃO EXISTE ESTE PRODUTO");
                   
                   
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void RecuperarDadosProId()
        {

            try
            {
                instrucaoSql = "select (Preco_Produto) from Produto where ID_Produto =" + _ID_Produto;
                SqlDataReader dr;
                dr = c.RetornarDataReader(instrucaoSql);
                dr.Read();
                if (dr.HasRows)
                {
                    _Preco_Produto = Convert.ToDecimal(dr["Preco_Produto"]);
                }
                else
                {
                    _Preco_Produto = Convert.ToDecimal("NÃO EXISTE ESTE PRODUTO");

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Pr()
        {
            try
            {
                instrucaoSql = "SELECT  (qtdeATUAL_Produto)   from Produto where Nome_Produto =" + _Nome_Produto;
                SqlDataReader ddr;
                ddr = c.RetornarDataReader(instrucaoSql);
                ddr.Read();
                if (ddr.HasRows)
                {
                    _qtdeATUAL_Produto = Convert.ToInt32(ddr["qtdeATUAL_Produto"]);

                }
                else
                {
                    _qtdeATUAL_Produto = 0;


                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void RecuperarQuant()
        {
            try
            {
                instrucaoSql = "select (qtdeATUAL_Produto) from Produto where ID_Produto =" + _ID_Produto;
                SqlDataReader dr;
                dr = c.RetornarDataReader(instrucaoSql);
                dr.Read();
                if (dr.HasRows)
                {
                    _qtdeATUAL_Produto = Convert.ToInt32(dr["qtdeAtual_Produto"]);
                }
                else
                {
                    _qtdeATUAL_Produto = Convert.ToInt32("NÃO TEM ESSE PRODUTO NO ESTOQUE");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //public void Entrada()
        //{
        //    try
        //    {
        //        SqlParameter[] listaComParametros = {
        //        //new SqlParameter("@ID_Produto", SqlDbType.Int) { Value= _ID_Produto },
        //        new SqlParameter("@Data_Produto", SqlDbType.DateTime) { Value= _Data_Produto },
        //        new SqlParameter("@QuantEntrada_Produto", SqlDbType.Int) { Value= _QuantidadeEntrada }, };



        //        instrucaoSql = "Insert into Produto( Data_Produto, QuantEntrada_Produto) values (@Data_Produto, @QuantEntrada_Produto)";
        //        c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
        //    }

        //    catch (Exception ex)
        //    {

        //       throw ex;
        //    }
        //}

        //public void EntradaComParametro()
        //{
        //    try
        //    {
        //        SqlParameter[] listaComParametros = {
        //        new SqlParameter("@Nome_Produto", SqlDbType.VarChar) { Value = _Nome_Produto },
        //         //new SqlParameter("Data", SqlDbType.DateTime) { Value = _Data },
        //         //new SqlParameter("QuantidadeEntrada", SqlDbType.Int) {Value = _QuantidadeEntrada} };

        //        instrucaoSql = "update Produto set qtdeATUAL_Produto = @qtdeATUAL_Produto - (select QTDADE_Itens from ITENS_VENDA where ID_Produto = "+ _ID_Produto + " AND ID_Venda = @ID_Venda)where ID_Produto =  @ID_Produto";
        //        c.ExecutarComandoParametro(instrucaoSql, listaComParametros);






        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

    }










}













