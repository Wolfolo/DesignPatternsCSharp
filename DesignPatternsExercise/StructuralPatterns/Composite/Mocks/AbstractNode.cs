using System;
using System.Collections.Generic;

namespace DesignPatternsExercise.StructuralPatterns.Composite.Mocks
{
    abstract class AbstractNode : INode
    {
        protected string content = "";
        protected INode parent = null;
        protected List<INode> children;

        public AbstractNode(string content)
        {
            this.content = content;
        }

        public virtual void AddChild(INode node)
        {
            node.SetParent(this);

            this.children.Add(node);
        }

        public virtual List<INode> GetChildren()
        {
            return this.children;
        }

        public virtual string GetContent()
        {
            return this.content;
        }

        public virtual INode GetParent()
        {
            return this.parent;
        }

        public virtual void SetParent(INode node)
        {
            this.parent = node;
        }
    }
}
