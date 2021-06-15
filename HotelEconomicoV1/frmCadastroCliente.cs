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
    public partial class frmCadastoCliente : Form
    {
        private string _stringTipoForm;
        public frmCadastoCliente(string stringTipoForm)
        {
            InitializeComponent();
            _stringTipoForm = stringTipoForm;
        }
        ConectaBanco conectaBancoCliente = new ConectaBanco();


        private void frmCadastoCliente_Load(object sender, EventArgs e)
        {
            
            //Configura Conexão
            conectaBancoCliente.MyCon.ConnectionString = conectaBancoCliente.MyConStr;
            conectaBancoCliente.Sel = "Select MAX(IDCLIENTE) as ID from cliente";
            conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;
            conectaBancoCliente.MyCmd.Connection = conectaBancoCliente.MyCon;
            conectaBancoCliente.MyAdapter.SelectCommand = conectaBancoCliente.MyCmd;

            //abre conexão
            conectaBancoCliente.MyCon.Open();

            //Configura estado inicial do formulário
            conectaBancoCliente.MyAdapter.Fill(conectaBancoCliente.MyDataTable);//Preenche tabela com dados do select espeficicado
            var dt = conectaBancoCliente.MyDataTable;

            // Gera o valor do ID do próximo cliente a ser cadastrado e mostra na janela de cadastro de cliente.
            nmrID.Enabled = false;
            
            //Seleciona o valor inteiro do campo ID na linha 0 da datatable DT 
            //Este valor refere-se ao ID do ultimo cliente cadastrado.
            int ultimoIDCadastrado = 0;

            if (dt.Rows[0].IsNull("ID") == false)
            {
                ultimoIDCadastrado = (dt.Rows[0].Field<int>("ID"));
            }
            //O controle nmrID mostra o ID do cliente que está sendo cadastrado no momento, ou seja, ultimo ID + 1
            nmrID.Text = (ultimoIDCadastrado + 1).ToString();
        }


        private void get_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("RG = "+mskRg.Text.Length.ToString() 
                + "\n" + "CPF ="+mskCpf.Text.Length.ToString()
                    +"\n"+ "nome="+txtNome.Text.Length.ToString() +
                    "\n" +"Nacimento=" +mskNascimento.Text.Length.ToString()
            );
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //CADASTRA NOVO CLIENTE
            //Define o INSERT a ser usado
            conectaBancoCliente.Sel = "SET DATEFORMAT dmy;\n" //seta o formato da data para dd/mm/yyyy
                        + "Insert into cliente(" +
                         "nome,Rg,Cpf,Celular,Telefone,DataNascimento,Endereco," +
                         "bairro,cidade,uf,cep,observacao)" +
                         "values(@Nome,@Rg,@Cpf,@Celular,@Telefone,@Nasc,@Endrc,@Bairro,@Cidade,"+
                                "@Uf,@Cep,@Obs);";

            //Seta o parametros SQL e a conexão usadas
            conectaBancoCliente.MyCmd.CommandText = conectaBancoCliente.Sel;
            conectaBancoCliente.MyCmd.Parameters.Clear();
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
            conectaBancoCliente.MyCmd.Connection = conectaBancoCliente.MyCon;

            execCadQuery();

        }

        private void frmCadastoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        
    }
}
