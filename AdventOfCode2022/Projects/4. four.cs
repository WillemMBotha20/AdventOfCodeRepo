using System.Diagnostics.Metrics;

namespace AdventOfCode2022.Projects
{
    public class four
    {
        List<string> lines = File.ReadAllLines(@"C:\Users\WillemBotha\Downloads\AdventOfCode-main\AdventOfCode-main\AdventOfCode2021\AdventOfCode2022\Data\Question4.txt").ToList();

        public int GetAnswer()
        {
            var data = lines.ToList();
            var sum = 0;

            foreach (var item in data)
            {
                var splitData = item.Split(",");

                var firstSpan = new List<int>();
                var secondSpan = new List<int>();

                var one = splitData[0].Split("-")[0];
                var two = splitData[0].Split("-")[1];

                for (int i = int.Parse(one); i <= int.Parse(two); i++)
                {
                    firstSpan.Add(i);
                }

                one = splitData[1].Split("-")[0];
                two = splitData[1].Split("-")[1];

                for (int i = int.Parse(one); i <= int.Parse(two); i++)
                {
                    secondSpan.Add(i);
                }

                if (firstSpan.Contains(secondSpan[0]) || firstSpan.Contains(secondSpan[secondSpan.Count - 1]))
                {
                    sum++;
                    continue;
                }


                if (secondSpan.Contains(firstSpan[0]) || secondSpan.Contains(firstSpan[firstSpan.Count - 1]))
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}