using System;

namespace MyDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, short> cities = new MyDictionary<string, short>();
            cities.Add("Kastamonu", 37);
            cities.Add("İstanbul", 34);
            cities.Add("Ankara", 06);
            cities.Add("Konya", 42);
            cities.Add("Şanlıurfa", 63);
            cities.Add("Hatay", 31);


            cities.List();
            Console.Read();
        }
    }
}
