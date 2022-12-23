namespace HotelEconomicoV1
{
    partial class frmAltConsQuarto
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
            this.gpbQuarto = new System.Windows.Forms.GroupBox();
            this.gpbTemTv = new System.Windows.Forms.GroupBox();
            this.optTvNao = new System.Windows.Forms.RadioButton();
            this.optTvSim = new System.Windows.Forms.RadioButton();
            this.lblDescr = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.lblVagas = new System.Windows.Forms.Label();
            this.nmrVagas = new System.Windows.Forms.NumericUpDown();
            this.lblIDQuarto = new System.Windows.Forms.Label();
            this.nmrID = new System.Windows.Forms.NumericUpDown();
            this.gridConsulta = new System.Windows.Forms.DataGridView();
            this.iDQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temTVDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vagasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.he_dadosDataSet = new HotelEconomicoV1.he_dadosDataSet();
            this.quartoTableAdapter = new HotelEconomicoV1.he_dadosDataSetTableAdapters.QuartoTableAdapter();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbQuarto.SuspendLayout();
            this.gpbTemTv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.he_dadosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbQuarto
            // 
            this.gpbQuarto.Controls.Add(this.gpbTemTv);
            this.gpbQuarto.Controls.Add(this.lblDescr);
            this.gpbQuarto.Controls.Add(this.txtDescr);
            this.gpbQuarto.Controls.Add(this.lblVagas);
            this.gpbQuarto.Controls.Add(this.nmrVagas);
            this.gpbQuarto.Controls.Add(this.lblIDQuarto);
            this.gpbQuarto.Controls.Add(this.nmrID);
            this.gpbQuarto.Location = new System.Drawing.Point(12, 34);
            this.gpbQuarto.Name = "gpbQuarto";
            this.gpbQuarto.Size = new System.Drawing.Size(465, 188);
            this.gpbQuarto.TabIndex = 1;
            this.gpbQuarto.TabStop = false;
            this.gpbQuarto.Text = "Dados do Quarto";
            // 
            // gpbTemTv
            // 
            this.gpbTemTv.Controls.Add(this.optTvNao);
            this.gpbTemTv.Controls.Add(this.optTvSim);
            this.gpbTemTv.Location = new System.Drawing.Point(145, 17);
            this.gpbTemTv.Name = "gpbTemTv";
            this.gpbTemTv.Size = new System.Drawing.Size(270, 39);
            this.gpbTemTv.TabIndex = 2;
            this.gpbTemTv.TabStop = false;
            this.gpbTemTv.Text = "Tem TV?";
            // 
            // optTvNao
            // 
            this.optTvNao.AutoSize = true;
            this.optTvNao.Location = new System.Drawing.Point(6, 16);
            this.optTvNao.Name = "optTvNao";
            this.optTvNao.Size = new System.Drawing.Size(45, 17);
            this.optTvNao.TabIndex = 6;
            this.optTvNao.TabStop = true;
            this.optTvNao.Text = "Não";
            this.optTvNao.UseVisualStyleBackColor = true;
            // 
            // optTvSim
            // 
            this.optTvSim.AutoSize = true;
            this.optTvSim.Location = new System.Drawing.Point(58, 16);
            this.optTvSim.Name = "optTvSim";
            this.optTvSim.Size = new System.Drawing.Size(42, 17);
            this.optTvSim.TabIndex = 7;
            this.optTvSim.TabStop = true;
            this.optTvSim.Text = "Sim";
            this.optTvSim.UseVisualStyleBackColor = true;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(11, 72);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(55, 13);
            this.lblDescr.TabIndex = 5;
            this.lblDescr.Text = "Descrição";
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(0, 88);
            this.txtDescr.Multiline = true;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(459, 94);
            this.txtDescr.TabIndex = 4;
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Location = new System.Drawing.Point(77, 17);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(37, 13);
            this.lblVagas.TabIndex = 3;
            this.lblVagas.Text = "Vagas";
            // 
            // nmrVagas
            // 
            this.nmrVagas.Location = new System.Drawing.Point(80, 34);
            this.nmrVagas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrVagas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrVagas.Name = "nmrVagas";
            this.nmrVagas.Size = new System.Drawing.Size(49, 20);
            this.nmrVagas.TabIndex = 2;
            this.nmrVagas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblIDQuarto
            // 
            this.lblIDQuarto.AutoSize = true;
            this.lblIDQuarto.Location = new System.Drawing.Point(6, 18);
            this.lblIDQuarto.Name = "lblIDQuarto";
            this.lblIDQuarto.Size = new System.Drawing.Size(55, 13);
            this.lblIDQuarto.TabIndex = 1;
            this.lblIDQuarto.Text = "nº. Quarto";
            // 
            // nmrID
            // 
            this.nmrID.Enabled = false;
            this.nmrID.Location = new System.Drawing.Point(9, 34);
            this.nmrID.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nmrID.Name = "nmrID";
            this.nmrID.Size = new System.Drawing.Size(35, 20);
            this.nmrID.TabIndex = 0;
            this.nmrID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gridConsulta
            // 
            this.gridConsulta.AllowUserToAddRows = false;
            this.gridConsulta.AllowUserToDeleteRows = false;
            this.gridConsulta.AllowUserToResizeRows = false;
            this.gridConsulta.AutoGenerateColumns = false;
            this.gridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDQuartoDataGridViewTextBoxColumn,
            this.temTVDataGridViewCheckBoxColumn,
            this.vagasDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.gridConsulta.DataSource = this.quartoBindingSource;
            this.gridConsulta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridConsulta.Location = new System.Drawing.Point(12, 228);
            this.gridConsulta.MultiSelect = false;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConsulta.Size = new System.Drawing.Size(462, 190);
            this.gridConsulta.TabIndex = 2;
            this.gridConsulta.SelectionChanged += new System.EventHandler(this.gridConsulta_SelectionChanged);
            // 
            // iDQuartoDataGridViewTextBoxColumn
            // 
            this.iDQuartoDataGridViewTextBoxColumn.DataPropertyName = "IDQuarto";
            this.iDQuartoDataGridViewTextBoxColumn.HeaderText = "IDQuarto";
            this.iDQuartoDataGridViewTextBoxColumn.Name = "iDQuartoDataGridViewTextBoxColumn";
            this.iDQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temTVDataGridViewCheckBoxColumn
            // 
            this.temTVDataGridViewCheckBoxColumn.DataPropertyName = "TemTV";
            this.temTVDataGridViewCheckBoxColumn.HeaderText = "TemTV";
            this.temTVDataGridViewCheckBoxColumn.Name = "temTVDataGridViewCheckBoxColumn";
            // 
            // vagasDataGridViewTextBoxColumn
            // 
            this.vagasDataGridViewTextBoxColumn.DataPropertyName = "Vagas";
            this.vagasDataGridViewTextBoxColumn.HeaderText = "Vagas";
            this.vagasDataGridViewTextBoxColumn.Name = "vagasDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataMember = "Quarto";
            this.quartoBindingSource.DataSource = this.he_dadosDataSet;
            // 
            // he_dadosDataSet
            // 
            this.he_dadosDataSet.DataSetName = "he_dadosDataSet";
            this.he_dadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quartoTableAdapter
            // 
            this.quartoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAltera
            // 
            this.btnAltera.Location = new System.Drawing.Point(402, 423);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(75, 23);
            this.btnAltera.TabIndex = 3;
            this.btnAltera.Text = "Alterar ";
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(182, 424);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmAltConsQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 458);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAltera);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.gpbQuarto);
            this.Name = "frmAltConsQuarto";
            this.Text = "Consulta Quartos";
            this.Load += new System.EventHandler(this.frmConsultaQuarto_Load);
            this.gpbQuarto.ResumeLayout(false);
            this.gpbQuarto.PerformLayout();
            this.gpbTemTv.ResumeLayout(false);
            this.gpbTemTv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.he_dadosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbQuarto;
        private System.Windows.Forms.GroupBox gpbTemTv;
        private System.Windows.Forms.RadioButton optTvNao;
        private System.Windows.Forms.RadioButton optTvSim;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.NumericUpDown nmrVagas;
        private System.Windows.Forms.Label lblIDQuarto;
        private System.Windows.Forms.NumericUpDown nmrID;
        private System.Windows.Forms.DataGridView gridConsulta;
        private he_dadosDataSet he_dadosDataSet;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private he_dadosDataSetTableAdapters.QuartoTableAdapter quartoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn temTVDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vagasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.Button btnSalvar;

    }
}