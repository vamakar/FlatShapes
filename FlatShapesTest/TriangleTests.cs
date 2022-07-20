using FlatShapes;
using NUnit.Framework;

namespace FlatShapesTest
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        [TestCase(3, 4, 5, 6)]
        [TestCase(1, 4.5, 5, 2.045383521494)]
        public void GetArea_CorrectAreaValidEdges_Equal(double edge1, double edge2, double edge3, double expectedArea)
        {
            var triangle = new Triangle(edge1, edge2, edge3);
            var actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea, 0.000001);
        }

        [Test]
        [TestCase(1, 4.5, 5, 1.1)]
        [TestCase(3, 4, 5, 10)]
        public void GetArea_CorrectAreaValidEdges_NotEqual(double edge1, double edge2, double edge3, double expectedArea)
        {
            var triangle = new Triangle(edge1, edge2, edge3);
            var actualArea = triangle.GetArea();

            Assert.AreNotEqual(expectedArea, actualArea);
        }

        [Test]
        [TestCase(0, 1.1, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(3, 5.1, -1)]
        [TestCase(1, 0, -1.1)]
        [TestCase(1, 4.5, 6.77)]
        public void NewTriangle_InvalidEdges_Exception(double edge1, double edge2, double edge3)
        {
            Assert.That(() => new Triangle(edge1, edge2, edge3), Throws.Exception);
        }

        [Test]
        [TestCase(3, 5, 4)]
        [TestCase(3, 4, 5)]
        [TestCase(3, 4, 5)]
        [TestCase(5, 4, 3)]
        [TestCase(5, 3, 4)]
        public void IsRight_ValidEdges_IsTrue(double edge1, double edge2, double edge3)
        {
            var triangle = new Triangle(edge1, edge2, edge3);

            Assert.IsTrue(triangle.IsRight());
        }

        [Test]
        [TestCase(1, 4.5, 5)]
        [TestCase(5, 8, 10.55)]
        public void IsRight_ValidEdges_IsFalse(double edge1, double edge2, double edge3)
        {
            var triangle = new Triangle(edge1, edge2, edge3);

            Assert.IsFalse(triangle.IsRight());
        }
    }
}