using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProdutosPetShop
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //adicionando transição de um botão para outro através de um panel(marcadorLateral)
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcadorLateral.Height = btnCadastra.Height;
            marcadorLateral.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0]; //tabPage na posição 0
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcadorLateral.Height = btnBusca.Height;
            marcadorLateral.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1]; //tabPage na posição 1
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //falta arrumar o botão(alterar) da lateral
        }
        /*---------------------------------------------------------------*/
        private void btnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            //set dos campos à classe Produto
            Produto produto = new Produto();

            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Marca = txtMarca.Text;
            produto.Quant = Convert.ToInt32(txtQtd.Text);
            produto.ValorCompra = Convert.ToSingle(txtValorCompra.Text);
            produto.ValorVenda = Convert.ToSingle(txtValorUni.Text);

            ConectaBanco con = new ConectaBanco();
            bool r = con.cadastraProdutos(produto);

            if(r == true) MessageBox.Show("Produto inserido com sucesso!");
            else MessageBox.Show("Error " + con.mensagem);

            listaProdutos();
            formClear();
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {

        }
        private void btnConfirmaRemocao_Click(object sender, EventArgs e)
        {

        }
        /*---------------------------------------------------------------*/
        
        //função para limpar o form após o cadastro
        void formClear()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtMarca.Clear();
            txtQtd.Clear();
            txtValorCompra.Clear();
            txtValorUni.Clear();
            txtNome.Focus();
        }
        void listaProdutos()
        {
            //chamando o banco no formulário com instância da calsse
            ConectaBanco con = new ConectaBanco();
            dgProdutos.DataSource = con.listaProdutos(); //DataGridView

            //dgProdutos.Columns["idProduto"].Visible = false; //está dando erro
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            //quando abrir o formulário, é chamada a função listaProdutos
            listaProdutos();
        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
