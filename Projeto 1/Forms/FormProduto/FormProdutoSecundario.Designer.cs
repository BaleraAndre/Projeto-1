namespace Projeto_1.Forms.FormProduto
{
    partial class FormProdutoSecundario
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
            this.lblUnidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.nudUnidade = new System.Windows.Forms.NumericUpDown();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.lblPreco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPreco_venda = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco_venda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(145, 126);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(59, 15);
            this.lblUnidade.TabIndex = 42;
            this.lblUnidade.Text = "Unidades:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(210, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(376, 23);
            this.txtNome.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(103, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(196, 249);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 38);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(352, 249);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(137, 38);
            this.btnremover.TabIndex = 35;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(508, 249);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(137, 38);
            this.btnadicionar.TabIndex = 34;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // nudUnidade
            // 
            this.nudUnidade.Location = new System.Drawing.Point(210, 118);
            this.nudUnidade.Name = "nudUnidade";
            this.nudUnidade.Size = new System.Drawing.Size(120, 23);
            this.nudUnidade.TabIndex = 43;
            // 
            // nudPreco
            // 
            this.nudPreco.DecimalPlaces = 2;
            this.nudPreco.Location = new System.Drawing.Point(204, 167);
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(120, 23);
            this.nudPreco.TabIndex = 44;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(158, 175);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(40, 15);
            this.lblPreco.TabIndex = 45;
            this.lblPreco.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Preço Venda:";
            // 
            // nudPreco_venda
            // 
            this.nudPreco_venda.DecimalPlaces = 2;
            this.nudPreco_venda.Location = new System.Drawing.Point(449, 167);
            this.nudPreco_venda.Name = "nudPreco_venda";
            this.nudPreco_venda.Size = new System.Drawing.Size(120, 23);
            this.nudPreco_venda.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "ID:";
            // 
            // FormProdutoSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPreco_venda);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.nudPreco);
            this.Controls.Add(this.nudUnidade);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnadicionar);
            this.Name = "FormProdutoSecundario";
            this.Text = "FormProdutoSecundario";
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco_venda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUnidade;
        private Label label2;
        private TextBox txtNome;
        private Label lblID;
        private Button btnEditar;
        private Button btnremover;
        private Button btnadicionar;
        private NumericUpDown nudUnidade;
        private NumericUpDown nudPreco;
        private Label lblPreco;
        private Label label1;
        private NumericUpDown nudPreco_venda;
        private Label label3;
    }
}