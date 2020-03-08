using GSlate.CodingChallenge.Common.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSlate.CodingChallenge.Common.Models.ViewModels
{
    public partial  class UserProjectViewModel:UserProject
    {
        public String TimeToStart
        {
            get 
            {
                int daysToStart = Convert.ToInt32 ((Project.StartDate - AssignedDate).TotalDays);
                return daysToStart>0? daysToStart.ToString(): "Started" ; 
            }
        }
        public String Status
        {
            get { return IsActive ? "Active" : "Inactive"; }
        }
    }
}
