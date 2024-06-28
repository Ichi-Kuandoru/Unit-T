using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Unit_T;

namespace UnitTestProject1
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            int a = -4;
            int b = 5;
            int expected = 15; // ожидаемое значение

            //полученные значения с помощью тестируемого метода:
            Geometry g = new Geometry();
            int actual = g.CalculateArea(a, b);
            //сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
