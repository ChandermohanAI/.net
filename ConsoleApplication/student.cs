using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class student : graduate
    {
        public string name;
        public int age;
        public int marks;

        public student(){
            Console.WriteLine("Derived Student class constructor");
        }

        public student(string a,int b,int c,int d,string e) : base(d,e){ // here to access parent class variable from derived class we use base metod
            name=a;
            age=b;
            marks=age;
            
        }

        public override void disp(){// override is used for polymorphismm
            Console.WriteLine("Derived Class\nName: {0}\nAge: {1}\nMarks: {2}\nYear: {3}\nresult: {4}",name,age,marks,year,result);
        }

        public new void print(){//new keyword for method hiding
            Console.WriteLine("Student class Method");
        }
        
    }
}