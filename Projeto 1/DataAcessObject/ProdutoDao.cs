using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.VisualBasic;
using Projeto_1.Entidade.Produto;
using Projeto_1.Entidade.Cliente;
using Projeto_1.Entidade.Funcionario;

namespace Projeto_1.DataAcessObject
{
    public class ProdutoDao
    {
        public static List<Produto> ObterTodos()
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = "select * from produto;";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            DataSet pessoas = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(pessoas);
            List<Produto> lista = new List<Produto>();
           
            foreach (DataRow row in pessoas.Tables[0].Rows)
            {
                Produto a = new Entidade.Produto.Produto();
                a.Id = int.Parse(row["ID"].ToString());
                a.Nome = row["nome"].ToString();
                a.Unidades = int.Parse(row["unidade"].ToString());
                a.Preco = double.Parse(row["preco"].ToString());                
                a.Preco_venda = double.Parse(row["preco_venda"].ToString());
                lista.Add(a);
            }
            return lista;
        }

        public static Produto ObterPorNome(string nome)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"select * from produto where nome='{nome}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            Produto produto = new Entidade.Produto.Produto();
           
            foreach (DataRow row in data.Tables[0].Rows)
            {
                if (row["nome"].ToString() == nome)
                {
                    produto.Id = int.Parse(row["id"].ToString());
                    produto.Nome = row["nome"].ToString();
                    produto.Preco = double.Parse(row["preco"].ToString());
                    produto.Unidades = int.Parse(row["unidade"].ToString());
                    produto.Preco_venda = double.Parse(row["preco_venda"].ToString());
                    return produto;
                }
                else
                {
                    MessageBox.Show("Produto nao lozalizado", "falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return produto;
                }
            }
            return produto;
        }

        public static bool RemoverProduto(string nome)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"delete from produto where nome='{nome}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            int removeu = command.ExecuteNonQuery();

            if (removeu > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool InserirProduto(Produto produto)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"insert into produto (nome,unidade,preco,preco_venda) values ( '{produto.Nome}' , {produto.Unidades} , {produto.Preco.ToString().Replace(',','.')} , {produto.Preco_venda.ToString().Replace(',', '.')} ) ; " ;
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            int inseriu = command.ExecuteNonQuery();
            if (inseriu > 0)
            {
                MessageBox.Show("Produto cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao inserir o registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public static void EditarProduto(Entidade.Produto.Produto produto)
        {

            
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"update produto set nome='{produto.Nome}',unidade={produto.Unidades},preco={produto.Preco.ToString().Replace(',','.')},preco_venda={produto.Preco_venda.ToString().Replace(',', '.')} where id={produto.Id};";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);

            int inseriu = command.ExecuteNonQuery();
            if (inseriu > 0)
            {
                MessageBox.Show("Registro editado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Erro ao editar o registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public static void AbaterItemVendido(Produto produto)
        {
            
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"update produto set unidade = unidade - {produto.Unidades} where nome = '{produto.Nome}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            command.ExecuteNonQuery();


            
        }



    }

}

