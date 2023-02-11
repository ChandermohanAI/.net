// See https://aka.ms/new-console-template for more information
using System.Collections;
using ConsoleApplication;

static int addi(int x,int y){
    return x+y;
}

int o = addi(7,9);
Console.WriteLine(o);

static void val(int  x)
{
    if ((x % 2) == 0)
    {
        Console.WriteLine("input is Even");
    }

    else
    {
        Console.WriteLine("input is odd");
    }
                
}

int v = Convert.ToInt32(Console.ReadLine());

val(v);
//Arrays






//ArrayLists

Console.WriteLine("Arraylist");
ArrayList arr = new ArrayList();
arr.Add(1);
arr.Add(2);
arr.Add(3);
for(int i = 0; i < arr.Count; i++)
{
    Console.Write(arr[i]+" ");
}
Console.WriteLine();
Console.WriteLine("ArrayList after insertion");
arr.Insert(1, "hello");

for (int i = 0; i < arr.Count; i++)
{
    Console.Write(arr[i]+ " ");
}
Console.WriteLine();
Console.WriteLine("New ArrayList");
ArrayList arr1 = new ArrayList() { 4, "world", 5, 6 };
arr.AddRange(arr1);

Console.WriteLine("ArrayList after insertion of new arrayList");
for (int i = 0; i < arr.Count; i++)
{
    Console.Write(arr[i]+" ");
}
Console.WriteLine();

//constructor

var c1 = new person("mohan",21);
Console.WriteLine(c1.name);
Console.WriteLine(c1.age);

// var c2 = new person();
// c2.name = "Chandermohan";
// c2.age = 21;
// Console.WriteLine(c2.name);
// Console.WriteLine(c2.age);

// type conversion

// Implicit Conversion(done by the compiler itself)
// smaller type to larger type
// char>int>long>float>double

char ch = 'a';
char ch1 ='A';
int _ch = ch;
int _ch1 = ch1;
Console.WriteLine(_ch);
Console.WriteLine(_ch1);

// this code will give error
// double d = 97D;
// char _d = d;
// Console.WriteLine(_d);

// Explicit Conversion(manually)
// larger type to smaller type
// double>float>long>int>char

// explicit casting
// double d = 97D;
// char _d = (char)d;
// Console.WriteLine(_d);


// int myint = 97;
// string _myint = Convert.ToString(myint);
// Console.WriteLine(_myint);
// Console.WriteLine(_myint+"hlo");

// Nullable types
//ValueType - int,float,,double,structs,enums
//In valueType we can not assign null vaue

// int _val = null; this will give error
int? _val = null;
Console.WriteLine(_val);


//reference Type - string,object,class,arrays
//In reference type we can assign value as null

string _val1 = null; // with reference type we can assign null value

bool? _val2 = null;

if(_val2 == true){
    Console.WriteLine("Value is True");
}
else if(_val2 == false){
    Console.WriteLine("Value is True");
}
else{ 
    Console.WriteLine("Value is Null");
}

//Inheritance

// Inheritance in Constructor

student ob = new student();

student obj = new student("mohan",32,12,2023,"pass");
Console.WriteLine(obj.year);
obj.disp();

//Method Hiding using "new" Keyword

// both student and graduate class have same method print but it will invoke the derived class metod on calling this is called method hiding 
student pr = new student();
pr.print();

// for the base class print method following methods are used
// Method 1 - Explicitly typecasting

((graduate)pr).print();

//Method -2 

graduate pr2 = new student();
pr2.print();

// recursion

static int recurr(int x){
    if(x ==0){
        return 0;
    }
    else if(x==1){
        return 1;
    }
    else{
        return (recurr(x-1) + recurr(x-2));
    }
    }

Console.WriteLine(recurr(6));


static int fact(int x){
    if(x==1){
        return 1;
    }
    else{
        return x*fact(x-1);
    }
}
Console.WriteLine(fact(6));

static int sumOfDigit(int x){
    if(x==0){
        return 0;
    }
    else{
        return ((x%10) +sumOfDigit(x/10));
    }
}

Console.WriteLine(sumOfDigit(1234));
