// See https://aka.ms/new-console-template for more information
using System;
using Calculator;

Console.WriteLine("Hello, World!");
UndsenCalculator calculator = new UndsenCalculator();
Memory memory = new Memory();
bool running = true;

while (running)
{
    Console.WriteLine("Edgeer uildlees songono uu: ");
    Console.WriteLine("1. Nemeh");
    Console.WriteLine("2. Hasah");
    Console.WriteLine("3. Urjih");
    Console.WriteLine("4. Huvaah");
    Console.WriteLine("5. Huvi tootsoh");
    Console.WriteLine("6. Urvuu too");
    Console.WriteLine("7. Kvadrat");
    Console.WriteLine("8. Yzguur");
    Console.WriteLine("9. Memory Store");
    Console.WriteLine("10. Memory recall");
    Console.WriteLine("11. Memory Add");
    Console.WriteLine("12. Memory Substract");
    Console.WriteLine("13. Memory Clear");
    Console.WriteLine("0. Exit");
    Console.WriteLine("Songoltoo oruulna uu:");
    int choice = Convert.ToUInt16(Console.ReadLine());
    if (choice == 0)
    {
        running = false;
        Console.WriteLine("Program closed.");
    }
    else if (choice >= 1 && choice <= 8)
    {
        Console.WriteLine("Ehnii too:");
        float a = Convert.ToSingle(Console.ReadLine());

        float b = 0;
        if (choice != 5 && choice != 6 && choice != 7 && choice != 8)
        {
            Console.WriteLine("2 doh too:");
            b = Convert.ToSingle(Console.ReadLine());
        }

        if (choice == 1)
        {
            calculator.Sum(a, b);
            calculator.Display();
        }
        else if (choice == 2)
        {
            calculator.Substraction(a, b);
            calculator.Display();
        }
        else if (choice == 3)
        {
            calculator.Multiplication(a, b);
            calculator.Display();
        }
        else if (choice == 4)
        {
            try
            {
                calculator.Division(a, b);
                calculator.Display();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else if (choice == 5)
        {
            calculator.Percentage(a);
            calculator.Display();
        }
        else if (choice == 6)
        {
            try
            {
                calculator.Inverse(a);
                calculator.Display();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else if (choice == 7)
        {
            calculator.Square(a);
            calculator.Display();
        }
        else if (choice == 8)
        {
            try
            {
                calculator.SquareRoot(a);
                calculator.Display();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine("Ur dung sanah oid hadgalah uu? (y/n)");
        string storeInMemory = Console.ReadLine();
        if (storeInMemory == "y" || storeInMemory == "Y")
        {
            memory.MemoryStore(new MemoryItem(calculator.Result));
        }
        else
        {
            continue;
        }
    }
    else if (choice == 9)
    {
        memory.PrintMemoryItems();
        Console.WriteLine("Sanah oigoos duudah.");
    }
    else if (choice == 10)
    {
        memory.PrintMemoryItems();
        Console.WriteLine("edgeerees duudah utgiin omnoh index ee songono uu:");
        int index = Convert.ToInt32(Console.ReadLine());
        try
        {
            float recalledValue = memory.RecallMemoryItem(index);
            Console.WriteLine($"Sanah oigoos duudsan utga: {recalledValue}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else if (choice == 11)
    {
        memory.PrintMemoryItems();
        Console.WriteLine("Sanah oigoo songono uu:");
        int index = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Memory ruu nemekh utgaa oruulna uu:");
        float addValue = Convert.ToSingle(Console.ReadLine());
        try
        {
            float result = memory.MemoryAdd(index, addValue);
            Console.WriteLine($"Memory-d nemeed ur dung sanana: {result}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else if (choice == 12)
    {
        memory.PrintMemoryItems();
        Console.WriteLine("Sanah oigoo songono uu:");
        int index = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Memory-s hasah utgaa oruulna uu:");
        float subtractValue = Convert.ToSingle(Console.ReadLine());
        try
        {
            float result = memory.MemorySubstract(index, subtractValue);
            Console.WriteLine($"Memory-s hasaad ur dung sanana: {result}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else if (choice == 13)
    {
        memory.ClearAllMemory();
        Console.WriteLine("Sanah oi bugd ustgagdlaa.");
    }
    else
    {
        Console.WriteLine("Ta 0 ees 13 iin hoorond songoltoo hiine uu.");
    }
}