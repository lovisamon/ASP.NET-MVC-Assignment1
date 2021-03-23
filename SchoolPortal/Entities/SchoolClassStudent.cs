using SchoolPortal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SchoolPortal.Entities
{
    public partial class SchoolClassStudent
    {
        [Required(ErrorMessage = "Please select a student")]
        [DisplayName("Student")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "Please select a class")]
        public Guid SchoolClassId { get; set; }

        //public virtual ApplicationUser Student { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }
    }
}
