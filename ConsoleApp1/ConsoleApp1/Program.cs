﻿// See https://aka.ms/new-console-template for more information


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] tbl = { 1, 2, 3, 4 };
        
        Console.WriteLine(Avg(tbl));
        
        
    }
    
    public static double Avg(int[] tab)
    {
        double res = 0;
        int counter = 0;
        foreach (int a in tab)
        {
            counter++;
            res += a;
        }

        res = res / counter;
        return res;
    }
    
    public static int max(int[] tab)
    {
        return 1;g
    }
}
