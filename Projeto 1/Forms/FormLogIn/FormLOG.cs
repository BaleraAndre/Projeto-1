using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_1
{
    public partial class FormMENU : Form
    {
        public FormMENU()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Entidade.Perfil.Perfil perfil = new Entidade.Perfil.Perfil();
            perfil._autenticacao = txtSenha.Text;
            perfil._identificacao = txtUsuario.Text;
            bool login = DataAcessObject.PerfilDao.LogIn(perfil);

            if (login)
            {
                Projeto_1.Forms.FormMenu.FormMenuPrincipal form = new Projeto_1.Forms.FormMenu.FormMenuPrincipal();
                form.ShowDialog();
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Em Construção");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Construção");
        }
    }
}
