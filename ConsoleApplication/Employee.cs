using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Employee : person
    {
        public string name;
        public string job;

    
        public Employee(){
            Console.WriteLine("Parameterless constructor of Derived class Employee");

        }
        public Employee(string name){
            this.name=name;
        }
    }
}