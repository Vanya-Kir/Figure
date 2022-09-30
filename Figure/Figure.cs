namespace Figure;

public abstract class Figure
{
    private double[] _sides;

    public double[] Sides
    {
        get
        {
            return _sides;
        }
        set
        {
            _sides = value.OrderBy(i => i).ToArray();;
        }
    }

    public Figure(params double[] sides)
    {
        Sides = sides;
    }
    public abstract double GetSquare();
    protected abstract void Validate();
}