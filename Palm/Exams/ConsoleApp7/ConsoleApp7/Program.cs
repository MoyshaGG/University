
using System;
using boocksinfo;
using System.IO;
using System.Diagnostics.Tracing;

namespace ConsoleApp1
{
    class Program
    {
        static AirLines[] ReadData(string fileName)
        {


            string path = "C:\\Users\\Moysha\\Desktop\\";
            string newPath = path.Insert(path.Length, fileName);
            int count = System.IO.File.ReadAllLines(newPath).Length;
            AirLines[] arlines = new AirLines[count];
            var stream = File.Open(newPath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream, System.Text.Encoding.Default);
            for (int i = 0; i < count; i++)
            {
                var line = sr.ReadLine();
                AirLines newAir = new AirLines(line);
                arlines[i] = newAir;
            }
            return arlines;

        }
        static void Perebor(AirLines[]airlines, string x)
        {
            for (int i = 0; i < airlines.Length; i++)
            {
                if(airlines[i].city == x)
                {
                    Console.WriteLine(airlines[i].time1);

                }
            }
        }

        static void Main(string[] args)
        {
            AirLines[] airlines = ReadData("input.txt");
            string x = Convert.ToString(Console.ReadLine());
            Perebor(airlines, x);

           

            Console.ReadKey();
        }
    }
}
