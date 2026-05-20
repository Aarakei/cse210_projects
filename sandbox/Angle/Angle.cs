class Angle
{
    private double _radians;

    public Angle()
    {
        _radians = 0;
    }

    public Angle(double radians)
    {
        _radians = radians;
    }

    public double GetRadians()
    {
        return _radians;
    }
    
    public void SetRadians(double radians)
    {
        _radians = radians;
    }
}