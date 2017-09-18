using System;
using System.Collections.Generic;

namespace DesignPatternsExercise.StructuralPatterns.Composite.Mocks
{
    class RootNode : AbstractNode
    {
        public RootNode(string content) : base(content)
        {
            this.children = new List<INode>();
        }

        public override void AddChild(INode node)
        {
            if (node.GetType() == typeof(RootNode))
            {
                throw new ArgumentException("Cannot add a root node as a child");
            }

            base.AddChild(node);
        }

        public override INode GetParent()
        {
            throw new InvalidOperationException("The root node does not have a parent");
        }

        public override void SetParent(INode node)
        {
            throw new InvalidOperationException("Cannot set a parent to a root node");
        }
    }
}
