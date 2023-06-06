using Kalinderya_Online_Api_Practice.Helper;
using Microsoft.AspNetCore.Mvc;
using Pet_match.Model;
using System;

namespace Pet_match.Logic
{

    public class Accounts
    {
        DbConnection Connection;
        public Accounts()
        {
            DbConnector connector = new DbConnector();
            DbConnection Dbconnection = connector.Kalinderia();
            this.Connection = Dbconnection;

        }
        public User RegisterUser(User user)
        {
            string query = "INSERT INTO (id,firstName,lastName,age) values (@id,@firstName,@lastName,@age)";
            using(var conn = this.Connection.GetConnection())
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@id", user.guid);
                command.Parameters.AddWithValue("@firstName", user.firstName);
                command.Parameters.AddWithValue("@lastName", user.lastName);
                command.Parameters.AddWithValue("@age", user.age);
                int index = command.ExecuteNonQuery();
                if (index == 0)
                {
                    throw new Exception("Something error occur, please try again.");
                }
                return user;
            }
        }
        public Login RegisterLogin(Login login)
        {
            
            string query = "INSERT INTO login(id,username,password) VALUES (@id,@userName,@password)";
            using(var conn = this.Connection.GetConnection())
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@id", generateUid());
                command.Parameters.AddWithValue("@userName", login.userName);
                command.Parameters.AddWithValue("@password", login.password);
                int index = command.ExecuteNonQuery();
                if (index == 0)
                {
                    throw new Exception("Something error occur, please try again.");
                }
                return login;
            }
            
        }
        public string generateUid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
