using System.Data.Common;

namespace Kalinderya_Online_Api_Practice.Helper
{
    public class DbConnector
    {
        public DbConnection connection;
        public DbConnection Kalinderia()
        {
            IniFile ini = new IniFile("C:\\Users\\MANA20236155\\source\\repos\\Pet match\\CertificateProject\\Databases.ini");
            String database = ini.ReadValue("PetMatch", "database");
            String password = ini.ReadValue("PetMatch", "pwd");
            String user = ini.ReadValue("PetMatch", "uid");
            String server = ini.ReadValue("PetMatch", "server");
            Boolean allowUserVariables = Convert.ToBoolean(ini.ReadValue("PetMatch", "AllowUserVariables"));
            Boolean useAffectedRows = Convert.ToBoolean(ini.ReadValue("PetMatch", "UseAffectedRows"));
            connection = new DbConnection(database, user, password, server, allowUserVariables, useAffectedRows);
            Console.WriteLine(ini + "found"); 
            return connection;
        }
    }
}
