using GSlate.CodingChallenge.Common.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSlate.CodingChallenge.DataAccess.Interfaces
{
    public interface IUserProjectDataAccess
    {
        public List<UserProject> GetUserProjectsByUser(int UserId);
    }
}
