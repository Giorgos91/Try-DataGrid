using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_DataGrid
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }


        public Person(string name, string surname,int id,int age,double height)
        {
            Name = name;
            Surname = surname;
            Id = id;
            Age = age;
            Height = height;
        }
    }
}
