using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace FormSingUp
{
    class MySQL
    {
        private static MySqlConnection conn;
        private static MySqlDataAdapter adpter;

        public MySQL()
        {
            conn = new MySqlConnection("Persist Security Info=False;server=localhost;database=Cadastro;uid=root;server = localhost; database = Cadastro; uid = root; pwd = ''");
            try
            {
                conn.Open();
            }
            catch(System.Exception ex)
            {
                Console.Write(ex.Message.ToString());
            }
        }

        public static MySqlConnection getConn()
        {
            return conn;
        }

        public static void setAdapter(String Cond, String Table)
        {
            adpter = new MySqlDataAdapter(Cond +" "+ Table, conn);
        }
    }
}
