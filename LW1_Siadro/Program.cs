using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW1_Siadro
{
    class Date 
    {
        private int year;
        private int month;
        private int day;

        public Date (int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public bool IsValid()
        {
            bool result = false;
            if (year > 0 && (month >= 1 && month <= 12) && (day >= 1 && day <= 31))
            {
                if ((month == 4 || month == 6 || month == 9 || month == 11)
                && (day >= 1 && day <= 30))
                {
                    return result = true;
                }
                else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    && day >= 1 && day <= 31)
                {
                    return result = true;
                }
                else if (day >= 1 && day <= 28)
                {
                    return result = true;
                }
            }
             return result;
        } 

        public int Plus1()
        {
            int resultPlus1 = day + 1;
            return resultPlus1;
        }

        public void Print()
        {
            Console.WriteLine("\n --------------------------------");
            Console.WriteLine(" Day = {0}, Month = {1}, Year = {2}", day, month, year);
            Console.WriteLine(" --------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int month, day, year;
            
            try
            {
                Console.WriteLine(" --------------------------------");
                Console.Write("\n Enter the day: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n Enter the month: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n Enter the year: ");
                year = Convert.ToInt32(Console.ReadLine());
                
                Date date = new Date(year, month, day);
            
                date.Print();

                if (date.IsValid())
                {
                    int dayPlus1 = date.Plus1();
                    Console.WriteLine(" Date: {0}/{1}/{2}", dayPlus1, month, year);
                }
                else
                {
                    Console.WriteLine(" The existence of such a date is impossible! :3");
                }
            }
            catch
            {
                Console.WriteLine("\n --------------------------------");
                Console.WriteLine(" Error! Try running the number again. ;3");
            }

            Console.ReadLine();
        }
    }
}
