﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Namn: {Name}, Lön: {Salary}";
        }
    }
}
