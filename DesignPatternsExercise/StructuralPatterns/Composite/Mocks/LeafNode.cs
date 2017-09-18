using System;
using System.Collections.Generic;

namespace DesignPatternsExercise.StructuralPatterns.Composite.Mocks
{
    class LeafNode : AbstractNode
    {
        public LeafNode(string content) : base(content)
        {
        }

        public override void AddChild(INode node)
        {
            throw new InvalidOperationException("Cannot add children to a leaf node");
        }

        public override List<INode> GetChildren()
        {
            throw new InvalidOperationException("A leaf node does not have children");
        }
    }
}
