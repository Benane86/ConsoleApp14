using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;


namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time Einstellen, bitte gib eine Zeit in Sekunden an!");
            int time1 = Convert.ToInt32(Console.ReadLine());
            int sekunden = time1 * 1000;
            Thread.Sleep(sekunden);
            Console.WriteLine("es sind {0} sekunden vergangen", time1);
            SystemSounds.Beep.Play();
            Console.ReadKey();
        }
    }
}
