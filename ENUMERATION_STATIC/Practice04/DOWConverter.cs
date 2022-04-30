using System;
using System.Collections.Generic;
using System.Text;

namespace Practice04
{
    public enum DataWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
    internal class DOWConverter
    {
        private int Month;
        private int Year;
        private int DayOfWeek;
        public string ConvertDaytoWeek(int day, int month, int year)
        {
            string result = "";
            if (month < 3)
            {
                Month = month + 12;
                Year = year - 1;
                DayOfWeek = (day + 2 * Month + 3 * (Month + 1) / 5 + Year + Year / 4) % 7;
            }
            else
            {
                DayOfWeek = (day + 2 * month + 3 * (month + 1) / 5 + year + year / 4) % 7;
            }
            switch(DayOfWeek)
            {
                case 0:
                    result += DataWeek.Sunday.ToString();
                    break;
                case 1:
                    result += DataWeek.Monday.ToString();
                    break;
                case 2:
                    result += DataWeek.Tuesday.ToString();
                    break;
                case 3:
                    result += DataWeek.Wednesday.ToString();
                    break;
                case 4:
                    result += DataWeek.Thursday.ToString();
                    break;
                case 5:
                    result += DataWeek.Friday.ToString();
                    break;
                case 6:
                    result += DataWeek.Saturday.ToString();
                    break;
            }
            return result;
        }
    }
}
