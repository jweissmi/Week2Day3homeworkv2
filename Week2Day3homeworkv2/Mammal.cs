using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3homeworkv2
{
    public abstract class Mammal : IAnimal
    {

        public string Name { get; set; }
        public string Species { get; set; }
        public string ExternalCovering { get; set; }

        public abstract int NumLegs();
        public abstract int AvgNumOffspring();

    }
}
