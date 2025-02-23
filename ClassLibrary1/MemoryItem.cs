using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MemoryItem
    {
        public float Value { get; set; }
        public MemoryItem(float value)
        {
            this.Value = value;
        }

        public void Display()
        {
            Console.WriteLine(Value);
        }
    }
}
