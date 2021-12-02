using System;
using System.IO;

namespace Program_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("D:\\C#_Programs\\File_Handling\\sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string fdata = reader.ReadToEnd();
            Console.WriteLine("Data int file is :");
            Console.WriteLine(fdata);
            //StreamWriter writer = new StreamWriter(fs);
            //writer.WriteLine("Hello c# File handling");
            //writer.Flush();
            fs.Close();
            Console.Read();
        }
    }
}
