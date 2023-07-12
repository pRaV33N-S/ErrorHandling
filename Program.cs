using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*int num1, num2, result;
                Console.WriteLine("Enter First Number ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
                Console.WriteLine($"Result after dividing {num1} by {num2} is = {result}");*/
                Console.WriteLine("Please Enter a Number");
                string input = Console.ReadLine();
                if(int.TryParse(input,out int result))
                {
                    Console.WriteLine("Parsed Number using intTryParse is : \t"+result);
                }
                else
                {
                    Console.WriteLine("Failed to Parse"); ;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!!"+ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
   
        }
    }
}
