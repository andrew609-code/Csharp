using System;


namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This writes the title at the top
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Asks the user the weight , width and height of their package
            Console.WriteLine("Please enter the package weight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package width: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

        //This makes sure that the package is not too heavy
        if (packageWeight > 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
        
        //This makes sure the dimentions of the package are not too large and weight is not too heavy    
        if (packageWidth + packageHeight > 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
        
        //Now that the package qualifys it figures out the total shipping cost for your package in accordance to the provided information.    
        else 
            {
                int quote = (packageHeight * packageWeight * packageWidth) * packageWeight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quote);
                Console.ReadLine();
            }

        }            

           
                

        
        

    }
}
