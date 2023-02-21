using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_1.Entidade.Produto;

namespace Projeto_1.Forms.FormProduto
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            CarregarGrid();
  
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto prd = new Entidade.Produto.Produto();
            Forms.FormProduto.FormProdutoSecundario form = new FormProdutoSecundario(prd);
            form.ShowDialog();
            dgvProduto.Rows.Clear();
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            List<Produto> lista = new List<Produto>();
            lista = DataAcessObject.ProdutoDao.ObterTodos();
            foreach (Produto prod in lista)
            {
                dgvProduto.Rows.Add(prod.Id, prod.Nome, prod.Unidades, prod.Preco.ToString(), prod.Preco_venda.ToString());

            }
            int totalrows = dgvProduto.Rows.Count;
            int numeroDeRows = totalrows - 1;
            for (int i = 0; i < numeroDeRows; i++)
            {
                if ((int)dgvProduto.Rows[i].Cells[2].Value == null)
                {
                    return;
                }
                else if ((int)dgvProduto.Rows[i].Cells[2].Value > 10)
                {
                    dgvProduto.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else if ((int)dgvProduto.Rows[i].Cells[2].Value < 10 && (int)dgvProduto.Rows[i].Cells[2].Value > 5)
                {
                    dgvProduto.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
                
                else
                {
                    dgvProduto.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto prod = new Entidade.Produto.Produto();
            prod.Id = int.Parse(dgvProduto.SelectedRows[0].Cells[0].Value.ToString());
            prod.Nome = dgvProduto.SelectedRows[0].Cells[1].Value.ToString();
            prod.Unidades = int.Parse(dgvProduto.SelectedRows[0].Cells[2].Value.ToString());
            prod.Preco = double.Parse(dgvProduto.SelectedRows[0].Cells[3].Value.ToString());
            prod.Preco_venda = double.Parse(dgvProduto.SelectedRows[0].Cells[4].Value.ToString());
            Forms.FormProduto.FormProdutoSecundario form = new FormProdutoSecundario(prod);
            form.ShowDialog();
            dgvProduto.Rows.Clear();
            CarregarGrid();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            Produto p = DataAcessObject.ProdutoDao.ObterPorNome(nome);
            if (p.Id > 0)
            {
                Forms.FormProduto.FormProdutoSecundario form = new FormProdutoSecundario(p);
                form.ShowDialog();
                dgvProduto.Rows.Clear();
                CarregarGrid();

            }
            else
            {
                MessageBox.Show("Produto nao localizado", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
