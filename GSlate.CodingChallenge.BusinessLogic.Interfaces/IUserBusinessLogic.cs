using GSlate.CodingChallenge.Common.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace GSlate.CodingChallenge.BussinessLogic.Interfaces
{
    public interface IUserBusinessLogic
    {
        public List<UserViewModel> GetUsers();
    }
}
