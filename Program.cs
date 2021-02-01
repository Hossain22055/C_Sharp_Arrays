using System;
using System.Collections.Generic;

namespace cSharp_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {    // Create list 
             // Example #1

            Console.WriteLine("Example #1");
            var numbers = new List<int>();
            
            // Add number 0 to 10 to the numbers variables using for-loop 
            for (int i = 0; i <=5; i++)
            {
                numbers.Add(i);
            }


            // To print the list  of numbers use foreach loop 
            // assigned the numbers to num in forecah loop condition 
            foreach (var num in numbers)
            {
                
                Console.WriteLine(num);
            }
            Console.WriteLine();


            //Example #2
            Console.WriteLine("Example #2");
            var threeNumbers = new List<int>();

             for (int h=7; h>4; h--)
            {
                threeNumbers.Add(h);
            }

             foreach(var three in threeNumbers)
            {
                Console.WriteLine(three);
            }
            Console.WriteLine();

            // Learnign Arrays 
            // Declaring and initializaing Arrays 

            Console.WriteLine("Arrays Example 1");
            int[] arraysNumber = new int[4] { 4, 3, 2, 1 };
            for (int m=0;m<arraysNumber.Length; m++)
            {
                Console.WriteLine(arraysNumber[m]);
            }
            Console.WriteLine();


            Console.WriteLine("Arrays Example 2");
            int[] arraysCount = new int[] { 9, 8, 7, 6, 5 };
            for(int n=0; n < arraysCount.Length; n++)
            {
                Console.WriteLine(arraysCount[n]);
            }
            Console.WriteLine();


            Console.WriteLine("Arrays Example 3");
            var myArrays = new int[] { 11, 12, 13 };
            string[] friendsName = { "Jamal", "Tenzin", "John" };
           
            for (int j=0; j<friendsName.Length;j++)
            {
                Console.WriteLine(friendsName[j]);
            }
            Console.WriteLine();

            // Print by index number 
            Console.WriteLine("Arrays Example 4");
            int[] simpleExample = { 6, 5, 4, 3 };
            Console.WriteLine(simpleExample[3]);
            Console.WriteLine();



            // print simpleExample using foreach loop
            Console.WriteLine("Arrays Example 5 ");
            foreach ( int b in simpleExample)
            {
                Console.WriteLine(b);
            }




















        }

    }
}
