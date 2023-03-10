﻿namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection programs");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:List Demo\n2:Dictionary Demo");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ListDemo.List();
                    break;
                case 2:
                    DictionaryDemo.Dictionary();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}