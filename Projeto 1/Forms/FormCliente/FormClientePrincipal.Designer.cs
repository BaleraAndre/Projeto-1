namespace Projeto_1
{
    partial class FormClientePrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnbusca = new Guna.UI2.WinForms.Guna2Button();
            this.txtbusca = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnadicionarnovo = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(108)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CausesValidation = false;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.cpf,
            this.email,
            this.Cidade,
            this.Estado,
            this.data_registro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.White;
            this.dgvCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvCliente.Location = new System.Drawing.Point(0, 35);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCliente.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgvCliente.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCliente.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCliente.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvCliente.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCliente.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowTemplate.DividerHeight = 1;
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.RowTemplate.ReadOnly = true;
            this.dgvCliente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(854, 324);
            this.dgvCliente.TabIndex = 4;
            this.dgvCliente.TabStop = false;
            this.toolTip1.SetToolTip(this.dgvCliente, "Registros Do Banco De Dados");
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // id
            // 
            this.id.DividerWidth = 1;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DividerWidth = 1;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DividerWidth = 1;
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // email
            // 
            this.email.DividerWidth = 1;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DividerWidth = 1;
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DividerWidth = 1;
            this.Estado.HeaderText = "UF";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // data_registro
            // 
            this.data_registro.DividerWidth = 1;
            this.data_registro.HeaderText = "Data De Registro";
            this.data_registro.Name = "data_registro";
            this.data_registro.ReadOnly = true;
            // 
            // btnbusca
            // 
            this.btnbusca.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnbusca.BorderRadius = 11;
            this.btnbusca.BorderThickness = 1;
            this.btnbusca.CustomizableEdges = customizableEdges1;
            this.btnbusca.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbusca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbusca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbusca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbusca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnbusca.FillColor = System.Drawing.Color.Black;
            this.btnbusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnbusca.ForeColor = System.Drawing.Color.White;
            this.btnbusca.Location = new System.Drawing.Point(0, 47);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnbusca.Size = new System.Drawing.Size(857, 24);
            this.btnbusca.TabIndex = 5;
            this.btnbusca.Text = "Buscar";
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // txtbusca
            // 
            this.txtbusca.BorderRadius = 11;
            this.txtbusca.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtbusca.CustomizableEdges = customizableEdges3;
            this.txtbusca.DefaultText = "";
            this.txtbusca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbusca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbusca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtbusca.FillColor = System.Drawing.Color.Black;
            this.txtbusca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbusca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusca.Location = new System.Drawing.Point(0, 2);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.PasswordChar = '\0';
            this.txtbusca.PlaceholderText = "Digite o nome aqui";
            this.txtbusca.SelectedText = "";
            this.txtbusca.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.txtbusca.Size = new System.Drawing.Size(857, 45);
            this.txtbusca.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtbusca);
            this.panel1.Controls.Add(this.btnbusca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 71);
            this.panel1.TabIndex = 7;
            // 
            // btnadicionarnovo
            // 
            this.btnadicionarnovo.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnadicionarnovo.BorderRadius = 11;
            this.btnadicionarnovo.BorderThickness = 1;
            this.btnadicionarnovo.CustomizableEdges = customizableEdges5;
            this.btnadicionarnovo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadicionarnovo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadicionarnovo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadicionarnovo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadicionarnovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnadicionarnovo.FillColor = System.Drawing.Color.Black;
            this.btnadicionarnovo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnadicionarnovo.ForeColor = System.Drawing.Color.White;
            this.btnadicionarnovo.Location = new System.Drawing.Point(0, 0);
            this.btnadicionarnovo.Name = "btnadicionarnovo";
            this.btnadicionarnovo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.btnadicionarnovo.Size = new System.Drawing.Size(857, 38);
            this.btnadicionarnovo.TabIndex = 7;
            this.btnadicionarnovo.Text = "Adicionar Novo";
            this.btnadicionarnovo.Click += new System.EventHandler(this.btnadicionarnovo_Click);
            // 
            // FormClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 427);
            this.Controls.Add(this.btnadicionarnovo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCliente);
            this.Name = "FormClientePrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvCliente;
        private ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btnbusca;
        private Guna.UI2.WinForms.Guna2TextBox txtbusca;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnadicionarnovo;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn data_registro;
    }
}