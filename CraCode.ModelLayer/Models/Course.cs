using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraCode.ModelLayer.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string courseName { get; set; }
        public string type { get; set; }
        public Professor professor { get; set; }


    }
}
