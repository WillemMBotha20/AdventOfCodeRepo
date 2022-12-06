using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Projects
{
    public class one
    {
        List<string> lines = File.ReadAllLines(@"C:\Users\snipe\source\repos\AdventOfCode2021\AdventOfCode2022\Data\question1.txt").ToList();

        public int GetAnswer()
        {
            var data = lines.ToList();

            var answer = new List<int>();
            var result = 0;

            foreach (var line in data)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    result += int.Parse(line);
                }
                else
                {
                    //answer = result > answer ? result : answer;
                    answer.Add(result);
                    result = 0;
                }
            }

            return answer.OrderByDescending( x => x).Take(3).Sum(x => x);
        }
    }
}
