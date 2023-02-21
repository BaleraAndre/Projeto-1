namespace Projeto_1.Forms.FormFuncionario
{
    partial class FormFuncionarioSecundario
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
            this.lblDataDeRegistro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudsalario = new System.Windows.Forms.NumericUpDown();
            this.btnsair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudsalario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataDeRegistro
            // 
            this.lblDataDeRegistro.AutoSize = true;
            this.lblDataDeRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDataDeRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataDeRegistro.Location = new System.Drawing.Point(107, 301);
            this.lblDataDeRegistro.Name = "lblDataDeRegistro";
            this.lblDataDeRegistro.Size = new System.Drawing.Size(111, 15);
            this.lblDataDeRegistro.TabIndex = 31;
            this.lblDataDeRegistro.Text = "DATA DE REGISTRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(115, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(115, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(115, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(376, 23);
            this.txtEmail.TabIndex = 27;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(159, 157);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(376, 23);
            this.txtCpf.TabIndex = 26;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(159, 119);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(376, 23);
            this.txtNome.TabIndex = 25;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblID.Location = new System.Drawing.Point(115, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 15);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "ID";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(316, 382);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 38);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(472, 382);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(137, 38);
            this.btnremover.TabIndex = 22;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(628, 382);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(137, 38);
            this.btnadicionar.TabIndex = 21;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(107, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Salario:";
            // 
            // nudsalario
            // 
            this.nudsalario.DecimalPlaces = 2;
            this.nudsalario.Location = new System.Drawing.Point(159, 233);
            this.nudsalario.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudsalario.Name = "nudsalario";
            this.nudsalario.Size = new System.Drawing.Size(120, 23);
            this.nudsalario.TabIndex = 34;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(717, 12);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(71, 24);
            this.btnsair.TabIndex = 35;
            this.btnsair.Text = "Voltar";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // FormFuncionarioSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.nudsalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDataDeRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnadicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFuncionarioSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFuncionarioSecundario";
            ((System.ComponentModel.ISupportInitialize)(this.nudsalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDataDeRegistro;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtNome;
        private Label lblID;
        private Button btnEditar;
        private Button btnremover;
        private Button btnadicionar;
        private Label label1;
        private NumericUpDown nudsalario;
        private Button btnsair;
    }
}