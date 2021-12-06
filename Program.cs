using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Key_Reader_Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" KeyBoard Reader PrO ");

            ConsoleKeyInfo keyInfo;


            do
            {
                keyInfo = Console.ReadKey(true);
                string writeText = Char.ToString(keyInfo.KeyChar);
                Console.WriteLine("You Entered : " + writeText);

                

                string fullpath = @"C:\Temp\MyTest.txt"; 

                using (StreamWriter writer = new StreamWriter(fullpath))
                {
                    writer.WriteLine(Char.ToString(keyInfo.KeyChar));
                }


            } while (keyInfo.Key != ConsoleKey.Escape);

            
            
        }
    }
}
