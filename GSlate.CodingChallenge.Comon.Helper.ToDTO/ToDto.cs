using GSlate.CodingChallenge.Common.Models.Entity;
using GSlate.CodingChallenge.Common.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace GSlate.CodingChallenge.Common.Helper.Transform
{
    public static class ToDtO
    {
        public static List <UserViewModel> UserListToDto(List<User> users)
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

        public static List<UserProjectViewModel> UserProyectToDto(List<UserProject> userProjects)
        {
            List<UserProjectViewModel> userProjectViewModels = new List<UserProjectViewModel>();
            foreach (var item in userProjects)
            {
                userProjectViewModels.Add(new UserProjectViewModel
                {
                    UserId = item.UserId,
                    ProjectId = item.ProjectId,
                    AssignedDate = item.AssignedDate,
                    IsActive = item.IsActive,
                    Project = item.Project,
                    User = item.User
                });
            }

            return userProjectViewModels;
        }
    }
}
