using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3homeworkv2
{
    public class Snake : Reptile
    {
        public Snake()
        {
        }

        public new string Species { get; set; }
        public new string ExternalCovering { get; set; }
        public new int AvgWeight { get; set; }
        public new string Name { get; set; }

        public bool IsVenomous()
        {
            return true;
        }
    }
}
