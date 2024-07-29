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
            DateTime startOfMonth = new DateTime(1403, CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(iranianCalendar.GetMonth(new DateTime())), 1, iranianCalendar);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            return (startOfMonth, endOfMonth);
        }
    }
}
