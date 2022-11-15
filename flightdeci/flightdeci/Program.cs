using System.Xml.Linq;

double[] fare = new double[3];
int i ;




Console.WriteLine("Input 10  fares in the array ");
for (i = 0; i < fare.Length; i++)
{
    Console.Write($"fare  {+i + 1} : ");
    fare[i] =Convert.ToInt32 (Console.ReadLine());
}

//Assending();
//dessending();
//Searh();
//Duplicate();
minmax();

void Assending()
{
    double a;
    Console.Write("\n Fare in Assending order : \n");




    for (i = 0; i < fare.Length; i++)
    {
        for (int j = i + 1; j < fare.Length; j++)
        {



            if (fare[i] > fare[j])
            {
                a = fare[i];
                fare[i] = fare[j];
                fare[j] = a;
            }




        }
        Console.WriteLine(fare[i]);
    }
}

void dessending()
{
    double a;
    Console.Write("\n Fare in Assending order : \n");




    for (i = 0; i < fare.Length; i++)
    {
        for (int j = i + 1; j < fare.Length; j++)
        {



            if (fare[i] < fare[j])
            {
                a = fare[i];
                fare[i] = fare[j];
                fare[j] = a;
            }




        }
        Console.WriteLine(fare[i]);
    }
}

void Searh()
{
    int str;
    bool flag = false;
    Console.Write("enter the fare to be searched:");
    str =Convert.ToInt32( Console.ReadLine());



    foreach (var item in fare)
    {
        if (str.Equals(item))
        {
            flag = true;
            break;
        }

    }
    if (flag)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");



}


void Duplicate()



{
    for (i = 0; i < fare.Length; i++)
    {
        for (int j = i + 1; j < fare.Length; j++)
        {



            if (fare[i] == fare[j])
            {
                Console.Write($" The Duplicate elements are : {fare[i]}");
               
            }



        }
    }
}


void minmax()
{
 
    double min, max;
 
    min = max = fare[0];
    for (i = 1; i < fare.Length; i++)
    {
        if (min > fare[i])
            min = fare[i];
        if (max < fare[i])
            max = fare[i];
    }
    Console.WriteLine($"smallest number : {min}");
    Console.WriteLine($"Largest number : {max}");
}


//Console.WriteLine("Input 10  fares in the array ");
//for (i = 0; i < fare.Length; i+=2)
//{
//    Console.Write($"fare  {+i + 1} : ");
//    fare[i] = Convert.ToInt32(Console.ReadLine());
//}