using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labik14
{
    [DeveloperInfoAttribute("Zarechnyi Maxim", Date = "12.12.2022")]
    internal class RationalNumbers
    {
        /// <summary>
        /// Числитель
        /// </summary>
        internal int Numerator { get; set; }
        /// <summary>
        /// Знаменатель
        /// </summary>
        internal int Denominator { get; set; }

        internal RationalNumbers(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        internal RationalNumbers() { }


        public static RationalNumbers operator +(RationalNumbers num1, RationalNumbers num2)
        {
            return new RationalNumbers()
            {
                Numerator = (num1.Numerator * num2.Denominator + num2.Numerator * num1.Denominator),
                Denominator = (num1.Denominator * num2.Denominator)
            };
        }

        public static RationalNumbers operator -(RationalNumbers num1, RationalNumbers num2)
        {
            return new RationalNumbers()
            {
                Numerator = (num1.Numerator * num2.Denominator - num2.Numerator * num1.Denominator),
                Denominator = (num1.Denominator * num2.Denominator)
            };
        }

        public static RationalNumbers operator ++(RationalNumbers num)
        {
            return new RationalNumbers()
            {
                Numerator = num.Numerator += num.Denominator,
                Denominator = num.Denominator
            };
        }

        public static RationalNumbers operator --(RationalNumbers num)
        {
            return new RationalNumbers()
            {
                Numerator = num.Numerator -= num.Denominator,
                Denominator = num.Denominator
            };
        }

        public static bool operator >(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator * num2.Denominator > num2.Numerator * num1.Denominator;
        }

        public static bool operator <(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator * num2.Denominator < num2.Numerator * num1.Denominator;
        }

        public static bool operator <=(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator / num1.Denominator <= num2.Numerator / num2.Denominator;
        }

        public static bool operator >=(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator / num1.Denominator >= num2.Numerator / num2.Denominator;
        }

        public static bool operator ==(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator == num2.Numerator && num1.Denominator == num2.Denominator;
        }

        public static bool operator !=(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator != num2.Numerator || num1.Denominator != num2.Denominator;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is RationalNumbers num)
            {
                return Numerator == num.Numerator && Denominator == num.Denominator;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string temp = $"{Numerator} / {Denominator}";
            return temp;
        }
    }
}