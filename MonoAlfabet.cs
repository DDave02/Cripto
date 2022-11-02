using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Cripto
{
    internal class MonoAlfabet : ICrypt
    {
        private string _plainText;
        private string _key;

        public string Decrypt()
        {
            StringBuilder decript = new StringBuilder();
            foreach(char c in _plainText)
            {
                if(char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    int index = _key.IndexOf(isUpper ? char.ToLower(c) : c);
                    decript.Append(isUpper ? (char)(index + 'A') : (char)(index + 'a'));
                }
                else
                    decript.Append(c);
            }
            return decript.ToString();
        }

        public string Encrypt()
        {
            StringBuilder cript = new StringBuilder();
            foreach(char c in _plainText)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    int index = isUpper ? c - 'A' : c - 'a';
                    cript.Append(isUpper ? char.ToUpper(_key[index]) : char.ToLower(_key[index]));
                }
                else
                    cript.Append(c);
            }
            return cript.ToString();
        }

        public void SetKey(string Key)
        {
            _key = Key.ToLower();
        }

        public void SetPlainText(string PlainText)
        {
            _plainText = PlainText;
        }
    }
}
