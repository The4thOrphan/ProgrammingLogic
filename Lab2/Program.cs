namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Part 1
        int randomNumber = 130;
        Console.WriteLine("The number "+ randomNumber +" is a number I chose at random.");
        double rochelimit = 2.5;
        Console.WriteLine("A smaller celistial body can get as close to "+ rochelimit +" times the radius of a larger celistial body before it is ripped apart by gravity.");
        float FirstDigits =3.14159F;
        Console.WriteLine("The first few digits of pi is "+ FirstDigits + "Isn't that neat.");
        char thefunnyletter = 'E';
        Console.WriteLine(thefunnyletter);
        //You only get E.
        bool booleansoundsfunny = true;
        Console.WriteLine(" It is "+ booleansoundsfunny +" that the word Boolean sounds funny.");
        string theMonger = "I am a uncertified cheesemonger";
        Console.WriteLine(theMonger);
        //Part 2
        double parttwo = 9.78;
        Console.WriteLine(parttwo);
        int convertable = (int) parttwo;
        Console.WriteLine(convertable);
        int Number = 23;
        Console.WriteLine(Convert.ToString(Number)); 
        bool intoString = false;
        Console.WriteLine(Convert.ToString(intoString)); 
        Console.WriteLine("double:" + parttwo);
        Console.WriteLine("int:" + Number);
        Console.WriteLine("bool:" +intoString);
        //Part 3
        Console.WriteLine("Enter your name:");
        string yourName = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        int yourAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello, your name and age is: " + yourName + "and you are" + yourAge + "years old.");
        //I couldn't figure out how to add space between the variables.
        //Part 4
        int num1 = 23;
        int num2 = 3657;
        int sum1 = num1 + 10;
        Console.WriteLine(sum1);
        int sum2 = num2 + 10;
        Console.WriteLine(sum2);
        int sub1 = num1 - 2;
        Console.WriteLine(sub1);
        int sub2 = num2 - 2;
        Console.WriteLine(sub2);
        int mult1 = num1 * 3;
        Console.WriteLine(mult1);
        int mult2 = num2 * 3;
        Console.WriteLine(mult2);
        int div1 = num1 / 2;
        Console.WriteLine(div1);
        int div2 = num2 / 2;
        Console.WriteLine(div2);
        int mod1 = num1 % 2;
        Console.WriteLine(mod1);
        int mod2 = num2 % 2;
        Console.WriteLine(mod2);
        //Part 5
        double samevar = 1.123456789;
        float samevar2 = 1.123456789F;
        Console.WriteLine(samevar);
        Console.WriteLine(samevar2);
        //Part 6
        int pleaseburgerCheese = 10;
        pleaseburgerCheese++;
        Console.WriteLine(pleaseburgerCheese);
        pleaseburgerCheese--;
        Console.WriteLine(pleaseburgerCheese);
        //I don't know if you wanted it to go down to 9 or not, but that would require another --.
    







    }
}
