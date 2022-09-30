using Figure;

namespace Tests
{
    public class CircleTest
    {
        [Fact]
        public void RadiusOne_True()
        {
            var value = new Circle(1).GetSquare();
            Assert.Equal(Math.PI, value);
        }

        [Fact]
        public void RadiusZero_True()
        {
            var value = new Circle(0).GetSquare();
            Assert.Equal(0, value);
        }

        [Fact]
        public void RadiusTen_True()
        {
            var value = new Circle(10).GetSquare();
            Assert.Equal(10 * 10 * Math.PI, value);
        }

        [Fact]
        public void RadiusNull_False()
        {
            var caughtException = Assert.Throws<ArgumentException>(() => new Circle().GetSquare());
            Assert.Equal("Неверное количество аргументов", caughtException.Message);
        }

        [Fact]
        public void RadiusTwoParams_False()
        {
            var caughtException = Assert.Throws<ArgumentException>(() => new Circle(1,2,3).GetSquare());
            Assert.Equal("Неверное количество аргументов", caughtException.Message);
        }

        [Fact]
        public void RadiusNegative_False()
        {
            var caughtException = Assert.Throws<ArgumentException>(() => new Circle(-3).GetSquare());
            Assert.Equal("Отрицательное значение аргумента", caughtException.Message);
        }
    }
}
