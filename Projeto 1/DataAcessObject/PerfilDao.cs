using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Projeto_1.Entidade.Perfil;

namespace Projeto_1.DataAcessObject
{
    public class PerfilDao
    {
        public static bool LogIn(Perfil perfil)
        {
            string path = @"C:\Users\andre\OneDrive\Área de Trabalho\andre\CriptoMD5.json";
            JsonSerializer serializer = new JsonSerializer();
            string json;           
            StreamReader stream = new StreamReader(path);
            json = stream.ReadToEnd();          
            Perfil per = new Entidade.Perfil.Perfil();
            per = Newtonsoft.Json.JsonConvert.DeserializeObject<Perfil>(json);
            bool comparar;
            Perfil perfilmd5 = new Entidade.Perfil.Perfil();
            perfilmd5 = Criptografia.Criptografia.CriptoGrafarPerfil(perfil);
            if (per._autenticacao ==  perfilmd5._autenticacao && per._identificacao == perfilmd5._identificacao) 
            {
                MessageBox.Show("LOGADO");
                return true;
            }
            else
            {
                MessageBox.Show("USUARIO OU SENHA INVALIDOS");
                return false;
            }

           
        }

        public static bool SalvarPerfil(Perfil perfil)
        {
            Perfil per = new Entidade.Perfil.Perfil();
            per = Criptografia.Criptografia.CriptoGrafarPerfil(perfil);
            string path = @"C:\Users\andre\OneDrive\Área de Trabalho\andre\CriptoMD5.json";
            JsonSerializer serializer = new JsonSerializer();
            StreamWriter stream = new StreamWriter(path);
            serializer.Serialize(stream, per);
            stream.Close();
            return true;

        }
    }
}
