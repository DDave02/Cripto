using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cripto
{
    internal class CaesarCip : ShiftByN
    {
        public CaesarCip()
        {
            _key = 3;
        }
        public override void SetKey(string Key)
        {

        }
    }
}
