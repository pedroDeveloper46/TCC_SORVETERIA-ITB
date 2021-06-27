using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //Trabalhar com dados desconectados
using System.Data.SqlClient; //Informar que estou trabalhando com data provider para o banco de dados SQL SERVER


namespace DAO_SORVETERIA
{
    public class ClasseParaManipularBancoDeDados
    {
        private static SqlConnection cn;
        //criar objeto 'cn' que representa a classe SQLCONNECTION. Esse objeto será usado para abrir (OPEN), fechar (CLOSE) e verificar o estado (STATE) do banco de dados. Para funcionar corretamente será necessário informar a string de conexão ao banco de dados (texto contendo computador-nome-usuario-senha). Esse objeto é privativo da classe e estára estático na memória RAM
        private static SqlCommand cmd;
        //criar objeto 'cmd' que representa a classe SQLCOMMAND. Esse objeto será usado para executar (EXECUTE) uma instrução junto ao banco de dados que utiliza os comandos INSERT, UPDATE, DELETE, SELECT, etc. - 'cmd' representa a execução do comando
        private static SqlDataReader dr;
        //criar objeto 'dr' que representa a classe SQLDATAREADER. Esse objeto é um leitor de dados de uma tabela. É utilizado para as situações: 1.LER TODOS OS DADOS DE UMA TABELA e de posse desses dados utilizar em COMBOBOX ou LISTBOX preenchendo com dados estas listas    2.LER OS DADOS DE UMA LINHA DE UMA TABELA (operação de consulta) ex. preciso saber o endereço da aluna LARISSA Rm 26967 e apresentar esses dados em TEXTBOXs (rua, cidade, bairro, etc.)          O DATAREADER é mais rápido que um DATASET
        private static SqlDataAdapter da;
        //criar objeto 'da' que representa a classe SQLDATAADAPTER. Esse objeto é uma ligação/ponte entre o banco de dados (conectado) com o dataset (desconectado). Segundo alguns alunos é como se fosse um cabo usb. Ele vai usar uma 'cn' + 'cmd' para preencher (FILL) um dataset
        private static DataSet ds;
        //criar objeto 'ds' que representa a classe DATASET. Esse objeto pode conter todas as tabelas, relações e visões do meu banco de dados. Para existir um 'ds' é necessário DATAADAPTER + COMMAND + CONNECTION. Vamos utilizar um 'ds' para preencher um DATAGRIDVIEW ou TREEVIEW (tipo windows explorer) com os dados de uma tabela dando ao usuário uma visão completa da tabela de dados.
        private static DataTable dt;
        //criar objeto 'dt' que representa a classe DATATABLE. Esse objeto representa uma tabela. para existir um 'dt' é necessário DATAADAPTER + COMMAND + CONNECTION.
        private static string instrucaoSql;
        //criar a variável 'instrucaoSql' que irá conter o texto do comando a ser utilizado pelo 'cmd'. Esse texto tem origem nos comandos das aulas de banco de dados.
        //private static string stringConexao = "server= DESKTOP-HHTQE0C\SQLEXPRESS01;database=Sorveteria_TCC2; user id=sa; password=123456;";
        private static string stringConexao = "server= DESKTOP-HHTQE0C\\SQLEXPRESS01;database=TELEMETRIA; user id=sa; password=123456;";
        //criar a variável 'stringconexao' que contém o texto que representa o computador onde está o banco de dados(provider), o nome do banco de dados(database), o usuario(user id, no caso sa-system administrator) e senha(password). Para conhecer e saber mais sobre strings de conexão visitinha básica no site https://www.connectionstrings.com/ 

