using System.Collections.Generic;

/// <summary>
/// The Composite interface provides a common way to access the nodes and the content through the tree
/// </summary>
namespace DesignPatternsExercise.StructuralPatterns.Composite
{
    interface INode
    {
        /// <summary>
        /// Allows to set a parent node
        /// </summary>
        /// <param name="node"></param>
        void SetParent(INode node);

        /// <summary>
        /// Returns the parent nodes, if any
        /// </summary>
        /// <returns></returns>
        INode GetParent();

        /// <summary>
        /// Allows to add a child node
        /// </summary>
        /// <param name="node"></param>
        void AddChild(INode node);

        /// <summary>
        /// Returns all the children nodes, if any
        /// </summary>
        /// <returns></returns>
        List<INode> GetChildren();

        /// <summary>
        /// Returns the content of the current node
        /// </summary>
        /// <returns></returns>
        string GetContent();
    }
}
