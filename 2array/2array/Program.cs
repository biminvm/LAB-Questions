
int[] fare = new int[3];
int i, pos;

string[] des = new string[3];

for (i = 0; i < fare.Length; i++)
{
    Console.Write($"enter  the fare  {+i + 1} : ");
    fare[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write($"enter  the Destination  {+i + 1} : ");
    des[i] =Console.ReadLine();

}

Console.WriteLine("enter the position :");
pos=Convert.ToInt32(Console.ReadLine());

for (i = 0; i < fare.Length; i++)
{
    if(i==pos-1)
    {
        Console.WriteLine( $" The fare is {fare[i]} and the destination is {des[i]}");
    }
}