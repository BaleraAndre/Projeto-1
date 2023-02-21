using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.IO;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Projeto_1.Configuracao;

namespace ConexaoBD
{
    public class ConexaoBD
    {
        public static NpgsqlConnection ObterConexao()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory+"appConfig.txt";
            Projeto_1.Configuracao.ArquivoDeConfiguracao.SetConfig();
            StreamReader reader = new StreamReader(path);
            
            
            ArquivoDeConfiguracao a = new ArquivoDeConfiguracao();
            
            string conection = reader.ReadToEnd().ToString();
            NpgsqlConnection conect = new NpgsqlConnection(conection);
            reader.Close();
            conect.Open();
            return conect;
        }








    }
}
