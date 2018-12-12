using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car>car  = new List<Car>();
            Car c = new Car();
            c.Name = "卡车";
            c.Money = 200000;

            car.Add(c);
        }
    }
}
