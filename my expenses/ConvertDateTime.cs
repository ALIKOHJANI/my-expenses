using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.PersianDateTime.Core;
using System.Globalization;

namespace myExpenses
{
    public static class ConvertDateTime
    {
        public static (DateTime, DateTime) GetGregorianDates(string iranianMonth)
        {
            PersianCalendar iranianCalendar = new PersianCalendar();
            var monthNum = GetMonthNum(iranianMonth);
            DateTime startOfMonth = new DateTime(1403, monthNum, 1, iranianCalendar);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            return (startOfMonth, endOfMonth);
        }

        private static int GetMonthNum(string iranianMonth)
        {
            switch (iranianMonth)
            {
                case "فروردین":
                    return 1;
                case  "اردیبهشت":
                    return 2;
                case "خرداد":
                    return 3;
                case "تیر":
                    return 4;
                case "مرداد":
                    return 5;
                case "شهریور":
                    return 6;
                case "مهر":
                    return 7;
                case "آبان":
                    return 8;
                case "آذر":
                    return 9;
                case "دی":
                    return 10;
                case "بهمن":
                    return 11;
                case "اسفند":
                    return 12;
                default:
                    return 0;
            }
        }
    }
}