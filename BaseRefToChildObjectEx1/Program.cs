using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseRefToChildObjectEx1
{
    class Vehicle
    {
        public void ShowMe()
        {
            Console.WriteLine("Vehicle.ShowMeの中にいます");
        }

    }
    class Bus : Vehicle
    {
        public void SHowMe()
        {
            Console.WriteLine("Bus.ShowMeの中にいます");
        }
        public void BusSpecificMethod()
        {
            Console.WriteLine("BusSpecificMethodの中にいます");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 基本クラスが子クラスのオブジェクトを参照するデモ ***\n\n");
            Vehicle obVehicle = new Bus();
            obVehicle.ShowMe(); // Vehicle.ShowMeの中にいる
            //obVehicle.BusSpecificMethod() //エラー
            ((Bus)obVehicle).BusSpecificMethod(); //ダウンキャストすればOK
            //Bus obBus = new Vehicle(); //エラー
            //Bus obBus = (Bus)new Vehicle(); //ダウンキャストすればビルドは通る(実行時エラー)
            //obBus.ShowMe();
            Console.ReadKey();
        }
    }
}
