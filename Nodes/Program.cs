using System;

namespace Nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node
            {
                Number = 15,
                LeftChild = new Node
                {
                    Number = 10,
                    LeftChild = new Node
                    {
                        Number = 4
                    },
                    RightChild = new Node
                    {
                        Number = 12
                    }
                },
                RightChild = new Node
                {
                    Number = 22,
                    LeftChild = new Node
                    {
                        Number = 18
                    },
                    RightChild = new Node
                    {
                        Number = 24
                    }
                }
            };
            Console.WriteLine(node1.ToString());
            Console.WriteLine(node1.ToString().Equals("4,12,10,18,24,22,15"));
        }
    }
}
