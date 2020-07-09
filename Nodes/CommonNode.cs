using System.Collections.Generic;

namespace Nodes
{
    public abstract class CommonNode
    {
        public int Number;
        public CommonNode LeftChild;
        public CommonNode RightChild;

        public void AddNumber(ref List<int> nodes)
        {
            if (LeftChild != null)
            {
                LeftChild.AddNumber(ref nodes);
            }
            if (RightChild != null)
            {
                RightChild.AddNumber(ref nodes);
            }
            nodes.Add(Number);
        }
    }
}
