using System;

namespace OperacoesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime e = new DateTime(2001, 8, 15, 13, 45, 58, 275);

             Console.WriteLine(e);
             Console.WriteLine("1)  Date: " + e.Date);
             Console.WriteLine("2)  Day: " + e.Day);
             Console.WriteLine("3)  DayOfWeek: " + e.DayOfWeek);
             Console.WriteLine("4)  DayOfYear: " + e.DayOfYear);
             Console.WriteLine("5)  Hour: " + e.Hour);
             Console.WriteLine("6)  Kind: " + e.Kind);
             Console.WriteLine("7)  Millisecond: " + e.Millisecond);
             Console.WriteLine("8)  Minute: " + e.Minute);
             Console.WriteLine("9)  Month: " + e.Month);
             Console.WriteLine("10) Second: " + e.Second);
             Console.WriteLine("11) Ticks: " + e.Ticks);
             Console.WriteLine("12) TimeOfDay: " + e.TimeOfDay);
             Console.WriteLine("13) Year: " + e.Year);

            Console.WriteLine("_____________________________________________________________");

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();

            string s5 = d.ToString();

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss:fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("_____________________________________________________________");

            DateTime x1 = DateTime.Now;

            DateTime x2 = d.AddHours(2);

            DateTime x3 = d.AddMinutes(3);

            DateTime x4 = d.AddDays(7);


            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);


        }
    }
}
