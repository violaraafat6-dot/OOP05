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
        }
    }
}
