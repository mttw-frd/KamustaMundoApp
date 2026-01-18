
// Matthew Ferdinand B. Curameng from Year 2 Block - D
// for OOP subject by Marco Yimyaem

class Task2
{
    static void Main(String[] args)
    {

        // Create array
        int[][] numberMatrix = new int[][]
        {
            new int[] { 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 }
        };

        // Locate array coordination
        int Digit1 = numberMatrix[1][3];
        int Digit2 = numberMatrix[0][0];
        int Digit3 = numberMatrix[1][4];

        // Convert all digits to string and combine
        string password = (Digit1.ToString() + Digit2.ToString() + Digit3.ToString());

        Console.WriteLine(password);
    
    }
}