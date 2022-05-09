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
        private char RowChair = ' ';
        private int NumbChair;
        private Status status;
        private TypeTicket type;

        private int QuantityTiket = 0;
        public int SumSold = 0;
        public float Revenue = 0;

        public Ticket(char rowChair, int numbChair)
        {
            RowChair = rowChair;
            NumbChair = numbChair;
            QuantityTiket++;
            status = Status.Available;
        }
        public string SetType()
        {
            if (RowChair >= 'C' && RowChair <= 'H')
            {
                if (NumbChair >= 3 && NumbChair <= 9)
                {
                    type = TypeTicket.VIP;

                }
                else
                    type = TypeTicket.Regular;
            }
            else
                type = TypeTicket.Regular;

            return type.ToString();
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
            if (status == Status.Available)
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
                Revenue = Revenue - GetPrice() * 0.8f;
            }
            if (status == Status.Available)
            {
                Console.WriteLine("Khong the huy ve");
            }
        }
    }
}
