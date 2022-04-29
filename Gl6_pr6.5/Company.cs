using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gl6_pr6._5
{
    public class Company
    {
        string name; //название
        int persons; //количество сотрудников
        int money; // месячный фонд заработной платы
        public string Name
        {// свойство
            get { return name; }
        }
        public int Persons
        {// свойство
            get { return persons; }
        }
        public Company(
        string name, int persons, int money)
        {
            this.name = name; this.persons = persons;
            this.money = money;
        }
        // печать информации о компании
        public void show()
        {
            Console.WriteLine("В компании " + name + " трудятся " + persons + " сотрудников ");
            Console.WriteLine("Фонд зарплаты: " + money);
        }
    }
}
