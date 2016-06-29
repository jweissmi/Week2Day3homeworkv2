using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3homeworkv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human myHuman = new Human("Brown");
            myHuman.Name = "Jim";
            myHuman.Species = "Developer";
            myHuman.NumLegs();
            myHuman.AvgNumOffspring();
            myHuman.ExternalCovering = "Thick Skin";

            Dog myDog = new Dog("German Shepard");
            myDog.Name = "Rusty";
            myDog.Species = "Canine";
            myDog.NumLegs();
            myDog.AvgNumOffspring();
            myDog.ExternalCovering = "Fur";

            Snake mySnake = new Snake();
            mySnake.Name = "Sam";
            mySnake.AvgWeight = (5);
            mySnake.ExternalCovering = "Scales";
            mySnake.Species = "Rattler";
            mySnake.IsVenomous();

            Lizard myLizard = new Lizard();
            myLizard.Name = "Larry";
            myLizard.AvgWeight = (7);
            myLizard.ExternalCovering = "Skin";
            myLizard.Species = "Iguania";
            myLizard.IsDesertDweller();

        }
    }
}
