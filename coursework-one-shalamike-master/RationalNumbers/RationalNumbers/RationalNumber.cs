using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace RationalNumbers
{
    public struct RationalNumber : IRationalNumber
    {
        public int Numerator { get;  set; }
        public int Denominator { get; set; }

        //constructor if only the numberator is provided otherwise seems like its gonna be unused
        public RationalNumber(int numerator)
        {
            
            if (numerator is int)
            {
                this.Numerator = numerator;
                this.Denominator = 1;
                
            }
            else
            {
                throw new Exception("input is not a number");
                
            }
        }
        //constructor if both numerator and denominator is provided
        public RationalNumber(int numerator, int denominator)
        {
            if ((numerator.GetType() != typeof(int)) && (denominator.GetType() != typeof(int)))
            {
                throw new Exception("input is not a number");
            }
            else
            {
                if (denominator != 0)
                {
                    this.Numerator = numerator;
                    this.Denominator = denominator;
                    //if the user enters a negative denominator, the rational number will always set the numerator to be negative
                    if (this.Denominator < 0)
                    {
                        // this will also set the number to be a positive number if both the numerator and denominator are negative
                        this.Numerator *= -1;
                        this.Denominator *= -1;
                    }
                }
                else
                {
                    throw new Exception("Denominator cannot be 0");
                }
                
            }
            
        }
        //operator overloding methods implemented by keith, to be used in the program
        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);
        
        public IRationalNumber Reduce()
        {
            // checking if the numerator is 0 then setting the denominator to 1 if true
            if (this.Numerator == 0)
            {
                this.Denominator = 1;
            }
            // creating a for loop that will divide both the numerator and denominator until it reaches its simplest form
            else
            {
                for (int i = this.Denominator; i >= 2; i--)
                {
                    if (this.Numerator % i == 0 && this.Denominator % i == 0)
                    {
                        //every time a number shares the same highest common factor i, both numbers will be devided by i and i will be set to the denominator
                        this.Numerator /= i;
                        this.Denominator /= i;
                        i = this.Denominator;
                    }
                } }
            return new RationalNumber(this.Numerator, this.Denominator);
            
        }
        //exp Real is a single lambda that uses the extension method intNumberExtension and returns the new baseNumber raised to the power of a rational number
        public double ExpReal(int baseNumber) => IntNumberExtension.ExpReal(baseNumber, new RationalNumber(this.Numerator, this.Denominator));
        //abs finds the magnitude of the rational number (sets it to a positive value, also can be done by cheking if number is less than 0 and then *= -1 if it is. this is also a lambda
        public IRationalNumber Abs() => new RationalNumber(Math.Abs(this.Numerator), Math.Abs(this.Denominator)).Reduce();

        //this method raises a rational number to the power of a positive or negative integer
        public IRationalNumber ExpRational(int power)
        {
            // checking if the power is greater or less than 
            if (power >= 0)
            {
                //simply raising the numerator and denominator to the value of power positive
                this.Numerator= (int) Math.Pow(this.Numerator, power);
                this.Denominator = (int) Math.Pow(this.Denominator, power);
                
            }  else if (power < 0 )
            {
                if (this.Numerator == 0)
                {
                    // setting the numerator and denominator to 0 and 1 if the power is negative and numerator is 0, this is to prevent the program returning a denominator with value 0
                    return new RationalNumber(0,1);
                }
                else
                {
                    // setting the power to be a positive int
                    power *= -1;
                    // creating placeholders for both the numerator and denominator
                    int numeratorPlaceholder = this.Numerator;
                    int denominatorPlaceholder = this.Denominator;
                    //setting the numerator to be the denominator and denominator to be the numerator and raising them to the power in the parameter
                    this.Numerator = (int) Math.Pow(denominatorPlaceholder, power );
                    this.Denominator = (int) Math.Pow(numeratorPlaceholder, power );
                }
            }
            return new RationalNumber(this.Numerator,this.Denominator).Reduce();
        }

        public IRationalNumber Add(IRationalNumber number)
        {
            IRationalNumber r1 = new RationalNumber(this.Numerator, this.Denominator);
            IRationalNumber r2 = number;
            // calling the method refactoredNumbers to ensure both numbers share the same denominator
            IRationalNumber[] NumbersToAdd = refactoredRationalNumbers(r1, r2);
            r1 = NumbersToAdd[0];
            r2 = NumbersToAdd[1];
            return new RationalNumber((r1.Numerator + r2.Numerator), r1.Denominator).Reduce();
            //throw new NotImplementedException();
        }

        public IRationalNumber Subtract(IRationalNumber number)
        {
            IRationalNumber r1 = new RationalNumber(this.Numerator, this.Denominator);
            IRationalNumber r2 = number;
            // calling the method refactoredNumbers to ensure both numbers share the same denominator
            IRationalNumber[] NumbersToSubtract = refactoredRationalNumbers(r1, r2);
            r1 = NumbersToSubtract[0];
            r2 = NumbersToSubtract[1];
            //returning the result of the 
            return new RationalNumber(r1.Numerator - r2.Numerator, r1.Denominator).Reduce();
        }

        public IRationalNumber Multiply(IRationalNumber number)
        {
            IRationalNumber r1 = new RationalNumber(this.Numerator, this.Denominator);
            IRationalNumber r2 = number;
            // returning the result of simply multiplying both numerators and denominators of the rational numbers 
            return new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator* r2.Denominator).Reduce();
            //throw new NotImplementedException();
        }

        public IRationalNumber Divide(IRationalNumber number)
        {
            IRationalNumber r1 = new RationalNumber(this.Numerator, this.Denominator);
            IRationalNumber r2 = number;
            // returning the result of multiplying the first rational number and the inverse of the second rational number
            return new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator).Reduce();
            //throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }


        // plus any other methods you deem necessary to meet the specification
        // this method refactors two rational numbers so that they share the same denominators for future calculations and returns an array of two rational numbers sharing the same denominator
        private IRationalNumber[] refactoredRationalNumbers(IRationalNumber number1, IRationalNumber number2)
        {
            IRationalNumber r1 = number1;
            IRationalNumber r2 = number2;
            //checking to see if they allready share the same denominator or not
            if (r1.Denominator == r2.Denominator)
            {
                //returning rational numbers as is when they share the same denominator
                IRationalNumber[] rationalNumbers = { r1, r2};
                return rationalNumbers;
            }
            else
            {
                // converting rational number one to have the same denominator as rational number two
                int numerator1 = r1.Numerator * r2.Denominator;
                int demoniator1 = r1.Denominator * r2.Denominator;
                // convertin rational number two to have the same denominator as rational number 1
                int numerator2 = r2.Numerator * r1.Denominator;
                int denominator2 = r2.Denominator * r1.Denominator;
                IRationalNumber[] rationalNumbers = { new RationalNumber(numerator1, demoniator1), new RationalNumber(numerator2, denominator2)};
                
                return rationalNumbers;
            }
        }
    }

    public static class IntNumberExtension
    {
        // exponentiate real number to the rational number power
        public static double ExpReal(this int intNumber, RationalNumber r)
        {
            // raising the values of the number to the power of the rational number and typecasting it to a floating point double
            double num =  Math.Pow((double) intNumber, (double) r.Numerator / (double) r.Denominator);
            // setting the floating point double to a decimal representation in order to utilize the Math.round() Method to 7 decimal places
            decimal DeciNum = (decimal) num;
            //rounding number to 7 decimal places while using toPositiveInfinity to ensure the last decimal is rounded up to the nearest decimal and never rounded down
            DeciNum = Math.Round(DeciNum, 7, MidpointRounding.ToPositiveInfinity);
            return (double) DeciNum;
        }
    }
}
