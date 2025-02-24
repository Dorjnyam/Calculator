using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// interface class that declare 2 method with no body section
    /// </summary>
    interface InterfaceOperators
    {
        /// <summary>
        /// sum method that have a 2 parameter that can be null and return nothing (void)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Sum(float? x, float? y);
        /// <summary>
        /// substracction method that have also 2 parameter that can be null and return nothing (void)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Substraction(float? x, float? y);
    }
}
