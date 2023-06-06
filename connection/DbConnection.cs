using MySqlConnector;

namespace Kalinderya_Online_Api_Practice.Helper
{
    public class DbConnection
    {
        //call the mysqlconnection
        private MySqlConnection connections;
        string connection;
        public DbConnection(string database, string user, string password, string server, bool allowUserVariables, bool useAffectedRows)
        {
            initiated(database, user, password, server, allowUserVariables, useAffectedRows);
        }

        public void initiated(string database, string user, string password, string server, bool allowUserVariable, bool useAffectedRows)
        {
            //string connection = "server =" + server + ";database=" + database + ";uid=" + user + ";pwd=" + password + ";";
            connection = "server=" + server + "; database=" + database + "; uid=" + user + "; pwd=" + password + "; AllowUserVariables=" + allowUserVariable + "; UseAffectedRows=" + useAffectedRows + ";";
            //
            connections = new MySqlConnection(connection);
        }
        public void connect()
        {
            this.connections.Open();
        }
        public void close()
        {
            this.connections.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connections;
        }

        public void Dispose()
        {
            connections.Dispose();
        }
    }
}
