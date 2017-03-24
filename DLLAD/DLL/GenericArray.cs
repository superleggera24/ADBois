using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD
{
    class GenericArray
    {
        public int[] NumberArray = new int[1000];
        
        public int[] _NumberArray
        {
            get { return NumberArray; }
            set { _NumberArray = NumberArray; }
        }
    }
}
