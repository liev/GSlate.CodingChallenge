using GSlate.CodingChallenge.Common.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GSlate.CodingChallenge.Common.Models.ViewModels
{
    public partial class UserProjectViewModel : UserProject
    {
        public String TimeToStart
        {
            get
            {
                int daysToStart = Convert.ToInt32((Project.StartDate - AssignedDate).TotalDays);
                return daysToStart > 0 ? daysToStart.ToString() : "Started";
            }
        }
        public String Status
        {
            get { return IsActive ? "Active" : "Inactive"; }
        }

        public DateTime StartDate
        {
            get => Project.StartDate;
        }
        public DateTime EndDate
        {
            get => Project.EndTime;
        }

        public int Credits
        {
            get => Project.Credits;
        }

        [JsonIgnore]
        public override User User { get => base.User; set => base.User = value; }

        [JsonIgnore]
        public override Project Project { get => base.Project; set => base.Project = value; }
    }
}
