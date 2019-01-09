using GiveSwitch.Data.Interfaces;
using GiveSwitch.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using System.Linq;

namespace GiveSwitch.Data.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly string connectionString;

        public UserProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<User> GetUsers()
        {
            IEnumerable<User> users = null;

            using (var connection = new SqlConnection(connectionString))
            {
                users = connection.Query<User>("select Id, FirstName, LastName from Users");
            }

            return users;
        }

        public User GetUserById(int userId)
        {
            User user = null;

            using (var connection = new SqlConnection(connectionString))
            {
                user = connection.Query<User>("select Id, FirstName, LastName from Users where Id=@Id", new { Id = userId }).FirstOrDefault();


                //test to use string in where clause works
                //user = connection.Query<User>("select Id, FirstName, LastName from Users where FirstName= 'Ben'").FirstOrDefault();
            }

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
