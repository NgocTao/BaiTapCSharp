using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    internal class TranferOutCity : InforTranfer
    {
        internal string Destination;
        internal int NumbMove;
        internal float Price;
        internal float Revenue;

        internal TranferOutCity()
        {
            Destination = string.Empty;
            NumbMove = 0;
            Price = 0;
            Revenue = 0;
        }

        internal TranferOutCity(string idTranfer, string nameDriver, string numbCar, string destination, int numbMove, float price, float reveneu) : base(idTranfer, nameDriver, numbCar)
        {
            Destination = destination;
            NumbMove = numbMove;
            Price = price;
            Revenue = reveneu;
        }

        internal override void InputInfo()
        {
            base.InputInfo();
            Console.WriteLine("Input Destination: ");
            Destination = Console.ReadLine();
            Console.WriteLine("Inpur Number Km Move: ");
            NumbMove = int.Parse(Console.ReadLine());
            Console.WriteLine("Inpur Price: ");
            Price = int.Parse(Console.ReadLine());
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Destination: {0}\nNumber Km move: {1}\nPrice: {2}", Destination, NumbMove, Price);
        }

        internal float GetMoney()
        {
            return Revenue = Price*NumbMove;
        }

        public override string ToString()
        {
            return String.Format("Destination: {0}\nNumber Km move: {1}\nRevenue: {2}", Destination, NumbMove, GetMoney()) +  base.ToString();
        }
    }
}
