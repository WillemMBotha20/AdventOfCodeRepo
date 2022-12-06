using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Classes
{
    public class two
    {
        List<string> lines = File.ReadAllLines(@"C:\Users\snipe\source\repos\AdventOfCode2021\AdventOfCode2021\Data\two.txt").ToList();

        public int GetAnswer()
        {
            var data = lines.Select(int.Parse).ToList();

            var answer = 0;

            var previous = new List<int>();

            for (int i = 0; i < data.Count; i++)
            {
                if (i + 2 >= data.Count)
                {
                    break;
                }
                previous.Add(data[i] + data[i + 1] + data[i + 2]);
            }

            for (int i = 0; i < previous.Count; i++)
            {
                if (i + 1 >= previous.Count)
                {
                    break;
                }
                answer = previous[i + 1] > previous[i] ? answer + 1 : answer;
            }

            return answer;
        }
    }
}