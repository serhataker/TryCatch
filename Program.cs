using System;
namespace Trycatch
{


    class TryCatch
    {

        static void Main(string[] args)
        {
            bool IsItNumber = false;
            while (!IsItNumber) { // we defined the bollan variable for the whille loop if it is dont true we turning loop
                try
                {
                    Console.WriteLine("Please Enter the number:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int squared = x * x;
                    Console.WriteLine($"Number's Square: {squared}"); // we print the number square
                    IsItNumber = true;
                }
                catch (FormatException ex)// we used the formatexceprion settings toint32
                {
                    
                    {
                        Console.WriteLine("Invalid number please try again");// if it is wrong value

                    } 
                }
            }
        }
    }
}