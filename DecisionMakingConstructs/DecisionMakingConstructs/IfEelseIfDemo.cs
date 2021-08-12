using System;

namespace DecisionMakingConstructs
{
    //  This program Shows how to work with multiple conditions using if-else if-else
    class EfElseIfDemo
    {
        static void Main()
        {
            // Using if-else if-else we can check multiple conditions
            try
            {
                Console.Write("Please Enter Item Name:");
                string itemName = Console.ReadLine();
                Console.Write("Enter Product Amount in INR:");
                double productAmt = Convert.ToDouble(Console.ReadLine());
                double gstAmt = 0;
                if (itemName == "Food")
                {
                    gstAmt = productAmt / 100 * 1;
                    Console.WriteLine("GST Amount is:{0}",gstAmt);
                }
                else if (itemName == "Services")
                {
                    gstAmt = productAmt / 100 * 8;
                    Console.WriteLine("GST Amount is:{0}", gstAmt);
                }
                else if (itemName == "Ornments")
                {
                    gstAmt = productAmt / 100 * 5;
                    Console.WriteLine("GST Amount is:{0}", gstAmt);
                }
                else
                {
                    Console.WriteLine("Invalid Item Name");

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
