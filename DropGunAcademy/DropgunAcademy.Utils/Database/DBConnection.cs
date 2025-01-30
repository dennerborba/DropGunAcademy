using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropgunAcademy.Utils.Database
{
    public class DBConnection
    {
        public const string CONNECTION_STRING = "Server=localhost;Database=escola_aviacao;User ID=root;Password=@1@senac2021;";

        public static bool TestarConexao()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

