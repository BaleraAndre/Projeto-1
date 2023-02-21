namespace Projeto_1.Forms.FormFuncionario
{
    partial class FormFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.txbbusca = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.Black;
            this.dgvFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.cpf,
            this.email,
            this.salario,
            this.data_registro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFuncionario.EnableHeadersVisualStyles = false;
            this.dgvFuncionario.Location = new System.Drawing.Point(5, 43);
            this.dgvFuncionario.MultiSelect = false;
            this.dgvFuncionario.Name = "dgvFuncionario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.RowTemplate.DividerHeight = 1;
            this.dgvFuncionario.RowTemplate.Height = 25;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(795, 322);
            this.dgvFuncionario.TabIndex = 8;
            this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
            // 
            // txbbusca
            // 
            this.txbbusca.BorderRadius = 14;
            this.txbbusca.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txbbusca.CustomizableEdges = customizableEdges1;
            this.txbbusca.DefaultText = "";
            this.txbbusca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbbusca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbbusca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbbusca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbbusca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbbusca.FillColor = System.Drawing.Color.Black;
            this.txbbusca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbbusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbbusca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbbusca.Location = new System.Drawing.Point(0, 409);
            this.txbbusca.Name = "txbbusca";
            this.txbbusca.PasswordChar = '\0';
            this.txbbusca.PlaceholderText = "Digite o nome aqui";
            this.txbbusca.SelectedText = "";
            this.txbbusca.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.txbbusca.Size = new System.Drawing.Size(800, 41);
            this.txbbusca.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.BorderRadius = 14;
            this.btnBuscar.BorderThickness = 1;
            this.btnBuscar.CustomizableEdges = customizableEdges3;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBuscar.FillColor = System.Drawing.Color.Black;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(0, 371);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btnBuscar.Size = new System.Drawing.Size(800, 38);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Pesquisar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnadd
            // 
            this.btnadd.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnadd.BorderRadius = 14;
            this.btnadd.BorderThickness = 1;
            this.btnadd.CustomizableEdges = customizableEdges5;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnadd.FillColor = System.Drawing.Color.Black;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(0, 0);
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.btnadd.Size = new System.Drawing.Size(800, 37);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Adicionar Novo";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // id
            // 
            this.id.DividerWidth = 1;
            this.id.FillWeight = 20F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nome
            // 
            this.nome.DividerWidth = 1;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // cpf
            // 
            this.cpf.DividerWidth = 1;
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            // 
            // email
            // 
            this.email.DividerWidth = 1;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // salario
            // 
            this.salario.DividerWidth = 1;
            this.salario.FillWeight = 50F;
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            // 
            // data_registro
            // 
            this.data_registro.DividerWidth = 1;
            this.data_registro.FillWeight = 60F;
            this.data_registro.HeaderText = "Data De Registro";
            this.data_registro.Name = "data_registro";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbbusca);
            this.Controls.Add(this.dgvFuncionario);
            this.Name = "FormFuncionario";
            this.Text = "Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvFuncionario;
        private Guna.UI2.WinForms.Guna2TextBox txbbusca;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn salario;
        private DataGridViewTextBoxColumn data_registro;
    }
}