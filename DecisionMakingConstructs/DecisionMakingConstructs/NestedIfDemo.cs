using System;
namespace DecisionMakingConstructs
{
    //  This program shows how to nest conditions.
    class NestedIfDemo
    {
        static void Main()
        {
            //  If there is dependency between conditions we can use nested if blocks.
            try
            {
                Console.Write("Enter Qualification (UG/PG):");
                string qualification = Console.ReadLine();
               
                if (qualification.ToLowerInvariant() == "pg")
                {
                    Console.Write("Enter Experence in Months:");
                    int exp = int.Parse(Console.ReadLine());
                    if (exp >= 12)
                    {
                        Console.WriteLine("You are eligible to appear interview");
                    }
                    else
                    {
                        Console.WriteLine("Experience must be greater than or equal to 12 months");
                    }
                }
                else
                {
                    Console.WriteLine("Qualification must be PG");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
