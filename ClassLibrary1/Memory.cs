using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Memory
    {
        private List<MemoryItem> memoryItem = new List<MemoryItem>();

        public void MemoryStore(MemoryItem item)
        {
            memoryItem.Add(item);
            Console.WriteLine("ug toog hadgallaa");
        }

        public float RecallMemoryItem(int n)
        {
            PrintMemoryItems();
            Console.WriteLine("butsaah tooniihoo urdah indexiig oruulna uu: \n");
            if (n < 0 || n >= memoryItem.Count)
            {
                throw new IndexOutOfRangeException("buruu index oruulsan bn");
            }

            return memoryItem[n].Value;
        }

        public float MemorySubstract(int n, float x)
        {
            if (n < 0 || n >= memoryItem.Count)
            {
                throw new IndexOutOfRangeException("buruu index oruulsan bn");
            }
            memoryItem[n].Value -= x;
            return memoryItem[n].Value;
        }
        public float MemoryAdd(int n, float x)
        {
            if (n < 0 || n >= memoryItem.Count)
            {
                throw new IndexOutOfRangeException("buruu index oruulsan bn");
            }
            memoryItem[n].Value += x;
            return memoryItem[n].Value;
        }

        public void PrintMemoryItems()
        {
            Console.WriteLine("hadgalagdsan elementuud: \n");
            for (int i = 0; i < memoryItem.Count; i++)
            {
                Console.WriteLine(i + ". " + memoryItem[i].Value);
            }
        }

        public void ClearAllMemory()
        {
            memoryItem.Clear();
        }

    }
}
