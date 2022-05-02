using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice05
{
    public enum TypeTicket
    {
        Regular,
        VIP
    }
    public enum Status
    {
        Available,
        Sold
    }
    internal class Ticket
    {
        private string RowChair = "";
        private int NumbChair;
        private int QuantityTiket = 0;
        private Status status;
        public float Revenue = 0;
        public int SumSold = 0;
        public Ticket(string rowChair, int numbChair)
        {
            RowChair = rowChair;
            NumbChair = numbChair;
            QuantityTiket++;
            status = Status.Available;
        }
        public string SetType()
        {
            string type = "";
            if (RowChair.Equals("C") || RowChair.Equals("D") || RowChair.Equals("E") || RowChair.Equals("F") || RowChair.Equals("G") || RowChair.Equals("H"))
            {
                switch (NumbChair)
                {
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        type += TypeTicket.VIP.ToString();
                        break;
                    default:
                        type += TypeTicket.Regular.ToString();
                        break;
                }
            }
            else
            {
                type += TypeTicket.Regular.ToString();
            }
            return type;
        }
        public int GetPrice()
        {
            int price = 0;
            if (SetType().Equals("VIP"))
                price = 150000;
            else
                price = 100000;
            return price;
        }
        public void ShowInfo()
        {
            Console.Write("{0} \t {1}, \t{2}, \t{3} ", RowChair, NumbChair, SetType(), GetPrice());
        }
        public void BuyTicket()
        {
            if (status==Status.Available)
            {
                status = Status.Sold;
                SumSold++;
                Revenue += GetPrice();
            }
            else if (status == Status.Sold)
            {
                Console.WriteLine("Khong the mua ve");
            }
        }
        public void CancleTicket()
        {
            if (status == Status.Sold)
            {
                status = Status.Available;
                SumSold--;
                Revenue = Revenue- GetPrice()*0.8f;
            }
            if (status == Status.Available)
            {
                Console.WriteLine("Khong the huy ve");
            }
        }
    }
}
