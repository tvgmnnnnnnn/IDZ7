using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz7_opp
{
    internal class Otdel
    {
        private string name;
        private string kabinet;
        private List<SotridnikInfo> sotrudniks;

        public Otdel(string pName, string pkabinet)
        {
            name = pName;
            kabinet = pkabinet;
            sotrudniks = new List<SotridnikInfo>();
        }
        public void Add(SotridnikInfo user)
        {
            sotrudniks.Add(user);
        }
        public void Delete(SotridnikInfo user)   
        {
            if (sotrudniks.Contains(user))
            {
                sotrudniks.Remove(user);
            }
            else
            {
                Console.WriteLine("Сотрудник не найден");
                Console.WriteLine();
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название отдела: {name} \n Кабинет отдела: {kabinet} \n Количество сотрудника: {sotrudniks.Count.ToString()}");
            Console.WriteLine();
        }
        public List<SotridnikInfo> GetList()
        {
            return sotrudniks;
        }
    }
}
