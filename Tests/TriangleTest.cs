using Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class TriangleTest
    {
        [Fact]
        public void ThreeFourFiveSquare_True()
        {
            var value = new Triangle(3, 4, 5).GetSquare();
            Assert.Equal(3*4*0.5, value);
        }

        [Fact]
        public void OneOneOne_True()
        {
            var value = new Triangle(1, 1, 1).GetSquare();
            Assert.Equal(Math.Sqrt(3)/4, value);
        }

        [Fact]
        public void NullParams_False()
        {
            var caughtException = Assert.Throws<ArgumentException>(() => new Triangle().GetSquare());
            Assert.Equal("Неверное количество аргументов", caughtException.Message);
        }

        [Fact]
        public void FiveParams_False()
        {
            var caughtException = Assert.Throws<ArgumentException>(() => new Triangle(1,2,3,4,5).GetSquare());
            Assert.Equal("Неверное количество аргументов", caughtException.Message);
        }

        [Fact]
        public void NegativeParams_False()
        {
            var caughtException = Assert.Throws<ArgumentException>(() => new Triangle(1, -2, 3).GetSquare());
            Assert.Equal("Отрицательное значение аргумента", caughtException.Message);
        }

        [Fact]
        public void NotTriangle_False()
        {
            var caughtException = Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10).GetSquare());
            Assert.Equal("Неверные аргументы", caughtException.Message);
        }

        [Fact]
        public void IsRightTriangle_True()
        {
            var value = new Triangle(3, 4, 5).IsRightTriangle();
            Assert.True(value);
        }

        [Fact]
        public void IsRightTriangle_False()
        {
            var value = new Triangle(3, 4, 5.5).IsRightTriangle();
            Assert.False(value);
        }
    }
}
