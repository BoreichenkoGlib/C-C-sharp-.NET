using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
        public class Fraction
    {
        public int numer,denom;

        public Fraction(int X , int Y)
        {
            this.numer = X;
            this.denom = Y;
        }
        public static Fraction operator -(Fraction fraction)
        {
            Fraction obj = new Fraction(-fraction.numer,fraction.denom);
            return obj;
        }

        public static Fraction operator +(Fraction fraction)        {
            Fraction obj = new Fraction(fraction.numer, fraction.denom);
            return obj;
        }
        public static Fraction operator ++(Fraction fraction)
        {
            Fraction obj = new Fraction(fraction.numer+fraction.denom,fraction.denom);
            return obj;
        }
        public static Fraction operator --(Fraction fraction)
        {
            Fraction obj = new Fraction(fraction.numer- fraction.denom, fraction.denom);
            return obj;
        }
        public static Fraction operator *(Fraction a,Fraction b)
        {
            Fraction obj = new Fraction(a.numer* b.numer, a.denom*b.denom);
            return obj;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction obj = new Fraction(a.numer*b.denom+a.denom*b.numer,a.denom*b.denom);
            return obj;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }
        public Fraction Reverse()
        {
            return new Fraction(denom, numer);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a * b.Reverse();
        }
        public override string ToString()
        {
            return $"{numer}/{denom}";
        }
        public static implicit operator double(Fraction obj)
        {
            return (double)obj.numer / obj.denom;
        }
        public static bool operator > (Fraction a, Fraction b)
        { return (double)a > (double)b;  }
        public static bool operator <(Fraction a, Fraction b)
        { return (double)a < (double)b; }
        public static bool operator >=(Fraction a, Fraction b)
        { return !(a < b); }
        public static bool operator <=(Fraction a, Fraction b)
        { return !(a > b); }
        public static bool operator ==(Fraction a, Fraction b)
        {if (a == b)
                return true;
            else return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (a != b)
                return true;
            else return false;
        }

    }
}
