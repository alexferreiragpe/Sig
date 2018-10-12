using System;
using System.Data.SqlClient;
using SGVB;

namespace SGVB
{
    public class ConexaoBanco
    {
        public static  SqlConnection sqlConnection = new SqlConnection(@"Data Source=casa;Initial Catalog=Dados;Integrated Security=True");
    }

}
