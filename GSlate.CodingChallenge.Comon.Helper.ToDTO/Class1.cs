using GSlate.CodingChallenge.Common.Models.Entity;
using GSlate.CodingChallenge.Common.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace GSlate.CodingChallenge.Comon.Helper.Transform
{
    public class ToDtO
    {
        public List <UserViewModel> UserListToDto(List<User> users)
        {
            List<UserViewModel> userViewModels = new List<UserViewModel>();
            foreach(var item in users)
            {
                userViewModels.Add(new UserViewModel
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                });
            }

            return userViewModels;
        }
    }
}
