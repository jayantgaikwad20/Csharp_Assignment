using System;

namespace SecondDay_Assignment2_ParaArray
{


   /* Write Average function to verify working param array.Pass different no of parameters and verify*/
    class Program
    {



        public static int Average(params int[] no)
        {
            int sum = 0,avg=0;
            for (int i = 0; i < no.Length; i++)
            {
                sum =sum+ no[i];
            }

            avg = sum / no.Length;
            return avg;
        }

      
        static void Main(string[] args)
        {
            Console.WriteLine(Average(1,2,3));
            Console.ReadKey();
        }
    }
}
