using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEconomicoV1
{
        public partial class frmAlteraCadastro : Form
        {
        
    
        private ConectaBanco conectaBancoCliente = new ConectaBanco();

        private string _tipoForm;
        private int idClienteSelecionado;

        public frmAlteraCadastro(int num, string tipoForm)
        {
            InitializeComponent();
            idClienteSelecionado = num;
            _tipoForm = tipoForm;
        }


        private void ativaCampos()
        {
            txtNome.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEndereco.Enabled = true;
            txtUf.Enabled = true;
            txtObs.Enabled = true;
            mskRg.Enabled = true;
            mskCelular.Enabled = true;
            mskCep.Enabled = true;
            mskCpf.Enabled = true;
            mskNascimento.Enabled = true;
            mskTelefone.Enabled = true;
        }

        private void desativaCampos()
        {
            txtNome.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEndereco.Enabled = false;
            txtUf.Enabled = false;
            txtObs.Enabled = false;
            mskRg.Enabled = false;
            mskCelular.Enabled = false;
            mskCep.Enabled = false;
            mskCpf.Enabled = false;
            mskNascimento.Enabled = false;
            mskTelefone.Enabled = false;
        }


        private void frmAlteraCadastro_Load(object sender, EventArgs e)
        {
            var ci = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            //Configura Conexão
            conectaBancoCliente.MyCon.ConnectionString = conectaBancoCliente.MyConStr;
            conectaBancoCliente.Sel = "set dateformat dmy \n" +
                                      "Select * from cliente where IDCliente = @ID";

            conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;
            conectaBancoCliente.MyCmd.Parameters.Add("@ID", SqlDbType.Int);
            conectaBancoCliente.MyCmd.Parameters["@ID"].Value = idClienteSelecionado;
            conectaBancoCliente.MyCmd.Connection = conectaBancoCliente.MyCon;
            conectaBancoCliente.MyAdapter.SelectCommand = conectaBancoCliente.MyCmd;
        
            //abre conexão
            conectaBancoCliente.MyCon.Open();

            //Cria e preenche tabela com os dados referentes ao cliente selecionado
            conectaBancoCliente.MyAdapter.Fill(conectaBancoCliente.MyDataTable);

            //Preenche tabela com dados do select espeficicado
            var dt = conectaBancoCliente.MyDataTable;

            //Preenche campos do form com os dados do cliente selecionado

                txtNome.Text = dt.Rows[0][1].ToString();
                txtNome.Text = dt.Rows[0][1].ToString();
                txtNome.Text = dt.Rows[0][1].ToString();
                mskRg.Text = dt.Rows[0][2].ToString();
                mskCpf.Text = dt.Rows[0][3].ToString();
                //MessageBox.Show(dt.Rows[0][4].ToString());
                mskCelular.Text = dt.Rows[0][4].ToString();
                mskTelefone.Text = dt.Rows[0][5].ToString();
                //A data necessita de conversão.
                DateTime dataNasc = (DateTime) dt.Rows[0][6];
                mskNascimento.Text = dataNasc.ToString("dd-MM-yyyy");

                txtEndereco.Text = dt.Rows[0][7].ToString();
                txtBairro.Text = dt.Rows[0][8].ToString();
                txtCidade.Text = dt.Rows[0][9].ToString();
                txtUf.Text = dt.Rows[0][10].ToString();
                mskCep.Text = dt.Rows[0][11].ToString();
                txtObs.Text = dt.Rows[0][12].ToString();
                
                if (_tipoForm == "consulta")
                {
                    desativaCampos();
                    lblTituloCadCli.Text = "Consulta de Cadastros";
                    btnSalvaAlts.Enabled = false;
                }
                else
                {
                    ativaCampos();
                    btnSalvaAlts.Enabled = true;
                    btnAlteraCad.Visible = false;
                }

                //Mostra o ID do cliente na caixa de seleção de numero de registro
                nmrID.Text = idClienteSelecionado.ToString();
        }

        private void btnSalvaAlts_Click(object sender, EventArgs e)
        {
            conectaBancoCliente.Sel = "SET DATEFORMAT dmy;\n " //seta o formato da data para dd/mm/yyyy
                                       + "update Cliente" +
                                       " set Nome = @Nome, Rg = @Rg, Cpf = @Cpf, Celular = @Celular, Telefone = @Telefone, " +
                                       "DataNascimento = @Nasc, Endereco = @Endrc, Bairro = @Bairro, Cidade = @Cidade, Uf = @Uf, " +
                                       "Cep = @Cep, Observacao = @Obs " +
                                       "WHERE IDCliente = @ID;";

            //Seta o parametros SQL e a conexão usadas
            conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;
            conectaBancoCliente.MyCmd.Parameters.Clear();
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@ID", idClienteSelecionado);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Rg", mskRg.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Cpf", mskCpf.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Celular", mskCelular.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Nasc", mskNascimento.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Endrc", txtEndereco.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Uf", txtUf.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Cep", mskCep.Text);
            conectaBancoCliente.MyCmd.Parameters.AddWithValue("@Obs", txtObs.Text);
            conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;

            execAltQuery();

        }

        private void gpbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnAlteraCad_Click(object sender, EventArgs e)
        {
            ativaCampos();
            btnSalvaAlts.Enabled = true;
            lblTituloCadCli.Text = "Alteração de Cadastros";
            btnAlteraCad.Visible = false;
        }
    }
}
