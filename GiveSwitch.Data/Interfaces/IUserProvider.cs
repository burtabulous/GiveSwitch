using GiveSwitch.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiveSwitch.Data.Interfaces
{
    public interface IUserProvider
    {
        IEnumerable<User> GetUsers();

        User GetUserById(int userId);
    }
}
