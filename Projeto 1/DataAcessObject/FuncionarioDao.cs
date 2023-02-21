using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Projeto_1.Entidade.Funcionario;

namespace Projeto_1.DataAcessObject
{
    public class FuncionarioDao
    {
        public static List<Funcionario> ObterTodos()
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = "select * from funcionario;";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            DataSet pessoas = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

            adapter.Fill(pessoas);
            List < Funcionario> lista = new List<Funcionario>();
            foreach (DataRow row in pessoas.Tables[0].Rows)
            {
                Funcionario a = new Entidade.Funcionario.Funcionario();
                a.Id = int.Parse(row["ID"].ToString());
                a.Nome = row["nome"].ToString();
                a.Cpf = row["cpf"].ToString();
                a.Email = row["email"].ToString();
                a.Salario = double.Parse(row["salario"].ToString());
                a.Data_Registro =DateTime.Parse(row["data_registro"].ToString());
                lista.Add(a);
                //DateTime.Parse(a.Data_Registro).ToString("dd/MM/yyyy")

            }
            return lista;
        }

        public static Funcionario ObterPorNome(string nome)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"select * from funcionario where nome='{nome}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            Funcionario funcionario = new Entidade.Funcionario.Funcionario();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                if (row["nome"].ToString() == nome)
                {
                    funcionario.Id = int.Parse(row["id"].ToString());
                    funcionario.Nome = row["nome"].ToString();
                    funcionario.Cpf = row["cpf"].ToString();
                    funcionario.Email = row["email"].ToString();
                    funcionario.Salario = double.Parse(row["salario"].ToString());
                    funcionario.Data_Registro = DateTime.Parse(row["data_registro"].ToString());
                    return funcionario;

                }
                else
                {
                    MessageBox.Show("cliente nao lozalizado", "falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return funcionario;
                }

            }
            return funcionario;
        }

        public static bool RemoverFuncionario(string nome)
        {
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"delete from funcionario where nome='{nome}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);
            int removeu = command.ExecuteNonQuery();

            if (removeu > 0)
            {
                MessageBox.Show("funcionario removido","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Falha ao remover registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static bool InserirFuncionario(Funcionario funcionario)
        {
            
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"insert into funcionario (nome,cpf,email,salario) values ('{funcionario.Nome}','{funcionario.Cpf}','{funcionario.Email}',{funcionario.Salario.ToString().Replace(',','.')});";
            NpgsqlCommand command = new NpgsqlCommand(sql, conect);

            int inseriu = command.ExecuteNonQuery();
            
            if (inseriu > 0)
            {
                MessageBox.Show("Funcionario inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao inserir o registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


        }

        public static bool EditarFuncionario(Funcionario funcionario,int id)
        {
            string salario = funcionario.Salario.ToString().Replace(',','.');
            NpgsqlConnection conect = ConexaoBD.ConexaoBD.ObterConexao();
            string sql = $"update funcionario set nome='{funcionario.Nome}',cpf='{funcionario.Cpf}',email='{funcionario.Email}',salario={salario.ToString()} where id='{id}';";
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
