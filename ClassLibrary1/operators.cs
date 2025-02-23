using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    // uildliin interface
    
    public abstract class Operators : InterfaceOperators
    {
        private float _result;
        // Result gesen property
        public float Result 
        { 
            get
            {
                return _result;
            }
            set
            {
                _result = value;
            }
        }
        public virtual void Sum(float? x, float? y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("hooson utga oruulj bolohgui.");
            }
            Result = x.Value + y.Value;
        }

        public virtual void Substraction(float x, float y)
        {
            Result = x - y;
        }

        public virtual void Division(float x, float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("0 ees oor too oruulna uu");
            }
            Result = x / y;
        }

        public virtual void Multiplication(float x, float y)
        {
            Result = x * y;
        }

        public virtual void Inverse(float x)
        {
            if (x == 0)
            {
                throw new DivideByZeroException("0 ees oor too oruulna uu");
            }
            Result = 1 / x;
        }

        public virtual void Square(float x)
        {
            Result = x * x;
        }

        public virtual void SquareRoot(float x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Bodit too oruulna uu");
            }
            Result = MathF.Sqrt(x);
        }
        public virtual void Percentage(float x)
        {
            Result = x / 100;
        }
        public virtual void Display()
        {
            Console.WriteLine(Result);
        }
    }
}
