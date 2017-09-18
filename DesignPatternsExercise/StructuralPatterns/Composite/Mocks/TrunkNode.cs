using System;
using System.Collections.Generic;

namespace DesignPatternsExercise.StructuralPatterns.Composite.Mocks
{
    class TrunkNode : BranchNode
    {
        public TrunkNode(string content) : base(content)
        {
        }

        public override void AddChild(INode node)
        {
            if (node.GetType() == typeof(LeafNode))
            {
                throw new ArgumentException("Cannot add a leaf node as a child");
            }

            /* The base class BranchNode don't allow to add a TrunkNode as a child, which also
             * makes sense for the TrunkNode itself, as you usually have one trunk with branches as children
             */
            base.AddChild(node);
        }
    }
}
