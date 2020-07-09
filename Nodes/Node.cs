using System;
using System.Collections.Generic;

namespace Nodes
{
    public class Node : CommonNode
    {
        public override string ToString()
        {
            var nodes = new List<int>();
            AddNumber(ref nodes);
            return String.Join(",", nodes);
        }
    }
}
