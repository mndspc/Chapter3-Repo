using System;
namespace DecisionMakingConstructs
{
    class Program
    {
        //  This program shows how to write if construct
        static void Main(string[] args)
        {
            //  If construct only accepts expressions which returns boolean value
            try
            {
                Console.Write("Please Enter Annual Income in INR:");
                int annualIncome = int.Parse(Console.ReadLine());
                if (annualIncome >= 280000)
                {
                    Console.WriteLine("You are liable to pay I.T.");
                }
                else
                {
                    Console.WriteLine("You are not liable to pay I.T.");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
