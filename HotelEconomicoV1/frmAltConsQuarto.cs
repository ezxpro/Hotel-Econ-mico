using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEconomicoV1
{
    public partial class frmAltConsQuarto : Form
    {
        private string _tipoForm = "";
        public frmAltConsQuarto(string tipoForm)
        {
            _tipoForm = tipoForm.ToLower();
            InitializeComponent();
        }

        void consultaLoad()
        {
            nmrID.Enabled = false;
            nmrVagas.Enabled = false;
            txtDescr.Enabled = false;
            gpbTemTv.Enabled = false;
            
        }

        void alteraLoad()
        {
            nmrID.Enabled = false;
            nmrVagas.Enabled = true;
            txtDescr.Enabled = true;
            gpbTemTv.Enabled = true;
        }

        private void frmConsultaQuarto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'he_dadosDataSet.Quarto' table. You can move, or remove it, as needed.
            this.quartoTableAdapter.Fill(this.he_dadosDataSet.Quarto);
            if (_tipoForm == "consulta")
            {
                consultaLoad();
            }
            else
            {
                alteraLoad();
            }

        }

        private void gridConsulta_SelectionChanged(object sender, EventArgs e)
        {
            if (gridConsulta.CurrentRow != null)
            {
                if (gridConsulta.CurrentRow.Cells[0].Value.GetType().ToString() == "System.Int32")
                {
                    nmrID.Text = gridConsulta.CurrentRow.Cells[0].Value.ToString();
                    nmrVagas.Text = gridConsulta.CurrentRow.Cells[2].Value.ToString();

                    bool temTV = (bool) gridConsulta.CurrentRow.Cells[1].Value;
                    //Nesse caso, o valor da coluna 'TemTV' é 1, logo é verdadeiro. Como efeito, o formulário marcará SIM na opção "Tem TV?"
                    if (temTV)
                    {
                        optTvSim.Checked = true;
                    }
                    //Nesse caso, o valor da coluna 'TemTV' é 0, logo é falso. Como efeito, o formulário marcará NÃO na opção "Tem TV?"
                    else if (!temTV)
                    {
                        optTvNao.Checked = true;
                    }
                }
                txtDescr.Text = gridConsulta.CurrentRow.Cells[3].Value.ToString();

            }

        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            alteraLoad();
            btnAltera.Visible = false;
            btnSalvar.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Armazena valor de 'TemTV'. Se a caixa "SIM" estiver marcada, temTV = true. Senão, recebe false;
            bool temTV = false;
            if (optTvSim.Checked)
                temTV = true;
            

            //Cria novo set de configurações para conectar ao banco
            var conectaBancoAltQuarto = new ConectaBanco();
            
            //Seta select
            conectaBancoAltQuarto.MyCmd.CommandText =
                "UPDATE Quarto set Vagas = @vagas, TemTV = @tv, Descricao = @descr " +
                "where IDQuarto = @ID";

            conectaBancoAltQuarto.MyCmd.CommandType = CommandType.Text;
            
            //Adiciona parametros
            conectaBancoAltQuarto.MyCmd.Parameters.Clear();
            conectaBancoAltQuarto.MyCmd.Parameters.Add("@ID", SqlDbType.Int);
            conectaBancoAltQuarto.MyCmd.Parameters.Add("@vagas",SqlDbType.TinyInt);
            conectaBancoAltQuarto.MyCmd.Parameters.Add("@tv",SqlDbType.Bit);
            conectaBancoAltQuarto.MyCmd.Parameters.Add("@descr",SqlDbType.VarChar);

            //Adiciona valor dos parâmetros
            conectaBancoAltQuarto.MyCmd.Parameters["@ID"].Value = Int32.Parse(nmrID.Text);
            conectaBancoAltQuarto.MyCmd.Parameters["@vagas"].Value = byte.Parse(nmrVagas.Text);
            conectaBancoAltQuarto.MyCmd.Parameters["@tv"].Value = temTV;
            conectaBancoAltQuarto.MyCmd.Parameters["@descr"].Value = txtDescr.Text;

            //seta conexão do banco.
            conectaBancoAltQuarto.MyCon.ConnectionString =
                "Server = .\\sqlexpress; trusted_connection = yes; database=he_dados;";
            conectaBancoAltQuarto.MyCmd.Connection = conectaBancoAltQuarto.MyCon;

            //Abre conexão
            try
            {
                conectaBancoAltQuarto.MyCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Executa Query
            bool deuErro = false;
            try
            {
                conectaBancoAltQuarto.MyCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                deuErro = true;
            }
            finally
            {
                try
                {
                    conectaBancoAltQuarto.MyCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (deuErro == false)
                {
                    MessageBox.Show("Cadastro do quarto " + nmrID.Text + " atualizado com sucesso.");
                    conectaBancoAltQuarto.MyCmd.CommandText = "Select * from Quarto";
                    conectaBancoAltQuarto.MyCmd.CommandType = CommandType.Text;
                    conectaBancoAltQuarto.MyCmd.Connection = conectaBancoAltQuarto.MyCon;
                    conectaBancoAltQuarto.MyAdapter.SelectCommand = conectaBancoAltQuarto.MyCmd;
                    conectaBancoAltQuarto.MyAdapter.Fill(he_dadosDataSet.Quarto);
                    gridConsulta.Update();
                }
            }
        }
    }
}
