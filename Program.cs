using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura_y_precion
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("inserta la temperatura");
            int Tm = int.Parse(Console.ReadLine());
            System.Console.WriteLine("inserta la precion");
            int Pr=int.Parse(Console.ReadLine());
            if(Pr>200 && Tm>100)
            {
                System.Console.WriteLine("alarma");
            }
            else
            {
                System.Console.WriteLine("normal");
            }
            Console.ReadKey();
        }
    }
}
