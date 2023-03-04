using System;
namespace ConsoleApp4;

public class Counter
{
    private int RNDnum;

    public int Value {
        get {
            return RNDnum;
        }
    }

    public Counter()
    {
        Random rnd = new Random();
        this.RNDnum = rnd.Next(10, 100);
    }
    public Counter(int RNDnum)
    {
        this.RNDnum = RNDnum;
    }

    public void Increase()
    {
        RNDnum++;
    }
    public void Decrease()
    {
        RNDnum--;
    }

    public void Plus()
    {
        Console.WriteLine($"Работа счётчика...\n(+) -- прибавить");
        for (int i = 0; i < 999; i++)
        {
            string kuda = Console.ReadLine();
            if (kuda == "+")
            {
                Increase();
                int res = Value;
                Console.WriteLine(res);
            }
            else if (kuda == "")
            {
                break;
            }
        }
        Console.WriteLine("Изменено...");
    }

    public void Minus()
    {
        Console.WriteLine($"Работа счётчика...\n(-) -- убавить");
        for (int i = 0; i < 999; i++)
        {
            string kuda = Console.ReadLine();
            if (kuda == "-")
            {
                Decrease();
                int res = Value;
                Console.WriteLine(res);
            }else if (kuda == "")
            {
                break;
            } 
        }
        Console.WriteLine("Изменено...");
    }
}