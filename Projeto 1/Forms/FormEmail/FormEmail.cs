using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Projeto_1.Forms.FormLogIn
{
    public partial class FormEmail : Form
    {
        public FormEmail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em construção");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
