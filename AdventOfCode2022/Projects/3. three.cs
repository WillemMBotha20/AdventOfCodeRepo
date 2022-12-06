using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Projects
{
    public class three
    {
        List<string> lines = File.ReadAllLines(@"C:\Users\WillemBotha\Downloads\AdventOfCode-main\AdventOfCode-main\AdventOfCode2021\AdventOfCode2022\Data\Question3.txt").ToList();

        public int GetAnswer()
        {
            var data = lines.ToList();
            var priorList = new List<int>();
            //var indexCount = 0;

            for (int i = 0; i < data.Count; i++)
            {
                var first = data[i].Substring(0, (int)(data[i].Length / 2));
                var second = data[i].Substring((int)(data[i].Length / 2), (int)(data[i].Length / 2));

                //var first = data[indexCount];
                //var second = data[indexCount + 1];
                //var third = data[indexCount + 2];

                //var intersect = first.Intersect(second);
                //var common = intersect.Intersect(third).FirstOrDefault();

                var common = first.Intersect(second).FirstOrDefault();

                int index = (int)common % 32;

                if (Char.IsUpper(common))
                {
                    index = 26 + index;
                }

                //indexCount = indexCount + 3;
                priorList.Add(index);
            }

            return priorList.Sum(x => x);

        }
    }
}