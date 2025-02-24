using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// memoryItem class that include each memory items operation
    /// </summary>
    public class MemoryItem
    {
        /// <summary>
        /// Value property is just saving value
        /// </summary>
        public float Value { get; set; }
        /// <summary>
        /// this is saving value parameter to Memory item objects value. and this is constraction method
        /// </summary>
        /// <param name="value"></param>
        public MemoryItem(float value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Display method is just printing value 
        /// </summary>
        public void Display()
        {
            Console.WriteLine(Value);
        }
    }
}
