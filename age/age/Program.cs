
int[] day = new int[3];
int[] mnt = new int[3];
int[] year = new int[3];
string[] cus = new string[3];
int i;

int[] age = new int[3];
int tdy = DateTime.Now.Year;



Console.WriteLine("Input 10 DOB in the array ");
for (i = 0; i < cus.Length; i++)
{
    Console.Write($"Costomer no : ");
    cus[i] =(Console.ReadLine());
    Console.Write($"day  {i + 1} : ");
    day[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write($"month  {i + 1} : ");
    mnt[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write($"year  {i + 1} : ");
    year[i] = Convert.ToInt32(Console.ReadLine());

    age[i] = tdy- year[i];

    if (age[i] < 10 && age[i] > 1)
    {
        Console.WriteLine($" {cus[i]} is  kid");
    }
    else if (age[i] > 10 && age[i] < 30)
    {
        Console.WriteLine($" {cus[i]} is a youth");
    }
    else if (age[i] > 30 && age[i] < 60)
    {
        Console.WriteLine($" {cus[i]} is adult");
    }
    else if (age[i] > 60)
    {
        Console.WriteLine($" {cus[i]} is older");
    }

    else
    {
        Console.WriteLine(" invalid age ");
    }
}





