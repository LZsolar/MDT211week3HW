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

        public static double coinChange(double coinLeft,double value)
        {
            double temp = coinLeft - (coinLeft % value);
            coinLeft = coinLeft - temp;

            Console.WriteLine("{0}: {1}",value,temp/value);
            return coinLeft;
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


            Console.Write("Please input Money: ");
            double money = double.Parse(Console.ReadLine());
            money = coinChange(money, 1000.0);
            money = coinChange(money, 500.0);
            money = coinChange(money, 100.0);
            money = coinChange(money, 50.0);
            money = coinChange(money, 20.0);
            money = coinChange(money, 10.0);
            money = coinChange(money, 2.0);
            money = coinChange(money, 1.0);
            money = coinChange(money, 0.50);
            money = coinChange(money, 0.25);
        }
    }

    public class ShopInfo
    {
        public string shopName;
        public int shopNumber;
        public string shopOwner;
        public int shopValue;
    }
}