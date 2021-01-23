using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> days = new Dictionary<int, string>();
            days.Add(0, "Pazartesi");

            MyDictionary<int, string> days2 = new MyDictionary<int, string>();
            days2.Add(1, "Pazartesi");
            days2.Add(2, "Salı");
            days2.Add(3, "Çarşamba");
            days2.Add(4, "Perşembe");
            days2.Add(5, "Cuma");
            days2.Add(6, "Cumartesi");
            days2.Add(7, "Pazar");
        }
    }
}
