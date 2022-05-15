using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    internal class TranferInCity : InforTranfer
    {
        internal int LineCar;
        internal float NumbKm;
        internal float Price;
        internal float Revenue;

        internal TranferInCity()
        {
            LineCar = 0;
            NumbKm = 0;
            Revenue = 0;
            Price = 0;
        }

        internal TranferInCity(string idTranfer, string nameDriver, string numbCar, int linecar, float numbKm, float price, float reveneu) : base(idTranfer, nameDriver, numbCar)
        {
            LineCar = linecar;
            NumbKm = numbKm;
            Price = price;
            Revenue = reveneu;
        }

        internal override void InputInfo()
        {
            base.InputInfo();
            Console.WriteLine("Input Line Car: ");
            LineCar = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Price: ");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Number Km: ");
            NumbKm = float.Parse(Console.ReadLine());
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Line Car: {0}\nNumber Km: {1}\nPrice: {2}", LineCar, NumbKm, Price);
        }

        internal float GetMoney()
        {
            return Revenue = Price * NumbKm * LineCar;
        }

        public override string ToString()
        {
            return String.Format("Line Car: {0}\nNumber Km: {1}\nRevenue: {2}", LineCar, NumbKm, GetMoney()) + base.ToString();
        }
    }
}
