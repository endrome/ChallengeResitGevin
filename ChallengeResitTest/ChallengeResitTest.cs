using System;
using ChallengeResitGevin;
using NUnit.Framework;


namespace ChallengeResitTest
{
    [TestFixture]
    public class ShapeTests
    {
        Square SQ1 { get; set; }
        Square SQ2 { get; set; }
        Square SQ3 { get; set; }
        Square SQ4 { get; set; }

        Rectangle REC1 { get; set; }
        Rectangle REC2 { get; set; }
        Rectangle REC3 { get; set; }
        Rectangle REC4 { get; set; }

        [SetUp]
        public void init()
        {
            SQ1 = new Square("Purple", 5);
            SQ2 = new Square("Purple", 15);
            SQ3 = new Square("Purple", 7);
            SQ4 = new Square("Purple", 11);

            REC1 = new Rectangle("Pink", 5, 10);
            REC2 = new Rectangle("Pink", 4, 6);
            REC3 = new Rectangle("Pink", 9, 7);
            REC4 = new Rectangle("Pink", 10, 11);
        }


        [Test]
        public void SquareTest()
        {
            int area = 25;
            int perimeter = 20;

            Assert.AreEqual(area, SQ1.GetArea());
            Assert.AreEqual(perimeter, SQ1.GetPerimeter());

            area = 225;
            perimeter = 60;

            Assert.AreEqual(area, SQ2.GetArea());
            Assert.AreEqual(perimeter, SQ2.GetPerimeter());

            area = 49;
            perimeter = 28;

            Assert.AreEqual(area, SQ3.GetArea());
            Assert.AreEqual(perimeter, SQ3.GetPerimeter());

            area = 121;
            perimeter = 44;

            Assert.AreEqual(area, SQ4.GetArea());
            Assert.AreEqual(perimeter, SQ4.GetPerimeter());
        }

        [Test]
        public void RectangleTest()
        {
            int area = 50;
            int perimeter = 30;

            Assert.AreEqual(area, REC1.GetArea());
            Assert.AreEqual(perimeter, REC1.GetPerimeter());

            area = 24;
            perimeter = 20;

            Assert.AreEqual(area, REC2.GetArea());
            Assert.AreEqual(perimeter, REC2.GetPerimeter());

            area = 63;
            perimeter = 32;

            Assert.AreEqual(area, REC3.GetArea());
            Assert.AreEqual(perimeter, REC3.GetPerimeter());

            area =  110;
            perimeter = 42;

            Assert.AreEqual(area, REC4.GetArea());
            Assert.AreEqual(perimeter, REC4.GetPerimeter());
        }
    }
}
