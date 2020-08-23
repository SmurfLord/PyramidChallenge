using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PyramidChallenge
{
    public class Reader
    {
        public Node ReadInput(string filename)
        {

            Node rootNode = null;
            
            using (var sr = new StreamReader(filename))
            {
                IList<Node> currentLineNumbers, nextLine;
                currentLineNumbers = ParseLine(sr.ReadLine());
                rootNode = currentLineNumbers.FirstOrDefault();

                do
                {
                    nextLine = ParseLine(sr.ReadLine());

                    if (nextLine != null)
                    {
                        for (int i = 0; i < currentLineNumbers.Count; i++)
                        {
                            Insert(i, currentLineNumbers, nextLine);
                        }
                    }
                   
                    currentLineNumbers = nextLine;
                }
                while (currentLineNumbers != null);
            }
            return rootNode;
        }

        private void Insert(int i, IList<Node> numbers, IList<Node> next)
        {
            numbers[i].Left = next[i];
            numbers[i].Right = next[i + 1];
        }

        private IList<Node> ParseLine(string line)
        {
            return line?.Split(' ').Select(p => new Node() { Value = Convert.ToInt32(p) }).ToList();
        }
    }
}
