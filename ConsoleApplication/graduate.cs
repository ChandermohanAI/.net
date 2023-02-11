using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class graduate
    {
        public int year;
        public string result;

        public graduate(int year,string result){
            this.year = year;
            this.result = result;
        }

        public virtual void disp(){
            Console.WriteLine("Base Class\nYear: {0}\nResult: {1}",year,result);
        }
    }
}