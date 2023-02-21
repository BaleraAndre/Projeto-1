using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Data;
using Npgsql;
using System.Data.Common;
using Projeto_1.Entidade.Gastos;

namespace Projeto_1.DataAcessObject
{
    public class GastosDao
    {
        public static void CriarArquivoDeGasto()
        {
            string path = @"C:\Users\andre\OneDrive\Área de Trabalho\andre\Projeto 1\Gasto.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                return;
            }
            else
            {
                return;
            }

        }




        public static void RegistrarGasto(Gastos gasto)
        {

            CriarArquivoDeGasto();
            string path = @"C:\Users\andre\OneDrive\Área de Trabalho\andre\Projeto 1\Gasto.json";
            StreamWriter stream = new StreamWriter(path);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(stream, gasto);
            stream.Close();


        }

        public static List<Gastos> TodosOsGastos()
        {
            List<Gastos> gastos = new List<Gastos>();
            NpgsqlConnection conection = ConexaoBD.ConexaoBD.ObterConexao();

            string sql = "select * from gastos;";
            DataSet data = new DataSet();
            NpgsqlCommand command = new NpgsqlCommand(sql, conection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(data);

            foreach (DataRow row in data.Tables[0].Rows)
            {
                Gastos gasto = new Entidade.Gastos.Gastos();
                gasto.Descricao = row["descricao"].ToString();
                gasto.Valor = double.Parse(row["valor"].ToString());
                gasto.Data_Gasto = DateTime.Parse(row["data_gasto"].ToString());
                gastos.Add(gasto);

            }
            return gastos;

        }

        public static List<Gastos> TodosOsGastosDoMes(int mes, int ano)
        {
            List<Gastos> gastos = new List<Gastos>();

            NpgsqlConnection conection = ConexaoBD.ConexaoBD.ObterConexao();

            string sql = $"select * from gastos WHERE data_gasto BETWEEN '{ano}-{mes}-01' AND '{ano}-{mes}-31';";
            DataSet data = new DataSet();
            NpgsqlCommand command = new NpgsqlCommand(sql, conection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(data);

            foreach (DataRow row in data.Tables[0].Rows)
            {
                Gastos gasto = new Entidade.Gastos.Gastos();
                gasto.Descricao = row["descricao"].ToString();
                gasto.Valor = double.Parse(row["valor"].ToString());
                gasto.Data_Gasto = DateTime.Parse(row["data_gasto"].ToString());
                gastos.Add(gasto);

            }

            return gastos;


        }




    }
}
