using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTDD
{
    public class ComputeHash
    {
        public int Hash(string toHash)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(toHash);
            int[] toHashArray = bytes.Select(x => (int)x).ToArray();
            if (toHashArray.Length == 0)
            {
                return -1;
            }
            else
            {
                int sum = toHashArray.Sum();
                return sum % 127;
            }
        }
    }
}
