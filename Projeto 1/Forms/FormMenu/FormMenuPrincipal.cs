using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Projeto_1.Forms.FormMenu
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();

            linkGoogle.Links.Add(0, 13, "https://www.google.com");
            

        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Projeto_1.FormClientePrincipal form = new Projeto_1.FormClientePrincipal();
            form.ShowDialog();

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Projeto_1.Forms.FormFuncionario.FormFuncionario form = new FormFuncionario.FormFuncionario();
            form.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Projeto_1.Forms.FormProduto.FormProduto form = new FormProduto.FormProduto();
            form.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Projeto_1.Forms.Venda.FormVenda form = new Venda.FormVenda();
            form.ShowDialog();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            Projeto_1.Forms.FormFinanceiro.FormFinanceiro form = new FormFinanceiro.FormFinanceiro();
            form.ShowDialog();
        }

        private void linkGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\", UseShellExecute = true });
            //string link = e.Link.LinkData as string;
            //string FileName = @"\C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\";
            //Process.Start(FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Forms.FormLogIn.FormEmail form = new FormLogIn.FormEmail();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Projeto_1.Forms.FormFinanceiro.FormFinanceiro form = new FormFinanceiro.FormFinanceiro();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Projeto_1.Forms.FormProduto.FormProduto form = new FormProduto.FormProduto();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Projeto_1.Forms.Venda.FormVenda form = new Venda.FormVenda();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Projeto_1.FormClientePrincipal form = new Projeto_1.FormClientePrincipal();
            form.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Projeto_1.Forms.FormFuncionario.FormFuncionario form = new FormFuncionario.FormFuncionario();
            form.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Forms.FormLogIn.FormEmail form = new FormLogIn.FormEmail();
            form.ShowDialog();
        }
    }
}
