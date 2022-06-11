using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWork2
{
    internal abstract class DecorationTree :Tree, IBeauty
    {
        public double BeautyScore { get; set; }
    }
}
