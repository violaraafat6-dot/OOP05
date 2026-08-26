using OOP005;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Theoretical



            //   Q1
            //(A) both variables refer to the same object in memory

            //(B) No, it does not create a new object.It only copies the reference to the same object

            //(C) Copying a reference means two variables refer to the same object Copying an object creates a separate object with its own data



            //                Q2
            //(A) A shallow copy creates a new object and copies all value - type fields
            //For reference - type fields,only the references(links)are copied-both objects point to the same nested object

            //(B) A deep copy creates a new object and recursively copies all nested objects
            //The original and the copy are completely independent

            //                (C) They are shared between the original object and the copied object

            //(D) New independent copies of the reference - type members are created

            //(E) Deep Copy is safer when we want to modify the copied object’s data without affecting the original object



            //                Q3

            //(A) A static field belongs to the class and is shared by all objects.An instance field belongs to each individual object

            //(B) static method belongs to the class and can be called without creating an object.No, it cannot directly access instance members

            //(C) static constructor is used to initialize static members.It is executed automatically once before the class is used for the first time

            //(D) A static class contains only static members No, we cannot create an object from a static class



            //            Q4
            //(A) An Extension Method allows us to add a new method to an existing class without modifying the original class

            //(B) The this keyword

            //(C) it must be declared inside a static class

            //(D) No, an extension method cannot directly access private members



            //            Q5
            //(A) A Partial Class is a class that can be split into multiple files using the partial keyword

            //(B) To organize large classes and separate different parts of their functionality

            //(C) A Partial Method is a method declared in one part of a partial class and can be implemented in another part

            // (D) It is ignored by the compiler and does not cause an error







            #endregion


            #region practical

         
                
    //            DeliveryUtilities.PrintSystemTitle();

                
    //            Console.WriteLine(
    //                $"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

    //            DeliveryUtilities.PrintSeparator();

    //            Console.WriteLine("Creating Shipments...");

    //            DeliveryUtilities.PrintSeparator();

                
    //            DeliveryCenter center = new DeliveryCenter();
    //            center.CenterName = "Delivery Center";

               
    //            DeliveryAddress standardAddress =
    //                new DeliveryAddress("Cairo", "Main Street", 10);

    //            DeliveryAddress expressAddress =
    //                new DeliveryAddress("Cairo", "Second Street", 20);

    //            DeliveryAddress internationalAddress =
    //                new DeliveryAddress("Cairo", "Third Street", 30);

                
    //            StandardShipment standardShipment =
    //                new StandardShipment(
    //                    "SH001",
    //                    "Laptop",
    //                    3,
    //                    80,
    //                    standardAddress);

    //            Console.WriteLine("Standard Shipment Created");

    //            ExpressShipment expressShipment =
    //                new ExpressShipment(
    //                    "SH002",
    //                    "Mobile Phone",
    //                    2,
    //                    60,
    //                    expressAddress,
    //                    30);

    //            Console.WriteLine("Express Shipment Created");

    //            InternationalShipment internationalShipment =
    //                new InternationalShipment(
    //                    "SH003",
    //                    "Television",
    //                    8,
    //                    120,
    //                    internationalAddress,
    //                    "Germany",
    //                    100);

    //            Console.WriteLine("International Shipment Created");

               
    //            center.AddShipment(standardShipment);
    //            center.AddShipment(expressShipment);
    //            center.AddShipment(internationalShipment);

    //            Console.WriteLine(
    //                $"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

               

    //            DeliveryUtilities.PrintSeparator();

    //            Console.WriteLine("Object Copying");

    //            DeliveryUtilities.PrintSeparator();

               
    //            Shipment shipment1 = standardShipment;
    //            Shipment shipment2 = shipment1;

    //            Console.WriteLine(
    //                $"Original Shipment : {shipment1.TrackingCode}");

    //            Console.WriteLine(
    //                $"Assigned Shipment : {shipment2.TrackingCode}");

    //            Console.WriteLine(
    //                $"Same Object : {ReferenceEquals(shipment1, shipment2)}");

               

    //            Console.WriteLine("------------------------------------------");
    //            Console.WriteLine("Shallow Copy");
    //            Console.WriteLine("------------------------------------------");

    //            standardShipment.Destination.City = "Cairo";

    //            Shipment shallowCopy = standardShipment.ShallowCopy();

    //            Console.WriteLine(
    //                $"Original Shipment Address : {standardShipment.Destination.City}");

    //            Console.WriteLine(
    //                $"Copied Shipment Address : {shallowCopy.Destination.City}");

    //            Console.WriteLine("Changing copied shipment address...");

    //            shallowCopy.Destination.City = "Giza";

    //            Console.WriteLine(
    //                $"Original Shipment Address : {standardShipment.Destination.City}");

    //            Console.WriteLine(
    //                $"Copied Shipment Address : {shallowCopy.Destination.City}");

    //            Console.WriteLine(
    //                $"Same DeliveryAddress Object : " +
    //                $"{ReferenceEquals(
    //                    standardShipment.Destination,
    //                    shallowCopy.Destination)}");

               

    //            Console.WriteLine("------------------------------------------");
    //            Console.WriteLine("Deep Copy");
    //            Console.WriteLine("------------------------------------------");

    //            // Return original address to Cairo before Deep Copy
    //            standardShipment.Destination.City = "Cairo";

    //            Shipment deepCopy = standardShipment.DeepCopy();

    //            Console.WriteLine(
    //                $"Original Shipment Address : {standardShipment.Destination.City}");

    //            Console.WriteLine(
    //                $"Copied Shipment Address : {deepCopy.Destination.City}");

    //            Console.WriteLine("Changing copied shipment address...");

    //            deepCopy.Destination.City = "Giza";

    //            Console.WriteLine(
    //                $"Original Shipment Address : {standardShipment.Destination.City}");

    //            Console.WriteLine(
    //                $"Copied Shipment Address : {deepCopy.Destination.City}");

    //            Console.WriteLine(
    //                $"Same DeliveryAddress Object : " +
    //                $"{ReferenceEquals(
    //                    standardShipment.Destination,
    //                    deepCopy.Destination)}");

                

    //            DeliveryUtilities.PrintSeparator();

    //            Console.WriteLine("Extension Methods");

    //            DeliveryUtilities.PrintSeparator();

    //            Console.WriteLine(standardShipment.GetSummary());
    //            Console.WriteLine(expressShipment.GetSummary());
    //            Console.WriteLine(internationalShipment.GetSummary());

    //            Console.WriteLine(
    //                $"{standardShipment.TrackingCode} Is Delivered : " +
    //                $"{standardShipment.IsDelivered()}");

    //            Console.WriteLine(
    //                $"{internationalShipment.TrackingCode} Is Delivered : " +
    //                $"{internationalShipment.IsDelivered()}");

               
    //            DeliveryUtilities.PrintSeparator();

    //            Console.WriteLine("Tracking Status");

    //            DeliveryUtilities.PrintSeparator();

    //            standardShipment.UpdateTrackingStatus("Out For Delivery");

               

    //            DeliveryUtilities.PrintSeparator();

    //            Console.WriteLine("Static Utilities");

    //            DeliveryUtilities.PrintSeparator();

    //            Console.WriteLine("------------------------------------------");
    //            Console.WriteLine(center.CenterName);
    //            Console.WriteLine("------------------------------------------");

    //            Console.WriteLine(
    //                $"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

                

    //            DeliveryUtilities.PrintSeparator();

    //            Console.WriteLine("Partial Method");

    //            DeliveryUtilities.PrintSeparator();

    //            internationalShipment.UpdateTrackingStatus("Delivered");

    //            // ==================================================
    //            // Assignment 04 functionality still works

    //            Console.WriteLine();
    //            Console.WriteLine("Assignment 04 Functionality");
    //            DeliveryUtilities.PrintSeparator();

    //            center.PrintAllShipments();

    //            Console.WriteLine("Tracking Statuses:");
    //            center.PrintTrackingStatuses();

    //            Console.WriteLine();

    //            Console.WriteLine("Insurance:");

    //            DeliveryReport.PrintInsurance(standardShipment);
    //            DeliveryReport.PrintInsurance(expressShipment);
    //            DeliveryReport.PrintInsurance(internationalShipment);

    //            // ==================================================

    //            DeliveryUtilities.PrintSeparator();

    //            Console.WriteLine("Assignment Completed");

    //            DeliveryUtilities.PrintSeparator();
    //        }
    //    }
    //}


            #endregion

