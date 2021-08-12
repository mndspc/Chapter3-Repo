using System;

namespace DecisionMakingConstructs
{
    //  This program shows how to use switch case
    class SwitchDemo
    {
        static void Main()
        {
            //  Switch-case is better than ladder if performance
            try
            {
                Console.Write("Please Enter Item Name:");
                string itemName = Console.ReadLine();
                Console.Write("Enter Product Amount in INR:");
                double productAmt = Convert.ToDouble(Console.ReadLine());
                double gstAmt = 0;

                switch (itemName)
                {
                    case "Food":
                        gstAmt = productAmt / 100 * 1;
                        Console.WriteLine("GST Amount is:{0}", gstAmt);
                        break;
                    case "Services":
                        gstAmt = productAmt / 100 * 8;
                        Console.WriteLine("GST Amount is:{0}", gstAmt);
                        break;
                    case "Ornments":
                        gstAmt = productAmt / 100 * 5;
                        Console.WriteLine("GST Amount is:{0}", gstAmt);
                        break;
                    default:
                        Console.WriteLine("Invalid Item Name");
                        break;
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
