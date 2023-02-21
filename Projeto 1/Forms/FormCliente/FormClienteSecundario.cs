using DataAcessObject;
using Projeto_1.Entidade.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_1.Forms.FormCliente
{
    public partial class FormClienteSecundario : Form
    {   
        private int id;
        public FormClienteSecundario(Cliente cli)
        {
            InitializeComponent();
           
            if (cli.Id > 0)
            {
                id = cli.Id;
                txbnome.Text = cli.Nome;
                txbcpf.Text = cli.CPF;
                txbemail.Text = cli.Email;
                lblID.Text = "ID: " +cli.Id.ToString();
                btnadd.Visible = false;
                lblDataDeRegistro.Text = "Data do Registro: " + cli.Data_Registro.ToString("dd/MM/yyyy");
                txbcidade.Text = cli.Cidade;
                cmbEstado.Text = cli.Estado;

            }
            
            else
            {
                lblID.Visible = false;
                btnedit.Visible = false;
                btnexcluir.Visible = false;
                lblDataDeRegistro.Visible = false;
            }
            

        }

      

        private void btnadd_Click(object sender, EventArgs e)
        {
            Cliente cli = new Entidade.Cliente.Cliente();
            try
            {
                if (txbcpf.Text.Length != 11)
                {
                    MessageBox.Show("Digite um CPF valido");
                    return;
                }

                long cpf = long.Parse(txbcpf.Text);
            }
            catch (FormatException Fex)
            {

                MessageBox.Show("Digite um CPF valido");
                return;
            }

            if (txbnome.Text.Length > 0 && txbcpf.Text.Length > 0 && txbemail.Text.Length > 0)
            {
                cli.Estado = cmbEstado.Text;
                cli.Cidade = txbcidade.Text;
                cli.Nome = txbnome.Text;
                cli.CPF = txbcpf.Text;
                cli.Email = txbemail.Text;
                bool inserido = ClienteDao.InserirCliente(cli);
                if (inserido == true)
                {
                    MessageBox.Show("Cliente iserido no banco de dados", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao inserir o cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            bool removido = ClienteDao.RemoverCliente(txbnome.Text);
            if (removido == true)
            {
                MessageBox.Show("Cliente removido do banco de dados", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao remover cliente do banco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Entidade.Cliente.Cliente();
            cliente.Nome = txbnome.Text;
            cliente.Email = txbemail.Text;
            cliente.CPF = txbcpf.Text;
            ClienteDao.EditarCliente(cliente, id);
            this.Close();
        }

        private void FormClienteSecundario_Load(object sender, EventArgs e)
        {

        }

        private void txbnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbcpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
