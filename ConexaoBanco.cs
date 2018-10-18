using System;
using System.Data.SqlClient;
using SIG;

namespace SIG
{
    public class ConexaoBanco
    {
        public static  SqlConnection sqlConnection = new SqlConnection(@"Data Source=ultrabook;Initial Catalog=Dados;Integrated Security=True");
    }

}
