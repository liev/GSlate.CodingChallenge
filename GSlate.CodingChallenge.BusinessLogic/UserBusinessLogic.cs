using AutoMapper;
using GSlate.CodingChallenge.Common.Models.Entity;
using GSlate.CodingChallenge.Common.Models.ViewModels;
using GSlate.CodingChallenge.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using GSlate.CodingChallenge.Common.Helper.Transform;
using GSlate.CodingChallenge.BusinessLogic.Interfaces;

namespace GSlate.CodingChallenge.BusinessLogic
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly IUserDataAccess _userDataAccess;     

        public UserBusinessLogic(IUserDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;            
        }
        public List<UserViewModel> GetUsers()
        { 
            
            return ToDtO.UserListToDto(_userDataAccess.GetUsers());
           
        }
    }
}
