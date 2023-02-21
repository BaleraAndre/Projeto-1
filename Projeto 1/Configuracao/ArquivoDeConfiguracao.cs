using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Projeto_1.Configuracao
{
    public class ArquivoDeConfiguracao
    {
        public string Server;
        public string Port;
        public string DataBase;
        public string User_ID;
        public string Password;



        public static bool CriarArquivoDeConfig()
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + "appConfig.txt";
            

            if (!File.Exists(path))
            {
                File.Create(path);
                return true;
            }
            else
            {                
                return true;
            }
            


        }
        public static void SetConfig()
        {
            CriarArquivoDeConfig();
            string path = AppDomain.CurrentDomain.BaseDirectory + "appConfig.txt";

            StreamWriter stream = new StreamWriter(path);
            JsonSerializer serializer= new JsonSerializer();
            
            ArquivoDeConfiguracao arqconf = new ArquivoDeConfiguracao();
            arqconf.Server = "SEUS DADOS AQUI";
            arqconf.Port = "SEUS DADOS AQUI";
            arqconf.DataBase = "SEUS DADOS AQUI";
            arqconf.User_ID = "SEUS DADOS AQUI";
            arqconf.Password = "SEUS DADOS AQUI";

            string conexaoBD = $"Server={arqconf.Server};Port={arqconf.Port};Database={arqconf.DataBase};User ID={arqconf.User_ID};Password={arqconf.Password}";
            
            stream.Write(conexaoBD);
           
            stream.Close();
        }


    }
}

