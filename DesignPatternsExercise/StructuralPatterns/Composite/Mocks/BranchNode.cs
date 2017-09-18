using System;
using System.Collections.Generic;

namespace DesignPatternsExercise.StructuralPatterns.Composite.Mocks
{
    class BranchNode : AbstractNode
    {
        public BranchNode(string content) : base(content)
        {
            this.children = new List<INode>();
        }

        public override void AddChild(INode node)
        {
            if (node.GetType() == typeof(RootNode))
            {
                throw new ArgumentException("Cannot add a root node as a child");
            }

            if (node.GetType() == typeof(TrunkNode))
            {
                throw new ArgumentException("Cannot add a trunk node as a child");
            }

            base.AddChild(node);
        }
    }
}
