using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsExercise.StructuralPatterns.Bridge.Mocks;
using System.Collections.Generic;

namespace DesignPatternsExercise.StructuralPatterns.Bridge
{
    [TestClass]
    public class BridgeTest
    {
        Dictionary<string, IShape> shapes;

        [TestInitialize]
        public void PrepareShapes()
        {
            shapes = new Dictionary<string, IShape>();

            shapes.Add("Circle", new Circle());
            shapes.Add("Square", new Square());
        }

        [TestMethod]
        public void TestArea()
        {
            foreach (KeyValuePair<string, IShape> shape in shapes)
            {
                var ashape = new AbstractShape(shape.Value);

                Assert.AreEqual(shape.Key + ".Area", ashape.GetShapeArea());
            }
        }

        [TestMethod]
        public void TestPerimeter()
        {
            foreach (KeyValuePair<string, IShape> shape in shapes)
            {
                var ashape = new AbstractShape(shape.Value);

                Assert.AreEqual(shape.Key + ".Perimeter", ashape.GetShapePerimeter());
            }
        }
    }
}
