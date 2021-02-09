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
        /*---------------------------------------------------------------*/
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
                mensagem = "MySql Error: " + erro.Message;
                return null;
            }
            finally
            {
                conexao.Close();//fecha banco de dados
            }
        }
        /*---------------------------------------------------------------*/
        //instância da classe Produto
        public bool cadastraProdutos(Produto produto)
        {
            MySqlCommand cmd = new MySqlCommand("cadastraProdutos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            //definindo parâmetros da StoredProcedure com modificadores de acesso da classe Produto
            cmd.Parameters.AddWithValue("nome", produto.Nome);
            cmd.Parameters.AddWithValue("descricao", produto.Descricao);
            cmd.Parameters.AddWithValue("marca", produto.Marca);
            cmd.Parameters.AddWithValue("quant", produto.Quant);
            cmd.Parameters.AddWithValue("valorCompra", produto.ValorCompra);
            cmd.Parameters.AddWithValue("valorVenda", produto.ValorVenda);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = "MySql Error: " + erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }



        }


    }
}
