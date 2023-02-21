using ConexaoBD;
using Npgsql;
using Projeto_1.Entidade.Cliente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject
{
    public class ClienteDao
    {
        public static List<Cliente> ObterTodos()
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = "select * from cliente;";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            DataSet pessoas = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

            adapter.Fill(pessoas);
            List<Cliente> lista = new List<Cliente>();
            foreach (DataRow row in pessoas.Tables[0].Rows)
            {
                Cliente a = new Projeto_1.Entidade.Cliente.Cliente();
                a.Id = int.Parse(row["ID"].ToString());
                a.Nome = row["nome"].ToString();
                a.CPF = row["cpf"].ToString();
                a.Email = row["email"].ToString();
                a.Cidade = row["cidade"].ToString();
                a.Estado = row["estado"].ToString();
                a.Data_Registro = DateTime.Parse(row["data_registro"].ToString());
               
                lista.Add(a);
                //DateTime.Parse(a.Data_Registro).ToString("dd/MM/yyyy")

            }
            return lista;
        }
       
        public static Cliente ObterPorNome(string nome)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"select * from cliente where nome='{nome}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            Cliente cliente = new Projeto_1.Entidade.Cliente.Cliente();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                if (row["nome"].ToString() == nome)
                {
                    cliente.Id = int.Parse(row["id"].ToString());
                    cliente.Nome = row["nome"].ToString();
                    cliente.CPF = row["cpf"].ToString();
                    cliente.Email = row["email"].ToString();
                    cliente.Cidade = row["cidade"].ToString();
                    cliente.Estado = row["estado"].ToString();
                    cliente.Data_Registro = DateTime.Parse(row["data_registro"].ToString());
                    return cliente;

                }
                else
                {
                    MessageBox.Show("cliente nao lozalizado", "falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return cliente;
                }

            }
            return cliente;
        }
    
        public static bool RemoverCliente(string nome)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"delete from cliente where nome='{nome}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            int removeu = command.ExecuteNonQuery();
            
            if(removeu > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public static bool InserirCliente(Cliente cliente)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"insert into cliente (nome,cpf,email,cidade,estado) values ('{cliente.Nome}','{cliente.CPF}','{cliente.Email}','{cliente.Cidade}','{cliente.Estado}');";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            
            int inseriu = command.ExecuteNonQuery();
            if (inseriu > 0)
            {
                MessageBox.Show("Cliente inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao inserir o registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            

        }

        public static bool EditarCliente(Cliente cliente,int id)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"update cliente set nome='{cliente.Nome}',cpf='{cliente.CPF}',email='{cliente.Email}',cidade='{cliente.Cidade}',estado='{cliente.Estado}' where id='{id}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);

            int inseriu = command.ExecuteNonQuery();
            if (inseriu > 0)
            {
                MessageBox.Show("Registro editado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao editar o registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
        }
    
    
    
    }


}
