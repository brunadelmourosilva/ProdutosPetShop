using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProdutosPetShop
{
    class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=vitoria1;database=prod_petshop");
        public string mensagem;

        public DataTable listaProdutos()
        {
            MySqlCommand cmd = new MySqlCommand("listaProdutos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conexao.Open();// conectando com o banco de dados
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //chama o objeto criado na conexão por meio de um canal de comunicação
                DataTable dados = new DataTable();
                da.Fill(dados);

                return dados;
            }
            catch (MySqlException erro)
            {
                mensagem = "Erro MySQL:" + erro.Message;
                return null;
            }
            finally
            {
                conexao.Close();//fecha banco de dados
            }
        }
        //-------------------------------------------------------


    }
}
