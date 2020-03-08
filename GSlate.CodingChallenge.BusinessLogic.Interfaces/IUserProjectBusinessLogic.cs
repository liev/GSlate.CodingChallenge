using GSlate.CodingChallenge.Common.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSlate.CodingChallenge.BusinessLogic.Interfaces
{
    public interface IUserProjectBusinessLogic
    {
        public List<UserProjectViewModel> GetUSerProjectsByUser(int UserId);
    }
}
