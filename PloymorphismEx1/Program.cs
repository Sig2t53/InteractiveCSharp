using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphismEx1
{
    // Javaではすべてのメソッドが既定でvirtualだが、C#では違う
    // C#では無意識に上書きが起こらないようにキーワードorverrideで修飾する必要がある
    // new キーワードでマークするとオーバーライドしないという意味になる
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
        public void BusSpecificmethod()
        {
            Console.WriteLine("Bus.BusSpecificmethodの中にいます");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ポリモーフィズムの例 その１ ***\n\n");
            Vehicle obVehicle = new Bus();
            obVehicle.ShowMe(); // Bus.ShowMeの中にいる
            // obVehicle.BusSpecificmethod(); //エラー
            // Bus obBus = new Vehicle(); //エラー
            Console.ReadKey();
        }
    }
}
