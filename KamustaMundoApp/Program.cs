
class Task1
{
    static void Main(String[] args)
    {
        //Console.WriteLine("Kamusta Mundo!");

        int[][] numberMatrix = new int[][]
        {
            new int[] { 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 }
        };

        int Digit1 = numberMatrix[1][3];
        int Digit2 = numberMatrix[0][0];
        int Digit3 = numberMatrix[1][4];

        string password = (Digit1.ToString() + Digit2.ToString() + Digit3.ToString());

        Console.WriteLine(password);

    }
}

class Task2
{
    static void Main(String[] args)
    {
        int[][] numberMatrix = new int[][]
        {
            new int[] { 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 }
        };

        int Digit1 = numberMatrix[1][3];
        int Digit2 = numberMatrix[0][0];
        int Digit3 = numberMatrix[1][4];

        string password = (Digit1.ToString() + Digit2.ToString() + Digit3.ToString());

        Console.WriteLine(password);
    
    }
}