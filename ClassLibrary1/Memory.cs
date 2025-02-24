using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Memory class that using memoryitem class to do some method and process
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// this memoryItem is a list and type is MemoryItem
        /// </summary>
        private List<MemoryItem> memoryItem = new List<MemoryItem>();

        /// <summary>
        /// adding item into memoryitem list and showing what item is saved.
        /// </summary>
        /// <param name="item"></param>
        public void MemoryStore(MemoryItem item)
        {
            memoryItem.Add(item);
            Console.WriteLine("ug toog hadgallaa");
        }

        /// <summary>
        /// this is getting memoryItems item by n(index) and if index is out of range then throw exception
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
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

        /// <summary>
        /// this method is doing substract from given index's value by x parameters
        /// </summary>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public float MemorySubstract(int n, float x)
        {
            if (n < 0 || n >= memoryItem.Count)
            {
                throw new IndexOutOfRangeException("buruu index oruulsan bn");
            }
            memoryItem[n].Value -= x;
            return memoryItem[n].Value;
        }

        /// <summary>
        /// this method is doing addition in given index's value by x parameters
        /// </summary>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public float MemoryAdd(int n, float x)
        {
            if (n < 0 || n >= memoryItem.Count)
            {
                throw new IndexOutOfRangeException("buruu index oruulsan bn");
            }
            memoryItem[n].Value += x;
            return memoryItem[n].Value;
        }

        /// <summary>
        /// this method is printing all items of memoryitems
        /// </summary>
        public void PrintMemoryItems()
        {
            Console.WriteLine("hadgalagdsan elementuud: \n");
            for (int i = 0; i < memoryItem.Count; i++)
            {
                Console.WriteLine(i + ". " + memoryItem[i].Value);
            }
        }

        /// <summary>
        /// clearing all memory of memoryitems
        /// </summary>
        public void ClearAllMemory()
        {
            memoryItem.Clear();
        }

    }
}
