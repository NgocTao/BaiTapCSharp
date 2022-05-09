using System;
using System.Collections.Generic;
using System.Text;

namespace Practice4
{
    public enum DataWeek
    {
        Sunday = 0,
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
    internal class DOWConverter
    {
        public int Day;
        public int Month;
        public int Year;
        public DataWeek DayOfWeek;
        public string ConvertDaytoWeek(int day, int month, int year)
        {
            string result = "";
            if (month < 3)
            {
                Month = month + 12;
                Year = year - 1;
                DayOfWeek = (DataWeek) ((day + 2 * Month + 3 * (Month + 1) / 5 + Year + Year / 4) % 7);
            }
            else
            {
                DayOfWeek = (DataWeek) ((day + 2 * month + 3 * (month + 1) / 5 + year + year / 4) % 7);
            }

            result += DayOfWeek.ToString();
            return result;
        }
    }
}
