namespace Figure;

public class Circle : Figure
{
    public Circle(params double[] sides) : base(sides)
    { }
    
    public override double GetSquare()
    {
        Validate();
        return Math.PI * Sides[0] * Sides[0];
    }

    protected override void Validate()
    {
        if (Sides.Length != 1) throw new ArgumentException("Неверное количество аргументов");
        
        if (Sides[0] < 0)
        {
            throw new ArgumentException("Отрицательное значение аргумента");
        }
    }
}