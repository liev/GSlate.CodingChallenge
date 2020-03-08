using GSlate.CodingChallenge.Common.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GSlate.CodingChallenge.Common.Models.ViewModels
{
    public partial class UserViewModel
    {
        

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        
        public String FullName { 
            get { return String.Format("{0} {1}", FirstName, LastName); } 
        }
    }
}
