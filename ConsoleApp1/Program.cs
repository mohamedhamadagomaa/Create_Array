﻿class Program
{
    static void Main(string[] args)
    {
        // CREATE an application to reverse a dynamic array using 'for'
        Console.Write("Enter the size of array: "); ;
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter the element #{i + 1}");
            myArr[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        foreach (int e in myArr)
            sum += e;
        double av = sum / size;
        Console.WriteLine($" The average is:  {av}");




    }
}