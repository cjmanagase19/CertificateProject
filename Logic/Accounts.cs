using Kalinderya_Online_Api_Practice.Helper;
using Microsoft.AspNetCore.Mvc;
using Pet_match.Model;
using System;

namespace Pet_match.Logic
{
    public class Accounts
    {
        public readonly DbConnection Connection;
        public readonly DbConnector Connector;
        public Accounts(DbConnection connection,DbConnector connector) { 
            this.Connection = connection;
            this.Connector = connector;
            connector.Kalinderia();
        }
        public User RegisterUser(User user)
        {
             string guid = generateUid();
            return user;
        }
        public string generateUid()
        {
            string stringUid = "";
            bool isThere = false;
            while(isThere!=true)
            {
                Guid guid = Guid.NewGuid();
                var query = "select id from login where id = @id ";
                using(var conn = this.Connection.GetConnection())
                {
                    conn.Open();
                    var command = conn.CreateCommand();
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@id", guid);
                    
                    int index = command.ExecuteNonQuery();
                    if(index == 0)
                    {
                        isThere = false;
                    }
                    else
                    {
                        isThere = true;
                        stringUid = guid.ToString();
                    }
                }

            }
            return stringUid;

        }
    }
}
