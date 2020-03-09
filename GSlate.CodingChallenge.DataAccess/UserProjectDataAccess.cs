using GSlate.CodingChallenge.Common.Models.Entity;
using GSlate.CodingChallenge.Common.Models.Entity.Context;
using GSlate.CodingChallenge.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GSlate.CodingChallenge.DataAccess
{
    public class UserProjectDataAccess : IUserProjectDataAccess
    {
        public List<UserProject> GetUserProjectsByUser(int UserId)
        {
            using GSlateContext __Context = new GSlateContext();
            return __Context.UserProjects.Include(up=>up.Project).Include(up=>up.User).Where(p => p.UserId == UserId).ToList();
        }
    }
}
