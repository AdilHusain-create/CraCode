using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraCode.ModelLayer.Models
{
    public class BaseModel
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int mobileNumber { get; set; }
        public string dateOfBirth { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public string qualification { get; set; }
    }
}
