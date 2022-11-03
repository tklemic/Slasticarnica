using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP_projekt
{
    public class PovezivanjeNaBazu
    {
        public NpgsqlConnection veza;

        public void OtvoriVezu()
        {
            string povezivanje = "Server=localhost;" +
                                 "Port=5432;" +
                                 "User Id=postgres;" +
                                 "Password = postgres;" +
                                 "Database = Slasticarnica;";
            veza = new NpgsqlConnection(povezivanje);
            veza.Open();
        }

        public void ZatvoriVezu()
        {
            veza.Close();
        }
    }
}