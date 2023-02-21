namespace Projeto_1.Forms.FormFinanceiro
{
    partial class FormFinanceiro
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
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.LPoint lPoint1 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint2 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint3 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint4 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint5 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint6 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint7 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint8 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint9 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint10 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint11 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint12 = new Guna.Charts.WinForms.LPoint();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgasto = new System.Windows.Forms.TabPage();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.btnFiltarMes = new System.Windows.Forms.Button();
            this.dgvGasto = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tbvenda = new System.Windows.Forms.TabPage();
            this.btnTodasVendas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMesVenda = new System.Windows.Forms.NumericUpDown();
            this.nudAnoVenda = new System.Windows.Forms.NumericUpDown();
            this.btnFiltrarVenda = new System.Windows.Forms.Button();
            this.btnRelatorioVenda = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chtgrafico = new Guna.Charts.WinForms.GunaChart();
            this.gunaDoughnutDataset1 = new Guna.Charts.WinForms.GunaDoughnutDataset();
            this.barradografico = new Guna.Charts.WinForms.GunaBarDataset();
            this.tabControl1.SuspendLayout();
            this.tpgasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasto)).BeginInit();
            this.tbvenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMesVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgasto);
            this.tabControl1.Controls.Add(this.tbvenda);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 549);
            this.tabControl1.TabIndex = 3;
            // 
            // tpgasto
            // 
            this.tpgasto.Controls.Add(this.btnTodos);
            this.tpgasto.Controls.Add(this.label2);
            this.tpgasto.Controls.Add(this.label1);
            this.tpgasto.Controls.Add(this.nudMes);
            this.tpgasto.Controls.Add(this.nudAno);
            this.tpgasto.Controls.Add(this.btnFiltarMes);
            this.tpgasto.Controls.Add(this.dgvGasto);
            this.tpgasto.Controls.Add(this.button1);
            this.tpgasto.Location = new System.Drawing.Point(4, 24);
            this.tpgasto.Name = "tpgasto";
            this.tpgasto.Padding = new System.Windows.Forms.Padding(3);
            this.tpgasto.Size = new System.Drawing.Size(944, 521);
            this.tpgasto.TabIndex = 0;
            this.tpgasto.Text = "Todos os gastos";
            this.tpgasto.UseVisualStyleBackColor = true;
            // 
            // btnTodos
            // 
            this.btnTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodos.Location = new System.Drawing.Point(724, 485);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(110, 23);
            this.btnTodos.TabIndex = 8;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ano >";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mes >";
            // 
            // nudMes
            // 
            this.nudMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudMes.Location = new System.Drawing.Point(66, 487);
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(120, 23);
            this.nudMes.TabIndex = 5;
            // 
            // nudAno
            // 
            this.nudAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudAno.Location = new System.Drawing.Point(251, 489);
            this.nudAno.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(120, 23);
            this.nudAno.TabIndex = 4;
            this.nudAno.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // btnFiltarMes
            // 
            this.btnFiltarMes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltarMes.AutoSize = true;
            this.btnFiltarMes.Location = new System.Drawing.Point(401, 485);
            this.btnFiltarMes.Name = "btnFiltarMes";
            this.btnFiltarMes.Size = new System.Drawing.Size(110, 25);
            this.btnFiltarMes.TabIndex = 3;
            this.btnFiltarMes.Text = "Filtrar ";
            this.btnFiltarMes.UseVisualStyleBackColor = true;
            this.btnFiltarMes.Click += new System.EventHandler(this.btnFiltarMes_Click);
            // 
            // dgvGasto
            // 
            this.dgvGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGasto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGasto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.preco,
            this.data});
            this.dgvGasto.Location = new System.Drawing.Point(3, 6);
            this.dgvGasto.Name = "dgvGasto";
            this.dgvGasto.ReadOnly = true;
            this.dgvGasto.RowHeadersVisible = false;
            this.dgvGasto.RowTemplate.Height = 25;
            this.dgvGasto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGasto.Size = new System.Drawing.Size(831, 473);
            this.dgvGasto.TabIndex = 1;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descição/Nome";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(527, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerar Relatorio Gasto txt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbvenda
            // 
            this.tbvenda.Controls.Add(this.btnTodasVendas);
            this.tbvenda.Controls.Add(this.label3);
            this.tbvenda.Controls.Add(this.label4);
            this.tbvenda.Controls.Add(this.nudMesVenda);
            this.tbvenda.Controls.Add(this.nudAnoVenda);
            this.tbvenda.Controls.Add(this.btnFiltrarVenda);
            this.tbvenda.Controls.Add(this.btnRelatorioVenda);
            this.tbvenda.Controls.Add(this.dgvVenda);
            this.tbvenda.Location = new System.Drawing.Point(4, 24);
            this.tbvenda.Name = "tbvenda";
            this.tbvenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbvenda.Size = new System.Drawing.Size(944, 521);
            this.tbvenda.TabIndex = 1;
            this.tbvenda.Text = "todas vendas";
            this.tbvenda.UseVisualStyleBackColor = true;
            // 
            // btnTodasVendas
            // 
            this.btnTodasVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodasVendas.Location = new System.Drawing.Point(768, 490);
            this.btnTodasVendas.Name = "btnTodasVendas";
            this.btnTodasVendas.Size = new System.Drawing.Size(110, 23);
            this.btnTodasVendas.TabIndex = 15;
            this.btnTodasVendas.Text = "Todos";
            this.btnTodasVendas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ano >";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mes >";
            // 
            // nudMesVenda
            // 
            this.nudMesVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudMesVenda.Location = new System.Drawing.Point(110, 492);
            this.nudMesVenda.Name = "nudMesVenda";
            this.nudMesVenda.Size = new System.Drawing.Size(120, 23);
            this.nudMesVenda.TabIndex = 12;
            // 
            // nudAnoVenda
            // 
            this.nudAnoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudAnoVenda.Location = new System.Drawing.Point(295, 494);
            this.nudAnoVenda.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudAnoVenda.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudAnoVenda.Name = "nudAnoVenda";
            this.nudAnoVenda.Size = new System.Drawing.Size(120, 23);
            this.nudAnoVenda.TabIndex = 11;
            this.nudAnoVenda.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // btnFiltrarVenda
            // 
            this.btnFiltrarVenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltrarVenda.AutoSize = true;
            this.btnFiltrarVenda.Location = new System.Drawing.Point(445, 490);
            this.btnFiltrarVenda.Name = "btnFiltrarVenda";
            this.btnFiltrarVenda.Size = new System.Drawing.Size(110, 25);
            this.btnFiltrarVenda.TabIndex = 10;
            this.btnFiltrarVenda.Text = "Filtrar ";
            this.btnFiltrarVenda.UseVisualStyleBackColor = true;
            // 
            // btnRelatorioVenda
            // 
            this.btnRelatorioVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatorioVenda.Location = new System.Drawing.Point(571, 492);
            this.btnRelatorioVenda.Name = "btnRelatorioVenda";
            this.btnRelatorioVenda.Size = new System.Drawing.Size(156, 23);
            this.btnRelatorioVenda.TabIndex = 9;
            this.btnRelatorioVenda.Text = "Gerar Relatorio Gasto txt";
            this.btnRelatorioVenda.UseVisualStyleBackColor = true;
            // 
            // dgvVenda
            // 
            this.dgvVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvVenda.Location = new System.Drawing.Point(3, 3);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.RowHeadersVisible = false;
            this.dgvVenda.RowTemplate.Height = 25;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(938, 483);
            this.dgvVenda.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Descição/Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chtgrafico);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(944, 521);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chtgrafico
            // 
            this.chtgrafico.AutoScroll = true;
            this.chtgrafico.BackColor = System.Drawing.Color.White;
            this.chtgrafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chtgrafico.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.gunaDoughnutDataset1,
            this.barradografico});
            this.chtgrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtgrafico.Legend.Display = false;
            chartFont1.FontName = "Arial";
            this.chtgrafico.Legend.LabelFont = chartFont1;
            this.chtgrafico.Location = new System.Drawing.Point(0, 0);
            this.chtgrafico.Misc.BarCornerRadius = 1;
            this.chtgrafico.Name = "chtgrafico";
            this.chtgrafico.Size = new System.Drawing.Size(944, 521);
            this.chtgrafico.TabIndex = 0;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chtgrafico.Title.Font = chartFont2;
            this.chtgrafico.Title.Text = "Vendas";
            chartFont3.FontName = "Arial";
            this.chtgrafico.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chtgrafico.Tooltips.TitleFont = chartFont4;
            this.chtgrafico.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.chtgrafico.XAxes.Ticks = tick1;
            this.chtgrafico.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            tick2.Maximum = 1000D;
            this.chtgrafico.YAxes.Ticks = tick2;
            this.chtgrafico.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.chtgrafico.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.chtgrafico.ZAxes.Ticks = tick3;
            // 
            // gunaDoughnutDataset1
            // 
            lPoint1.Label = "Janeiro";
            lPoint1.Y = 0D;
            lPoint2.Label = "Fevereiro";
            lPoint2.Y = 0D;
            lPoint3.Label = "Março";
            lPoint3.Y = 0D;
            lPoint4.Label = "Abril";
            lPoint4.Y = 0D;
            lPoint5.Label = "Maio";
            lPoint5.Y = 0D;
            lPoint6.Label = "Junho";
            lPoint6.Y = 0D;
            lPoint7.Label = "Julho";
            lPoint7.Y = 0D;
            lPoint8.Label = "Agosto";
            lPoint8.Y = 0D;
            lPoint9.Label = "Setembro";
            lPoint9.Y = 0D;
            lPoint10.Label = "Outubro";
            lPoint10.Y = 0D;
            lPoint11.Label = "Novembro";
            lPoint11.Y = 0D;
            lPoint12.Label = "Dezembro";
            lPoint12.Y = 0D;
            this.gunaDoughnutDataset1.DataPoints.AddRange(new Guna.Charts.WinForms.LPoint[] {
            lPoint1,
            lPoint2,
            lPoint3,
            lPoint4,
            lPoint5,
            lPoint6,
            lPoint7,
            lPoint8,
            lPoint9,
            lPoint10,
            lPoint11,
            lPoint12});
            this.gunaDoughnutDataset1.Label = "Doughnut1";
            this.gunaDoughnutDataset1.TargetChart = this.chtgrafico;
            // 
            // barradografico
            // 
            this.barradografico.BorderWidth = 1;
            this.barradografico.FillColors.AddRange(new System.Drawing.Color[] {
            System.Drawing.Color.Black});
            this.barradografico.Label = "Bar1";
            this.barradografico.TargetChart = this.chtgrafico;
            // 
            // FormFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 549);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormFinanceiro";
            this.Text = "FormFinanceiro";
            this.Shown += new System.EventHandler(this.FormFinanceiro_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tpgasto.ResumeLayout(false);
            this.tpgasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasto)).EndInit();
            this.tbvenda.ResumeLayout(false);
            this.tbvenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMesVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpgasto;
        private DataGridView dgvGasto;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn data;
        private Button button1;
        private TabPage tbvenda;
        private DataGridView dgvVenda;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnFiltarMes;
        private Label label2;
        private Label label1;
        private NumericUpDown nudMes;
        private NumericUpDown nudAno;
        private Button btnTodos;
        private Button btnTodasVendas;
        private Label label3;
        private Label label4;
        private NumericUpDown nudMesVenda;
        private NumericUpDown nudAnoVenda;
        private Button btnFiltrarVenda;
        private Button btnRelatorioVenda;
        private TabPage tabPage1;
        private Guna.Charts.WinForms.GunaChart chtgrafico;
        private Guna.Charts.WinForms.GunaDoughnutDataset gunaDoughnutDataset1;
        private Guna.Charts.WinForms.GunaBarDataset barradografico;
    }
}