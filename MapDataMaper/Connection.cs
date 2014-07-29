using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDataMaper
{
    class Connection
    {
           public string createSqlServerConnection(string server, string db, string pass, string user)
           {
               string conStr;
               


               conStr = "Server=" + server + ";Database=" + db + ";User Id =" + user + ";Password=" + pass;

               return conStr;
           }
    }
}
