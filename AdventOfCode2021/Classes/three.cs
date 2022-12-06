using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2021.Classes
{
    public class three
    {
        List<string> lines = File.ReadAllLines(@"C:\Users\snipe\source\repos\AdventOfCode2021\AdventOfCode2021\Data\three.txt").ToList();

        public double GetAnswer()
        {
            var f = lines.Where(x => x.Contains("forward"));
            var d = lines.Where(x => x.Contains("down"));
            var u = lines.Where(x => x.Contains("up"));

            var fn = f.Select(x => Regex.Match(x, @"\d+").Value).Sum(x => long.Parse(x));
            var dn = d.Select(x => Regex.Match(x, @"\d+").Value).Sum(x => long.Parse(x));
            var un = u.Select(x => Regex.Match(x, @"\d+").Value).Sum(x => long.Parse(x));

            var y = dn - un;

            return fn * y;
        }
    }
}
