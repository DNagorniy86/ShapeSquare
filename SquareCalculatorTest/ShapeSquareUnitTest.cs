using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculatorLibrary;

namespace SquareCalculatorTest
{
    [TestClass]
    public class ShapeSquareUnitTest
    {
        [TestMethod]
        public void CircleSquareWithZeroValue()
        {
            //arrange
            ShapeSquareFactory factory = new ShapeSquareFactory();
            //act
            var square = factory.Circle(0);
            //assert
            Assert.AreEqual(0, square.Square());
        }

        [TestMethod]
        public void CircleSquareWithCorrectValue()
        {
            //arrange
            ShapeSquareFactory factory = new ShapeSquareFactory();
            //act
            var correctArea = Math.PI * Math.Pow(10, 2);
            var square = factory.Circle(10);
            //assert
            Assert.AreEqual(correctArea, square.Square());
        }

        [TestMethod]
        public void TriangleSquareValues()
        {
            //arrange
            ShapeSquareFactory factory = new ShapeSquareFactory();
            //act
            var square = factory.Triangle(new Point(10, 0), new Point(10, 10), new Point(20, 0));
            //assert
            Assert.AreEqual(50, square.Square());
        }

        [TestMethod]
        public void TriangleIsRight()
        {
            //arrange
            ShapeSquareFactory factory = new ShapeSquareFactory();
            //act
            var square = factory.Triangle(new Point(10, 0), new Point(10, 10), new Point(20, 0));
            //assert
            Assert.IsTrue(square.IsRight());
        }

        [TestMethod]
        public void TriangleFindSquare()
        {
            //arrange
            ShapeSquareFactory factory = new ShapeSquareFactory();
            
            //act
            var correctArea = Math.PI * Math.Pow(10, 2);
            var square = factory.FindSquare(new Point(10, 0), new Point(10, 10));
            //assert
            Assert.AreEqual(correctArea, square.Square());

            //act
            square = factory.FindSquare();
            //assert
            Assert.AreEqual(0, square.Square());

            //act
            square = factory.FindSquare(new Point(10, 0), new Point(10, 10), new Point(20, 0));
            //assert
            Assert.AreEqual(50, square.Square());
        }
    }
}
