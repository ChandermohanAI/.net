using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class person
    {
        public string name;
        public int age;

        public person(){
            Console.WriteLine("Parameterless constructor of Base class Employee");
        
        }

        public person(string name){
            this.name=name;
        }
        public person(string name,int age){
            this.name = name;
            this.age =age;
        } 
    }
}