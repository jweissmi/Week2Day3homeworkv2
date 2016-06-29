using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3homeworkv2
{
    public class Human : Mammal
    {
        public Human()
        {
        }
        public Human(string hairColor)
        {
            HairColor = hairColor;
        }

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

        public string HairColor { get; set; }

        public override int NumLegs()
        {
            return 2;
        }
        public override int AvgNumOffspring()
        {
            return 1;
        }
    }
}
