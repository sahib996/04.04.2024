using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._2024.model
{
    internal class Employee
    {
        protected int salary;

        public Employee()
        {
           salary = 500; 
        }

        public virtual void GetPromotion()
        {
            salary += 100; 
            Console.WriteLine("salary");
        }
    }
}
