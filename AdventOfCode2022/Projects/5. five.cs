using System.Collections;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Projects
{
    public class five
    {
        List<string> location = File.ReadAllLines(@"C:\Users\WillemBotha\Downloads\AdventOfCode-main\AdventOfCode-main\AdventOfCode2021\AdventOfCode2022\Data\question5.txt").ToList();
        List<string> moves = File.ReadAllLines(@"C:\Users\WillemBotha\Downloads\AdventOfCode-main\AdventOfCode-main\AdventOfCode2021\AdventOfCode2022\Data\Question5 .1.txt").ToList();
        public string GetAnswer()
        {
            Stack<string>[] grid = new Stack<string>[3];
            Stack<string>[] gridRev = new Stack<string>[3];
            var data = location.ToList();
            var dataMoves = moves.ToList();

            var index = 1;

            for (int i = 0; i < 3; i++)
            {
                grid[i] = new Stack<string>();
            }

            foreach (var item in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (item[index].ToString() != " ")
                    {
                        grid[i].Push(item[index].ToString());
                    }

                    index += 4;
                }
                index = 1;
            }

            for (int i = 0; i < 3; i++)
            {
                gridRev[i] = new Stack<string>();
            }

            for (int i = 0; i < grid.Length; i++)
            {
                while (grid[i].Count != 0)
                {
                    gridRev[i].Push(grid[i].Pop());
                }

            }

            foreach (var item in dataMoves)
            {
                var count = int.Parse(item.Split(" ")[0]);
                var from = int.Parse(item.Split(" ")[1]) - 1;
                var to = int.Parse(item.Split(" ")[2]) - 1;

                var temp = new List<string>();

                var tempStack = new Stack<string>();

                for (int i = 0; i < count; i++)
                {
                    tempStack.Push(gridRev[from].Pop());


                }

                for (int z = 0; z < tempStack.Count; z++)
                {
                    gridRev[to].Push(tempStack.ToArray()[z]);
                }
            }

            var anw = "";

            for (int i = 0; i < gridRev.Length; i++)
            {
                anw = anw + gridRev[i].First();
            }

            return anw;
        }
    }
}
