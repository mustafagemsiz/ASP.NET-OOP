using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccesLayer
{
    public class Baglanti
    {
         public static SqlConnection bgl = new SqlConnection(@"Data Source=MUSTAFA;Initial Catalog=Db_Personel;Integrated Security=True");
    }
}
