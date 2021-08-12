using System;

namespace DecisionMakingConstructs
{
    // This program shows how to change control flow of program using goto lable.
    class GotoDemo
    {
        static void Main()
        {
            //  Goto has lable to change flow of program.it should have conditional exit.
                     
                try
                {
start:              Console.Write("Please Enter Annual Income in INR:");
                    int annualIncome = int.Parse(Console.ReadLine());
                    if (annualIncome >= 280000)
                    {
                        Console.WriteLine("You are liable to pay I.T.");
                    }
                    else
                    {
                        Console.WriteLine("You are not liable to pay I.T.");
                    }
                    Console.Write("Do you want to continue:(yes/no):");
                    string response = Console.ReadLine();
                    if (response.ToLowerInvariant() == "yes")
                    {
                    goto start;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
            Console.ReadLine();
        }
    }
}
