using System;
using System.IO;

namespace FourthDay_Assignment4_Program00_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream F = new FileStream("D:\\C#_Programs\\File_Handling\\sample.dat", FileMode.OpenOrCreate
               ,FileAccess.ReadWrite);
                for (int i = 1; i <= 20; i++)
                {
                    F.WriteByte((byte)i);
                }
                F.Position= 0;
                for (int i = 0; i <= 20; i++)
                {
                    Console.Write(F.ReadByte() + " ");
                }
                F.Close();
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
