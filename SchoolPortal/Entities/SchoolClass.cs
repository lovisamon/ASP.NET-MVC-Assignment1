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
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            SchoolClassStudents = new HashSet<SchoolClassStudent>();
        }

        public Guid Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string ClassName { get; set; }

        [Required(ErrorMessage = "Please select a teacher")]
        [DisplayName("Teacher")]
        public string TeacherId { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public virtual ApplicationUser Teacher { get; set; }
        public virtual ICollection<SchoolClassStudent> SchoolClassStudents { get; set; }
    }
}
