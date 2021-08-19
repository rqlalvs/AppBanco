using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ConsoleBanco11
{
    class Banco : IDisposable
    {

        private readonly SqlConnection conexao;

        public Banco()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
            conexao.Open();
        }


        public void ExecutaComando (string StrQuery)
        {
            var vComando = new SqlCommand
            {
                CommandText = StrQuery,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            vComando.ExecuteNonQuery();
        }

        public SqlDataReader RetornaComando (string StrQuery)
        {
            var comando = new SqlCommand(StrQuery, conexao);
            return comando.ExecuteReader();
        }

        public void Dispose()
        {
            if (conexao.State==ConnectionState.Open)
            conexao.Close();
        }

    }
}
