using FlatShapes;
using NUnit.Framework;

namespace FlatShapesTest
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        [TestCase(1, 3.141592653589793)]
        [TestCase(15, 706.8583470577034)]
        [TestCase(123, 47529.15525615998)]
        [TestCase(4582, 65956870.68254532)]
        [TestCase(78945, 19579388814.21198)]
        [TestCase(1258.5, 4975724.345192057)]
        [TestCase(895.85, 2521276.458364893)]
        [TestCase(95.123, 28426.340248117533)]
        [TestCase(1.2548, 4.946510015371867)]
        [TestCase(0.21569, 0.14615372666477064)]
        [TestCase(0.0215869, 0.0014639641174730496)]
        public void GetArea_CorrectAreaValidRadius_Equal(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            var actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea, 0.000001);
        }

        [Test]
        [TestCase(100, 84512.4)]
        [TestCase(0.11, 0.58412)]
        public void GetArea_IncorrectAreaValidRadius_NotEquals(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            var actualArea = circle.GetArea();

            Assert.AreNotEqual(expectedArea, actualArea);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1.1)]
        public void NewCircle_InvalidRadius_Exception(double radius)
        {
            Assert.That(() => new Circle(radius), Throws.Exception);
        }
    }
}