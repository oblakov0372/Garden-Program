using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWork2
{
    internal abstract class Plant : IGardenItem
    {
        public double WaterRequired { get; set; }
    }
}
