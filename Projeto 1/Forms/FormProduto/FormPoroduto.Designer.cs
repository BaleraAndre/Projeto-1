namespace Projeto_1.Forms.FormProduto
{
    partial class FormProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.unidade,
            this.preco,
            this.Preco_Venda});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.Location = new System.Drawing.Point(0, 0);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.RowTemplate.Height = 25;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(800, 377);
            this.dgvProduto.TabIndex = 12;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // unidade
            // 
            this.unidade.HeaderText = "Unidades";
            this.unidade.Name = "unidade";
            this.unidade.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // Preco_Venda
            // 
            this.Preco_Venda.HeaderText = "Preço de Venda";
            this.Preco_Venda.Name = "Preco_Venda";
            this.Preco_Venda.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNome.Location = new System.Drawing.Point(0, 377);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Pesquisar um produto";
            this.txtNome.Size = new System.Drawing.Size(800, 23);
            this.txtNome.TabIndex = 11;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 400);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(800, 25);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 425);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(800, 25);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adcionar novo";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "FormProduto";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProduto;
        private TextBox txtNome;
        private Button btnPesquisar;
        private Button btnAdicionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn unidade;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn Preco_Venda;
    }
}