using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment
{
    internal class Student
    {
        public int roll  { get; set; } 
        public string name { get; set; }        

        public int age { get; set; }

        public string address { get; set; }

        public void GetData()
        {
            Console.WriteLine("Please enter the value for Student Roll No:");
            this.roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value for Student Name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Please enter the value for Student Age:");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value for Student Address:");
            this.address = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Roll no = " + this.roll);
            Console.WriteLine("Name = " + this.name);
            Console.WriteLine("Age = " + this.age);
            Console.WriteLine("Address=" + this.address);
        
        }


    }
}
