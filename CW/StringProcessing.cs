using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Forms;

namespace CW
{
    internal class StringProcessing
    {
        private string inputString;
        private int shiftValue;
        private string encodedString;

        public string InputString
        {
            get { return inputString; }
            private set
            {
                if (!string.IsNullOrEmpty(value) &&
                    value.Length <= 40 &&
                    IsAllUpperCaseLetters(value))
                {
                    inputString = value;
                }
                else
                {
                    throw new ArgumentException("Input must be up to 40 uppercase letters only.");
                }
            }
        }

        public int ShiftValue
        {
            get { return shiftValue; }
            private set
            {
                if (value >= -25 && value <= 25)
                {
                    shiftValue = value;
                }
                else
                {
                    throw new ArgumentException("Shift value must be between -25 and 25.");
                }
            }
        }

        public StringProcessing(string s, int n)
        {
            InputString = s;
            ShiftValue = n;
            encodedString = "";
        }

        public void Encode()
        {
            char[] result = new char[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                char originalChar = inputString[i];
                int offset = ((originalChar - 'A' + shiftValue + 26) % 26);
                result[i] = (char)('A' + offset);
            }
            encodedString = new string(result);
        }

        public string Print() => encodedString;

        public int[] InputCode()
        {
            int[] codes = new int[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
                codes[i] = (int)inputString[i];
            return codes;
        }

        public int[] OutputCode()
        {
            int[] codes = new int[encodedString.Length];
            for (int i = 0; i < encodedString.Length; i++)
                codes[i] = (int)encodedString[i];
            return codes;
        }

        public string Sort()
        {
            char[] chars = inputString.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }

        private bool IsAllUpperCaseLetters(string s)
        {
            foreach (char c in s)
                if (c < 'A' || c > 'Z')
                    return false;
            return true;
        }
    }
}
