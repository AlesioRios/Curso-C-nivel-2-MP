using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2006,5,18);
            DateTime fecha1 = DateTime.Now;
            Console.WriteLine(fecha.Date);
            Console.WriteLine($"Fecha: {fecha1.ToString("dddd, MMMM yyyy.")}");
            

            Console.ReadKey();
        }
    }
}
