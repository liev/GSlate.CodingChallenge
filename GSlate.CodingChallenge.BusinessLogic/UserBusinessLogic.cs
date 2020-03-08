using AutoMapper;
using GSlate.CodingChallenge.BussinessLogic.Interfaces;
using GSlate.CodingChallenge.Common.Models.ViewModels;
using GSlate.CodingChallenge.DataAccess.Interfaces;
using System;
using System.Collections.Generic;

namespace GSlate.CodingChallenge.BusinessLogic
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly IUserDataAccess _userDataAccess;
        private readonly IMapper _mapper;

        public UserBusinessLogic(IUserDataAccess userDataAccess, IMapper mapper)
        {
            _userDataAccess = userDataAccess;
            _mapper = mapper;
        }
        public List<UserViewModel> GetUsers()
        {
            return _mapper.Map<List<UserViewModel>> (_userDataAccess.GetUsers());
        }
    }
}
