using Projeto_1.DataAcessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Projeto_1.Entidade.Funcionario;
using Projeto_1.Entidade.Gastos;

namespace Projeto_1.Forms.FormFuncionario
{
    public partial class FormFuncionarioSecundario : Form
    {
        private int id;
        public FormFuncionarioSecundario(Funcionario a)
        {
            InitializeComponent();
            

            if (a.Id > 0 && a.Nome.Length>0 && a.Cpf.Length>0 && a.Email.Length > 0)
            {
                id = a.Id;
                lblID.Text ="ID: " + a.Id.ToString();
                txtNome.Text = a.Nome.ToString();
                txtCpf.Text= a.Cpf.ToString();
                txtEmail.Text= a.Email.ToString();
                nudsalario.Value = decimal.Parse(a.Salario.ToString());
                lblDataDeRegistro.Text ="Data do registro: " + a.Data_Registro.ToString("dd/MM/yyyy");
                btnadicionar.Visible = false;

            }
            else
            {
                lblID.Visible = false;
                lblDataDeRegistro.Visible = false;
                btnEditar.Visible = false;
                btnremover.Visible = false;
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            Gastos gastos= new Entidade.Gastos.Gastos();
            Funcionario a = new Entidade.Funcionario.Funcionario();
            a.Nome = txtNome.Text;
            a.Cpf = txtCpf.Text;
            a.Email = txtEmail.Text;
            a.Salario = double.Parse(nudsalario.Value.ToString());
            gastos.Descricao = txtNome.Text;
            gastos.Valor = double.Parse(nudsalario.Value.ToString());
            gastos.Data_Gasto = DateTime.Now;
            GastosDao.RegistrarGasto(gastos);
            FuncionarioDao.InserirFuncionario(a);
            this.Close();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            Projeto_1.DataAcessObject.FuncionarioDao.RemoverFuncionario(txtNome.Text);
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           Funcionario funcionario = new Entidade.Funcionario.Funcionario();
            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Salario = double.Parse(nudsalario.Value.ToString().Replace('.',','));
            
            DataAcessObject.FuncionarioDao.EditarFuncionario(funcionario, id);
            this.Close();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
