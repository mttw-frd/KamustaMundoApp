
// Matthew Ferdinand B. Curameng from Year 2 Block - D
// for OOP subject by Marco Yimyaem

class Task4
{   

    // Addition function
    static void Add(int num1, int num2)
    {

        Console.WriteLine( $"{num1} + {num2} = " + (num1 + num2) );

    }
    // Substraction function
    static void Substract(int num1, int num2)
    {

        Console.WriteLine( $"{num1} - {num2} = " + (num1 - num2) );

    }
    // Multiplication function
    static void Multiply(int num1, int num2)
    {

        Console.WriteLine( $"{num1} * {num2} = " + (num1 * num2) );

    }
    // Division function
    static void Divide(int num1, int num2)
    {

        Console.WriteLine( $"{num1} / {num2} = " + (num1 / num2) );

    
    }
    // Function for prompting two values and check if input are numbers, reason: to maintain order of the assignment :P
    static (int , int) PromptValue()
    {
        // Start label for function
        Start:
            int int1, int2 = 0;
            string num1, num2 = "";

            //Ask for two values
            Console.WriteLine("Input Value 1: ");
            num1 = Console.ReadLine();

            Console.WriteLine("Input Value 2: ");
            num2 = Console.ReadLine();

            // Check if both values are numbers
            bool check1 = int.TryParse(num1, out int1);
            bool check2 = int.TryParse(num2, out int2);

            if(!check1 || !check2)
            {       
                // Print warning and go back to Start if letters are found
                    Console.WriteLine("You can only input numbers.");
                    goto Start;
            }

        // Return values back to function caller
        return (int1, int2);

    }

    static void Main(String[] args)
    {
        //  Global variables for calculator
        int num1, num2 = 0;
        bool loop = true;
        string input = "";

        // Start of main loop
        while(loop)
        {
            // Print choices
            Console.Write(" 1 - Addition \n 2 - Subraction \n 3 - Multiplication \n 4 - Division \n");

            // Prompt user input and pick proper arithmetic, loop if not 1-4
            Switch:
                input = Console.ReadLine();
                switch(int.Parse(input))
                {
                    case(1):
                        //Console.Write("Add");

                        (num1, num2) = PromptValue();
                        Add( num1, num2 );
                        break;

                    case(2):
                        //Console.Write("Sub");

                        (num1, num2) = PromptValue();
                        Substract( num1, num2 );
                        break;

                    case(3):
                        //Console.Write("Mult");

                        (num1, num2) = PromptValue();
                        Multiply( num1, num2 );     
                        break;

                    case(4):
                        // Console.Write("Divide");

                        (num1, num2) = PromptValue();
                        Divide( num1, num2 );            
                        break;

                    default:

                        //Go back to start
                        Console.WriteLine("Only use numbers 1-4.");
                        goto Switch;
                }


            // Ask if user wants to do another calculation
            Console.WriteLine("Do you want to continue again (Y/N)?");

            //Check if user inputs Y or N, loop if not
            YesNo:
                input = Console.ReadLine();
                if (input == "Y" || input == "y")
                {
                    loop = true;
                }
                else if (input == "N" || input == "n")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("You can only input Y or N."); 
                    goto YesNo;
                }
        }
    }
        //Add( int.Parse(num1), int.Parse(num2) );
} 