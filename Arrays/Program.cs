using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
               //Names
            {   string[] names = new string[5];
                names[0] = "Steven";
                names[1] = "Kevin";
                names[2] = "Linda";
                names[3] = "John";
                names[4] = "Jane";

                foreach(string s in names)
                Console.WriteLine("Hello " + s);
            }
            //Number
            int[] numbers = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            int sum=0;
            Console.WriteLine();
            for(int counter=0; counter<numbers.Length;counter++) {
                sum+=numbers[counter];
            }
            Console.WriteLine("The total is " + sum);
            
        }
    }
}
