class Task3
{
    static void Main(String[] args)
    {
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };
        string number = "21";

        for(int i = 0; i < numbers.Length; i++)
        {

            if ("21" == number)
            {
                Console.WriteLine("Number found at position " + i + "!");
            }
            else
            {
                break;
            }

            Console.WriteLine("Number not found in the list.");

        }
    }
}