using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sbecker17302h2
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {

            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
            return result;

        }
        public static string DateCalc07(string strDate)
        {

            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }
            return result;

        }
        public static string DateCalc08(string strDate)
        {

            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();
            return result;

        }
        public static string DateCalc09(string strDateA, string strDateB)

        {
            string result = "Invalid input";
            try
            {
                DateTime start = new DateTime(2013, 1, 13);
                DateTime end = new DateTime(2012, 12, 12);
                TimeSpan difference = end - start;



          }
            catch { }
            return result;


        }
    }
}