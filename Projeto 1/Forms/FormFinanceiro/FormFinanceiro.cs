using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_1.Entidade.Gastos;

namespace Projeto_1.Forms.FormFinanceiro
{
    public partial class FormFinanceiro : Form
    {
        public FormFinanceiro()
        {
            InitializeComponent();


        }

        private void FormFinanceiro_Shown(object sender, EventArgs e)
        {
            List<Gastos> lista = new List<Gastos>();
            lista = DataAcessObject.GastosDao.TodosOsGastos();
            foreach (Gastos gasto in lista)
            {
                dgvGasto.Rows.Add(gasto.Descricao, gasto.Valor, gasto.Data_Gasto.ToShortDateString());
            }

            List<Projeto_1.Venda.Venda> listavenda = new List<Projeto_1.Venda.Venda>();
            listavenda = DataAcessObject.VendaDao.ObterTodas();
            foreach (Projeto_1.Venda.Venda venda in listavenda)
            {

                dgvVenda.Rows.Add(venda.Descricao, venda.Valor, venda.Unidade, venda.Data_venda.ToShortDateString());
            }

            carregarGrafico();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto_1.RegrasDeNegocio.Relatorio.GerarRelatorioDeGasto();

        }

        private void btnFiltarMes_Click(object sender, EventArgs e)
        {
            int a = (int)nudAno.Value;
            int m = (int)nudMes.Value;
            if (m > 0 && m < 13 && a > 1)
            {
                List<Gastos> lista = DataAcessObject.GastosDao.TodosOsGastosDoMes(m, a);
                dgvGasto.Rows.Clear();
                foreach (Gastos gasto in lista)
                {
                    dgvGasto.Rows.Add(gasto.Descricao, gasto.Valor, gasto.Data_Gasto.ToShortDateString());
                }
            }
            else
            {
                MessageBox.Show("Digite um mes entre 1 e 12 (ex: 01 , 02 , 03..)");
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgvGasto.Rows.Clear();
            List<Gastos> lista = new List<Gastos>();
            lista = DataAcessObject.GastosDao.TodosOsGastos();
            foreach (Gastos gasto in lista)
            {
                dgvGasto.Rows.Add(gasto.Descricao, gasto.Valor, gasto.Data_Gasto.ToShortDateString());
            }

        }

        private void carregarGrafico()
        {
            double valorTotalJaneiro = 0;
            double valorTotalFevereiro = 0;
            List<Projeto_1.Venda.Venda> listavenda = new List<Projeto_1.Venda.Venda>();
            listavenda = DataAcessObject.VendaDao.ObterTodas();
            int quantvenda = listavenda.Count;
            int i;

            foreach (Projeto_1.Venda.Venda venda in listavenda)
            {
                for (i = 0; i < quantvenda; i++)
                {
                    if (venda.Data_venda.Month == 1)
                    {
                        valorTotalJaneiro += venda.Valor;
                        break;

                    }
                    else if (venda.Data_venda.Month == 2)
                    {
                        valorTotalFevereiro += venda.Valor;
                        break;
                    }

                }

            }
            barradografico.DataPoints.Add("Janeiro", valorTotalJaneiro);
            barradografico.DataPoints.Add("Fevereiro", valorTotalFevereiro);
        }
    }
}
