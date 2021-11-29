using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace WindowsFormsApp01
{
    public static class Conexao
    {
        public static NpgsqlConnection Abrir()
        {
            //alterar campos: Database e Password
            string connection = (@"Host=localhost;Port=5432;Database=SISGestor;Username=postgres;Password=123;");
            NpgsqlConnection conn = new NpgsqlConnection(connection);
            conn.Open();
            return conn;
        }      

    }
}
