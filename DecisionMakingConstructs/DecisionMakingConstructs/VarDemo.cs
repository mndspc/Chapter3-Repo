using System;

namespace GettingStartedWithCSharp
{
    //  This program demo. what is var type.
    class VarDemo
    {
        static void Main()
        {
            //  The var is implicite type of varaible.

            #region  Var Demo         
                var varInt = 50;
                var varString = "hello";
                var varChar = 'A';
                var varBool = true;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",varInt,varString,varChar,varBool);
            #endregion

            int[] nums = {10,20,30,40,50 };
            var varArray = nums;
            Console.ReadLine();
        }

        #region Public Functions
           public void Function1()
            {

            }

            public void Function2()
            {

            }
        #endregion
    }
}
