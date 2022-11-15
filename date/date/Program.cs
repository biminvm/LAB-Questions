Console.Write("Enter a month: ");
int month = int.Parse(Console.ReadLine());
Console.Write("Enter a day: ");
int day = int.Parse(Console.ReadLine());
Console.Write("Enter a year: ");
int year = int.Parse(Console.ReadLine());

DateTime inputtedDate = new DateTime(year, month, day);


int age ,age1 , hr_age , day_age , wk_age, mnt_age, yr_age;
age = (2022 - year) ;
age1 = 11 - month;

Console.WriteLine($"Age : {age} Years {age1} Months");

hr_age = (age * (365 * 24));
day_age = (age * 365);
wk_age = age * 52;
mnt_age = age * 12;
yr_age = age;
Console.WriteLine($"Age in hours: {hr_age } hrs");
Console.WriteLine($"Age in days : {day_age} days");
Console.WriteLine($"Age in weeks: {wk_age} weeks");
Console.WriteLine($"Age in months: {mnt_age} months ");
Console.WriteLine($"Agein years : {yr_age} years");

if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
{
    Console.WriteLine("its a leep year");

}
else
{
    Console.WriteLine(" its not a leap year");
}