using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend
{
    class Platform
    {
        public int[] Dimensions { get; set; } = new int[2];

        public int[] Location { get; set; } = new int[2];

        public void ScrollDown (int distance)
        {
            Location[1] -= distance;
        }
    }
}
