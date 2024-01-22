using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" This will  write same line ");
            Console.WriteLine(" This will \n wrap to next line ");
            Console.WriteLine(" This will \" print out the quotation mark.");

            string firstName = "Thandeka";
            string lastName = "Ndlovu";
            //concatination
            Console.WriteLine( firstName + " " + lastName );

            //functions with strings
            Console.WriteLine(lastName.Length);
            //console on strings
            Console.WriteLine(firstName.ToUpper());
            //method with a parameter eg the contains(), its case sensetive
            Console.WriteLine(lastName.Contains("Ndlo"));
            //access characters using index
            Console.WriteLine(firstName[0]);
            //indexOf will tell you if the value is there and at what position
            Console.WriteLine(" index of a is");
            Console.WriteLine(lastName.IndexOf('a'));// can use double quotes too
            //subtracting, to grab from the index onwards
            Console.WriteLine(firstName.Substring(1));
            //you can also give index and length ie how many chairs you want to grab
            Console.WriteLine(firstName.Substring (1,2));
            Console.Read();
                                                    // 
        }
    }
}
