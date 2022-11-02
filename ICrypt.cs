using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto
{
    internal interface ICrypt
    {
        string Encrypt();
        void SetKey(string Key);
        void SetPlainText(string PlainText);
        string Decrypt();
    }
}
