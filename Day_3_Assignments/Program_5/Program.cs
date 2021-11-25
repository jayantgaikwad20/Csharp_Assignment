using System;

namespace ThirdDay_Assignment3_Program5_Throw
{


/*
 Rushikesh Patil

    Program 5 -->

    Throw Example  
    using program 4 
 
 
 */



    class Program
    {
        static int Divide_Fun(int no_1, int no_2)
        {

            int ans;
            ans = no_1 / no_2;
            return ans;

        }


        static void Call_Method_1(int a, int b)
        {
            try
            {
                Divide_Fun(a, b);
            }
            catch (DivideByZeroException Div)
            {
                throw Div;
            }



        }


        static void Call_Method_2(int a, int b)
        {
            try
            {
                Call_Method_1(a,b);
            }
            catch (DivideByZeroException Div)
            {
                throw Div;
            }



        }



        static void Main(string[] args) 
        {
            Console.WriteLine("Enter 2  numbers -");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Call_Method_2(a, b);
            }
            catch (System.FormatException s)
            {
                Console.WriteLine("Catch block 1 sytsem Formate Exception");
                Console.WriteLine(s.Message);
            }
            catch (DivideByZeroException Div)
            {
                Console.WriteLine("Catch block 2 DivideByZeroException Exception");
                Console.WriteLine(Div.Message);
                // throw Div;
                
            }

                Console.ReadKey();
        }
    }
}
