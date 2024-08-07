using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rang
    {
        public class Range<T> where T : IComparable<T>
        {
            private T _min;
            private T _max;

            // Constructor to initialize the range
            public Range(T min, T max)
            {
                if (min.CompareTo(max) > 0)
                {
                    throw new ArgumentException("Min value must be less or equal to max value");
                }
                _min = min;
                _max = max;
            }
            public bool IsInRange(T value)
            {
                return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
            }
            public T Length()
            {
                dynamic min = _min;
                dynamic max = _max;
                return (T)(max - min);
            }
        }
    }
}
