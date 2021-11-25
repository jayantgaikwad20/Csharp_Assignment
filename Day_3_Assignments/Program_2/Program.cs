using System;

namespace ThirdDay_Assignment3_Program2_SealedClass
{

    /*  
     *  Rushikesh Patil 
     *  
     *  Program 2 -->
     *  
     *  Create parent class and child class use sealed keyword for class 
          and dummy method and verify behavior*/

     class Base_Class
    {
        public virtual void method_1()
        {
            Console.WriteLine("Base Class Sealed Method");
        }

    }


/*    class Child_Base : Base_Class  
        // if Base_Class is sealed then can not inherit it in child
        //  error --- >  'Child_Base': cannot derive from sealed type 'Base_Class'
    {

    }*/

    class Child_class_1 : Base_Class
    {
       public sealed override void method_1()
        {
            base.method_1();
            Console.WriteLine("Base Method override in Child Class 1");
        }
    }



/*    class Child_class_2 : Child_class_1
    {
        public override void method_1()

            //  can't override inherited method  because it is sealed 
        {
            base.method_1();
            Console.WriteLine("Base Method override in Child Class 1");
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            new Child_class_1().method_1();
            Console.ReadKey();
        }
    }
}
