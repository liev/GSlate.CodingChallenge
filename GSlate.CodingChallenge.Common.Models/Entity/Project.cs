﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GSlate.CodingChallenge.Common.Models.Entity
{
    [Table("Project")]
    public partial class Project
    {
        public Project()
        {
            UserProjects = new HashSet<UserProject>();
        }

        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }
        public int Credits { get; set; }

        [InverseProperty("Project")]
        public virtual ICollection<UserProject> UserProjects { get; set; }
    }
}