﻿using System;

namespace Area_of_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base of the triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseLength * height;

            Console.WriteLine($"The area of the triangle is: {area}");

            Console.ReadLine();
        }
    }
}

