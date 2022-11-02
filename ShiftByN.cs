using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto
{
    internal class ShiftByN : ICrypt
    {
        private string _plainText;
        protected int _key;
        public string Decrypt()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in _plainText)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    int value = isUpper ? c - 'A' : c - 'a';
                    value -= _key;
                    value = value >= 0 ? value : value + 26;
                    sb.Append(isUpper ? (char)(value + 'A') : (char)(value + 'a'));
                }
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

        public string Encrypt()
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in _plainText)
            {
               if(char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    int value = isUpper ? c - 'A' : c - 'a';
                    value = (value + _key)%26;
                    sb.Append(isUpper ? (char) (value + 'A') : (char) (value + 'a'));
                }
               else
                    sb.Append(c);
            }
            return sb.ToString();
        }

        public virtual void SetKey(string Key)
        {
            if (!int.TryParse(Key, out _key))
                throw new Exception();
        }

        public void SetPlainText(string PlainText)
        {
            _plainText = PlainText;
        }
    }
}
