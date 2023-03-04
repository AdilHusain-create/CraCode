using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CraCode.ModelLayer.Models;

namespace CraCode.ModelLayer.Models
{
    public class Student : BaseModel
    {
        public string college { get; set; }
        public string profession { get; set; }
        public Course course { get; set; }
        public Professor professor { get; set; }
    }
}
