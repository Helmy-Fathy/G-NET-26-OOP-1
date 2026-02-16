using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_1
{
    internal class Student
    {
        public string? Name;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, age {Age}");
        }
    }
}
