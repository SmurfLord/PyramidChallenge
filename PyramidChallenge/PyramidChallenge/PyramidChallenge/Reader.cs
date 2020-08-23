using System.IO;

namespace PyramidChallenge
{
    public class Reader
    {
        public int[,] ReadInput(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            int[,] triangleInput = new int[lines.Length, lines.Length];
            int c = 0;

            foreach (string line in lines)
            {
                int r = 0;
                var numbers = line.Split(' ');
                for (int i = 0; i < numbers.Length; i++)
                {
                    var number = int.Parse(numbers[i]);
                    bool shouldBeEven;

                    if (c > 0)
                        shouldBeEven = !(triangleInput[c - 1, 0] % 2 == 0);
                    else
                        shouldBeEven = number % 2 == 0;

                    if ((number % 2 == 0) == shouldBeEven)
                    {
                        triangleInput[c, r] = number;
                        r++;
                    }
                }
                c++;
            }

            return triangleInput;
        }
    }
}
