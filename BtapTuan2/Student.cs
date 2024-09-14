using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtapTuan2
{
    class Student
    {
        private int id;
        private string name;
        private int age;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Student() { }
        public Student(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;

        }
        public override string ToString()
        {
            return $"MSHS: {Id}     Ho Ten: {Name}      Tuoi: {Age}";
        }


    }
    }
