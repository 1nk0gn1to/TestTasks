using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name) => Name = name;
    }
    class Company
    {
        Person[] personal;
        public Company(Person[] peolpe) => personal = peolpe;
        public Person this[int index]
        {
            get => personal[index];
            set => personal[index] = value;
        }
    }
}
