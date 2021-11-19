using System;

namespace Daya_In_Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter eny no from 1 to 12");
            int MonthNo = Convert.ToInt32(Console.ReadLine());
            switch (MonthNo)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 11:
                    Console.WriteLine("day in month is 31 ");
                    break;
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("day in month is 30");
                    break;
                case 2:
                    Console.WriteLine("day in month is 30");
                    break;

                    
                    Console.ReadKey();


            }

        }
    }
}
