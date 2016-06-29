using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3homeworkv2
{
    public class Dog : Mammal
    {
        public Dog()
        {
        }
        public Dog(string dogBreed)
        {
            DogBreed = dogBreed;
        }
        public string DogBreed { get; set; }

        public string myName
        {
            get { return base.Name; }
        }
        public string mySpecies
        {
            get { return base.Species; }
        }
        public string myExternalCovering
        {
            get { return base.ExternalCovering; }
        }

        public new string Name { get; set; }
        public new string Species { get; set; }
        public new string ExternalCovering { get; set; }

        public override int NumLegs()
        {
            return 4;
        }
        public override int AvgNumOffspring()
        {
            return 6;
        }
    }
}
