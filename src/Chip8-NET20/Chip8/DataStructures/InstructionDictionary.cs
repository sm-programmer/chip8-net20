using System;
using System.Collections.Generic;
using System.Text;

namespace Chip8.DataStructures
{
    delegate void InstructionHandler();

    class InstructionDictionary
    {
        private Dictionary<string, InstructionHandler> data;
        private List<int> availableFilters;
        private StringBuilder sb;

        public InstructionHandler this[string key]
        {
            set { data[key] = value; }
        }

        public InstructionDictionary()
        {
            data = new Dictionary<string, InstructionHandler>();
            availableFilters = new List<int>();
            sb = new StringBuilder();

            computeFilters();
        }

        private int ascendentOrderByOnesCount(int x, int y)
        {
            if (countOnes(x) == countOnes(y))
                return x - y;

            return countOnes(x) - countOnes(y);
        }

        private void computeFilters()
        {
            for (int i = 0; i < 16; i++)
                availableFilters.Add(i);

            availableFilters.Sort(ascendentOrderByOnesCount);
        }

        private int countOnes(int num)
        {
            int count = 0;

            while (num != 0)
            {
                count++;
                num &= num - 1;
            }

            return count;
        }

        private int getNibble(ushort addr, int pattern, int shift)
        {
            return (addr & pattern) >> shift;
        }

        private string computeKey(ushort addr, int pattern)
        {
            sb.Length = 0;

            for (int nb = 0; nb < 4; nb++)
            {
                bool bit = (pattern & 1) == 1;

                if (bit)
                    sb.Insert(0, "X");
                else
                    sb.Insert(0, String.Format("{0:X}", getNibble(addr, 0xF << (4 * nb), 4 * nb)));

                pattern >>= 1;
            }

            return sb.ToString();
        }

        public bool TryGetValue(ushort addr, out InstructionHandler value)
        {
            string key = "";
            foreach (int filter in availableFilters)
            {
                key = computeKey(addr, filter);
                if (data.ContainsKey(key))
                    break;
            }

            if (key == "")
            {
                value = null;
                return false;
            }

            return data.TryGetValue(key, out value);
        }
    }
}
