using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public struct Fraction
    {
        public int num;
        public int den;
        public Fraction(int numerator, int denominator)
        {
            num = numerator;
            den = denominator;
        }

        public static Fraction operator +(Fraction fraction1)
        {
            return fraction1;
        }
        public static Fraction operator -(Fraction fraction1)
        {
            return new Fraction(-fraction1.num,fraction1.den);
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.num*fraction2.den + fraction2.num*fraction1.den, fraction1.den*fraction2.den);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            return fraction1 + (-fraction2);
            //return new Fraction(fraction1.num*fraction2.den - fraction2.num*fraction1.den, fraction1.den*fraction2.den);
        }
    }


    //public readonly struct Fraction
    //{
    //    public readonly int num;
    //    public readonly int den;

    //    public Fraction(int numerator, int denominator)
    //    {
    //        num = numerator;
    //        den = denominator;
    //    }

    //    public static Fraction operator +(Fraction a)
    //    {
    //        return new Fraction(a.num,a.den);
    //    }

    //    public static Fraction operator -(Fraction a)
    //    {
    //        return new Fraction(-a.num, a.den);
    //    }

    //    public static Fraction operator +(Fraction a, Fraction b)
    //    {
    //        return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
    //    }

    //    public static Fraction operator -(Fraction a, Fraction b)
    //    {
    //        return a + (-b);
    //    }

    //    public static Fraction operator *(Fraction a, Fraction b)
    //    {
    //        return new Fraction(a.num * b.num, a.den * b.den);
    //    }

    //    public static Fraction operator /(Fraction a, Fraction b)
    //    {
    //        return new Fraction(a.num * b.den, a.den * b.num);
    //    }
    //}
























} 