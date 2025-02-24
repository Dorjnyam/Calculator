using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    /// <summary>
    /// This Operators abstract class is including all main operations and also implementing from InterfaceOperators
    /// </summary>    
    public abstract class Operators : InterfaceOperators
    {
        /// <summary>
        /// private feild that saving float value
        /// </summary>
        private float _result;
        
        /// <summary>
        /// Result property saving value and return _result
        /// </summary>
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

        /// <summary>
        /// this method is adding 2 number and save in Result property
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual void Sum(float? x, float? y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("hooson utga oruulj bolohgui.");
            }
            Result = x.Value + y.Value;
        }

        /// <summary>
        /// this is substraction that like a first_number - second_number and save in Result property
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual void Substraction(float? x, float? y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("Hooson utga oruulj bolohgui");
            }
            Result = x.Value - y.Value;
        }

        // this is no needed in instroction but i just added for just i wanna trying
        /// <summary>
        /// Division method that second number must not 0
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <exception cref="DivideByZeroException"></exception>
        public virtual void Division(float x, float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("0 ees oor too oruulna uu");
            }
            Result = x / y;
        }

        /// <summary>
        /// multiplication method 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void Multiplication(float x, float y)
        {
            Result = x * y;
        }

        /// <summary>
        /// inverse method is like x_2 = 1 / x_1 and x_1 is must not be zero
        /// </summary>
        /// <param name="x"></param>
        /// <exception cref="DivideByZeroException"></exception>
        public virtual void Inverse(float x)
        {
            if (x == 0)
            {
                throw new DivideByZeroException("0 ees oor too oruulna uu");
            }
            Result = 1 / x;
        }

        /// <summary>
        /// squere method is just saving given numbers square in Result
        /// </summary>
        /// <param name="x"></param>
        public virtual void Square(float x)
        {
            Result = x * x;
        }

        /// <summary>
        /// squareroot method is using mathf class to do squareroot of float given number and this is only work in real number
        /// </summary>
        /// <param name="x"></param>
        /// <exception cref="ArgumentException"></exception>
        public virtual void SquareRoot(float x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Bodit too oruulna uu");
            }
            Result = MathF.Sqrt(x);
        }

        /// <summary>
        /// this is giving percent that caclculating by 100's what like 
        /// </summary>
        /// <param name="x"></param>
        public virtual void Percentage(float x)
        {
            Result = x / 100;
        }

        /// <summary>
        /// this is displaying the result
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine(Result);
        }
    }
}
