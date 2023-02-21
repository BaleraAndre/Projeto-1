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

namespace Projeto_1.Forms.Venda
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }

        private void btnAddCarrinho_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(nudUnidade.Value.ToString());
               
            }
            catch 
            { 
                MessageBox.Show("digite apenas numeros inteiros para unidade");
                return;
            }
            
            bool valido = Projeto_1.RegrasDeNegocio.Venda.ChecarDisponibilidadeProduto(txtNomeProduto.Text, nudUnidade.Value.ToString());
            if (valido)
            {
                Entidade.Produto.Produto produto = new Produto();
                produto = DataAcessObject.ProdutoDao.ObterPorNome(txtNomeProduto.Text);

                dgvVenda.Rows.Add(produto.Nome, nudUnidade.Value.ToString(),produto.Preco_venda.ToString()); 

               
                txtNomeProduto.Text = string.Empty;
               
                nudUnidade.Value = 0;
            }
            else
            {
                return;
            }
        }

        private void dgvVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            txtNomeProduto.Text = dgvVenda.SelectedRows[0].Cells[0].Value.ToString();
            
            nudUnidade.Value = (int)dgvVenda.SelectedRows[0].Cells[1].Value;
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            int unidades;
            List<Produto> lista = new List<Produto>();
            foreach (DataGridViewRow row in dgvVenda.Rows)
            {

                if (row.Cells[0].Value != null)
                {
                    Produto produto = new Entidade.Produto.Produto();
                    produto = DataAcessObject.ProdutoDao.ObterPorNome(row.Cells[0].Value.ToString());
                    
                    
                    lista.Add(produto);
                }
              

            }
            Projeto_1.RegrasDeNegocio.Venda.FinalizarVenda(lista);
            dgvVenda.Rows.Clear();
            MessageBox.Show("VENDA REALIZADA");
        }

        private void btnLimparCarrinho_Click(object sender, EventArgs e)
        {
            dgvVenda.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto_1.Forms.FormVenda.FormSangria form = new Forms.FormVenda.FormSangria();
            form.ShowDialog();
        }
    }
}
