using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1.DataAcessObject
{
    public class VendaDao
    {
        public static List<Venda.Venda> ObterTodas()
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = "select * from venda;";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            DataSet pessoas = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(pessoas);
            List<Venda.Venda> lista = new List<Venda.Venda>();

            foreach (DataRow row in pessoas.Tables[0].Rows)
            {
                Venda.Venda a = new Venda.Venda();
                a.Descricao = row["descricao"].ToString();
                a.Valor = double.Parse(row["valor"].ToString());
                a.Unidade = int.Parse(row["unidade"].ToString());               
                a.Data_venda = DateTime.Parse(row["data"].ToString());
                lista.Add(a);
            }
            return lista;
        }

        public static List<Venda.Venda> ObterTodasDoMes(int mes , int ano)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"select * from venda WHERE data BETWEEN '{ano}-{mes}-01' AND '{ano}-{mes}-31';";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            DataSet pessoas = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(pessoas);
            List<Venda.Venda> lista = new List<Venda.Venda>();

            foreach (DataRow row in pessoas.Tables[0].Rows)
            {
                Venda.Venda a = new Venda.Venda();
                a.Descricao = row["descricao"].ToString();
                a.Valor = double.Parse(row["valor"].ToString());
                a.Unidade = int.Parse(row["unidade"].ToString());
                a.Data_venda = DateTime.Parse(row["data"].ToString());
                lista.Add(a);
            }
            return lista;
        }

       
        

        public static bool InserirVenda(Venda.Venda venda)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"insert into venda (descricao,valor,unidade) values ('{venda.Descricao}',{venda.Valor.ToString().Replace(',','.')},{venda.Unidade});";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            int inseriu = command.ExecuteNonQuery();
            if (inseriu > 0)
            {
          
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao inserir o registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

       

        
    }
}
