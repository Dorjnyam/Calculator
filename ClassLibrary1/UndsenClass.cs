using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// main class that inherits from Operators class
    /// </summary>
    public class UndsenCalculator : Operators
    {
        Memory memory = new Memory();

        public void MemoryStore(MemoryItem item)
        {
            memory.MemoryStore(item);
        }

        public float RecallMemoryItem(int n)
        {
            return memory.RecallMemoryItem(n);
        }

        public float MemorySubstract(int n, float x)
        {
            return memory.MemorySubstract(n, x);
        }

        public float MemoryAdd(int n, float x)
        {
            return memory.MemoryAdd(n, x);
        }

        public void PrintMemoryItems()
        {
            memory.PrintMemoryItems();
        }

        public void ClearAllMemory()
        {
            memory.ClearAllMemory();
        }
    }
}
