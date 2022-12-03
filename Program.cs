using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0, p2 = 0;
            string input = " ";
            List<string> strings = new List<string>();
            strings.Add(input);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < int.MaxValue; j++)
                {
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        if (p1 >= p2)
                        {
                            p2 = p1;
                        }
                        p1 = 0;
                        break;
                    }
                    strings.Add(input);
                    p1 += int.Parse(input);
                    input = " ";
                }
            }
            Console.WriteLine(p2);
        }
    }
}