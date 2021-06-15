using System.Data;
using System.Data.SqlClient;


namespace HotelEconomicoV1
{
    class ConectaBanco
    {
        //Dados para conectar no banco.
        public string MyConStr = "Server = (localdb)\\MSSQLLocalDB; trusted_connection = yes; database=he_dados;";
        public SqlConnection MyCon = new SqlConnection();

        //Dados do comando sql a ser usado
        public string Sel = "Select * from cliente";
        public SqlCommand MyCmd = new SqlCommand();

        //Adaptador e tabela de clientes
        public SqlDataAdapter MyAdapter = new SqlDataAdapter();
        public DataTable MyDataTable = new DataTable();

    }
}
