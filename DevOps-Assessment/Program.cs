﻿using System;

class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Please, enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 17)
            {
                Console.WriteLine("Hi " + name + ", you can drink alchool because you are " + age + " years old.");
            }
            else
            {
                Console.WriteLine("Hi " + name + ", you can not drink alchool because you are " + age + " years old.");
            }
        }
    }








