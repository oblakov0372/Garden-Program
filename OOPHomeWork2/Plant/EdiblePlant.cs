using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWork2
{
    internal class EdiblePlant : Plant, IFood
    {
        public double Energy { get; set; }
    }
}
