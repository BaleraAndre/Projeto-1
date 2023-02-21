using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_1.Entidade.Produto;

namespace Projeto_1.RegrasDeNegocio
{
    public class Venda
    {
        public static bool ChecarDisponibilidadeProduto(string nome, string quant)
        {
            int quantidade = int.Parse(quant);
            List<Produto> lista = new List<Produto>();
            lista = DataAcessObject.ProdutoDao.ObterTodos();
            foreach (Produto prod in lista)
            {
                if (prod.Nome == nome)
                {
                    if (prod.Unidades >= quantidade)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade insuficiente em estoque", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                }


            }
            MessageBox.Show("Produto nao localizado", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;

        }

        public static bool FinalizarVenda(List<Produto> lista)
        {
            foreach (Produto prod in lista)
            {
                Projeto_1.Venda.Venda venda = new Projeto_1.Venda.Venda();
                DataAcessObject.ProdutoDao.AbaterItemVendido(prod);
                venda.Descricao = prod.Nome;
                venda.Valor = prod.Preco;
                venda.Unidade = prod.Unidades;
                DataAcessObject.VendaDao.InserirVenda(venda);
               

            }
            return true;
        }




        
    }
}
