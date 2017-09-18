using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsExercise.StructuralPatterns.Composite.Mocks;
using System.Collections.Generic;

namespace DesignPatternsExercise.StructuralPatterns.Composite
{
    [TestClass]
    public class CompositeTest
    {
        [TestMethod]
        public void TestNodeContent()
        {
            var root = new RootNode("Root");

            Assert.AreEqual("Root", root.GetContent());
        }

        [TestMethod]
        public void TestNodeParent()
        {
            var root = new RootNode("Root");
            var trunk = new TrunkNode("Trunk");

            root.AddChild(trunk);

            Assert.AreEqual(root, trunk.GetParent());
        }

        [TestMethod]
        public void TestNodeChildren()
        {
            var branch = new BranchNode("Branch");
            const int NUM_LEAVES = 4;

            for (int i = 0; i < NUM_LEAVES; i++)
            {
                branch.AddChild(new LeafNode("Leaf " + i));
            }

            Assert.AreEqual(NUM_LEAVES, branch.GetChildren().Count);
            Assert.AreEqual("Leaf 1", branch.GetChildren()[1].GetContent());
        }

        [TestMethod]
        public void TestCanAddBranchesOnAnyLevel()
        {
            var nodes = new List<INode>{
                new BranchNode("Branch"),
                new TrunkNode("Trunk"),
                new RootNode("Root"),
            };

            foreach (INode n in nodes)
            {
                try
                {
                    n.AddChild(new BranchNode("Branch"));
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void TestRootCannotBeAddedAsChild()
        {
            var nodes = new List<INode>{
                new BranchNode("Branch"),
                new TrunkNode("Trunk"),
                new RootNode("Root"),
            };

            foreach (INode n in nodes)
            {
                try
                {
                    n.AddChild(new RootNode("Root"));

                    Assert.Fail();
                }
                catch (Exception ex)
                {
                    Assert.AreEqual(typeof(ArgumentException), ex.GetType());
                }
            }
        }

        [TestMethod]
        public void TestTrunkCannotBeAddedToABranchOrOtherTrunk()
        {
            var nodes = new List<INode>{
                new BranchNode("Branch"),
                new TrunkNode("Trunk"),
            };

            foreach (INode n in nodes)
            {
                try
                {
                    n.AddChild(new TrunkNode("Trunk"));

                    Assert.Fail();
                }
                catch (Exception ex)
                {
                    Assert.AreEqual(typeof(ArgumentException), ex.GetType());
                }
            }
        }

        [TestMethod]
        public void TestCannotAddLeavesToTrunk()
        {
            var trunk = new TrunkNode("Trunk doesn't allow leaves to be added");

            try
            {
                trunk.AddChild(new LeafNode("Leaf"));

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(ArgumentException), ex.GetType());
            }
        }

        [TestMethod]
        public void TestLeavesCannotHaveChildren()
        {
            var leaf = new LeafNode("A leaf doesn't allow to add any child");

            var nodes = new List<INode>{
                new LeafNode("Leaf"),
                new BranchNode("Branch"),
                new TrunkNode("Trunk"),
            };

            foreach (INode n in nodes)
            {
                try
                {
                    leaf.AddChild(n);

                    Assert.Fail();
                }
                catch (Exception ex)
                {
                    Assert.AreEqual(typeof(InvalidOperationException), ex.GetType());
                }
            }
        }
    }
}
