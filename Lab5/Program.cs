using System.Security.AccessControl;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        //part 1 
        string[] LeSeasons = {"Spring", "Summer", "Fall", "Winter"};
        foreach (string season in LeSeasons)
        {
            Console.WriteLine(season);
        }
        //part 2 
        string[] theDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        Console.WriteLine("Enter a number between 1 and 7: ");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
            Console.WriteLine("The day is " + theDays[0]);
            break;
            case "2":
            Console.WriteLine("The day is " + theDays[1]);
            break;
            case "3":
            Console.WriteLine("The day is " + theDays[2]);
            break;
            case "4":
            Console.WriteLine("the day is " + theDays[3]);
            break;
            case "5":
            Console.WriteLine("The day is " + theDays[4]);
            break;
            case "6":
            Console.WriteLine("The day is " + theDays[5]);
            break;
            case "7":
            Console.WriteLine("The day is " + theDays[6]);
            break;
            default:
            Console.WriteLine("Type a number between 1 and 7 numbnuts");
            break;
            //I hope that this is what you intended. I mean I got it working at least. 

        }
        //part 3
        string[] books = {"The Cat in the Hat", "The Great Gatsby", "Macbeth"};
        string[] authors = { "Dr Suess", "F Scott Fitzgerald", "William Shakespear" };
        for (int b = 0; b < books.Length; b++)
        {
            Console.WriteLine($"{books[b]} by {authors[b]}");
        
        }
        //part 4
        int[] temperatures = { 65, 72, 78, 70, 68 };
        Array.Sort(temperatures);
        Console.WriteLine("Temperatures in ascending order:");
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        
        }
        int most = temperatures[temperatures.Length - 1];
        int least =temperatures[0];
        Console.WriteLine($"Highest temperature: {most}");
        Console.WriteLine($"Lowest temperature: {least}");

        //part 5 
        int[] downcount = {5, 4, 3, 2, 1};
        Array.Reverse(downcount);
        Console.WriteLine("Le countdown reversed: ");
        for (int OxyClean = 0; OxyClean < downcount.Length; OxyClean++)
        {
            Console.WriteLine(downcount[OxyClean]);
        }


    }
}
