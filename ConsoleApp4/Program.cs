using System;
using System.Diagnostics;

namespace ConsoleApp4;

public class Program
{
    static void Main(string[] args)
    {
        Counter chislo = new Counter();
        
        Console.WriteLine("1 - Прибавить в счётчику; 2 - убавить у счётчика; 3 - выход");
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a) {
            case 1:
               chislo.Plus();
                break;
            case 2 :
                chislo.Minus();
                break; 
            case 3:
                break;
        }
    }
}