using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    internal class InforTranfer
    {
        internal string IdTransfer;
        internal string NameDriver;
        internal string NumbCar;
        internal InforTranfer()
        {
            IdTransfer = string.Empty;
            NameDriver = string.Empty;
            NumbCar = string.Empty;
        }

        internal InforTranfer(string idTransfer, string nameDriver, string numbCar)
        {
            IdTransfer = idTransfer;
            NameDriver = nameDriver;
            NumbCar = numbCar;
        }

        internal virtual void InputInfo()
        {
            Console.WriteLine("Input Id Transfer: ");
            IdTransfer = Console.ReadLine();
            Console.WriteLine("Input Name Driver: ");
            NameDriver = Console.ReadLine();
            Console.WriteLine("Input Number Car: ");
            NumbCar = Console.ReadLine();
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Id Tranfer: {0}\nName Driver: {1}\nNumber Car: {3}", IdTransfer, NameDriver, NumbCar);
        }

        public override string ToString()
        {
            return String.Format("Id Tranfer: {0}\nName Driver: {1}\nNumber Car: {3}", IdTransfer, NameDriver, NumbCar);
        }
    }
}
