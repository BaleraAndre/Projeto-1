using Projeto_1.Entidade.Gastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1.RegrasDeNegocio
{
    public class Relatorio
    {
        public static void GerarRelatorioDeGasto()
        {
            Projeto_1.DataAcessObject.GastosDao.CriarArquivoDeGasto();
            string path = @"C:\Users\andre\OneDrive\Área de Trabalho\andre\Projeto 1\Gasto.txt";

            StreamWriter stream = new StreamWriter(path);
            List<Gastos> lista = new List<Gastos>();

            lista = Projeto_1.DataAcessObject.GastosDao.TodosOsGastos();
            foreach (Gastos gasto in lista)
            {
                stream.Write("Descrição: "+gasto.Descricao + '|');
                stream.Write("Valor: "+gasto.Valor + "|");
                stream.WriteLine("Data: "+gasto.Data_Gasto);
            }
            stream.Close();
        }
    }
}
