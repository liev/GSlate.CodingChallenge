﻿using GSlate.CodingChallenge.Common.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GSlate.CodingChallenge.Common.Models.ViewModels
{
    public partial class UserViewModel : User
    {
        
        
        public String FullName { 
            get { return String.Format("{0} {1}", FirstName, LastName); } 
        }
    }
}