        public static SqlConnection ConectarBanco()
        {
            try
            {
                cn = new SqlConnection(stringConexao);
                //objeto 'cn' é instanciado. Instanciar [ = new]  é definir alguns valores/parametros para o objeto.. é criar o objeto para ser usado
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //testar o estado (STATE) da conexão 'cn' para verificar se está (==) fechada (CLOSED). Sendo verdadeiro este teste a conexão com o banco de dados será aberta (OPEN)
                return cn;
                //retorna a conexao
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void FecharBanco(SqlConnection minhaConexao)
        {
            try
            {
                if (minhaConexao.State == ConnectionState.Open)
                {
                    minhaConexao.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static string infoBanco()
        {
            try
            {
                string msg = "";
                //variavel 'msg' que será usada para retornar a mensagem
                cn = new SqlConnection(stringConexao);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    msg = "versao " + cn.ServerVersion + " fonte de dados " + cn.DataSource + ".";
                     
                }
                return msg;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader RetornarDataReader(string instrucaoSelecionar)
        {
            try
            {
                cmd = new SqlCommand(instrucaoSelecionar, ConectarBanco());
                //objeto 'cmd' é instanciado com a 'instrucaoSelecionar' que representa o comando 'SELECT * FROM MINHATABELA' que você irá aprender em LIEC. Para usar o comando é preciso 'ConectarBanco'
                dr = cmd.ExecuteReader();
                //objeto 'dr' recebe o resultado da leitura (ExecuteReader) dos dados da tabela. Lembre-se que a tabela pode ter 0(zero) linha ou várias linhas de dados. Um 'dr' pode ser usado para PREENCHER com dados um LISTBOX ou COMBOBOX ou para apresentar em TEXTBOX o dado de uma coluna da tabela
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RetornarDataTable(string instrucao)
        {
            try
            {
                dt = new DataTable();
                cmd = new SqlCommand(instrucao, ConectarBanco());
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                //objeto 'da' preenche (FILL) o objeto 'dt' com dados do banco de dados. Segundo alguns alunos o FILL é como se fosse TRANSFERIR DADOS usando o cabo USB. Lembre-se 'da' é ponte/ligação CONECTADO/DESCONECTADO
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet RetornarDataSet(string instrucao)
        {
            try
            {
                ds = new DataSet();
                cmd = new SqlCommand(instrucao, ConectarBanco());
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
                //objeto 'ds' pode representar todas as tabelas, relações entre tabelas, visões(novas) tabelas que estão no banco de dados. o 'ds' pode ser usado para um DATAGRIDVIEW

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExecutarComando(string instrucao)
        {
            try
            {
                //a entrada 'instrucao' é um comando escrito para o banco de dados. Esse comando pode ser INSERT-inserir/UPDATE-atualizar/DELETE-excluir   uma linha de dados na tabela do banco de dados
                cmd = new SqlCommand(instrucao, ConectarBanco());
                cmd.ExecuteNonQuery();
                //a ação(método) 'ExecuteNonQuery' é usada pelo objeto 'cmd' para EXECUTAR o comando no banco de dados
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Int32 RetornarContagem(string instrucao)
        {
            try
            {
                //esse método será usado para responder algumas perguntas sobre os dados que temos nas tabelas. A entrada 'instrucao' é algo do tipo 'SELECT COUNT(coluna) FROM TABELA GROUPY BY coluna'--isso você irá aprender em LIEC
                cmd = new SqlCommand(instrucao, ConectarBanco());
                return Convert.ToInt32(cmd.ExecuteScalar());
                //convert.toint32 = converter um dado para número inteiro de 32bits    o método 'ExecuteScalar' executa a 'instrução' e o dado gerado é único. Lembre-se 'quantos alunos temos na turma INF2CM'

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public double RetornarTotal(string instrucao)
        {
            try
            {
                cmd = new SqlCommand(instrucao, ConectarBanco());
                //'instrucao' contém a função SUM() aula de LIEC
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public double RetornarMenorValor(string instrucao)
        {
            try
            {
                cmd = new SqlCommand(instrucao, ConectarBanco());
                //objeto 'cmd' instanciado '=new' com a 'instrucao'    +   'conectarbanco()'     'instrucao' contém a função de agrupamento MIN()  LIEC
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public double RetornarMaiorValor(string instrucao)
        {
            try
            {
                cmd = new SqlCommand(instrucao, ConectarBanco());
                //'instrucao' contém a função MAX() LIEC
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ObterNumeroAutomaticoInserir(string instrucao)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = instrucao;
                //propriedade '.commandtext' é definida (=) com a 'instrucao'
                cmd.CommandType = CommandType.Text;
                //propriedade '.comandtype' é definido (=) como um comando de texto
                cmd.Connection = ConectarBanco();
                //propriedade '.connection' é definido (=) com o método 'conectarbanco()' para abrir o banco de dados
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                //'select @@identity' para obter a numeração automatica quando inserimos uma linha na tabela (LIEC)
                dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
                //coluna [0] contém a numeração automatica

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlParameter CriarParametro(string nomeParametro, SqlDbType tipoParametro, object valorParametro)
        {
            try
            {
                SqlParameter p = new SqlParameter();
                //objeto 'p' criado e também é instanciado (=new)
                p.ParameterName = nomeParametro;
                //.parametername é uma propriedade do meu objeto 'p'. Essa propriedade recebe (=) o 'nomeparametro'
                p.SqlDbType = tipoParametro;
                //.sqldbtype é uma propriedade do objeto 'p'. Essa propriedade recebe (=) o 'tipoparametro'
                if ((valorParametro == null) || (tipoParametro == SqlDbType.Char && valorParametro.ToString().Length == 0))
                {
                    p.Value = DBNull.Value;
                    //a propriedade '.value' do objeto 'p' recebe (=) o valor nulo
                }
                else
                {
                    p.Value = valorParametro;
                    //propridade .value do objeto 'p' recebe (=) o valor do parametro
                }
                return p;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExecutarComandoParametro(string instrucao, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = instrucao;
                //propriedade '.commandtext' recebe (=) a 'instrucao'
                cmd.CommandType = CommandType.Text;
                //propriedade '.commandtype' recebe (=) um comando do tipo texto
                if (listaParametros != null)
                {
                    //testar a lista de parametros para saber se ela não é nula (!=), ou seja, tem algo dentro da lista
                    foreach (SqlParameter item in listaParametros)
                    {
                        cmd.Parameters.Add(item);
                        //foreach - para cada    objeto 'item' do tipo 'sqlparameter' na minha 'listaparametros' vamos '.add' adicionar o 'item' aos '.parameters' do objeto 'cmd'
                    }
                }
                cmd.Connection = ConectarBanco();
                //propriedade '.connection' do objeto de 'cmd' recebe (=) o método 'conectarbanco'
                cmd.ExecuteNonQuery();
                //executa o comando

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExecutarStoredProcedureParametro(string nomeProcedure, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (SqlParameter item in listaParametros)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                cmd.Connection = ConectarBanco();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            } }



    }
}
