


Console.WriteLine(" enter the Name :");
string name = Console.ReadLine();
Console.WriteLine("enter the total miles travelled :");
int miles = int.Parse(Console.ReadLine());





if (miles > 10000 && miles < 20000) 
{
   
    Console.Write($"Dear {name} you are awarded with 10 frequent flyer points. ");
}

else if (miles > 20000 && miles < 30000)
{

    Console.Write($"Dear {name} you are awarded with 20 frequent flyer points. ");
}

else if (miles > 50000 && miles < 100000)
{

    Console.Write($"Dear {name} you are awarded with 30 frequent flyer points. ");
}

else if (miles > 100000)
{

    Console.Write($"Dear {name} you are awarded with 50 frequent flyer points. ");
}

else
        {
    Console.WriteLine(" you are not getting any points");

}

