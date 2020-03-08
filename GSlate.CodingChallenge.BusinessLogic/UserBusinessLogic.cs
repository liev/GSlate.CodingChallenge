﻿using AutoMapper;
using GSlate.CodingChallenge.BussinessLogic.Interfaces;
using GSlate.CodingChallenge.Common.Models.Entity;
using GSlate.CodingChallenge.Common.Models.ViewModels;
using GSlate.CodingChallenge.DataAccess.Interfaces;
using System;
using System.Collections.Generic;

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
            
            return UsertoDTO(_userDataAccess.GetUsers());
           
        }
    }
}