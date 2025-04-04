using System.Transactions;

{
//Part 1
int a = 10;
int b = 5;
int c = 15;
Console.WriteLine(a > b);
Console.WriteLine(a < c);
Console.WriteLine(a > b && a > c);
//Part 2
bool isRaining = true;
bool haveUmbrella = false;
if (isRaining && !haveUmbrella)
{
    Console.WriteLine("Take an Umbrella.");
}
else
{
    Console.WriteLine("You're good to go.");
}
//Part 3
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
if (age < 5)
{
    Console.WriteLine("Tickets are free");
}
else if (age > 5 && age < 12)
{
    Console.WriteLine("Child ticket: 5 dollars");
}
else if (age > 13 && age < 64)
{
    Console.WriteLine("Standard ticket: 10 dollars");
}
else if (age >= 65)
{
    Console.WriteLine("Senoir ticket: 6 dollars");
}
//Part 4 
Console.WriteLine("Enter a number: ");
int dayofWeek = Convert.ToInt32(Console.ReadLine());
switch (dayofWeek) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
  default:
   Console.WriteLine("Invalid day");
break;
}
}