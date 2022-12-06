using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Classes
{
    public class one
    {
        List<string> lines = File.ReadAllLines(@"C:\Users\snipe\source\repos\AdventOfCode2021\AdventOfCode2021\Data\one.txt").ToList();

        public int GetAnswer()
        {
            var data = lines.Select(int.Parse).ToList();

            var answer = 0;

            for (int i = 0; i < data.Count; i++)
            {
                if (i + 1 >= data.Count)
                {
                    break;
                }
                answer = data[i + 1] > data[i] ? answer + 1 : answer;
            }

            return answer;
        }
    }
}
