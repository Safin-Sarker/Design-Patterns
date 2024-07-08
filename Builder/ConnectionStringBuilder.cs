using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    internal class ConnectionStringBuilder
    {

        private ConnectionString _connectionString;

        
        public ConnectionStringBuilder(string server)
        {
            _connectionString = new ConnectionString();
            _connectionString.ConnectionStringItem.Append($"server={server};");
        }



        public void AddUsernameAndPassword(string username, string password)
        {
            _connectionString.ConnectionStringItem.Append($"User={username}, pass={password};");
        }

        public void AddTrustedConnection(bool IsTrue)
        {
            _connectionString.ConnectionStringItem.Append($"Trusted Connection={IsTrue}");
        }

        public void AddTrustedCertificate()
        {

        }


         

        public ConnectionString GetConnectionString ()
        {
            return _connectionString;


        }
    }
}
