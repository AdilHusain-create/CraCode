using System.ComponentModel.DataAnnotations;


namespace CraCode.ModelLayer.Models
{
    
    public class Credentials
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public string Password { get; set; }
    }
}
