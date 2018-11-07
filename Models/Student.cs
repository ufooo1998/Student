using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class Student
    {
        [Key]
        [Display(Name ="Roll ID")]
        public string RollNumber { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Email")]
        public string Email { get; set; }

        [Display(Name ="Phone")]
        public string Phone { get; set; }

        [Display(Name ="Gender")]
        public Gender Gender { get; set; }

        [Display(Name ="Birthday")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        [Display(Name ="Address")]
        public string Address { get; set; }

        [Display(Name ="Avatar Picture")]
        public string AvatarPicture { get; set; }

        [Display(Name ="Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name ="Updated Date")]
        public DateTime UpdatedDate { get; set; }

        [Display(Name ="Status")]
        public Status Status { get; set; }
    }

    public enum Status
    {
        Deactivated = 0,
        Activated = 1
    }

    public enum Gender
    {
        Female = 0,
        Male = 1,
        Other = 2
    }
}
