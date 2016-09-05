using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmPlus
{
    class Globals
    {
        public static string DBConn = "Data Source=.;Initial Catalog=Users;Integrated Security=True";
        public static String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
