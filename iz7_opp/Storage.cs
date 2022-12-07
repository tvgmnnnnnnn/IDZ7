using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz7_opp
{
    internal class Storage
    {
        private List<Otdel> data;

        public Storage()
        {
            data = new List<Otdel>();
        }
        public void Add(Otdel otdel)
        {
            data.Add(otdel);
        }
        public void Delete(Otdel otdel)
        {
            if (data.Contains(otdel))
            {
                data.Remove(otdel);
            }
            else
            {
                Console.WriteLine("Отдел с таким названием не найден");
            }
        }
        public void Find(string name)
        {
            bool found = false;
            foreach (Otdel otdel in data)
            {
                List<SotridnikInfo> sotrudnikinfo = otdel.GetList();
                foreach (SotridnikInfo sotrudniks in sotrudnikinfo)
                {
                    if (name.Equals(sotrudniks.fio))
                    {
                        Console.WriteLine("Информация об отделе сотрудника:");
                        otdel.GetInfo();
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Преподаватель не найден");
            }
        }
    }
}
