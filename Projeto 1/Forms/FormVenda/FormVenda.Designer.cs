namespace Projeto_1.Forms.Venda
{
    partial class FormVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.nudUnidade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCarrinho = new System.Windows.Forms.Button();
            this.btnLimparCarrinho = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidade)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFuncionario);
            this.panel1.Controls.Add(this.lblFuncionario);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 65);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(299, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caixa n*";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(20, 24);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(273, 23);
            this.txtFuncionario.TabIndex = 1;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(20, 2);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(70, 15);
            this.lblFuncionario.TabIndex = 0;
            this.lblFuncionario.Text = "Funcionario";
            // 
            // dgvVenda
            // 
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.unidades,
            this.preco});
            this.dgvVenda.EnableHeadersVisualStyles = false;
            this.dgvVenda.Location = new System.Drawing.Point(12, 98);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVenda.RowHeadersVisible = false;
            this.dgvVenda.RowTemplate.Height = 25;
            this.dgvVenda.Size = new System.Drawing.Size(776, 188);
            this.dgvVenda.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dgvVenda, "Carrinho");
            this.dgvVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellClick);
            // 
            // nome
            // 
            this.nome.HeaderText = "Descrição produto";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // unidades
            // 
            this.unidades.HeaderText = "Unidades";
            this.unidades.Name = "unidades";
            this.unidades.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(117, 302);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.PlaceholderText = "Nome do produto";
            this.txtNomeProduto.Size = new System.Drawing.Size(252, 23);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // nudUnidade
            // 
            this.nudUnidade.Location = new System.Drawing.Point(464, 303);
            this.nudUnidade.Name = "nudUnidade";
            this.nudUnidade.Size = new System.Drawing.Size(120, 23);
            this.nudUnidade.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descriçao/Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unidades:";
            // 
            // btnAddCarrinho
            // 
            this.btnAddCarrinho.Location = new System.Drawing.Point(32, 363);
            this.btnAddCarrinho.Name = "btnAddCarrinho";
            this.btnAddCarrinho.Size = new System.Drawing.Size(161, 35);
            this.btnAddCarrinho.TabIndex = 8;
            this.btnAddCarrinho.Text = "Adicionar item ao carrinho";
            this.btnAddCarrinho.UseVisualStyleBackColor = true;
            this.btnAddCarrinho.Click += new System.EventHandler(this.btnAddCarrinho_Click);
            // 
            // btnLimparCarrinho
            // 
            this.btnLimparCarrinho.Location = new System.Drawing.Point(405, 363);
            this.btnLimparCarrinho.Name = "btnLimparCarrinho";
            this.btnLimparCarrinho.Size = new System.Drawing.Size(161, 35);
            this.btnLimparCarrinho.TabIndex = 9;
            this.btnLimparCarrinho.Text = "Esvaziar carrinho";
            this.toolTip1.SetToolTip(this.btnLimparCarrinho, "Remover todos items do carrinho");
            this.btnLimparCarrinho.UseVisualStyleBackColor = true;
            this.btnLimparCarrinho.Click += new System.EventHandler(this.btnLimparCarrinho_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(217, 363);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(164, 35);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover item do carrinho";
            this.toolTip1.SetToolTip(this.btnRemover, "Remover item selecionado do carrinho");
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNumeroVenda);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Location = new System.Drawing.Point(451, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 63);
            this.panel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pedido n*";
            // 
            // txtNumeroVenda
            // 
            this.txtNumeroVenda.Location = new System.Drawing.Point(213, 21);
            this.txtNumeroVenda.Name = "txtNumeroVenda";
            this.txtNumeroVenda.Size = new System.Drawing.Size(91, 23);
            this.txtNumeroVenda.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(3, 21);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(193, 23);
            this.txtCliente.TabIndex = 2;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(640, 303);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(148, 81);
            this.btnFinalizarVenda.TabIndex = 12;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sangria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimparCarrinho);
            this.Controls.Add(this.btnAddCarrinho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudUnidade);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.panel1);
            this.Name = "FormVenda";
            this.Text = "Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidade)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TextBox txtFuncionario;
        private Label lblFuncionario;
        private DataGridView dgvVenda;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn unidades;
        private DataGridViewTextBoxColumn preco;
        private TextBox txtNomeProduto;
        private NumericUpDown nudUnidade;
        private Label label2;
        private Label label4;
        private Button btnAddCarrinho;
        private Button btnLimparCarrinho;
        private Button btnRemover;
        private Panel panel2;
        private Label label6;
        private TextBox txtNumeroVenda;
        private Label label5;
        private TextBox txtCliente;
        private Button btnFinalizarVenda;
        private ToolTip toolTip1;
        private Button button1;
    }
}