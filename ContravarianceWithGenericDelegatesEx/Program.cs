using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContravarianceWithGenericDelegatesEx
{
    //反変性
    //  もとの指定型よりも派生が浅く、範囲の広い型も使用できる。
    // 
    //数学的な観点からの共変性(※整数の領域についてだけ考えた場合)
    //  すべての整数x に対して、f(x) = -x と定義します。
    // この時、10は20以下ですが、f(10)はf(20) 以上です。
    // f(10)=-10、f(20)=-20 → -10 > -20 なので、大小関係が逆転する。

    // ジェネリックなデリゲート
    delegate void aDelegeteMethod<in T>(T t);

    class Vehicle
    {
        public virtual void ShowMe()
        {
            Console.WriteLine("Vehicle.ShowMe()");
        }
    }

    class Bus : Vehicle
    {
        public override void ShowMe()
        {
            Console.WriteLine("Bus.ShowMe()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ジェネリックデリゲートで反変性を実現する例 ***");
            Vehicle obVehicle = new Vehicle();
            Bus obBus = new Bus();
            aDelegeteMethod<Vehicle> delVehicle = ShowVehicleType;
            delVehicle(obVehicle);
            // デリゲートで反変性
            // 基本型を派生型に代入する
            aDelegeteMethod<Bus> delBus = ShowVehicleType;
            delBus(obBus);
            Console.ReadKey();
        }
        private static void ShowVehicleType(Vehicle p)
        {
            p.ShowMe();
        }
    }
}
