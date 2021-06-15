using System;
using System.Windows.Forms;

namespace HotelEconomicoV1
{

    partial class frmAlteraCadastro
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

        private void execAltQuery()
        {
            //CHECA SE CAMPOS OBRIGATORIOS ESTÃO PREENCHIDOS
            bool nomeOK = false, rgOK = false, cpfOK = false, nascOK = false;
            if (txtNome.Text.Length < 4)//Campo nome
            {
                MessageBox.Show("Atenção, o nome não pode conter menos que 4 caracteres.");
            }
            else
            {
                nomeOK = true;
            }

            if (mskRg.Text.Length < 12)//Campo RG
            {
                if (nomeOK)
                    MessageBox.Show("O RG digitado possui menos de 9 dígitos. \nVerifique e tente novamente.");
            }
            else
            {
                rgOK = true;
            }

            if (mskCpf.Text.Length < 14)//Campo CPF
            {
                if (rgOK)
                    MessageBox.Show("O CPF digitado possui menos de 11 dígitos. \nVerifique e tente novamente.");
            }
            else
            {
                cpfOK = true;
            }

            if (mskNascimento.Text.Length < 10)//Data de Nascimento
            {
                if (cpfOK)
                    MessageBox.Show("A data de nascimento está incorreta ou não foi inserida. \nVerifique e tente novamente.");
            }
            else
            {
                nascOK = true;
            }

            //Executa query e retorna mensagem de sucesso
            if (nascOK && cpfOK && rgOK && nomeOK)
            {
                bool deuErro = false;
                try
                {
                    conectaBancoCliente.MyCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    deuErro = true;
                }
                finally
                {
                    if (deuErro == false)
                    {
                        MessageBox.Show("Cadastro do cliente número " + nmrID.Text +" foi atualizado com sucesso.");
                    }

                }
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.nmrID = new System.Windows.Forms.NumericUpDown();
            this.lblRegCli = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.btnSalvaAlts = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.btnAlteraCad = new System.Windows.Forms.Button();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.mskNascimento = new System.Windows.Forms.MaskedTextBox();
            this.gpbContato = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblTituloCadCli = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).BeginInit();
            this.gpbContato.SuspendLayout();
            this.gpbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskTelefone
            // 
            this.mskTelefone.BackColor = System.Drawing.Color.White;
            this.mskTelefone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskTelefone.Location = new System.Drawing.Point(10, 84);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(135, 22);
            this.mskTelefone.TabIndex = 12;
            this.mskTelefone.Text = "16";
            // 
            // nmrID
            // 
            this.nmrID.BackColor = System.Drawing.Color.White;
            this.nmrID.Enabled = false;
            this.nmrID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nmrID.InterceptArrowKeys = false;
            this.nmrID.Location = new System.Drawing.Point(10, 32);
            this.nmrID.Maximum = new decimal(new int[] {
            839452,
            0,
            0,
            0});
            this.nmrID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrID.Name = "nmrID";
            this.nmrID.Size = new System.Drawing.Size(72, 22);
            this.nmrID.TabIndex = 25;
            this.nmrID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRegCli
            // 
            this.lblRegCli.AutoSize = true;
            this.lblRegCli.Location = new System.Drawing.Point(8, 16);
            this.lblRegCli.Name = "lblRegCli";
            this.lblRegCli.Size = new System.Drawing.Size(44, 13);
            this.lblRegCli.TabIndex = 24;
            this.lblRegCli.Text = "nº Reg.";
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.White;
            this.txtObs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtObs.Location = new System.Drawing.Point(10, 258);
            this.txtObs.MaxLength = 700;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(751, 74);
            this.txtObs.TabIndex = 13;
            this.txtObs.Text = "";
            // 
            // mskCep
            // 
            this.mskCep.BackColor = System.Drawing.Color.White;
            this.mskCep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskCep.Location = new System.Drawing.Point(479, 156);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(56, 22);
            this.mskCep.TabIndex = 9;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(479, 141);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(27, 13);
            this.lblCep.TabIndex = 22;
            this.lblCep.Text = "Cep";
            // 
            // txtUf
            // 
            this.txtUf.BackColor = System.Drawing.Color.White;
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUf.Location = new System.Drawing.Point(447, 156);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(26, 22);
            this.txtUf.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCidade.Location = new System.Drawing.Point(196, 156);
            this.txtCidade.MaxLength = 40;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(242, 22);
            this.txtCidade.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBairro.Location = new System.Drawing.Point(11, 156);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(177, 22);
            this.txtBairro.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(7, 67);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(50, 13);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(7, 25);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(45, 13);
            this.lblCelular.TabIndex = 0;
            this.lblCelular.Text = "Celular ";
            // 
            // btnSalvaAlts
            // 
            this.btnSalvaAlts.Location = new System.Drawing.Point(713, 403);
            this.btnSalvaAlts.Name = "btnSalvaAlts";
            this.btnSalvaAlts.Size = new System.Drawing.Size(75, 23);
            this.btnSalvaAlts.TabIndex = 25;
            this.btnSalvaAlts.Text = "Salvar Alterações";
            this.btnSalvaAlts.UseVisualStyleBackColor = true;
            this.btnSalvaAlts.Click += new System.EventHandler(this.btnSalvaAlts_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndereco.Location = new System.Drawing.Point(194, 114);
            this.txtEndereco.MaxLength = 80;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(384, 22);
            this.txtEndereco.TabIndex = 5;
            // 
            // mskCpf
            // 
            this.mskCpf.BackColor = System.Drawing.Color.White;
            this.mskCpf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskCpf.Location = new System.Drawing.Point(88, 115);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 22);
            this.mskCpf.TabIndex = 4;
            // 
            // mskRg
            // 
            this.mskRg.BackColor = System.Drawing.Color.White;
            this.mskRg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskRg.Location = new System.Drawing.Point(11, 114);
            this.mskRg.Mask = "00,000,000-0";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(71, 22);
            this.mskRg.TabIndex = 3;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(193, 140);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(444, 140);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 13);
            this.lblUf.TabIndex = 11;
            this.lblUf.Text = "UF";
            // 
            // mskCelular
            // 
            this.mskCelular.BackColor = System.Drawing.Color.White;
            this.mskCelular.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskCelular.Location = new System.Drawing.Point(10, 42);
            this.mskCelular.Mask = "(99) 0 0000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(135, 22);
            this.mskCelular.TabIndex = 11;
            this.mskCelular.Text = "16";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(191, 99);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(54, 13);
            this.lblEndereco.TabIndex = 13;
            this.lblEndereco.Text = "Endereço";
            // 
            // btnAlteraCad
            // 
            this.btnAlteraCad.Location = new System.Drawing.Point(595, 403);
            this.btnAlteraCad.Name = "btnAlteraCad";
            this.btnAlteraCad.Size = new System.Drawing.Size(112, 23);
            this.btnAlteraCad.TabIndex = 27;
            this.btnAlteraCad.Text = "Alterar Cadastro";
            this.btnAlteraCad.UseVisualStyleBackColor = true;
            this.btnAlteraCad.Click += new System.EventHandler(this.btnAlteraCad_Click);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(8, 242);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(67, 13);
            this.lblObservacao.TabIndex = 10;
            this.lblObservacao.Text = "Observação";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(8, 140);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 13);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Red;
            this.lblCPF.Location = new System.Drawing.Point(85, 99);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(35, 13);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF *";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.Color.Red;
            this.lblRG.Location = new System.Drawing.Point(8, 98);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(30, 13);
            this.lblRG.TabIndex = 7;
            this.lblRG.Text = "RG *";
            // 
            // mskNascimento
            // 
            this.mskNascimento.BackColor = System.Drawing.Color.White;
            this.mskNascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mskNascimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNascimento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskNascimento.Location = new System.Drawing.Point(11, 197);
            this.mskNascimento.Mask = "00/00/0000";
            this.mskNascimento.Name = "mskNascimento";
            this.mskNascimento.Size = new System.Drawing.Size(118, 23);
            this.mskNascimento.TabIndex = 10;
            this.mskNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // gpbContato
            // 
            this.gpbContato.Controls.Add(this.mskTelefone);
            this.gpbContato.Controls.Add(this.mskCelular);
            this.gpbContato.Controls.Add(this.lblTelefone);
            this.gpbContato.Controls.Add(this.lblCelular);
            this.gpbContato.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gpbContato.Location = new System.Drawing.Point(610, 57);
            this.gpbContato.Name = "gpbContato";
            this.gpbContato.Size = new System.Drawing.Size(151, 115);
            this.gpbContato.TabIndex = 5;
            this.gpbContato.TabStop = false;
            this.gpbContato.Text = "Informações de Contato";
            // 
            // txtNome
            // 
            this.txtNome.AcceptsReturn = true;
            this.txtNome.AcceptsTab = true;
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(11, 73);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(568, 22);
            this.txtNome.TabIndex = 2;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.Red;
            this.lblNomeCliente.Location = new System.Drawing.Point(8, 57);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(47, 13);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome *";
            // 
            // lblTituloCadCli
            // 
            this.lblTituloCadCli.AutoSize = true;
            this.lblTituloCadCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadCli.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTituloCadCli.Location = new System.Drawing.Point(14, 9);
            this.lblTituloCadCli.Name = "lblTituloCadCli";
            this.lblTituloCadCli.Size = new System.Drawing.Size(179, 21);
            this.lblTituloCadCli.TabIndex = 26;
            this.lblTituloCadCli.Text = "Alteração de Cadastros";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.Color.Red;
            this.lblNascimento.Location = new System.Drawing.Point(8, 181);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblNascimento.TabIndex = 5;
            this.lblNascimento.Text = "Data Nascimento *";
            // 
            // gpbCliente
            // 
            this.gpbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.gpbCliente.Controls.Add(this.nmrID);
            this.gpbCliente.Controls.Add(this.lblRegCli);
            this.gpbCliente.Controls.Add(this.txtObs);
            this.gpbCliente.Controls.Add(this.mskCep);
            this.gpbCliente.Controls.Add(this.lblCep);
            this.gpbCliente.Controls.Add(this.txtUf);
            this.gpbCliente.Controls.Add(this.txtCidade);
            this.gpbCliente.Controls.Add(this.txtBairro);
            this.gpbCliente.Controls.Add(this.txtEndereco);
            this.gpbCliente.Controls.Add(this.mskCpf);
            this.gpbCliente.Controls.Add(this.mskRg);
            this.gpbCliente.Controls.Add(this.lblEndereco);
            this.gpbCliente.Controls.Add(this.lblCidade);
            this.gpbCliente.Controls.Add(this.lblUf);
            this.gpbCliente.Controls.Add(this.lblObservacao);
            this.gpbCliente.Controls.Add(this.lblBairro);
            this.gpbCliente.Controls.Add(this.lblCPF);
            this.gpbCliente.Controls.Add(this.lblRG);
            this.gpbCliente.Controls.Add(this.mskNascimento);
            this.gpbCliente.Controls.Add(this.lblNascimento);
            this.gpbCliente.Controls.Add(this.gpbContato);
            this.gpbCliente.Controls.Add(this.txtNome);
            this.gpbCliente.Controls.Add(this.lblNomeCliente);
            this.gpbCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpbCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gpbCliente.Location = new System.Drawing.Point(18, 56);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(770, 341);
            this.gpbCliente.TabIndex = 24;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Dados Cliente";
            this.gpbCliente.Enter += new System.EventHandler(this.gpbCliente_Enter);
            // 
            // frmAlteraCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 431);
            this.Controls.Add(this.btnSalvaAlts);
            this.Controls.Add(this.btnAlteraCad);
            this.Controls.Add(this.lblTituloCadCli);
            this.Controls.Add(this.gpbCliente);
            this.Name = "frmAlteraCadastro";
            this.Text = "Alterar Cadastro";
            this.Load += new System.EventHandler(this.frmAlteraCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).EndInit();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.NumericUpDown nmrID;
        private System.Windows.Forms.Label lblRegCli;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button btnSalvaAlts;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button btnAlteraCad;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mskNascimento;
        private System.Windows.Forms.GroupBox gpbContato;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblTituloCadCli;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.GroupBox gpbCliente;

    }
}