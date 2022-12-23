namespace HotelEconomicoV1
{
    partial class frmPrincipal
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.nmrID = new System.Windows.Forms.NumericUpDown();
            this.gridPrincipal = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.optID = new System.Windows.Forms.RadioButton();
            this.optNome = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadCli = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlteraCadCli = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPrincipal.Location = new System.Drawing.Point(13, 24);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(371, 25);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Hotel Econômico 1.0a - Gestor de Quartos";
            this.lblPrincipal.Click += new System.EventHandler(this.lblPrincipal_Click);
            // 
            // lblConsulta
            // 
            this.lblConsulta.Controls.Add(this.btnConsulta);
            this.lblConsulta.Controls.Add(this.nmrID);
            this.lblConsulta.Controls.Add(this.gridPrincipal);
            this.lblConsulta.Controls.Add(this.txtNome);
            this.lblConsulta.Controls.Add(this.optID);
            this.lblConsulta.Controls.Add(this.optNome);
            this.lblConsulta.Location = new System.Drawing.Point(12, 67);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(1300, 389);
            this.lblConsulta.TabIndex = 2;
            this.lblConsulta.TabStop = false;
            this.lblConsulta.Text = "Consultar Cliente";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(564, 42);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // nmrID
            // 
            this.nmrID.Location = new System.Drawing.Point(7, 44);
            this.nmrID.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrID.Name = "nmrID";
            this.nmrID.Size = new System.Drawing.Size(74, 22);
            this.nmrID.TabIndex = 6;
            this.nmrID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrID.Enter += new System.EventHandler(this.nmrID_Enter);
            // 
            // gridPrincipal
            // 
            this.gridPrincipal.AllowUserToDeleteRows = false;
            this.gridPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPrincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrincipal.Location = new System.Drawing.Point(0, 83);
            this.gridPrincipal.MultiSelect = false;
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.ReadOnly = true;
            this.gridPrincipal.RowHeadersWidth = 51;
            this.gridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrincipal.Size = new System.Drawing.Size(1294, 293);
            this.gridPrincipal.TabIndex = 6;
            this.gridPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrincipal_CellContentClick);
            this.gridPrincipal.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPrincipal_CellMouseDoubleClick);
            this.gridPrincipal.SelectionChanged += new System.EventHandler(this.gridPrincipal_SelectionChanged);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(87, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(453, 22);
            this.txtNome.TabIndex = 4;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            // 
            // optID
            // 
            this.optID.AutoSize = true;
            this.optID.Location = new System.Drawing.Point(6, 21);
            this.optID.Name = "optID";
            this.optID.Size = new System.Drawing.Size(36, 17);
            this.optID.TabIndex = 1;
            this.optID.TabStop = true;
            this.optID.Text = "ID";
            this.optID.UseVisualStyleBackColor = true;
            this.optID.CheckedChanged += new System.EventHandler(this.optID_CheckedChanged);
            // 
            // optNome
            // 
            this.optNome.AutoSize = true;
            this.optNome.Location = new System.Drawing.Point(87, 21);
            this.optNome.Name = "optNome";
            this.optNome.Size = new System.Drawing.Size(55, 17);
            this.optNome.TabIndex = 0;
            this.optNome.TabStop = true;
            this.optNome.Text = "Nome";
            this.optNome.UseVisualStyleBackColor = true;
            this.optNome.CheckedChanged += new System.EventHandler(this.optNome_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1347, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadCli,
            this.quartoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // mnuCadCli
            // 
            this.mnuCadCli.Name = "mnuCadCli";
            this.mnuCadCli.Size = new System.Drawing.Size(111, 22);
            this.mnuCadCli.Text = "Cliente";
            this.mnuCadCli.Click += new System.EventHandler(this.mnuCadCli_Click);
            // 
            // quartoToolStripMenuItem
            // 
            this.quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            this.quartoToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quartoToolStripMenuItem.Text = "Quarto";
            this.quartoToolStripMenuItem.Click += new System.EventHandler(this.quartoToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlteraCadCli,
            this.quartoToolStripMenuItem2});
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // mnuAlteraCadCli
            // 
            this.mnuAlteraCadCli.Name = "mnuAlteraCadCli";
            this.mnuAlteraCadCli.Size = new System.Drawing.Size(178, 22);
            this.mnuAlteraCadCli.Text = "Cadastro do Cliente";
            this.mnuAlteraCadCli.Click += new System.EventHandler(this.mnuAlteraCadCli_Click);
            // 
            // quartoToolStripMenuItem2
            // 
            this.quartoToolStripMenuItem2.Name = "quartoToolStripMenuItem2";
            this.quartoToolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
            this.quartoToolStripMenuItem2.Text = "Quarto";
            this.quartoToolStripMenuItem2.Click += new System.EventHandler(this.quartoToolStripMenuItem2_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quartoToolStripMenuItem1});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // quartoToolStripMenuItem1
            // 
            this.quartoToolStripMenuItem1.Name = "quartoToolStripMenuItem1";
            this.quartoToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.quartoToolStripMenuItem1.Text = "Quarto";
            this.quartoToolStripMenuItem1.Click += new System.EventHandler(this.quartoToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1347, 461);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Opacity = 0.9D;
            this.Text = "Hotel Econômico 1.0a ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblConsulta.ResumeLayout(false);
            this.lblConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.GroupBox lblConsulta;
        private System.Windows.Forms.DataGridView gridPrincipal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton optID;
        private System.Windows.Forms.RadioButton optNome;
        private System.Windows.Forms.NumericUpDown nmrID;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadCli;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAlteraCadCli;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem2;


    }
}

