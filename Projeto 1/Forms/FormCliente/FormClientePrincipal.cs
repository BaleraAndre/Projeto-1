using System.Data;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using DataAcessObject;
using Npgsql;
using Projeto_1;
using Projeto_1.Entidade.Cliente;

namespace Projeto_1
{
    public partial class FormClientePrincipal : Form
    {
        public FormClientePrincipal()
        {
            InitializeComponent();

            CarregarGrid();
        }

      

        public void CarregarGrid()
        {
            List<Cliente> lista = new List<Cliente>();
            lista = ClienteDao.ObterTodos();
            foreach (Cliente p in lista)
            {
                dgvCliente.Rows.Add(p.Id, p.Nome, p.CPF, p.Email,p.Cidade,p.Estado, p.Data_Registro.ToShortDateString());

            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente a = new Entidade.Cliente.Cliente();
            a.Id = int.Parse(dgvCliente.SelectedRows[0].Cells[0].Value.ToString());
            a.Nome = dgvCliente.SelectedRows[0].Cells[1].Value.ToString();
            a.CPF = dgvCliente.SelectedRows[0].Cells[2].Value.ToString();
            a.Email = dgvCliente.SelectedRows[0].Cells[3].Value.ToString();
            a.Cidade = dgvCliente.SelectedRows[0].Cells[4].Value.ToString();
            a.Estado = dgvCliente.SelectedRows[0].Cells[5].Value.ToString();
            a.Data_Registro = DateTime.Parse(dgvCliente.SelectedRows[0].Cells[6].Value.ToString());
            Projeto_1.Forms.FormCliente.FormClienteSecundario form = new Projeto_1.Forms.FormCliente.FormClienteSecundario(a);
            form.ShowDialog();
            dgvCliente.Rows.Clear();
            CarregarGrid();
           
        }

       

        private void btnbusca_Click(object sender, EventArgs e)
        {
            string nome = txtbusca.Text;
            Cliente cliente = new Entidade.Cliente.Cliente();
            int i;
            int num = dgvCliente.Rows.Count;
            for (i = 0; i != num; i++)
            {
                if (dgvCliente.Rows[i].Cells[1].Value != null)

                {
                    if (nome.Equals(dgvCliente.Rows[i].Cells[1].Value.ToString()))
                    {
                        cliente = ClienteDao.ObterPorNome(nome);
                        Projeto_1.Forms.FormCliente.FormClienteSecundario form = new Forms.FormCliente.FormClienteSecundario(cliente);
                        form.ShowDialog();

                        return;
                    }
                }
            }
            MessageBox.Show("Nao localizado");
        }

        private void btnadicionarnovo_Click(object sender, EventArgs e)
        {
            Cliente a = new Entidade.Cliente.Cliente();
            Projeto_1.Forms.FormCliente.FormClienteSecundario form = new Projeto_1.Forms.FormCliente.FormClienteSecundario(a);
            form.ShowDialog();
            dgvCliente.Rows.Clear();
            CarregarGrid();
        }
// lalalalalala
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}