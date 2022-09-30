namespace Figure;

public class Triangle : Figure
{
    public Triangle(params double[] sides) : base(sides)
    { }
    
    public override double GetSquare()
    {
        Validate();
        double semiPerimeter = Sides.Sum() / 2;
        return Math.Sqrt(
            semiPerimeter * (semiPerimeter - Sides[0]) * (semiPerimeter - Sides[1]) * (semiPerimeter - Sides[2])
            );
    }

    protected override void Validate()
    {
        if (Sides.Length != 3) throw new ArgumentException("Неверное количество аргументов");
        if (Sides[0] <= 0 || Sides[1] <= 0 || Sides[2] <= 0) throw new ArgumentException("Отрицательное значение аргумента");
        if (Sides[0] + Sides[1] < Sides[2]) throw new ArgumentException("Неверные аргументы");
    }

    public bool IsRightTriangle()
    {
        const double TOLERANCE = 0.0001;
        if (Math.Abs(Sides[0] * Sides[0] + Sides[1] * Sides[1] - Sides[2] * Sides[2]) < TOLERANCE) return true;
        return false;
    }
}