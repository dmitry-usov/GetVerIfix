using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace getVer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("insert path:");
            path = Console.ReadLine();

            var fst = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            UTF8Encoding temp = new UTF8Encoding(true);
            byte[] etalon = {221, 221, 221, 221, 221, 221, 221, 221 }; //DDDD... в числовом виде

            int counter = 0;
            using (FileStream fs = File.OpenRead(path))
            { 
                byte[] b = new byte[8];
                
                
                while (fs.Read(b, 0, b.Length) > 0)
                {

                    if (Enumerable.SequenceEqual(b, etalon)) //
                    {
                        Console.WriteLine("Нашел бля!");
                        
                        byte[] m = new byte[8]; //пропускам 8 байт
                        byte[] n = new byte[8]; //нужные 8 байт
                        fs.Read(m, 0, m.Length);
                        fs.Read(n, 0, n.Length);
                        Console.WriteLine(n[0]   + (n[1] << 8)); //делаем 16 битный инт

                    }
                    counter = counter + 8;
                }

            }
            Console.ReadKey();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }


    }
}
