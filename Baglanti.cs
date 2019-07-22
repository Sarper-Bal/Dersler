using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti 
    {
        public static SqlConnection bg1 = new SqlConnection(@"Data Source=EXPER14\SQLEXPRESS;
           Initial Catalog=Dkayıt;Integrated Security=True");
    }
}
