public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;


    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }


    public void SetFraction(int top, int bot)
    {
        _topNumber = top;
        _bottomNumber = bot;
    }

    public void GetFraction()
    {
        Console.WriteLine($"Fraction {_topNumber}/{_bottomNumber}");
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }


}