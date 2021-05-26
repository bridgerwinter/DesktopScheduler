using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktopScheduler
{
    class Database
    {
        static MySqlConnection con;
        public static void connectAndOpenDB()
        {
            con = new MySqlConnection("server = wgudb.ucertify.com; user id = U057MV; persistsecurityinfo = True; database = U057MV");
            con.Open();
        }
    }
}
