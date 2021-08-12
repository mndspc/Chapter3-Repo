using System;


namespace DecisionMakingConstructs
{
    //  This program shows how can make decision using ternary op. ?:
    class TernaryDemo
    {
        static void Main()
        {
            //  Ternary operator is alternative for if-else construct
            try
            {
                Console.Write("Please Enter Annual Income in INR:");
                int annualIncome = int.Parse(Console.ReadLine());
                string result= annualIncome >= 280000 ? "You are liable to pay I.T." : "You are not liable to pay I.T.";
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
