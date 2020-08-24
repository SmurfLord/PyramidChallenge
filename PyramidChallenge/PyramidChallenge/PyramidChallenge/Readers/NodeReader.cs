using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PyramidChallenge
{
    public class NodeReader
    {
        public Node ReadInput(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException("The file is empty.");

            Node rootNode = null;

            using (var sr = new StreamReader(filename))
            {
                IList<Node> currentLineNumbers, nextLineNumbers;
                currentLineNumbers = ParseLine(sr.ReadLine());
                rootNode = currentLineNumbers.FirstOrDefault();

                do
                {
                    nextLineNumbers = ParseLine(sr.ReadLine());

                    if (nextLineNumbers != null)
                    {
                        for (int i = 0; i < currentLineNumbers.Count; i++)
                        {
                            Insert(i, currentLineNumbers, nextLineNumbers);
                        }
                    }

                    currentLineNumbers = nextLineNumbers;
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
            return line?.Split(' ').Select(p => new Node() { Value = this.ParseNumber(p) }).ToList();
        }

        private int ParseNumber(string value)
        {
            if (Int32.TryParse(value, out var result) == false)
                throw new ArgumentException("The file used contains invalid data.");
            return result;
        }
    }
}
