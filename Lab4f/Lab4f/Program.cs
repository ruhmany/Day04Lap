using Day4Lap;
using System;

class Program
{


    static void Main(string[] args)
    {
        DynamicCustomeArray dca = new DynamicCustomeArray() { 1, 2, 3, 4, 5 };
        foreach(var item in dca)
            Console.WriteLine(item);
        dca.Insert(3, 7);
        foreach (var item in dca)
            Console.WriteLine(item);
        dca.RemoveAt(3);
        foreach (var item in dca)
            Console.WriteLine(item);
    }
    
}


