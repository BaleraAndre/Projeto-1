using DataAcessObject;
using Projeto_1.DataAcessObject;
using Projeto_1.Entidade.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_1.Forms.FormFuncionario
{
    public partial class FormFuncionario : Form
    {
        
        public FormFuncionario()
        {
            InitializeComponent();
            CarregarGrid();
            
        }

        public void CarregarGrid()
        {
            List<Funcionario> lista = new List<Funcionario>();
            lista = FuncionarioDao.ObterTodos();
            foreach (Funcionario p in lista)
            {
                dgvFuncionario.Rows.Add(p.Id, p.Nome, p.Cpf, p.Email, p.Salario, p.Data_Registro.ToShortDateString());

            }
        }
        
        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Funcionario a = new Entidade.Funcionario.Funcionario();
            a.Id = int.Parse(dgvFuncionario.SelectedRows[0].Cells[0].Value.ToString());
            a.Nome = dgvFuncionario.SelectedRows[0].Cells[1].Value.ToString();
            a.Cpf = dgvFuncionario.SelectedRows[0].Cells[2].Value.ToString();
            a.Email = dgvFuncionario.SelectedRows[0].Cells[3].Value.ToString();
            a.Salario = double.Parse(dgvFuncionario.SelectedRows[0].Cells[4].Value.ToString());
            a.Data_Registro = DateTime.Parse(dgvFuncionario.SelectedRows[0].Cells[5].Value.ToString());
            Forms.FormFuncionario.FormFuncionarioSecundario form = new Forms.FormFuncionario.FormFuncionarioSecundario(a);
            form.ShowDialog();
            dgvFuncionario.Rows.Clear();
            CarregarGrid();
            
        }

     

        private void btnadd_Click(object sender, EventArgs e)
        {
            Funcionario a = new Entidade.Funcionario.Funcionario();
            Forms.FormFuncionario.FormFuncionarioSecundario form = new Forms.FormFuncionario.FormFuncionarioSecundario(a);
            form.ShowDialog();
            dgvFuncionario.Rows.Clear();
            CarregarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txbbusca.Text;
            Funcionario funcionario = new Entidade.Funcionario.Funcionario();
            int i;
            int num = dgvFuncionario.Rows.Count;
            for (i = 0; i != num; i++)
            {
                if (dgvFuncionario.Rows[i].Cells[1].Value != null)

                {
                    if (nome.Equals(dgvFuncionario.Rows[i].Cells[1].Value.ToString()))
                    {
                        Funcionario funcionario1 = new Entidade.Funcionario.Funcionario();
                        funcionario1 = DataAcessObject.FuncionarioDao.ObterPorNome(nome);
                        Forms.FormFuncionario.FormFuncionarioSecundario form = new FormFuncionarioSecundario(funcionario1);
                        form.ShowDialog();
                        dgvFuncionario.Rows.Clear();
                        CarregarGrid();

                        return;
                    }
                }
            }
            MessageBox.Show("Nao localizado");
        }
    }
    
}
