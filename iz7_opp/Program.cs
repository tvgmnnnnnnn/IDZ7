using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz7_opp
{
    class Programm
    {
        static void Main(string[] args)
        {
            SotridnikInfo t1 = new SotridnikInfo("Савченко", "savchenko@mail.ru", "Менеджер");
            SotridnikInfo t2 = new SotridnikInfo("Бакланова", "baklanova@mail.ru", "Программист");
            SotridnikInfo t3 = new SotridnikInfo("Маршенкулова", "marshenkulova@mail.ru", "Менеджер");
            SotridnikInfo t4 = new SotridnikInfo("Кодина", "kodina@mail.ru", "Программист");
            SotridnikInfo t5 = new SotridnikInfo("Пелихович", "pelihovich@mail.ru", "Главный программист");
            SotridnikInfo t6 = new SotridnikInfo("Шевченко", "shevchenko@mail.ru", "Программист");
            Otdel k1 = new Otdel("Бэк-отдел", "321");
            k1.Add(t1);
            k1.Add(t2);
            Otdel k2 = new Otdel("Фронт-отдел", "330");
            k2.Add(t3);
            k2.Add(t4);
            Otdel k3 = new Otdel("Отдел БД", "302");
            k3.Add(t5);
            k3.Add(t6);
            Storage data = new Storage();
            data.Add(k1);
            data.Add(k2);
            data.Add(k3);

            k1.GetInfo();
            List<SotridnikInfo> info1 = k1.GetList();
            foreach (SotridnikInfo t in info1)
            {
                Console.WriteLine(t.fio);
                Console.WriteLine(" ");
            }

            k2.GetInfo();
            List<SotridnikInfo> info2 = k2.GetList();
            foreach (SotridnikInfo t in info2)
            {
                Console.WriteLine(t.fio);
                Console.WriteLine(" ");
            }

            k3.GetInfo();
            List<SotridnikInfo> info3 = k3.GetList();
            foreach (SotridnikInfo t in info3)
            {
                Console.WriteLine(t.fio);
                Console.WriteLine(" ");
            }

            Console.WriteLine();
            t2.GetInfo();
            data.Find("Бакланова");
        }
    }
}
