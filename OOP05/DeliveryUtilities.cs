using System;
using System.Collections.Generic;
using System.Text;

#region DeliveryUtilities

namespace OOP005
{
    public static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine(
                "==========================================");
        }

        public static void PrintSystemTitle()
        {
            PrintSeparator();
            Console.WriteLine(
                "Smart Delivery Management System");
            PrintSeparator();
        }
    }
}


#endregion