using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nodes;

namespace NodesTest
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void NodeWithTwoChildren()
        {
            Node node = new Node
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
            Assert.AreEqual("4,12,10,18,24,22,15", node.ToString());
        }

        [TestMethod]
        public void NodeWithOneChild()
        {
            Node node = new Node
            {
                Number = 15,
                LeftChild = new Node
                {
                    Number = 10
                },
                RightChild = new Node
                {
                    Number = 22
                }
            };
            Assert.AreEqual("10,22,15", node.ToString());
        }

        [TestMethod]
        public void NodeWithLeftChildren()
        {
            Node node = new Node
            {
                Number = 15,
                LeftChild = new Node
                {
                    Number = 10,
                    LeftChild = new Node
                    {
                        Number = 4
                    }
                }
            };
            Assert.AreEqual("4,10,15", node.ToString());
        }

        [TestMethod]
        public void NodeWithRightChildren()
        {
            Node node = new Node
            {
                Number = 15,
                RightChild = new Node
                {
                    Number = 22,
                    RightChild = new Node
                    {
                        Number = 24
                    }
                }
            };
            Assert.AreEqual("24,22,15", node.ToString());
        }

        [TestMethod]
        public void NodeWith3LevelsOfChildren()
        {
            Node node = new Node
            {
                Number = 15,
                LeftChild = new Node
                {
                    Number = 10,
                    LeftChild = new Node
                    {
                        Number = 4,
                        LeftChild = new Node
                        {
                            Number = 2
                        },
                        RightChild = new Node
                        {
                            Number = 13
                        }
                    },
                    RightChild = new Node
                    {
                        Number = 12,
                        LeftChild = new Node
                        {
                            Number = 33
                        },
                        RightChild = new Node
                        {
                            Number = 66
                        }
                    }
                },
                RightChild = new Node
                {
                    Number = 22,
                    LeftChild = new Node
                    {
                        Number = 18,
                        LeftChild = new Node
                        {
                            Number = 29
                        },
                        RightChild = new Node
                        {
                            Number = 52
                        }
                    },
                    RightChild = new Node
                    {
                        Number = 24,
                        LeftChild = new Node
                        {
                            Number = 88
                        },
                        RightChild = new Node
                        {
                            Number = 43
                        }
                    }
                }
            };
            Assert.AreEqual("2,13,4,33,66,12,10,29,52,18,88,43,24,22,15", node.ToString());
        }

        [TestMethod]
        public void NodeWithNoChildren()
        {
            Node node = new Node
            {
                Number = 15
            };
            Assert.AreEqual("15", node.ToString());
        }
    }
}
