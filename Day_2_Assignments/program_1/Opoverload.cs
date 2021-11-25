using System;

namespace SecondDay_Assignment1_OperatorOverloading
{
    class Opoverload
    {
        int no;
        public Opoverload(int no)
        {
            this.no =no;
        }
        public static Opoverload operator +(Opoverload obj_1_no, Opoverload obj_2_no)
        {
            Opoverload add = new Opoverload(0);
            add.no = obj_1_no.no + obj_2_no.no;
            return add;
        }

        public static Opoverload operator -(Opoverload obj_1_no, Opoverload obj_2_no)
        {
            Opoverload sub = new Opoverload(0);
            sub.no = obj_1_no.no - obj_2_no.no;
            return sub;
        }

        public static Opoverload operator *(Opoverload obj_1_no, Opoverload obj_2_no)
        {
            Opoverload mult = new Opoverload(0);
            mult.no = obj_1_no.no * obj_2_no.no;
            return mult;
        }

        public static Opoverload operator /(Opoverload obj_1_no, Opoverload obj_2_no)
        {
            Opoverload div = new Opoverload(0);
            div.no = obj_1_no.no / obj_2_no.no;
            return div;
        }

        public static bool operator ==(Opoverload obj_1_no, Opoverload obj_2_no)
        {
            if (obj_1_no.no == obj_2_no.no)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Opoverload obj_1_no, Opoverload obj_2_no)
        {
            if (obj_1_no.no != obj_2_no.no)
            {
                return true;
            }
            else
            { 
                return false;
            }

        }

        public static bool operator >(Opoverload obj_1_no, Opoverload obj_2_no)
        {
            if (obj_1_no.no > obj_2_no.no)
            {
         return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Opoverload obj_1_no, Opoverload obj_2_no)
        {
            if (obj_1_no.no < obj_2_no.no)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void displayNumber()
        {
            Console.WriteLine(no);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Opoverload op1 = new Opoverload(4);
            Opoverload op2 = new Opoverload(2);

            Opoverload add = op1 + op2;
            add.displayNumber();

            Opoverload sub = op1 - op2;
            sub.displayNumber();

            Opoverload mult = op1 * op2;
            mult.displayNumber();

            Opoverload div = op1 / op2;
            div.displayNumber();

            if (op1 > op2)
            {
                Console.WriteLine("op1 is greater");
            }
            else
            {
                Console.WriteLine("op2 is greater");
            }


            if (op1 == op2)
            {
                Console.WriteLine("both are equal");
            }
            else
            {
                Console.WriteLine("both are not equal");
            }






            Console.ReadKey();
        }
    }

}
