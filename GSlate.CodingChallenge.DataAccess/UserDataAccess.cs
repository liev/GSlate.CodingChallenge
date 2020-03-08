using GSlate.CodingChallenge.Common.Models.Entity;
using GSlate.CodingChallenge.Common.Models.Entity.Context;
using GSlate.CodingChallenge.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSlate.CodingChallenge.DataAccess
{
    public class UserDataAccess : IUserDataAccess
    {
        public List<User> GetUsers()
        {
            using GSlateContext __Context = new GSlateContext();
            return __Context.Users.ToList();
        }
    }
}
