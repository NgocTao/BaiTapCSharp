using System;
using System.Collections.Generic;
using System.Text;

namespace Practice02
{
    public enum CurrencyType
    {
        USD,
        BAHT,
        EUR,
        HKD,
        YEN,
        WON
    }
    public class Currency
    {
        public double ConvertToVND(double numbcurrency, CurrencyType currencyType)
        {
            double Result = 0;
            switch (currencyType)
            {
                case CurrencyType.USD:
                    Result = numbcurrency * 23145;
                    break;
                case CurrencyType.BAHT:
                    Result = numbcurrency * 651.42;
                    break;
                case CurrencyType.EUR:
                    Result = numbcurrency * 23574;
                    break;
                case CurrencyType.HKD:
                    Result = numbcurrency * 2936;
                    break;
                case CurrencyType.YEN:
                    Result = numbcurrency * 208.93;
                    break;
                case CurrencyType.WON:
                    Result = numbcurrency * 16.93;
                    break;
            }
            return Result;
        }
        public double ConvertFromVND(double vnd, CurrencyType currencyType)
        {
            double Result = 0;
            switch (currencyType)
            {
                case CurrencyType.USD:
                    Result = vnd / 23145;
                    break;
                case CurrencyType.BAHT:
                    Result = vnd / 651.42;
                    break;
                case CurrencyType.EUR:
                    Result = vnd / 23574;
                    break;
                case CurrencyType.HKD:
                    Result = vnd / 2936;
                    break;
                case CurrencyType.YEN:
                    Result = vnd / 208.93;
                    break;
                case CurrencyType.WON:
                    Result = vnd / 16.93;
                    break;
            }
            return Result;
        }
        public double FindForeignExchange(CurrencyType currency)
        {
            double Result = 0;
            switch (currency)
            {
                case CurrencyType.USD:
                    Result = 23145;
                    break;
                case CurrencyType.BAHT:
                    Result = 651.42;
                    break;
                case CurrencyType.EUR:
                    Result = 3574;
                    break;
                case CurrencyType.HKD:
                    Result = 2936;
                    break;
                case CurrencyType.YEN:
                    Result = 208.93;
                    break;
                case CurrencyType.WON:
                    Result = 16.93;
                    break;
            }
            return Result;
        }
        public string showForeignExchangeList()
        {
            string Result = "";
            Result += CurrencyType.USD.ToString() + "\n" + CurrencyType.BAHT.ToString() + "\n" + CurrencyType.HKD.ToString() + "\n" + CurrencyType.EUR.ToString() + "\n" + CurrencyType.YEN.ToString() + "\n" + CurrencyType.WON.ToString() + "\n";
            return Result;
        }
        public bool CheckInput(string value)
        {
            return string.IsNullOrEmpty(value);
        }
        public bool ConvertInput(string value)
        {
            bool Result = int.TryParse(value, out int a);
            return Result;
        }
    }
}
