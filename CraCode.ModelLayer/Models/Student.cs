using System;
using System.Collections.Generic;
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

        [Required(ErrorMessage = "Please enter Correct Password")]
        public string Password { get; set; }
    }
}
