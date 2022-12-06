using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Projects
{
    public class two
    {
        List<string> lines = File.ReadAllLines(@"C:\Users\WillemBotha\Downloads\AdventOfCode-main\AdventOfCode-main\AdventOfCode2021\AdventOfCode2022\Data\question2.txt").ToList();

        public enum OpHands
        {
            A = 1,
            B = 2,
            C = 3
        }

        public enum Hands
        {
            X = 1,
            Y = 2,
            Z = 3
        }

        public int GetAnswer()
        {
            var data = lines.ToList();


            // A - ROCK 1
            // B - PAPER 2
            // C - SCIC 3

            // X - ROCK - 1
            // Y - PAPER - 2
            // Z - SCIC - 3

            // W -6
            // T - 3
            // L - 0

            //X L - 1
            //Y D - 2
            //Z W - 3

            var sum = 0;

            foreach (var item in data)
            {
                var hands = item.Split(" ");

                Enum.TryParse(hands[0], out OpHands first);
                Enum.TryParse(hands[1], out Hands second);

                var one = (int)first;
                var two = (int)second;

                var set = false;

                if (two == 1 && set == false)
                {
                    if (one == 1)
                    {
                        two = 3;
                    }

                    if (one == 2)
                    {
                        two = 1;
                    }

                    if (one == 3)
                    {
                        two = 2;
                    }
                    set = true;
                }
                else if (two == 2 && set == false)
                {
                    if (one == 1)
                    {
                        two = 1;
                    }

                    if (one == 2)
                    {
                        two = 2;
                    }

                    if (one == 3)
                    {
                        two = 3;
                    }
                    set = true;
                }
                else if (two == 3 && set == false)
                {
                    if (one == 1)
                    {
                        two = 2;
                    }

                    if (one == 2)
                    {
                        two = 3;
                    }

                    if (one == 3)
                    {
                        two = 1;
                    }
                    set = true;
                }

                if (two == 1 && one == 3)
                {
                    sum = sum + 6;
                }

                if (two == 3 && one == 2)
                {
                    sum = sum + 6;
                }

                if (two == 2 && one == 1)
                {
                    sum = sum + 6;
                }
                if (one == two)
                {
                    sum = sum + 3;
                }

                sum += two;
            }

            return sum;
        }
    }
}
