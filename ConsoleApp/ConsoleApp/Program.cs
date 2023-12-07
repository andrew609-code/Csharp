using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a do while loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                count++; //add one to count each time
            }
            while (count < 5); //continue the loop until count reaches 5

            //This is a while loop
            int counting = 0;
            while (counting < 3) //continue to loop until counting reaches 3
            {
                Console.WriteLine("Counting numbers");
                counting++; //add one to the count each time
            }
            Console.ReadLine();
        
                    
        }
    }
}
