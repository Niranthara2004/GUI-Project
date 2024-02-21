using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
     class Database
    {
        public SqlConnection DB() {
            String con_String = "Data Source=DESKTOP-GM5HL4H;Initial Catalog=Student;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(con_String);
            return con;
        }
        
        
    }
}
