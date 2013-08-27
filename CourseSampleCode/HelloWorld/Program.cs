using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstVideo
            //Code from the first video
            //Console.WriteLine("Hello World");
            //Console.WriteLine("This is my first C# App");
            #endregion

            #region 3rdVideo
            //Code from 3rd video
            //Write more comments
            string firstName = "John";
            int age = 12;
            decimal salary = 34.67m;

            //Console.WriteLine(firstName + " " + age + " "+ salary);
            #endregion

            //4th video about how to add comments to your code

            //5th video - Loops
            //for loop
            //for (int i = 1; i < 21; i++)
            //{
            //    Console.WriteLine("This is a for loop " + i);
            //}

            string[] list = new string[]
                                {
                                    "Hello",
                                    "Bye",
                                    "Dinner Time"
                                };

            //foreach (string item in list)
            //{
            //    Console.WriteLine("This is a for each loop " + item);
            //}

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("A while loop " + counter);
                counter++;
            }
            Console.ReadLine();
        }
    }
}
