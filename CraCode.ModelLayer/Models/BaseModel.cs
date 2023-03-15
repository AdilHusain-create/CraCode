using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CraCode.ModelLayer.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int MobileNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Birth year")]
        public string DateOfBirth { get; set; }

        [DisplayName("Gender")]
        public string Gender { get; set; }
        
        [Required]
        public string Country { get; set; }

        [Required]
        public string State { get; set; }


        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("Qualification")]
        public string Qualification { get; set; }
    }
}
