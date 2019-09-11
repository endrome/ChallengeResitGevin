using System;
using NUnit.Framework;
using ChallengeResitGevin;

namespace Quadrilateral_Tests
{
    [TestFixture]
    public class Tests
    {
        Square SQ1 { get; set; }
        Rectangle REC1 { get; set; }

        Square SQ2 { get; set; }
        Rectangle REC2 { get; set; }

        [SetUp]
        public void Init()
        {
            SQ1 = new Square("Blue", 4);
            REC1 = new Rectangle("Red", 4, 3);

            SQ2 = new Square("Blue", 6);
            REC2 = new Rectangle("Red", 5, 4);
        }

        [Test]
        public void SquareTests()
        {
            int area = 16;
            int perimeter = 16;

            Assert.AreEqual(area, SQ1.GetArea());
            Assert.AreEqual(perimeter, SQ1.GetPerimeter());

            area = 36;
            perimeter = 24;

            Assert.AreEqual(area, SQ2.GetArea());
            Assert.AreEqual(perimeter, SQ2.GetPerimeter());

        }

        [Test]
        public void RectangleTests()
        {
            int area = 12;
            int perimeter = 14;

            Assert.AreEqual(area, REC1.GetArea());
            Assert.AreEqual(perimeter, REC1.GetPerimeter());

            area = 20;
            perimeter = 18;

            Assert.AreEqual(area, REC2.GetArea());
            Assert.AreEqual(perimeter, REC2.GetPerimeter());

        }

    }
}