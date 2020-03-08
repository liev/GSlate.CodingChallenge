using GSlate.CodingChallenge.BusinessLogic.Interfaces;
using GSlate.CodingChallenge.Common.Helper.Transform;
using GSlate.CodingChallenge.Common.Models.ViewModels;
using GSlate.CodingChallenge.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSlate.CodingChallenge.BusinessLogic
{
    public class UserProjectBusinessLogic : IUserProjectBusinessLogic
    {
        private IUserProjectDataAccess _userProjectDataAccess;
        public UserProjectBusinessLogic(IUserProjectDataAccess userProjectDataAccess) 
        {
            _userProjectDataAccess = userProjectDataAccess;
        }
        public List<UserProjectViewModel> GetUSerProjectsByUser(int UserId)
        {
            return ToDtO.UserProyectToDto(_userProjectDataAccess.GetUserProjectsByUser(UserId));
        }
    }
}
