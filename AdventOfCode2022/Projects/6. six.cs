using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Projects
{
    public class six
    {
        List<string> lines = File.ReadAllLines(@"C:\Users\WillemBotha\Downloads\AdventOfCode-main\AdventOfCode-main\AdventOfCode2021\AdventOfCode2022\Data\question6.txt").ToList();

        public int GetAnswer()
        {
            var line = lines[0];
            var packet = "";
            var digit = 0;

            for (int i = 0; i < line.Length; i++)
            {
                packet = line.Substring(i, 14);
                if (packet.Distinct().Count() == packet.Length)
                {
                    digit = i + 14;
                    break;
                }
            }

            return digit;
        }
    }
}
