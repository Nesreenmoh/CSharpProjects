using Person1_Proejct.Models;
using System;

namespace Person1_Proejct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celebrating Birthday");

            Person Nesreen = new Person("Nesreen", 38);
            Person Yusuf = new Person("Yusuf", 5);
            Person Sara = new Person("Sara", 3);
            Person Anis = new Person("Anis", 41);

            Nesreen.CelebrateMyBirthday();
            Yusuf.CelebrateMyBirthday();
            Sara.CelebrateMyBirthday();
            Anis.CelebrateMyBirthday();

            Console.WriteLine(Nesreen.ToString());
            Console.WriteLine(Yusuf.ToString());
            Console.WriteLine(Sara.ToString());
            Console.WriteLine(Anis.ToString());
        }
    }
}
