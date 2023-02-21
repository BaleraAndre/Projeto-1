using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Projeto_1.Entidade.Produto;
using Projeto_1.Entidade.Funcionario;

namespace Projeto_1.Forms.FormProduto
{
    public partial class FormProdutoSecundario : Form
    {
        public FormProdutoSecundario(Produto produto)
        {
            InitializeComponent();
            if (produto.Id > 0 && produto.Nome.Length > 0 && produto.Preco > 0)
            {
                lblID.Text = produto.Id.ToString();
                txtNome.Text = produto.Nome;
                nudPreco.Value = (decimal)produto.Preco;
                nudUnidade.Value = (int)produto.Unidades;
                nudPreco_venda.Value = (decimal)produto.Preco_venda;
                btnadicionar.Visible = false;
            }
            else
            {
                lblID.Visible = false;
                btnremover.Visible = false;
                btnEditar.Visible = false;
            }

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new Entidade.Produto.Produto();
            produto.Nome = txtNome.Text;
            produto.Unidades = int.Parse(nudUnidade.Value.ToString());
            produto.Preco = double.Parse(nudPreco.Value.ToString());
            produto.Preco_venda = double.Parse(nudPreco_venda.Value.ToString());
            DataAcessObject.ProdutoDao.InserirProduto(produto);
            this.Close();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            DataAcessObject.ProdutoDao.RemoverProduto(txtNome.Text);
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Entidade.Produto.Produto produto = new Entidade.Produto.Produto();
            produto.Id = int.Parse(lblID.Text.ToString());
            produto.Nome = txtNome.Text;
            produto.Unidades = (int)nudUnidade.Value;
            produto.Preco = (double)nudPreco.Value;
            produto.Preco_venda = double.Parse(nudPreco_venda.Value.ToString().Replace('.', ','));

            DataAcessObject.ProdutoDao.EditarProduto(produto);
            this.Close();
        }
    }
}

