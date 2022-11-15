using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



   
        string[] names = new string[3];
        int i ;
        string name = string.Empty;

Console.WriteLine("Input 10 names in the array ");
        for (i = 0; i < names.Length; i++)
        {
Console.Write($"Name  {+i + 1 } : ");
            names[i] =(Console.ReadLine());
        }

//Assending();
//Desending();
//Searh();
//Namelength();
//split();
//Duplicate();

void Assending()
{
    Console.Write("\n Names in Assending order : \n");
   

    for (i = 0; i < names.Length; i++)
    {
        for (int j = i + 1; j < names.Length; j++)
        {

            if (names[i][0] > names[j][0])
            {
                name = names[i];
                names[i] = names[j];
                names[j] = name;
            }


        }
        Console.WriteLine(names[i]);
    }
}



void Desending()
{


    Console.Write("\n Names in Desending order : \n");


    for (i = 0; i < names.Length; i++)
    {
        for (int j = i + 1; j < names.Length; j++)
        {

            if (names[i][0] < names[j][0])
            {
                name = names[i];
                names[i] = names[j];
                names[j] = name;
            }


        }
        Console.WriteLine(names[i]);
    }
}



void Searh()
{
    string str;
    bool flag=false;    
    Console.Write("enter the name to be searched:");
    str = Console.ReadLine();

    foreach(var item in names)
    {
        if (str.Equals(item)) 
        {
            flag= true;
            break;
        }
          
    }
    if (flag)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");

}

void   Namelength()
    {

    Console.Write("Length of each names");
for (i = 0; i < name.Length; i++)
    {
        Console.Write($"Name  {+i + 1} : ");

        Console.WriteLine(names[i].Length);
    }

}


void split()
    {

    foreach ( var x in names)
    {
        string[] item = x.Split(" ");

        Console.WriteLine($"Name : {x }|| First name :{item[0]} || Lastname : {item[1]}");
    }


}

void Duplicate()

{
    for (i = 0; i < names.Length; i++)
    {
        for ( int j = i+1; j < names.Length; j++)
        {

            if (names[i] == names[j])
            {
                Console.Write( $" The Duplicate elements are : { names[i] + ' '}");
                break;
            }

        }
    }
}
///