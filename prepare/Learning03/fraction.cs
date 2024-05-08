public class Fraction
{
    private int _top;
    private int _bottom;

    //defualt constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //whole number constructor
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //custom fraction constructor
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string DisplayFractionString()
    {
        return $"{_top}/{_bottom}";
        
    }

    public double DisplayFractionDecimal()
    {
        return (double)_top / _bottom;
    }
}