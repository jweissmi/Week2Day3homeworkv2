using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3homeworkv2
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Species { get; set; }
        string ExternalCovering { get; set; }
    }
}
