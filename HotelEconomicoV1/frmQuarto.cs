using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEconomicoV1
{

    public partial class frmQuarto : Form
    {
        void geraIDQuarto()
        {
            //Encontra ID do último quarto cadastrado
            if (conectaBancoQuarto.MyDataTable.Rows[0].IsNull("ID") != true)
                nmrID.Value = conectaBancoQuarto.MyDataTable.Rows[0].Field<int>("ID") + 1;
        }

        //Conecta no banco
        ConectaBanco conectaBancoQuarto  = new ConectaBanco();
        private string _tipoForm = "";
        
        public frmQuarto(string tipoForm)
        {
            _tipoForm = tipoForm.ToLower();
            InitializeComponent();
        }

        void loadCadastro()
        {
            conectaBancoQuarto.Sel = "SELECT MAX(IDQuarto) as ID from Quarto;";
            conectaBancoQuarto.MyCmd.CommandText = conectaBancoQuarto.Sel;
            conectaBancoQuarto.MyCmd.CommandType = CommandType.Text;

            //Seta conexão
            conectaBancoQuarto.MyCon.ConnectionString =
                "Server = .\\sqlexpress; trusted_connection = yes; database=he_dados;";
            conectaBancoQuarto.MyCmd.Connection = conectaBancoQuarto.MyCon;

            //Abre conexão
            try
            {
                conectaBancoQuarto.MyCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Preenche tabela com resultado do select
            DataTable dt = new DataTable();
            conectaBancoQuarto.MyAdapter.SelectCommand = conectaBancoQuarto.MyCmd;
            conectaBancoQuarto.MyAdapter.Fill(conectaBancoQuarto.MyDataTable);
            ;
            geraIDQuarto(); 
        }

        private void frmQuarto_Load(object sender, EventArgs e)
        {
            //Inicializa conexão, select e região do programa
            CultureInfo ci = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            
            //Executa form LOAD para cadastro
            if(_tipoForm == "cadastro")
                loadCadastro();

            //Define parâmetros da query
            conectaBancoQuarto.MyCmd.Parameters.Clear();
            conectaBancoQuarto.MyCmd.Parameters.Add("@Vagas", SqlDbType.Int);
            conectaBancoQuarto.MyCmd.Parameters.Add("@Descr", SqlDbType.VarChar);
            conectaBancoQuarto.MyCmd.Parameters.Add("@TV", SqlDbType.Bit);

            //Inicializa botões de rádio
            optTvNao.Checked = true;

        }

        private void optTvNao_Click(object sender, EventArgs e)
        {
            conectaBancoQuarto.MyCmd.Parameters["@TV"].Value = 0;
        }

        private void optTvSim_CheckedChanged(object sender, EventArgs e)
        {
            conectaBancoQuarto.MyCmd.Parameters["@TV"].Value = 1;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            //Busca valor dos parâmetros nos respectivos controles do form
            conectaBancoQuarto.MyCmd.Parameters["@Vagas"].Value = nmrVagas.Text;
            conectaBancoQuarto.MyCmd.Parameters["@Descr"].Value = txtDescr.Text;


            MessageBox.Show(txtDescr.Text + "      " + conectaBancoQuarto.MyCmd.Parameters["@Descr"].Value);
            conectaBancoQuarto.MyCmd.CommandText = "INSERT INTO Quarto (Vagas,Descricao,TemTV) " +
                                                   "VALUES (@Vagas,@Descr,@TV);";
            bool deuErro = false;
            try
            {
                conectaBancoQuarto.MyCmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                deuErro = true;
            }

            if (deuErro == false)
            {
                MessageBox.Show("Os dados do quarto foram registrados com sucesso.");
                nmrID.Value++;
            }
        }
    }
}
