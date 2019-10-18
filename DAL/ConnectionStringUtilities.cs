using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ConnectionStringUtilities
    {
        public static string getConnectionString()
        {
            return "data source=DESKTOP-RHGPVC0;initial catalog=CustomerHelpDesk1;integrated security=sspi";
        }
    }
}
