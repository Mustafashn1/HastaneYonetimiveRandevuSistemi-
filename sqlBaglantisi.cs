using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LC9R15P\\;Initial Catalog=HastaneProjesi;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
