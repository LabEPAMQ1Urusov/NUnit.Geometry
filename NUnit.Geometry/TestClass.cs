using GeometricFigures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    [TestFixture]
    public class Test_Geometry
    {

        static object[] CircleSource =
       {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };

        static object[] TriangleSource =
        {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };

        static object[] SquareSource =
        {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };

        [Test, TestCaseSource("CircleSource")]
        public void GetAreaCirclePositiveTest(int r)
        {
            Circle circle = new Circle(r);
            double c_area = Math.Round(Math.PI * r * r, 3);
            double mc_area = Math.Round(circle.getAreaCircle(), 3);
            Assert.AreEqual(c_area, mc_area, "Возврат неверного значения площади круга при радиусе равном {0}", r);
        }

        [Test, TestCaseSource("CircleSource")]
        public void GetLengthCirclePositiveTest(int r)
        {
            Circle circle = new Circle(r);
            double c_length = Math.Round(2 * Math.PI * r, 3);
            double mc_length = Math.Round(circle.getLengthCircle(), 3);
            Assert.AreEqual(c_length, mc_length, "Возврат неверного значения длины окружности при радиусе равном {0}", r);
        }

        [Test, TestCaseSource("SquareSource")]
        public void GetAreaSquarePositiveTest(int a)
        {
            Square square = new Square(a);
            int s_area = a * a;
            double ms_area = square.getAreaSquare();
            Assert.AreEqual(s_area, ms_area, "Возврат неверного значения площади квадрата при стороне равной {0}", a);
        }

        [Test, TestCaseSource("SquareSource")]
        public void GetLengthSquarePositiveTest(int a)
        {
            Square square = new Square(a);
            int s_length = a * 4;
            double ms_length = square.getLengthSquare();
            Assert.AreEqual(s_length, ms_length, "Возврат неверного значения периметра квадрата при стороне равной {0}", a);
        }

        [Test, TestCaseSource("TriangleSource")]
        public void GetAreaTrianglePositiveTest(int b)
        {
            Triangle triangle = new Triangle(b, b, b);
            double halfP = (double)(b + b + b) / 2;
            double t_area = Math.Round(
            Math.Pow(halfP * (halfP - b) * (halfP - b) * (halfP - b)
            , 0.5), 5);
            double mt_area = Math.Round(triangle.getAreaTriangle(), 5);
            Assert.AreEqual(t_area, mt_area, "Возврат неверного значения площади треугольника при условии " +
                "что \n сторона1  = {0}\n сторона2 = {1}\n сторона3 = {2}", b, b, b);
        }

        [Test, TestCaseSource("TriangleSource")]
        public void GetLengthTrianglePositiveTest(int b)
        {
            Triangle triangle = new Triangle(b, b, b);
            double t_length = b + b + b;
            double mt_length = triangle.getLengthTriangle();
            Assert.AreEqual(t_length, mt_length, "Возврат неверного значения периметра треугольника при условии" +
                " что \n сторона1 = {0}\n сторона2 = {1}\n сторона3 = {2}", b, b, b);
        }
    }
}
