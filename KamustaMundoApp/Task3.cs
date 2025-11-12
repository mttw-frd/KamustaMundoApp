class Task3
{
    static void Main(String[] args)
    {

        // Intialize number array and found bool
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };
        bool found = false;

        // Ask for user input
        Console.Write("Number to Find: ");
        string number = Console.ReadLine();

        // for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            // print successful if number is found, set found to true and break from loop
            if (numbers[i].ToString() == number)
            {
                Console.WriteLine("Number found at position " + i + "!");
                found = true;
                break;
            }

        }
        
        // if found is false, print unsuccesssful
        if (!found)
        {
            Console.WriteLine("Number not found in the list.");
        }
    
    }
}