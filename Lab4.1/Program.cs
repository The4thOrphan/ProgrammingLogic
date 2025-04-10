namespace Lab4._1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    
    //Part 1
    for (int i = 0; i <= 10; i++)
    {
     Console.WriteLine(i);   
    }
   
   
    //Part 2
    for (int i = 0; i <= 20; i = i + 2)
    {
        Console.WriteLine(i);
    }
    //Part 3
    int w = 5;
    while (w >= 1)
    {
        Console.WriteLine(w);
        w--;
    }
    //Part 4
   int number;
        do
        {
            Console.Write("Enter a number greater than 100: ");
            number = Convert.ToInt32(Console.ReadLine());
        } while (number <= 100);

        Console.WriteLine("Thank you! You entered: " + number);
        //Part 5 
        int numbskull = 10;
        while (numbskull <= 1000)
        {
            Console.WriteLine(numbskull);
            numbskull += 10;
            
        }
        //Part 6
        int rows = 10; 

        for (int i = 1; i <= rows; i++)
        {
            for (int cheese = 1; cheese <= i; cheese++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}
