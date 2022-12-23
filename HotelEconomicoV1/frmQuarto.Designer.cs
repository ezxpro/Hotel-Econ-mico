namespace HotelEconomicoV1
{
    partial class frmQuarto
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
            this.lblQuarto = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.gpbQuarto.SuspendLayout();
            this.gpbTemTv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).BeginInit();
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
            this.gpbQuarto.Location = new System.Drawing.Point(3, 34);
            this.gpbQuarto.Name = "gpbQuarto";
            this.gpbQuarto.Size = new System.Drawing.Size(465, 188);
            this.gpbQuarto.TabIndex = 0;
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
            this.optTvNao.Size = new System.Drawing.Size(46, 17);
            this.optTvNao.TabIndex = 6;
            this.optTvNao.TabStop = true;
            this.optTvNao.Text = "Não";
            this.optTvNao.UseVisualStyleBackColor = true;
            this.optTvNao.Click += new System.EventHandler(this.optTvNao_Click);
            // 
            // optTvSim
            // 
            this.optTvSim.AutoSize = true;
            this.optTvSim.Location = new System.Drawing.Point(58, 16);
            this.optTvSim.Name = "optTvSim";
            this.optTvSim.Size = new System.Drawing.Size(43, 17);
            this.optTvSim.TabIndex = 7;
            this.optTvSim.TabStop = true;
            this.optTvSim.Text = "Sim";
            this.optTvSim.UseVisualStyleBackColor = true;
            this.optTvSim.CheckedChanged += new System.EventHandler(this.optTvSim_CheckedChanged);
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(11, 72);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(56, 13);
            this.lblDescr.TabIndex = 5;
            this.lblDescr.Text = "Descrição";
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(9, 88);
            this.txtDescr.Multiline = true;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(450, 94);
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
            this.nmrVagas.Size = new System.Drawing.Size(49, 22);
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
            this.lblIDQuarto.Size = new System.Drawing.Size(61, 13);
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
            this.nmrID.Size = new System.Drawing.Size(35, 22);
            this.nmrID.TabIndex = 0;
            this.nmrID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarto.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblQuarto.Location = new System.Drawing.Point(-1, 0);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(133, 21);
            this.lblQuarto.TabIndex = 1;
            this.lblQuarto.Text = "Cadastra Quarto";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(387, 222);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 2;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // frmQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 251);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.gpbQuarto);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuarto";
            this.Text = "Cadastra Quarto";
            this.Load += new System.EventHandler(this.frmQuarto_Load);
            this.gpbQuarto.ResumeLayout(false);
            this.gpbQuarto.PerformLayout();
            this.gpbTemTv.ResumeLayout(false);
            this.gpbTemTv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbQuarto;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.Label lblIDQuarto;
        private System.Windows.Forms.NumericUpDown nmrID;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.NumericUpDown nmrVagas;
        private System.Windows.Forms.GroupBox gpbTemTv;
        private System.Windows.Forms.RadioButton optTvNao;
        private System.Windows.Forms.RadioButton optTvSim;
        private System.Windows.Forms.Button btnCad;

    }
}