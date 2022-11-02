using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto
{
    internal class ROT13 : ShiftByN
    {
        public ROT13()
        {
            _key = 13;
        }
        public override void SetKey(string key)
        {

        }
    }
}
