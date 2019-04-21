using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsmEx3
{
    class Vehicle
    {
        public virtual void ShowMe()
        {
            Console.WriteLine("Vehicle.ShowMeの中にいます");
        }
    }
    class Bus : Vehicle
    {
        public override void ShowMe()
        {
            Console.WriteLine("Bus.ShowMeの中にいます");
        }
    }
    class Taxi : Vehicle
    {
        public override void ShowMe()
        {
            Console.WriteLine("Taxi.ShowMeの中にいます");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ポリモーフィズムの例 その３ ***");
            Vehicle obVehicle;
            int count = 0;
            Random r = new Random();
            while(count < 5)
            {
                int tick = r.Next(0,10);
                if(tick %2 == 0)
                {
                    obVehicle = new Bus();
                }
                else
                {
                    obVehicle = new Taxi();
                }
                obVehicle.ShowMe();
                count++;
            }
            Console.ReadKey();
        }
    }
}
