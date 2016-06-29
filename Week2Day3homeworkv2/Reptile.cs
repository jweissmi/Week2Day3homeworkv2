using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3homeworkv2
{
    public abstract class Reptile : IAnimal
    {
        public string Species { get; set; }
        public string ExternalCovering { get; set; }
        public int AvgWeight { get; set; }
        public string Name { get; set; }
    }
}
