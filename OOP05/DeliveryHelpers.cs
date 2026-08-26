using System;
using System.Collections.Generic;
using System.Text;

#region DeliveryHelpers

namespace OOP005
{
    public static class DeliveryHelper
    {
        public static void PrintShipmentDetails(
            Shipment shipment)
        {
            shipment.PrintShipment();
        }
    }
}
#endregion
