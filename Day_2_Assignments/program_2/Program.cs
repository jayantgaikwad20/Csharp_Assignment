using System;

namespace SecondDay_Assignment2_Enum
{

    enum Days
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    };

    class Program
    {
        /*       Create enumeration with name Days containing Day name as constants.
                   Write a method which is accepting enumeration as parameter and verify working of enumeration.*/

        public static void Week(Days d)
        {
            Console.WriteLine("days is "+d);
        }
       
        
        static void Main(string[] args)
        {
            Week(Days.Monday);


            Console.ReadKey();
        }
    }
}
