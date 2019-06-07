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
            Console.WriteLine("Minuten eingeben!");
            int time1 = Convert.ToInt32(Console.ReadLine());
            int minuten = time1 * 60000;
            Console.WriteLine("Sekunden eingaben!");
            int time2 = Convert.ToInt32(Console.ReadLine());
            int sekunden = time2 * 1000;
            int endtime = minuten + sekunden;
            Thread.Sleep(endtime);
            Console.WriteLine("es sind {0} Minuten und {1} Sekunden vergangen", time1, time2);
            SystemSounds.Beep.Play();
            Console.ReadKey();
        }
    }
}
