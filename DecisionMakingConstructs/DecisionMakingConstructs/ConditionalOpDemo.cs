using System;


namespace DecisionMakingConstructs
{
    // This program shows how to make decisions using && || operator
    class ConditionalOpDemo
    {
        static void Main()
        {
            //  logical && || evaluate expresion together and returns true/false.
            try
            {
                Console.Write("Enter Qualification (UG/PG):");
                string qualification = Console.ReadLine();
                Console.Write("Enter Experence in Months:");
                int exp = int.Parse(Console.ReadLine());

                if (qualification.ToLowerInvariant() == "pg" || exp >= 12)
                {
                    Console.WriteLine("You are eligible to appear interview");             
                }
                else
                {
                    Console.WriteLine("You are not eligible to appear interview");
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
