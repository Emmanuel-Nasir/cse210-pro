using System;

public class Fraction
{
    private int _above;
    private int _below;
    public Fraction(){
        _above = 1;
        _below = 1;
    }
    public Fraction(int wholeNum)
    {
        _above = wholeNum;
        _below = 1;
    }
    public Fraction(int top, int bottom){
        _above = top;
        _below = bottom;
    }
    public string GetFractionString(){
        string text = $"{_above}/{_below}";
        return text;
    }
    public double GetDecimalValue(){
        return  (double)_above / (double)_below;
    }
}