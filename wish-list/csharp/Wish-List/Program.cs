using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wishes = new List<string> {
                "Raindrops on roses",
                "Whiskers on kittens",
                "Bright copper kettles",
                "Warm woolen mittens",
                "Brown paper packages tied up with strings",
            };

            Console.WriteLine("My wishes....");

            foreach (string wish in wishes)
            {
                Console.WriteLine(wish);
            }
        }
    }
}