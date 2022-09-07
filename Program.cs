using System;

namespace MDTwork1023
{
    class Program
    {
        public static void shopPrint(ShopInfo shop)
        {
            Console.WriteLine("—--------- Shop Information —-----");
            Console.WriteLine("Name: {0}",shop.shopName);
            Console.WriteLine("Number: {0}",shop.shopNumber);
            Console.WriteLine("Owner Name: {0}",shop.shopOwner);
            Console.WriteLine("Registed Value: {0}",shop.shopValue);
            Console.WriteLine("----------------------------------");
        }

        static void Main(string[] args)
        {
            ShopInfo shop = new ShopInfo();
            Console.Write("Please input Name: ");
            shop.shopName = Console.ReadLine();
            Console.Write("Please input Number: ");
            shop.shopNumber = int.Parse(Console.ReadLine());
            Console.Write("Please input Owner Name: ");
            shop.shopOwner = Console.ReadLine();
            Console.Write("Please input Name: ");
            shop.shopValue = int.Parse(Console.ReadLine());
            shopPrint(shop);


            coinChange m = new coinChange();
            Console.Write("Please input Money: ");
            m.money = double.Parse(Console.ReadLine());

            Console.WriteLine("1000: {0}",m.cChange(1000.0));
            Console.WriteLine("500: {0}", m.cChange(500.0));
            Console.WriteLine("100: {0}", m.cChange(100.0));
            Console.WriteLine("50: {0}", m.cChange(50.0));
            Console.WriteLine("20: {0}", m.cChange(20.0));
            Console.WriteLine("10: {0}", m.cChange(10.0));
            Console.WriteLine("2: {0}", m.cChange(2.0));
            Console.WriteLine("1: {0}", m.cChange(1.0));
            Console.WriteLine(".50: {0}", m.cChange(0.5));
            Console.WriteLine(".25: {0}", m.cChange(0.25));
        }
    }
    public class ShopInfo
    {
        public string shopName;
        public int shopNumber;
        public string shopOwner;
        public int shopValue;
    }

    public class coinChange
    {
        public double money;

        public double cChange(double value)
        {
            double temp = this.money - (this.money % value);
            this.money = this.money - temp;

            return temp/value;
        }

    }
}