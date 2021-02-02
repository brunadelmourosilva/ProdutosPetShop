using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdutosPetShop
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }
        void listaProdutos()
        {
            //chamando o banco no formulário com instância da calsse
            ConectaBanco con = new ConectaBanco();
            dgProdutos.DataSource = con.listaProdutos(); //DataGridView

            dgProdutos.Columns["idProduto"].Visible = false;
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            //quando abrir o formulário, chama a função listaProdutos
            listaProdutos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //adicionando transição de um botão para outro através de um panel(marcadorLateral)
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcadorLateral.Height = btnCadastra.Height;
            marcadorLateral.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcadorLateral.Height = btnBusca.Height;
            marcadorLateral.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }
    }
}
