﻿// See https://aka.ms/new-console-template for more information
using System.Collections;

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

