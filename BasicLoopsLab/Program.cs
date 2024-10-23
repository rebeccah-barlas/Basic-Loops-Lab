// do-while loop:

string userResponse;
{
    do
    {
        Console.WriteLine("Hello,World!");
        Console.WriteLine("Would you like to continue? (y/n)");
        userResponse = Console.ReadLine();
    } while (userResponse.Equals("y"));
}
Console.WriteLine("Okay, goodbye.");

// for loop:

do
{
    Console.WriteLine("Please enter a number.");
    int userNumber = int.Parse(Console.ReadLine());
    {
        for (int i = userNumber; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
        for (int i = 0; i <= userNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
    Console.WriteLine("Would you like to continue? (y/n)");
    userResponse = Console.ReadLine();
} while (userResponse.Equals("y")) ;
Console.WriteLine("Goodbye!");

// while loop:

{
    string correctCode = "13579";
    string userInput;
    bool doorLock = true;
    int attempt = 0;
    int maxAttempt = 5;

    while (true && attempt < maxAttempt)
    {
        Console.WriteLine("Please enter the correct key code.");
        userInput = Console.ReadLine();
        {
            if (userInput == correctCode)
            {
                Console.WriteLine("Access granted. Welcome!");
                break;
            }
            else
            {
                attempt++;
                Console.WriteLine("Incorrect code. You have " + (maxAttempt - attempt) + " attempts remaining.");
            }
        }
    }

    while (true && attempt >= maxAttempt)
    {
        Console.WriteLine("Warning. There were too many incorrect attempts. You have one last try to enter the code correctly.");
        userInput = Console.ReadLine();
        {
            if (userInput == correctCode)
                Console.WriteLine("Access Granted. Welcome!");
            else
                Console.WriteLine("You have exhausted all attempts.");
            break;
        }
    }
}











