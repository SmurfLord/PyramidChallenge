using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PyramidChallenge
{
    public class Reader
    {
        public Node[,] ReadInput(string filename)
        {
            Node rootNode = null;
            List<Node> children = new List<Node>();

            using (var sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var numbers = ParseLine(line);



                    foreach (var item in numbers)
                    {
                        var rootNode
                    }

                }
            }

        }


        private IList<int> ParseLine(string line)
        {
            return line.Split(' ').Select(p => Convert.ToInt32(p));
        }
    }
}
