using System;
namespace RationalNumbers
{
    public interface IRationalNumber
    {
        IRationalNumber Add(IRationalNumber number);
        IRationalNumber Subtract(IRationalNumber number);
        IRationalNumber Multiply(IRationalNumber number);
        IRationalNumber Divide(IRationalNumber number);
        IRationalNumber Abs();
        IRationalNumber ExpRational(int power);
        // anything else you need to add?
        // stuff that i added to the interface to make the methodds work
        IRationalNumber Reduce();
        double ExpReal(int baseNumber);
        int Numerator { get; set; }
        int Denominator { get; set; }
        
    }
}
