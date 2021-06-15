using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEconomicoV1
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }
        ConectaBanco conectaBancoCliente = new ConectaBanco();
       
        public int IdClienteSelecionado = 0;//Armazenará valor do ID do cliente selecionado no DataGridView

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Seta região
            CultureInfo ci = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            //Seta Conexão
            conectaBancoCliente.MyCon.ConnectionString = conectaBancoCliente.MyConStr;
            //Seta comandos sql
            conectaBancoCliente.Sel = "Select * from cliente";
            conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;
            conectaBancoCliente.MyCmd.CommandType = CommandType.Text;
            conectaBancoCliente.MyCmd.Connection = conectaBancoCliente.MyCon;
            conectaBancoCliente.MyAdapter.SelectCommand = conectaBancoCliente.MyCmd;

            //PEGA TABELA DE CLIENTE E COLOCA NO DATAGRIDVIEW      
            //Tentativa de conexão
            try
            {
                conectaBancoCliente.MyCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Busca tabela de clientes no banco e joga num datatable do c#
            conectaBancoCliente.MyAdapter.Fill(conectaBancoCliente.MyDataTable);
            var dt = conectaBancoCliente.MyDataTable;

            //Libera espaço na grade removendo colunas menos importantes
            gridPrincipal.AutoGenerateColumns = true;
            gridPrincipal.DataSource = dt;
        
            gridPrincipal.Columns.Remove("Cep");
            gridPrincipal.Columns.Remove("Uf");
            gridPrincipal.Columns.Remove("Observacao");

            //Seta a largura das colunas
            gridPrincipal.Columns[0].Width = 58;//ID
            gridPrincipal.Columns[1].Width = 280;//Nome
            gridPrincipal.Columns[2].Width = 80;//Rg
            gridPrincipal.Columns[3].Width = 85;//cpf
            gridPrincipal.Columns[4].Width = 90;//Celular
            gridPrincipal.Columns[5].Width = 85;//Telefone
            gridPrincipal.Columns[6].Width = 65;//Nascimento

            //bloqueia acesso às células
            gridPrincipal.ReadOnly = true;

            //Habilita e seleciona consulta por ID
            optID.Enabled = true;
            optID.Checked = true;

            //Seta ID padrão como 1
            nmrID.Value = 1;
        }

        

        private void optID_CheckedChanged(object sender, EventArgs e)
        {
            if (optID.Checked)
            {
                txtNome.Enabled = false;
                nmrID.Enabled = true;
            }
        }

        private void optNome_CheckedChanged(object sender, EventArgs e)
        {
            if (optNome.Checked)
            {
                txtNome.Enabled = true;
                nmrID.Enabled = false;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (optID.Checked) //Consulta por ID
            {
                if (nmrID.Text == "0" || nmrID.Text == "")
                {
                    conectaBancoCliente.Sel = "select * from cliente;";
                    conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;
                }
                else
                {
                    conectaBancoCliente.Sel = "Select * from cliente " +
                                 "WHERE IDCliente = @ID";

                    conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;
                    conectaBancoCliente.MyCmd.Parameters.Clear();
                    conectaBancoCliente.MyCmd.Parameters.Add("@ID", SqlDbType.Int);
                    conectaBancoCliente.MyCmd.Parameters["@ID"].Value = nmrID.Text;
                }
                conectaBancoCliente.MyDataTable.Clear();
                conectaBancoCliente.MyAdapter.Fill(conectaBancoCliente.MyDataTable);
                gridPrincipal.Update();

            }
            else if (optNome.Checked) //Consulta por Nome
            {
                if (txtNome.Text == "")
                {
                    conectaBancoCliente.Sel = "select * from cliente";
                    conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;
                }
                else
                {
                    conectaBancoCliente.Sel = "Select * from [Cliente] " +
                                 "WHERE Nome like @Nome";

                    conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;
                    conectaBancoCliente.MyCmd.Parameters.Clear();
                    conectaBancoCliente.MyCmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                    conectaBancoCliente.MyCmd.Parameters["@Nome"].Value = "%"+txtNome.Text+"%";
                }
                conectaBancoCliente.MyDataTable.Clear();
                try
                {
                    conectaBancoCliente.MyAdapter.Fill(conectaBancoCliente.MyDataTable);
                    gridPrincipal.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void mnuCadCli_Click(object sender, EventArgs e)
        {
            var frmCadastrarCliente = new frmCadastoCliente("Cadastro");
            frmCadastrarCliente.Show();
        }

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }


        public void gridPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            //Armazena valor do ID do cliente selecionado.
            if (gridPrincipal.CurrentRow != null)
            {
                int id = 0;
                if(gridPrincipal.CurrentRow.Cells[0].Value.GetType().ToString() == "System.Int32")//Necessário checar tipo de dados, que pode ser Int32 ou DBNull.
                    id =(int) gridPrincipal.CurrentRow.Cells[0].Value;//Caso Value esteja vazio o programa trava.
                IdClienteSelecionado =  id;
                nmrID.Text = id.ToString();
            }
            
        }

        private void mnuAlteraCadCli_Click(object sender, EventArgs e)
        {

            //Chama formulário de alteração e passa ID do cliente a ser alterado
            if (IdClienteSelecionado != 0)
            {
                var frmAlteraCadastroCliente = new frmAlteraCadastro(IdClienteSelecionado, "altera");
                frmAlteraCadastroCliente.Show();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado para alteração!");
            }
        }

        private void gridPrincipal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Chama formulário de alteração de cadastro com todos os botões desativados
            if (IdClienteSelecionado != 0)
            {
                var frmAltCli = new frmAlteraCadastro(IdClienteSelecionado, "consulta");
                frmAltCli.Show();
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {

        }

        private void nmrID_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCadastraQuarto = new frmQuarto("cadastro");
            frmCadastraQuarto.Show();
        }

        private void gridPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmConsultaQuarto = new frmAltConsQuarto("consulta");
            frmConsultaQuarto.Show();
        }

        private void quartoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frmConsultaQuarto = new frmAltConsQuarto("altera");
            frmConsultaQuarto.Show();
        }
        
        
    }
}
