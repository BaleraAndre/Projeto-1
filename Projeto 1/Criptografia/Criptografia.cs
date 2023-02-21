using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Newtonsoft.Json.Serialization;
using Projeto_1.Entidade.Perfil;

namespace Projeto_1.Criptografia
{
    public class Criptografia
    {

        public static Perfil CriptoGrafarPerfil(Perfil perfil)
        {
            Perfil perfil1 = new Entidade.Perfil.Perfil();
            perfil1._autenticacao = RetornarMD5(perfil._autenticacao);
            perfil1._identificacao = RetornarMD5(perfil._identificacao);

            return perfil1;

        }



        public static bool CriarArqCrip()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "CriptoMD5.json";

            if (!File.Exists(path))
            {
               File.Create(path);
               StreamWriter stream = new StreamWriter(path);
                stream.Close();
                return true;
            } 
            
            return true;

        }



        public static string RetornarHash(MD5 hashmd5, string input)
        {
            byte[] data = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sbuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sbuilder.Append(data[i].ToString("X2"));
            }
            return sbuilder.ToString();

        }

        public static string RetornarMD5(string Senha)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return RetornarHash(md5Hash, Senha);
            }
        }

        public static bool VerificarHash(string input, string Hash)
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;
            if (comparar.Compare(input, Hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CompararMD5(string senhaEntrada, string Senhamd5)
        {
            
            if (VerificarHash(Senhamd5, senhaEntrada))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
