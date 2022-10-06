using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_manager
{
    internal class DALC
    {
        public static string GetConnectionString()
        {
            string conString = "Data Source = DESKTOP-IAEJSI3; Initial Catalog=ORIENT; Integrated Security = true;";

            return conString;
        }

    }
}
