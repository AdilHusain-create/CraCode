using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

//using CraCode.ModelLayer.Models;

namespace CraCode.ModelLayer.Models
{
    public class Student : BaseModel
    {
        [Required]
        public string Username { get; set; }

        public string College { get; set; }

        public string Profession { get; set; }

        public Course Course { get; set; }

        public Professor Professor { get; set; }

        [Required]
        [DisplayName("Get Updates to New Courses")]
        public bool GetUpdateFlag { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public string Password { get; set; }

        [Compare("Password")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
