using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

//ref link:https://www.youtube.com/watch?v=JQegkohBSbE&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=21
//

/*class MainClass : IEnumerable
{
    static void Main()
    {
        //ICollection<int> // specific interface
        //var meList = new List<int>
        var meList = new MainClass
        {
            3,7,45,1,2,3,4,1,2,3 // 
        };
        //meList.P(); // .P() function  created extension method
        /*
        var meList = new List<int>();// macro ctrlshift+r ctrilshift+p ---removed byVS2022
        meList.Add(3);
        meList.Add(7);
        meList.Add(45);
        meList.Add(1);
        meList.Add(2);
        meList.Add(3);
        meList.Add(4);
        meList.Add(1);
        meList.Add(2);
        meList.Add(3);
        //meList.P();
        */
/*}

public IEnumerator GetEnumerator()
{
    return null;
}

void Add(int blah) { Console.WriteLine(blah); } // add method called several times
}*/

// REFLECTION DATATYPES
// .P() function created extension method

class MainClass
{
    static void Main()
    {
        //ICollection<int>
        new List<int> { 1, 3, 2, 4 };
        //typeof(List<>).Assembly.P(); // core library
        Assembly mscorlib = Assembly.Load("mscorlib");
        //mscorlib.GetTypes().Length.P(); // 2708 types
        //mscorlib.GetTypes().Where(t => t.Namespace == null ? false : t.Namespace.Contains("System.Collections")).Select(t => t.Name).P();
        //mscorlib.GetTypes().Where(t => t.GetInterfaces().Any(it => it.IsGenericType ? it.GetGenericTypeDefinition().Equals(typeof(IEnumerable<>)) : false)).Count().P(); // 34 type generic IEnumerable
        //mscorlib.GetTypes().Where(t => t.GetInterfaces().Any(it => it.IsGenericType ? it.GetGenericTypeDefinition().Equals(typeof(ICollection<>)) : false)).Count().P(); // 15 type generic ICollection
    }
}