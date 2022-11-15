
using System;

string[] names = new string[3]; int i;
string[] des = new string[3];


for (i = 0; i < names.Length; i++)
{
    Console.Write($"Name  {+i + 1} : ");
    names[i] = (Console.ReadLine());

   Console.Write($"Destination  {+i + 1} : ");
    des[i] = (Console.ReadLine());
}


Console.WriteLine("Names....");
        foreach (var ele in names)
        {
            Console.WriteLine(ele);
        }
      
        Console.WriteLine("Destinations....");
        foreach (string ele in des)
        {
            Console.WriteLine(ele);
        }
        var myList = new List<string>();
        myList.AddRange(names);
        myList.AddRange(des);
        string[] arr3 = myList.ToArray();
        Console.WriteLine("Combined array elements..");
        foreach (string res in arr3)
        {
            Console.WriteLine(res);
        }
