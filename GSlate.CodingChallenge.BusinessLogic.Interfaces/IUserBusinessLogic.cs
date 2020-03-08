﻿using GSlate.CodingChallenge.Common.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace GSlate.CodingChallenge.BusinessLogic.Interfaces
{
    public interface IUserBusinessLogic
    {
        public List<UserViewModel> GetUsers();
    }
}
